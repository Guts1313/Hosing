using System.Drawing;
using System.Windows.Forms;
using System;
using DesktopAppMediaBazaar.CustomElements.Classes;
using DesktopAppMediaBazaar.CustomElements.Classes;

namespace DesktopAppMediaBazaar.CustomElements.Controls
{
    public class CustomLinkLabel : LinkLabel
    {
        #region Fields

        private readonly Color linkColor       = ColorTranslator.FromHtml("#9C54D5");
        private readonly Color activeLinkColor = ColorTranslator.FromHtml("#462964");
        private readonly Cursor NativeHand;

        #endregion

        public CustomLinkLabel()
        {
            Font = new Font("Segoe UI", 9, FontStyle.Regular);
            BackColor = Color.Transparent;
            LinkColor = linkColor;
            ActiveLinkColor = activeLinkColor;
            VisitedLinkColor = activeLinkColor;
            LinkBehavior = LinkBehavior.NeverUnderline;
            Cursor = Cursors.Arrow;

            NativeHand = new Cursor(NativeMethods.LoadCursor(IntPtr.Zero, NativeConstants.IDC_HAND));
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            Focus();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (OverrideCursor == Cursors.Hand)
                OverrideCursor = NativeHand;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            OverrideCursor = null;
        }

        protected override void OnInvalidated(InvalidateEventArgs e)
        {
            base.OnInvalidated(e);
            ActiveLinkColor  = activeLinkColor;
            VisitedLinkColor = activeLinkColor;
        }
    }
}