// web/app/layout.tsx — Root Layout for Next.js 14 App Router
// =============================================================================
// Defines the root HTML structure, metadata, and global providers for the
// AI Face Upscaler web application.
//
// Features:
//   - Inter font from Google Fonts for modern typography
//   - Global metadata for SEO (title, description, Open Graph)
//   - Dark theme support
//   - Tailwind CSS global styles
// =============================================================================

// TODO: Import Inter font from next/font/google
// TODO: Import global CSS
// TODO: Define metadata export (title, description, OG tags)
// TODO: Implement RootLayout component with html/body structure
// TODO: Add dark mode class to html element

export default function RootLayout({
  children,
}: {
  children: React.ReactNode;
}) {
  return (
    <html lang="en">
      <body>{children}</body>
    </html>
  );
}
