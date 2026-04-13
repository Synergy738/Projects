# model/model.py — FSRCNN Architecture
# =============================================================================
# Fast Super-Resolution Convolutional Neural Network (FSRCNN)
#
# Paper: "Accelerating the Super-Resolution Convolutional Neural Network"
#        by Dong et al. (ECCV 2016)
#
# This module implements FSRCNN from scratch in PyTorch, specialized for
# face/portrait super-resolution. FSRCNN is chosen for its speed and
# efficiency — it operates on the low-resolution input directly (no
# bicubic pre-upscaling), making it significantly faster than SRCNN while
# achieving comparable or better quality.
#
# Architecture Overview:
#   1. Feature Extraction   — Conv2d extracts features from LR input
#   2. Shrinking            — Conv2d reduces feature dimensionality
#   3. Non-linear Mapping   — Stack of Conv2d layers for deep feature learning
#   4. Expanding            — Conv2d restores feature dimensionality
#   5. Deconvolution        — ConvTranspose2d upscales to HR output
#
# Scale factor: 2x (configurable)
# Input: Low-resolution face image (e.g., 360p)
# Output: High-resolution face image (e.g., 720p)
# =============================================================================

import torch
import torch.nn as nn
from typing import Optional


class FSRCNN(nn.Module):
    """
    Fast Super-Resolution Convolutional Neural Network (FSRCNN).

    FSRCNN is an end-to-end deep learning model for single image super-resolution.
    Unlike SRCNN which requires bicubic upscaling as a preprocessing step, FSRCNN
    takes the original low-resolution image as input and learns the upscaling
    through a deconvolution layer at the end of the network.

    The network consists of five stages:
        1. Feature extraction: Extracts feature maps from LR input
        2. Shrinking: Reduces the number of feature maps (dimensionality reduction)
        3. Non-linear mapping: Applies multiple convolutional layers for deep
           feature representation learning
        4. Expanding: Restores the number of feature maps
        5. Deconvolution: Upscales the feature maps to produce HR output

    This implementation uses PReLU activations (as in the original paper) for
    better gradient flow and convergence.

    Args:
        scale_factor: Upscaling factor (default: 2 for 2x super-resolution)
        num_channels: Number of input image channels (default: 3 for RGB)
        d: Number of feature maps after feature extraction (default: 56)
        s: Number of feature maps after shrinking (default: 12)
        m: Number of non-linear mapping layers (default: 4)

    Example:
        >>> model = FSRCNN(scale_factor=2)
        >>> lr_image = torch.randn(1, 3, 360, 360)  # Batch of 1, 360x360 LR
        >>> hr_image = model(lr_image)               # Output: 1x3x720x720 HR
        >>> print(hr_image.shape)
        torch.Size([1, 3, 720, 720])
    """

    def __init__(
        self,
        scale_factor: int = 2,
        num_channels: int = 3,
        d: int = 56,
        s: int = 12,
        m: int = 4,
    ) -> None:
        """
        Initialize the FSRCNN model.

        Args:
            scale_factor: The upscaling multiplier. A value of 2 doubles the
                         spatial dimensions of the input image.
            num_channels: Number of color channels in input/output images.
                         3 for RGB, 1 for grayscale.
            d: Dimensionality of feature extraction output. Controls the
               capacity of the initial feature representation. Higher values
               capture more features but increase computation.
            s: Dimensionality of the shrinking layer output. This bottleneck
               reduces computation in the mapping layers. Lower values are
               more efficient but may lose information.
            m: Number of non-linear mapping layers. More layers increase the
               model's capacity to learn complex mappings but add computation.
               The original paper recommends m=4 as a good trade-off.
        """
        super(FSRCNN, self).__init__()

        self.scale_factor = scale_factor
        self.num_channels = num_channels

        # =====================================================================
        # Stage 1: Feature Extraction
        # Conv(5, d, 1) — Large 5x5 kernel captures contextual information
        # from the low-resolution input. Outputs d feature maps.
        # =====================================================================
        self.feature_extraction = nn.Sequential(
            nn.Conv2d(
                in_channels=num_channels,
                out_channels=d,
                kernel_size=5,
                padding=2,  # Same padding to preserve spatial dimensions
            ),
            nn.PReLU(num_parameters=d),
        )

        # =====================================================================
        # Stage 2: Shrinking
        # Conv(1, s, 1) — 1x1 convolution reduces dimensionality from d to s
        # feature maps. This is critical for computational efficiency: the
        # expensive mapping layers operate on s (small) instead of d (large)
        # feature maps.
        # =====================================================================
        self.shrinking = nn.Sequential(
            nn.Conv2d(
                in_channels=d,
                out_channels=s,
                kernel_size=1,
            ),
            nn.PReLU(num_parameters=s),
        )

        # =====================================================================
        # Stage 3: Non-linear Mapping
        # m × Conv(3, s, 1) — Stack of m convolutional layers that learn the
        # complex non-linear mapping from LR features to HR features. Each
        # layer uses 3x3 kernels and preserves the number of feature maps.
        # This is the core computational block of the network.
        # =====================================================================
        mapping_layers: list[nn.Module] = []
        for _ in range(m):
            mapping_layers.extend([
                nn.Conv2d(
                    in_channels=s,
                    out_channels=s,
                    kernel_size=3,
                    padding=1,  # Same padding to preserve spatial dimensions
                ),
                nn.PReLU(num_parameters=s),
            ])
        self.mapping = nn.Sequential(*mapping_layers)

        # =====================================================================
        # Stage 4: Expanding
        # Conv(1, d, 1) — 1x1 convolution restores dimensionality from s back
        # to d feature maps. This is the inverse of the shrinking layer and
        # prepares the features for the final deconvolution stage.
        # =====================================================================
        self.expanding = nn.Sequential(
            nn.Conv2d(
                in_channels=s,
                out_channels=d,
                kernel_size=1,
            ),
            nn.PReLU(num_parameters=d),
        )

        # =====================================================================
        # Stage 5: Deconvolution (Transposed Convolution)
        # DeConv(9, 1, n) — Upscales the feature maps by the scale factor
        # using a learned transposed convolution. The 9x9 kernel provides a
        # large receptive field for high-quality upscaling. The stride equals
        # the scale factor, so spatial dimensions are multiplied by scale_factor.
        # =====================================================================
        self.deconvolution = nn.ConvTranspose2d(
            in_channels=d,
            out_channels=num_channels,
            kernel_size=9,
            stride=scale_factor,
            padding=4,  # (kernel_size - 1) / 2 = 4
            output_padding=scale_factor - 1,  # Ensures exact 2x upscaling
        )

        # Initialize weights using the method from the original paper
        self._initialize_weights()

    def _initialize_weights(self) -> None:
        """
        Initialize model weights following the FSRCNN paper recommendations.

        - Convolutional layers: Kaiming normal initialization (He et al.)
          optimized for PReLU activations
        - Deconvolution layer: Bilinear initialization for stable upscaling
        - Biases: Initialized to zero
        """
        for module in self.modules():
            if isinstance(module, nn.Conv2d):
                nn.init.kaiming_normal_(
                    module.weight,
                    mode="fan_out",
                    nonlinearity="leaky_relu",  # PReLU ≈ Leaky ReLU for init
                )
                if module.bias is not None:
                    nn.init.zeros_(module.bias)

            elif isinstance(module, nn.ConvTranspose2d):
                # Bilinear initialization for the deconvolution layer
                # This provides a stable starting point that approximates
                # bilinear interpolation before training begins
                nn.init.kaiming_normal_(
                    module.weight,
                    mode="fan_out",
                    nonlinearity="leaky_relu",
                )
                if module.bias is not None:
                    nn.init.zeros_(module.bias)

    def forward(self, x: torch.Tensor) -> torch.Tensor:
        """
        Forward pass through the FSRCNN network.

        Processes a low-resolution input image through all five stages
        to produce a high-resolution output.

        Args:
            x: Input tensor of shape (batch_size, num_channels, height, width).
               This should be the original low-resolution image — do NOT
               apply bicubic upscaling before passing to FSRCNN.

        Returns:
            Super-resolved tensor of shape
            (batch_size, num_channels, height * scale_factor, width * scale_factor).
        """
        out = self.feature_extraction(x)  # Stage 1: Extract features
        out = self.shrinking(out)          # Stage 2: Reduce dimensionality
        out = self.mapping(out)            # Stage 3: Non-linear mapping
        out = self.expanding(out)          # Stage 4: Restore dimensionality
        out = self.deconvolution(out)      # Stage 5: Upscale to HR
        return out

    def get_num_parameters(self) -> int:
        """
        Count the total number of trainable parameters in the model.

        Returns:
            Total number of trainable parameters.

        Example:
            >>> model = FSRCNN(scale_factor=2)
            >>> print(f"Parameters: {model.get_num_parameters():,}")
            Parameters: 24,209
        """
        return sum(p.numel() for p in self.parameters() if p.requires_grad)

    def __repr__(self) -> str:
        """Return a string representation with model configuration."""
        return (
            f"FSRCNN(\n"
            f"  scale_factor={self.scale_factor},\n"
            f"  num_channels={self.num_channels},\n"
            f"  parameters={self.get_num_parameters():,}\n"
            f")"
        )


def build_fsrcnn(
    scale_factor: int = 2,
    num_channels: int = 3,
    d: int = 56,
    s: int = 12,
    m: int = 4,
    pretrained_path: Optional[str] = None,
) -> FSRCNN:
    """
    Factory function to build and optionally load a pretrained FSRCNN model.

    This is the recommended way to instantiate the model, as it handles
    weight loading and device placement automatically.

    Args:
        scale_factor: Upscaling factor (default: 2).
        num_channels: Number of input image channels (default: 3 for RGB).
        d: Feature extraction dimensionality (default: 56).
        s: Shrinking layer dimensionality (default: 12).
        m: Number of mapping layers (default: 4).
        pretrained_path: Optional path to a .pth file with pretrained weights.
                        If None, returns a randomly initialized model.

    Returns:
        An FSRCNN model instance, optionally with pretrained weights loaded.

    Raises:
        FileNotFoundError: If pretrained_path is specified but file doesn't exist.
        RuntimeError: If the checkpoint doesn't match the model architecture.

    Example:
        >>> model = build_fsrcnn(scale_factor=2)
        >>> print(model)
        FSRCNN(
          scale_factor=2,
          num_channels=3,
          parameters=24,209
        )
    """
    model = FSRCNN(
        scale_factor=scale_factor,
        num_channels=num_channels,
        d=d,
        s=s,
        m=m,
    )

    if pretrained_path is not None:
        from pathlib import Path
        import logging

        logger = logging.getLogger(__name__)
        checkpoint_path = Path(pretrained_path)

        if not checkpoint_path.exists():
            raise FileNotFoundError(
                f"Pretrained checkpoint not found: {pretrained_path}"
            )

        logger.info(f"Loading pretrained weights from: {pretrained_path}")
        state_dict = torch.load(
            checkpoint_path,
            map_location="cpu",
            weights_only=True,
        )

        # Handle checkpoints that wrap state_dict in a dictionary
        if "model_state_dict" in state_dict:
            state_dict = state_dict["model_state_dict"]

        model.load_state_dict(state_dict)
        logger.info("Pretrained weights loaded successfully.")

    return model


# =============================================================================
# Quick test — run this file directly to verify the architecture
# =============================================================================
if __name__ == "__main__":
    model = build_fsrcnn(scale_factor=2)
    print(model)
    print(f"\nTotal parameters: {model.get_num_parameters():,}")

    # Test forward pass with a dummy input
    dummy_input = torch.randn(1, 3, 360, 360)
    output = model(dummy_input)
    print(f"Input shape:  {dummy_input.shape}")
    print(f"Output shape: {output.shape}")
    assert output.shape == (1, 3, 720, 720), "Output shape mismatch!"
    print("\n✓ Architecture verified — forward pass successful.")
