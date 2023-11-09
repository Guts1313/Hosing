using System.Windows.Forms;
using System.Drawing;

namespace DesktopAppMediaBazaar.CustomElements.Controls
{
    public class CustomLabelV2 : Label
    {
        public CustomLabelV2()
        {
            Font = new Font("Segoe UI", 9, FontStyle.Regular);
            BackColor = Color.Transparent;
            ForeColor = ColorTranslator.FromHtml("#72767F");
            Cursor = Cursors.Arrow;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            Focus();
        }
    }
}