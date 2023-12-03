using DataItems.LogicItems;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopAppMediaBazaar.ChildForms;
using DesktopAppMediaBazaar.CustomElements.Classes;
using System.Security.Permissions;
using DesktopAppMediaBazaar.Forms;
using Vacation = DesktopAppMediaBazaar.Forms.Vacations;

namespace DesktopAppMediaBazaar
{
    public partial class Dashboard : Form
    {
        private Employee _loggedInEmployee;
        #region WINDOW ROUND CORNER
        private bool aeroShadow;
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
            SetButtonStyle(btnAnnouncements);
            SetButtonStyle(btnBusiness);
            SetButtonStyle(btnEmployee);
            SetButtonStyle(btnDepartments);
            SetButtonStyle(btnTimesheet);
            SetButtonStyle(btnShifts);
            SetButtonStyle(btnCancelledShifts);
            SetButtonStyle(btnVacations);
        }

        private void SetButtonImages()
        {
            SetImageButtonStyle(btnAnnouncements, btnAnnouncements.Image, DesktopAppMediaBazaar.Properties.Resources.Announcements_Invert);
            SetImageButtonStyle(btnBusiness, btnBusiness.Image, DesktopAppMediaBazaar.Properties.Resources.Business_Invert);
            SetImageButtonStyle(btnEmployee, btnEmployee.Image, DesktopAppMediaBazaar.Properties.Resources.Employees_Invert);
            SetImageButtonStyle(btnDepartments, btnDepartments.Image, DesktopAppMediaBazaar.Properties.Resources.Departments_Invert);
            SetImageButtonStyle(btnTimesheet, btnTimesheet.Image, DesktopAppMediaBazaar.Properties.Resources.Timesheet_Invert);
            SetImageButtonStyle(btnShifts, btnShifts.Image, DesktopAppMediaBazaar.Properties.Resources.shifts_Invert);
            SetImageButtonStyle(btnCancelledShifts, btnCancelledShifts.Image, DesktopAppMediaBazaar.Properties.Resources.CancelledShift_Invert);
            SetImageButtonStyle(btnVacations, btnVacations.Image, DesktopAppMediaBazaar.Properties.Resources.Vacations_Invert);
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
            if (button == btnAnnouncements)
            {
                return Color.FromArgb(156, 84, 213);
            }
            else if (button == btnBusiness)
            {
                return Color.FromArgb(156, 84, 213);
            }
            else if (button == btnTimesheet)
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
                //ResetButtonStyle();
                activeButton = null;
            }
        }

        private void hideSubMenu()
        {
            panelInformation.Visible = false;
            panelInformation2.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        #endregion

        public Dashboard(Employee loggedInEmployee)
        {
            InitializeComponent();
            SetButtonStyles();
            SetButtonImages();
            _loggedInEmployee = loggedInEmployee;
            panelChildForm.SuspendLayout();
            openChildForm(new AnnouncementsForm(_loggedInEmployee));
            panelChildForm.ResumeLayout();
            SetActiveButton(btnAnnouncements);
            hideSubMenu();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            _loggedInEmployee = null;
            Login form = new Login();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btnBusiness_Click(object sender, EventArgs e)
        {
            showSubMenu(panelInformation);
        }

        private void btnTimesheet_Click(object sender, EventArgs e)
        {
            showSubMenu(panelInformation2);
        }

        private void btnAnnouncements_Click(object sender, EventArgs e)
        {
            openChildForm(new AnnouncementsForm(_loggedInEmployee));
            SetActiveButton((Button)sender);
        }

        private static bool IsDwmCompositionEnabled()
        {
            if (Environment.OSVersion.Version.Major < 6)
                return false;

            bool isEnabled;
            NativeMethods.DwmIsCompositionEnabled(out isEnabled);

            return isEnabled;
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            openChildForm(new EmployeesForm(_loggedInEmployee));
            SetActiveButton((Button)sender);
        }

        private void btnDepartments_Click(object sender, EventArgs e)
        {
            openChildForm(new Departments(_loggedInEmployee));
            SetActiveButton((Button)sender);
        }

        private void btnShifts_Click(object sender, EventArgs e)
        {
            panelChildForm.SuspendLayout();
            openChildForm(new Shifts(_loggedInEmployee));
            panelChildForm.ResumeLayout();
            SetActiveButton((Button)sender);
        }

        private void btnCancelledShifts_Click(object sender, EventArgs e)
        {
            panelChildForm.SuspendLayout();
            openChildForm(new Shifts(_loggedInEmployee));
            panelChildForm.ResumeLayout();
            SetActiveButton((Button)sender);
        }

        private void btnVacations_Click(object sender, EventArgs e)
        {
            openChildForm(new Vacation(_loggedInEmployee));
            SetActiveButton((Button)sender);
        }
    }
}
