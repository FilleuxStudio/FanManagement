using System.Drawing.Drawing2D;

namespace ManagementFans.UI
{
    internal class RoundButton : Button
    {
        private int cornerRadius;

        public int CornerRadius
        {
            get { return cornerRadius; }
            set
            {
                if (value >= 0)
                {
                    cornerRadius = value;
                    Invalidate();
                }
                else
                {
                    throw new ArgumentException("Le rayon de coin doit être supérieur ou égal à zéro.");
                }
            }
        }

        public RoundButton()
        {
            CornerRadius = 10; // Valeur par défaut du rayon des coins
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            GraphicsPath path = new GraphicsPath();
            int radius = CornerRadius;
            int diameter = radius * 2;
            Rectangle bounds = new Rectangle(0, 0, Width - 1, Height - 1);

            path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
            path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90);
            path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            Region = new Region(path);
        }
    }

}
