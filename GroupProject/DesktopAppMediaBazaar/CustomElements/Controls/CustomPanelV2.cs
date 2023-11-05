using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System;

namespace DesktopAppMediaBazaar.CustomElements.Controls
{
    public class CustomPanelV2 : Panel
    {
        private readonly string leftSideColor = "#9C54D5";
        private readonly string rightSideColor = "#E5E5E5";

        public enum PanelSide
        {
            Left,
            Right
        }

        #region Properties

        [Browsable(false)]
        [Description("The background color of the component.")]
        public override Color BackColor { get; set; }

        private PanelSide _Side = PanelSide.Left;
        public PanelSide Side
        {
            get { return _Side; }
            set
            {
                _Side = value;
                if (_Side == PanelSide.Left)
                    BackColor = ColorTranslator.FromHtml(leftSideColor);
                else
                    BackColor = ColorTranslator.FromHtml(rightSideColor);

                Invalidate();
            }
        }

        #endregion

        protected override void OnClick(EventArgs e)
        {
            Focus();
            base.OnClick(e);
        }

        public CustomPanelV2()
        {
            DoubleBuffered = true;

            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.UserPaint, true);

            UpdateStyles();

            ForeColor = ColorTranslator.FromHtml("#FAFAFA");
            BackColor = ColorTranslator.FromHtml(leftSideColor);

            BorderStyle = BorderStyle.None;
            Dock = DockStyle.Left;
            Cursor = Cursors.Arrow;
        }
    }
}