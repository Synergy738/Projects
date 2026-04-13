// web/lib/api.ts — API Client for FastAPI Backend
// =============================================================================
// Handles all communication between the Next.js frontend and the FastAPI
// backend. Uses the native fetch API with proper error handling.
//
// Functions:
//   - upscaleImage(file: File): Promise<UpscaleResult>
//     Uploads an image to POST /upscale and returns the upscaled image blob
//     along with metadata (original/upscaled resolution, processing time).
//
//   - checkHealth(): Promise<boolean>
//     Calls GET /health to verify the backend is running.
//
// Configuration:
//   - Base URL read from NEXT_PUBLIC_API_URL environment variable
//   - Timeout: 60 seconds (model inference may take time on CPU)
//   - Retry: 1 retry on network failure
//
// Types:
//   - UpscaleResult: { image: Blob; metadata: ImageMetadata }
//   - ImageMetadata: { originalWidth, originalHeight, upscaledWidth,
//                      upscaledHeight, processingTimeMs }
// =============================================================================

// TODO: Define UpscaleResult and ImageMetadata types
// TODO: Implement upscaleImage function
// TODO: Implement checkHealth function
// TODO: Add error handling with typed errors
// TODO: Add request timeout handling

export {};
