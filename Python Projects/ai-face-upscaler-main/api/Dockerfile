# api/Dockerfile — Container for the FastAPI Backend
# =============================================================================
# Multi-stage Docker build for the AI Face Upscaler API.
# Uses a slim Python base to minimize image size.
#
# Build:  docker build -t ai-face-upscaler-api .
# Run:    docker run -p 8000:8000 ai-face-upscaler-api
# =============================================================================

# TODO: Implement multi-stage Dockerfile
# Stage 1: Install dependencies
# Stage 2: Copy application code + ONNX model
# Stage 3: Run uvicorn with production settings
#
# Notes:
#   - Use python:3.11-slim as base image
#   - Copy only requirements.txt first for layer caching
#   - Do not include PyTorch in production (ONNX Runtime only)
#   - Expose port 8000
#   - Set PYTHONUNBUFFERED=1 for proper logging
