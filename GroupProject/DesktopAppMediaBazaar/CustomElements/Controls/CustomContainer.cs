﻿using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System;
using System.Drawing.Drawing2D;

namespace DesktopAppMediaBazaar.CustomElements.Controls
{
    public class CustomContainer : ContainerControl
    {
        #region Fields

        private readonly int draggableHeight;
        private bool isBeingDragged;
        private Point mouseLocation;

        private Rectangle titleBarRect;
        private int titleBarStringLeft;

        #endregion
        #region Enumerations

        public enum Alignment
        {
            Left,
            Center
        }

        #endregion
        #region Custom Properties

        private bool _ControlMode;
        protected bool ControlMode
        {
            get { return _ControlMode; }
            set
            {
                _ControlMode = value;
                Invalidate();
            }
        }

        private Alignment _TextAlignment = Alignment.Left;
        [Browsable(true)]
        [Description("Indicates how the window title should be aligned.")]
        public Alignment TextAlignment
        {
            get { return _TextAlignment; }
            set
            {
                _TextAlignment = value;
                Invalidate();
            }
        }

        private bool _DrawIcon;
        [Browsable(true)]
        [Description("Determines whether the icon specified in the parent form should be drawn.")]
        public bool DrawIcon
        {
            get { return _DrawIcon; }
            set
            {
                _DrawIcon = value;
                Invalidate();
            }
        }

        private Color _TitleBarTextColor = Color.Gainsboro;
        [Browsable(true)]
        [Description("Sets the title bar title color.")]
        public Color TitleBarTextColor
        {
            get { return _TitleBarTextColor; }
            set
            {
                _TitleBarTextColor = value;
                Invalidate();
            }
        }

        #endregion
        #region Hidden Properties

        [Bindable(false),  EditorBrowsable(EditorBrowsableState.Never)]
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new ImageLayout BackgroundImageLayout { get; set; }

        [Bindable(false),  EditorBrowsable(EditorBrowsableState.Never)]
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new Image BackgroundImage { get; set; }

        #endregion
        #region Functions

        /// <summary>
        /// Returns true if the mouse is over the title bar icon.
        /// </summary>
        private bool IsOverTitleBarIcon(MouseEventArgs e)
        {
            var point = (e.X > 8 && e.X < 26) && (e.Y > 6 && e.Y < 22);
            return point;
        }

        #endregion
        #region EventArgs

        protected override void OnSizeChanged(EventArgs e)
        {
            if (!ControlMode)
                titleBarRect = new Rectangle(9, 2, Width, draggableHeight);

            base.OnSizeChanged(e);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            if (titleBarRect.Contains(e.Location))
            {
                isBeingDragged = true;
                mouseLocation = e.Location;
            }

            base.OnMouseDown(e);
        }

        protected override void OnMouseDoubleClick(MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            // Close when double-clicking on the title bar icon
            if (_DrawIcon && IsOverTitleBarIcon(e))
                Application.Exit();

            base.OnMouseDoubleClick(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (isBeingDragged)
                Parent.Location = Point.Subtract(MousePosition, (Size)mouseLocation);

            base.OnMouseMove(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (isBeingDragged)
                isBeingDragged = false;

            base.OnMouseUp(e);
        }

        #endregion

        public CustomContainer()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint |
                     ControlStyles.ResizeRedraw, true);

            DoubleBuffered = true;
            Dock = DockStyle.Fill;
            Padding = new Padding(0, 31, 0, 0);
            MinimumSize = new Size(100, 42);

            Font = new Font("Segoe UI", 9);
            Cursor = Cursors.Arrow;

            draggableHeight = 28;
        }

        protected override void CreateHandle()
        {
            base.CreateHandle();

            ParentForm.FormBorderStyle = FormBorderStyle.None;
            ParentForm.TransparencyKey = Color.Fuchsia; // IMPORTANT!
            ParentForm.BackColor = SystemColors.ControlDarkDark;
            ParentForm.MaximumSize = Screen.FromRectangle(ParentForm.Bounds).WorkingArea.Size;
        }

        /// <summary>
        /// Draws the title bar.
        /// </summary>
        /// 
        /// <param name="g">Reference to the Graphics class.</param>
        private void DrawTitleBar(Graphics g)
        {
            // Define the start and end points of the gradient.
            Point startPoint = new Point(0, 0); // Top-left corner of the title bar
            Point endPoint = new Point(Width, 0); // Top-right corner of the title bar

            // Create a Color array that represents the colors to use at corresponding positions along the gradient.
            Color[] gradientColors = new Color[]
            {
                ColorTranslator.FromHtml("#9C54D5"), // Start color
                ColorTranslator.FromHtml("#9C54D5"), // Middle color
                ColorTranslator.FromHtml("#E5E5E5")  // End color
            };

            // Create a new instance of the LinearGradientBrush
            using (LinearGradientBrush brush = new LinearGradientBrush(startPoint, endPoint, gradientColors[0], gradientColors[2]))
            {
                // Create a Blend object to define the mix of colors along the gradient.
                Blend blend = new Blend();
                blend.Positions = new float[] { 0, 0.4f, 1 }; // Positions of the gradient stops, with the third color starting earlier
                blend.Factors = new float[] { 0, 1, 1 }; // Intensity of the colors at those positions

                // Assign the blend to the brush
                brush.InterpolationColors = new ColorBlend
                {
                    Positions = blend.Positions,
                    Colors = gradientColors
                };

                // Fill the rectangle representing the title bar with the gradient
                g.FillRectangle(brush, new Rectangle(0, 0, Width, 31));
            }
            // ========== FOR TESTING PURPOSES ONLY! ==========
            // PLACEMENT BACKGROUNDS FOR THE CONTROLBOX BUTTONS
            // ================================================
            //          using (var brush = new SolidBrush(ColorTranslator.FromHtml("#FF0000")))
            //              g.FillRectangle(brush, new Rectangle(Width - 46, 0, 46, 31));
            //          
            //          using (var brush = new SolidBrush(ColorTranslator.FromHtml("#00FF00")))
            //              g.FillRectangle(brush, new Rectangle(Width - 92, 0, 46, 31));
            //          
            //          using (var brush = new SolidBrush(ColorTranslator.FromHtml("#0000FF")))
            //              g.FillRectangle(brush, new Rectangle(Width - 138, 0, 46, 31));
        }

        /// <summary>
        /// Draws a 16x16 icon like the native window title bar.
        /// </summary>
        /// 
        /// <param name="g">Reference to the Graphics class.</param>
        private void DrawTitleBarIcon(Graphics g)
        {
            if (_DrawIcon)
            {
                titleBarStringLeft = _TextAlignment == Alignment.Left ? 33 : 5;
                var iconRect = new Rectangle(10, 7, 16, 16);

                g.DrawIcon(FindForm().Icon, iconRect);
            }
            else
                titleBarStringLeft = 5;
        }

        /// <summary>
        /// Draws the text set in the Text property.
        /// </summary>
        /// 
        /// <param name="g">Reference to the Graphics class.</param>
        private void DrawTitleBarText(Graphics g)
        {
            var stringRect = new Rectangle(titleBarStringLeft, 7, Width - 13, Height);

            switch (_TextAlignment)
            {
                case Alignment.Left:
                    using (var stringColor = new SolidBrush(_TitleBarTextColor))
                    using (var sf = new StringFormat
                    {
                        Alignment = StringAlignment.Near,
                        LineAlignment = StringAlignment.Near
                    })
                    {
                        g.DrawString(Text, Font, stringColor, stringRect, sf);
                    }
                    break;
                case Alignment.Center:
                    using (var stringColor = new SolidBrush(_TitleBarTextColor))
                    using (var sf = new StringFormat
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Near
                    })
                    {
                        g.DrawString(Text, Font, stringColor, stringRect, sf);
                    }
                    break;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.Clear(SystemColors.Control);

            DrawTitleBar(g);
            DrawTitleBarIcon(g);
            DrawTitleBarText(g);

            base.OnPaint(e);
        }
    }
}