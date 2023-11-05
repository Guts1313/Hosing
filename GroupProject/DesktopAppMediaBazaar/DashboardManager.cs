using DataItems.LogicItems;
using DesktopAppMediaBazaar.ChildForms;
using DesktopAppMediaBazaar.CustomElements.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopAppMediaBazaar.Forms;

namespace DesktopAppMediaBazaar
{
    public partial class DashboardManager : Form
    {
        private Employee _loggedInEmployee;
        #region WINDOW ROUND CORNER
        private bool aeroShadow;
        private static bool IsDwmCompositionEnabled()
        {
            if (Environment.OSVersion.Version.Major < 6)
                return false;

            bool isEnabled;
            NativeMethods.DwmIsCompositionEnabled(out isEnabled);

            return isEnabled;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Demand();
                aeroShadow = IsDwmCompositionEnabled();

                var cp = base.CreateParams;

                return cp;
            }
        }
        protected override void WndProc(ref Message m)
        {
            switch ((NativeMethods.WindowsMessages)m.Msg)
            {
                case NativeMethods.WindowsMessages.WM_NCPAINT:
                    if (aeroShadow)
                    {
                        var ncAttr = NativeMethods.DWMWINDOWATTRIBUTE.DWMWA_NCRENDERING_POLICY;
                        var dwAttrPntr = 2;
                        NativeMethods.DwmSetWindowAttribute(Handle, ncAttr, ref dwAttrPntr, 4);

                        var margins = new NativeMethods.MARGINS()
                        {
                            cyBottomHeight = 1,
                            cxLeftWidth = 1,
                            cxRightWidth = 1,
                            cyTopHeight = 1
                        };

                        NativeMethods.DwmExtendFrameIntoClientArea(Handle, ref margins);
                    }
                    break;
                case NativeMethods.WindowsMessages.WM_NCACTIVATE:
                    if (m.WParam == IntPtr.Zero)
                        LogInContainer.TitleBarTextColor = Color.DarkGray;
                    else
                        LogInContainer.TitleBarTextColor = Color.Gainsboro;
                    break;
            }
            base.WndProc(ref m);
        }
        #endregion
        #region BUTTON STYLE

        private class ButtonImages
        {
            public Image Original { get; set; }
            public Image Inverted { get; set; }
        }

        private Button activeButton = null;
        private Dictionary<Button, ButtonImages> buttonImages = new Dictionary<Button, ButtonImages>();
        private Form activeForm = null;

        private void SetButtonStyles()
        {
            SetButtonStyle(btnEmployees);
            SetButtonStyle(btnShifts);

        }

        private void SetButtonImages()
        {
            SetImageButtonStyle(btnEmployees, btnEmployees.Image, DesktopAppMediaBazaar.Properties.Resources.Employees_Invert);
            SetImageButtonStyle(btnShifts, btnShifts.Image, DesktopAppMediaBazaar.Properties.Resources.shifts_Invert);

        }

        private void SetImageButtonStyle(Button button, Image originalImage, Image invertedImage)
        {
            SetButtonStyle(button);
            buttonImages[button] = new ButtonImages { Original = originalImage, Inverted = invertedImage };
        }

        private void SetButtonStyle(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderColor = Color.FromArgb(124, 75, 163);
            button.FlatAppearance.MouseDownBackColor = Color.FromArgb(124, 75, 163);
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(229, 229, 229);
            button.FlatAppearance.BorderSize = 0;
            button.MouseEnter += Button_MouseEnter;
            button.MouseMove += Button_MouseMove;
            button.MouseLeave += Button_MouseLeave;
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                button.ForeColor = Color.FromArgb(156, 84, 213);
                if (buttonImages.ContainsKey(button))
                {
                    button.Image = buttonImages[button].Inverted;
                }
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                if (button != activeButton)
                {
                    button.ForeColor = Color.FromArgb(229, 229, 229);
                    if (buttonImages.ContainsKey(button))
                    {
                        button.Image = buttonImages[button].Original;
                    }
                }
                else
                {
                    button.ForeColor = Color.FromArgb(156, 84, 213);
                    if (buttonImages.ContainsKey(button))
                    {
                        button.Image = buttonImages[button].Inverted;
                    }
                }
            }
        }

        private void Button_MouseMove(object sender, MouseEventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                Button_MouseEnter(button, EventArgs.Empty);
            }
        }

        private void HighlightButton()
        {
            activeButton.BackColor = Color.FromArgb(229, 229, 229);
            activeButton.ForeColor = Color.FromArgb(156, 84, 213);
            if (buttonImages.ContainsKey(activeButton))
            {
                activeButton.Image = buttonImages[activeButton].Inverted;
            }
        }

        private void SetActiveButton(Button button)
        {
            if (activeButton != null)
            {
                ResetButtonStyle();
            }

            activeButton = button;

            HighlightButton();
        }

        private void ResetButtonStyle()
        {
            if (activeButton != null)
            {
                activeButton.BackColor = GetOriginalButtonColor(activeButton);
                activeButton.ForeColor = Color.FromArgb(229, 229, 229);
                if (buttonImages.ContainsKey(activeButton))
                {
                    activeButton.Image = buttonImages[activeButton].Original;
                }
            }
        }

        private Color GetOriginalButtonColor(Button button)
        {
            if (button == btnShifts)
            {
                return Color.FromArgb(156, 84, 213);
            }
            else if (button == btnEmployees)
            {
                return Color.FromArgb(156, 84, 213);
            }
            else if (button == btnLogout)
            {
                return Color.FromArgb(156, 84, 213);
            }
            return Color.FromArgb(124, 75, 163);
        }

        #endregion
        #region CHILD FORMS

        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ChildForm_Closed(object sender, EventArgs e)
        {
            if (activeButton != null)
            {
                activeButton = null;
            }
        }


        #endregion
        public DashboardManager(Employee loggedInEmployee)
        {
            InitializeComponent();
            SetButtonStyles();
            SetButtonImages();
            _loggedInEmployee = loggedInEmployee;
            panelChildForm.SuspendLayout();
            openChildForm(new EmployeesForm(_loggedInEmployee));
            panelChildForm.ResumeLayout();
            SetActiveButton(btnEmployees);
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            panelChildForm.SuspendLayout();
            openChildForm(new EmployeesForm(_loggedInEmployee));
            panelChildForm.ResumeLayout();
            SetActiveButton((Button)sender);
        }

        private void btnShifts_Click(object sender, EventArgs e)
        {
            panelChildForm.SuspendLayout();
            openChildForm(new Shifts(_loggedInEmployee));
            panelChildForm.ResumeLayout();
            SetActiveButton((Button)sender);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            _loggedInEmployee = null;
            Login form = new Login();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
