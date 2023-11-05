using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesktopAppMediaBazaar.CustomElements;

namespace DesktopAppMediaBazaar.CustomElements
{
    public class NoHoverButton : Button
    {
        public NoHoverButton()
        {
            // Prevent the button from drawing its own border
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;

            // Set the hover and click colors to the button's initial BackColor
            this.FlatAppearance.MouseOverBackColor = this.BackColor;
            this.FlatAppearance.MouseDownBackColor = this.BackColor;
        }

        public new Color BackColor
        {
            get => base.BackColor;
            set
            {
                base.BackColor = value;
                this.FlatAppearance.MouseOverBackColor = value;
                this.FlatAppearance.MouseDownBackColor = value;
            }
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            // Fill the background
            pevent.Graphics.FillRectangle(new SolidBrush(this.BackColor), 0, 0, this.Width, this.Height);

            // Initialize the padding for the text and image
            int horizontalPadding = 8; // You can adjust this padding as needed
            int textImageSpacing = 4; // Spacing between the text and the image

            // Calculate the Y position to vertically center the image and text
            int verticalCenter = (this.Height - (this.Image?.Height ?? 0)) / 2;

            // Draw the button image if one exists
            if (this.Image != null)
            {
                Point imagePosition = new Point(horizontalPadding, verticalCenter);
                pevent.Graphics.DrawImage(this.Image, imagePosition);
            }

            // Calculate the X position for text, considering the image width and spacing if the image exists
            int textLeftStart = horizontalPadding + (this.Image?.Width ?? 0) + (this.Image != null ? textImageSpacing : 0);

            // Draw the button text
            Rectangle textRect = new Rectangle(textLeftStart, 0, this.Width - textLeftStart, this.Height);
            TextRenderer.DrawText(
                pevent.Graphics,
                this.Text,
                this.Font,
                textRect,
                this.ForeColor,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter
            );
        }


    }
}