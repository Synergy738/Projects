using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms; 
using System.Drawing.Drawing2D;
using System.Windows.Forms.VisualStyles;

namespace TitanicSyndrome
{
    internal class RJPanel : Panel
    {
        private int borderRadius = 30;
        private float gradientAngle = 90F;
        private Color gradientTopColor = Color.DodgerBlue;
        private Color gradientBottomColor = Color.CadetBlue;

        public RJPanel()
        {
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            this.Size = new Size(350, 200);
        }

        public int BorderRadius { get { return borderRadius; } set { borderRadius = value; this.Invalidate(); } }
        public float GradientAngle { get { return gradientAngle; } set { gradientAngle = value; this.Invalidate(); } }
        public Color GradientTopColor { get { return gradientTopColor; } set { gradientTopColor = value; this.Invalidate(); } }
        public Color GradientBottomColor { get { return gradientBottomColor; } set { gradientBottomColor = value; this.Invalidate(); } }


        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            LinearGradientBrush brushRJ = new LinearGradientBrush(this.ClientRectangle, this.GradientTopColor, this.GradientBottomColor, this.GradientAngle);
            Graphics graphicsRJ = e.Graphics;

            RectangleF rectF = new RectangleF(0, 0, this.Width, this.Height);   
            if (borderRadius > 2)
            {
                using (GraphicsPath path = GetFigurePath(rectF, borderRadius))
                using (Pen pen = new Pen(this.Parent.BackColor, 2))
                {
                    this.Region = new Region(path);
                    e.Graphics.DrawPath(pen, path);                    
                }
            }
            else { this.Region = new Region(rectF); }
        }
    }
}