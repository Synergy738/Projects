<div align="center">

# 🧠 AI Face Upscaler

**Enhance low-resolution face photos to high resolution using a custom-trained deep learning model**

[![Python](https://img.shields.io/badge/Python-3.10+-3776AB?style=for-the-badge&logo=python&logoColor=white)](https://python.org)
[![PyTorch](https://img.shields.io/badge/PyTorch-2.0+-EE4C2C?style=for-the-badge&logo=pytorch&logoColor=white)](https://pytorch.org)
[![FastAPI](https://img.shields.io/badge/FastAPI-0.104+-009688?style=for-the-badge&logo=fastapi&logoColor=white)](https://fastapi.tiangolo.com)
[![Next.js](https://img.shields.io/badge/Next.js-14-000000?style=for-the-badge&logo=next.js&logoColor=white)](https://nextjs.org)
[![TypeScript](https://img.shields.io/badge/TypeScript-5.0+-3178C6?style=for-the-badge&logo=typescript&logoColor=white)](https://typescriptlang.org)
[![ONNX](https://img.shields.io/badge/ONNX_Runtime-1.16+-005CED?style=for-the-badge&logo=onnx&logoColor=white)](https://onnxruntime.ai)
[![License](https://img.shields.io/badge/License-MIT-green?style=for-the-badge)](LICENSE)

[Live Demo](#) · [Model on HuggingFace](#) · [Architecture](#architecture) · [Results](#training-results)

</div>

---

## 📖 Overview

AI Face Upscaler is a full-stack application that uses a **custom-trained FSRCNN** (Fast Super-Resolution Convolutional Neural Network) to upscale low-resolution face and portrait images. The model is trained from scratch on the **FFHQ dataset** — no pretrained weights, no black boxes.

This project demonstrates end-to-end ML engineering: from data preparation and model training to ONNX optimization, API serving, and a polished web interface with an interactive before/after comparison slider.

### ✨ Key Features
- 🔬 **Custom FSRCNN** built from scratch in PyTorch
- 📸 **Face-specialized** — trained exclusively on the FFHQ face dataset
- ⚡ **Fast inference** — ONNX Runtime optimized for CPU deployment
- 🎨 **Polished UI** — drag-and-drop upload with interactive comparison slider
- 📊 **Transparent metrics** — PSNR/SSIM benchmarks against bicubic baseline

---

## 🏗️ Architecture

```
┌─────────────────────────────────────────────────────────────────────┐
│                        AI Face Upscaler                             │
├─────────────────────────────────────────────────────────────────────┤
│                                                                     │
│  ┌──────────────┐    ┌──────────────────┐    ┌───────────────────┐  │
│  │   Training    │    │     Backend      │    │     Frontend      │  │
│  │   Pipeline    │    │   (FastAPI)      │    │   (Next.js 14)    │  │
│  │              │    │                  │    │                   │  │
│  │  PyTorch     │    │  ONNX Runtime    │    │  React + TS       │  │
│  │  FFHQ Data   │──▶│  /upscale API    │◀──│  Upload UI        │  │
│  │  MSE + VGG   │    │  /health API     │──▶│  Compare Slider   │  │
│  │  PSNR/SSIM   │    │  Pillow + NumPy  │    │  Results Panel    │  │
│  │              │    │                  │    │                   │  │
│  └──────┬───────┘    └──────────────────┘    └───────────────────┘  │
│         │                     ▲                                     │
│         │    .pth ──▶ .onnx   │                                     │
│         └─────────────────────┘                                     │
│                                                                     │
├─────────────────────────────────────────────────────────────────────┤
│  Training: Google Colab (T4 GPU)                                    │
│  Backend:  Hugging Face Spaces (Docker)                             │
│  Frontend: Vercel                                                   │
└─────────────────────────────────────────────────────────────────────┘
```

### FSRCNN Model Architecture

```
Input (LR Image)
      │
      ▼
┌─────────────────────┐
│ Feature Extraction   │  Conv2d(3→56, k=5, p=2) + PReLU
│ 5×5 kernel          │
└──────────┬──────────┘
           │
           ▼
┌─────────────────────┐
│ Shrinking            │  Conv2d(56→12, k=1) + PReLU
│ 1×1 kernel          │
└──────────┬──────────┘
           │
           ▼
┌─────────────────────┐
│ Non-linear Mapping   │  4× Conv2d(12→12, k=3, p=1) + PReLU
│ 3×3 kernel (×4)     │
└──────────┬──────────┘
           │
           ▼
┌─────────────────────┐
│ Expanding            │  Conv2d(12→56, k=1) + PReLU
│ 1×1 kernel          │
└──────────┬──────────┘
           │
           ▼
┌─────────────────────┐
│ Deconvolution        │  ConvTranspose2d(56→3, k=9, s=2)
│ 9×9 kernel, stride 2│
└──────────┬──────────┘
           │
           ▼
    Output (HR Image)
    2× spatial dims
```

**Total Parameters: ~24,209** — Lightweight enough for real-time CPU inference.

---

## 📁 Project Structure

```
ai-face-upscaler/
├── notebooks/                    # Jupyter notebooks for ML pipeline
│   ├── 01_data_preparation.ipynb #   Download & preprocess FFHQ dataset
│   ├── 02_model_training.ipynb   #   Train FSRCNN with loss curves
│   └── 03_evaluation.ipynb       #   PSNR/SSIM evaluation + ONNX export
│
├── model/                        # ML model source code
│   ├── model.py                  #   ✅ FSRCNN architecture (complete)
│   ├── dataset.py                #   FFHQ dataset loader + LR/HR pairs
│   ├── losses.py                 #   MSE pixel loss + VGG perceptual loss
│   ├── train.py                  #   Training loop with checkpointing
│   ├── evaluate.py               #   PSNR/SSIM evaluation script
│   └── export_onnx.py            #   Export .pth → .onnx
│
├── api/                          # FastAPI backend
│   ├── main.py                   #   App entry + /upscale & /health endpoints
│   ├── upscale.py                #   ONNX Runtime inference pipeline
│   ├── requirements.txt          #   Python dependencies
│   └── Dockerfile                #   Container for deployment
│
├── web/                          # Next.js 14 frontend
│   ├── app/
│   │   ├── page.tsx              #   Main upload + comparison page
│   │   └── layout.tsx            #   Root layout with metadata
│   ├── components/
│   │   ├── ImageUploader.tsx     #   Drag-and-drop upload component
│   │   ├── CompareSlider.tsx     #   Before/after comparison slider
│   │   └── ResultsPanel.tsx      #   Metadata + download panel
│   ├── lib/
│   │   └── api.ts                #   API client for backend calls
│   └── package.json              #   Node.js dependencies
│
├── .gitignore                    # Python + Node.js + ML checkpoints
├── .cursorrules                  # Code standards for AI assistants
└── README.md                     # This file
```

---

## 🧪 Training Results

> 📋 *Results will be populated after model training is complete.*

### Metrics Comparison

| Metric | Bicubic (Baseline) | FSRCNN (Ours) | Improvement |
|--------|-------------------|---------------|-------------|
| PSNR ↑ | — dB              | — dB          | — dB        |
| SSIM ↑ | —                 | —             | —           |

### Training Configuration

| Parameter       | Value                          |
|----------------|--------------------------------|
| Dataset         | FFHQ (subset)                  |
| Training Images | 5,000–10,000                   |
| Scale Factor    | 2×                             |
| Loss Function   | MSE + VGG Perceptual (α + β)   |
| Optimizer       | Adam (lr=1e-3)                 |
| Epochs          | 100                            |
| Batch Size      | 16                             |
| GPU             | NVIDIA T4 (Google Colab Free)  |

---

## 🖼️ Before / After Examples

> 📋 *Example images will be added after training and evaluation.*

| Original (Low-Res) | Bicubic Upscale | FSRCNN Upscale (Ours) |
|--------------------|----------------|-----------------------|
| *Coming soon*      | *Coming soon*  | *Coming soon*         |

---

## 🚀 Getting Started

### Prerequisites

- **Python 3.10+** with pip
- **Node.js 18+** with npm
- **Git**

### 1. Clone the Repository

```bash
git clone https://github.com/yourusername/ai-face-upscaler.git
cd ai-face-upscaler
```

### 2. Set Up the Backend

```bash
cd api
python -m venv venv
source venv/bin/activate  # Windows: venv\Scripts\activate
pip install -r requirements.txt
```

### 3. Set Up the Frontend

```bash
cd web
npm install
```

### 4. Environment Variables

Create `.env` files:

**`api/.env`**
```env
MODEL_PATH=./model.onnx
MAX_FILE_SIZE_MB=10
CORS_ORIGINS=http://localhost:3000
```

**`web/.env.local`**
```env
NEXT_PUBLIC_API_URL=http://localhost:8000
```

### 5. Run Locally

```bash
# Terminal 1: Backend
cd api
uvicorn main:app --reload --port 8000

# Terminal 2: Frontend
cd web
npm run dev
```

Open [http://localhost:3000](http://localhost:3000) to use the application.

---

## 🏋️ Training the Model

Training is designed for **Google Colab** with free T4 GPU access.

1. Open `notebooks/01_data_preparation.ipynb` in Colab
2. Follow the steps to download and preprocess the FFHQ dataset
3. Open `notebooks/02_model_training.ipynb` to train the model
4. Open `notebooks/03_evaluation.ipynb` to evaluate and export to ONNX

> 💡 Checkpoints are saved to Google Drive automatically for persistence between Colab sessions.

---

## 🌐 Deployment

### Backend → Hugging Face Spaces

```bash
# Build and push Docker container
cd api
# Follow Hugging Face Spaces Docker deployment guide
```

### Frontend → Vercel

```bash
cd web
npx vercel --prod
```

> 📋 *Detailed deployment instructions will be added after initial development.*

---

## 📚 References

- **FSRCNN Paper**: Dong, C., Loy, C.C., Tang, X. (2016). *Accelerating the Super-Resolution Convolutional Neural Network*. ECCV 2016. [arXiv:1608.00367](https://arxiv.org/abs/1608.00367)
- **FFHQ Dataset**: Karras, T., Laine, S., Aila, T. (2019). *A Style-Based Generator Architecture for Generative Adversarial Networks*. [GitHub](https://github.com/NVlabs/ffhq-dataset)
- **ONNX Runtime**: [onnxruntime.ai](https://onnxruntime.ai)

---

## 📄 License

This project is licensed under the MIT License — see the [LICENSE](LICENSE) file for details.

---

<div align="center">

**Built with ❤️ as a portfolio project showcasing ML engineering skills**

*From data preparation → model training → ONNX optimization → API serving → polished UI*

</div>