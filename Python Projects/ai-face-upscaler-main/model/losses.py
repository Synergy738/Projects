# model/losses.py — Loss Functions for Super-Resolution Training
# =============================================================================
# Implements the composite loss function for training the FSRCNN model:
#
#   Total Loss = α * MSE Pixel Loss + β * VGG Perceptual Loss
#
# Components:
#   1. MSE Pixel Loss (nn.MSELoss):
#      - Measures per-pixel reconstruction accuracy
#      - Ensures structural fidelity between predicted HR and ground truth
#
#   2. VGG Perceptual Loss:
#      - Uses a pretrained VGG16/VGG19 network as a feature extractor
#      - Computes MSE between feature maps of predicted HR and ground truth
#      - Captures high-level perceptual similarity (textures, edges, patterns)
#      - Produces visually sharper results compared to pixel loss alone
#
# The combination of both losses produces outputs that are both numerically
# accurate (high PSNR) and perceptually pleasing (sharp, natural-looking).
# =============================================================================

# TODO: Implement PixelLoss wrapper class
# TODO: Implement VGGPerceptualLoss class (using torchvision.models.vgg16)
# TODO: Implement CompositeLoss class combining both with configurable weights
# TODO: Add feature extraction hook for intermediate VGG layers
