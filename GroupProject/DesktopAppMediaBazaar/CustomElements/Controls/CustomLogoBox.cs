﻿using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace DesktopAppMediaBazaar.CustomElements.Controls
{
    public class CustomLogoBox : Control
    {
        public CustomLogoBox()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint |
                     ControlStyles.ResizeRedraw, true);

            Size = new Size(310, 146);
            MinimumSize = new Size(100, 42);
            BackColor = ColorTranslator.FromHtml("#A85FE1");
        }
        
        private void DrawBorder(Graphics g)
        {
            var borderRect = new Rectangle(1, 0, Width, Height - 1);

            using (var border = new Pen(ColorTranslator.FromHtml("#B986E5"), 2f))
            using (var fill = new SolidBrush(ColorTranslator.FromHtml("#A85FE1")))
            {
                g.DrawRectangle(border, borderRect);
                g.FillRectangle(fill, 1, 0, Width - 1, Height - 1);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.None;

            DrawBorder(g);

            base.OnPaint(e);
        }
    }
}