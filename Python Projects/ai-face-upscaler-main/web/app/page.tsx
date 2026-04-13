// web/app/page.tsx — Main Upload & Comparison UI
// =============================================================================
// The primary page of the AI Face Upscaler application. This page provides:
//
//   1. Hero section with project title and description
//   2. Drag-and-drop image upload area (ImageUploader component)
//   3. Real-time upload preview
//   4. Loading state with progress indicator during model inference
//   5. Before/After comparison slider (CompareSlider component)
//   6. Results panel with metadata (ResultsPanel component)
//   7. Download upscaled image button
//
// State Management:
//   - Original image (File + preview URL)
//   - Upscaled image (Blob + preview URL)
//   - Upload/processing status (idle | uploading | processing | done | error)
//   - Error messages
//   - Image metadata (original resolution, upscaled resolution)
//
// This is a client component due to interactive state management.
// =============================================================================

// TODO: Mark as "use client"
// TODO: Import ImageUploader, CompareSlider, ResultsPanel components
// TODO: Import API functions from lib/api
// TODO: Implement state management for upload flow
// TODO: Implement handleUpload function
// TODO: Implement handleDownload function
// TODO: Build responsive layout with all sections

export default function Home() {
  return (
    <main>
      <h1>AI Face Upscaler</h1>
      <p>Upload a face photo to enhance it with AI-powered super-resolution.</p>
      {/* TODO: Add ImageUploader component */}
      {/* TODO: Add CompareSlider component (shown after upscaling) */}
      {/* TODO: Add ResultsPanel component (shown after upscaling) */}
    </main>
  );
}
