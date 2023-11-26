using AnimatorNS;
using BussinessLayer.Controllers;
using DataAccessLayer.DAL;
using DesktopAppMediaBazaar.CustomElements;
using DesktopAppMediaBazaar.CustomElements.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace DesktopAppMediaBazaar
{
    public partial class ResetPassword : Form
    {
        private EmployeeController _employeeController;
        private string _email;

        private readonly Timer tmrFadeIn;
        private bool aeroShadow;
        private Animator animator;

        #region Constants

        /// <summary>
        /// Allows minimizing from taskbar.
        /// </summary>
        private const int WS_MINIMIZEBOX = 0x20000;

        /// <summary>
        /// Paints all descendants of a window in bottom-to-top painting order
        /// using double-buffering.
        /// </summary>
        private const int WS_EX_COMPOSITED = 0x02000000;

        #endregion

        public ResetPassword(string email)
        {
            InitializeComponent();
            _employeeController = new EmployeeController(new DALEmployeeController());
            _email = email;

            animator = new Animator()
            {
                AnimationType = AnimationType.Transparent,
                Interval = 8,
                MaxAnimationTime = 1000,
                TimeStep = 0.02F
            };

            tmrFadeIn = new Timer
            {
                Interval = 1,
                Enabled = true
            };
            tmrFadeIn.Tick += FadeIn_Tick;

            Opacity = 0;

            // Initially disable the confirm button
            rbConfirm.Enabled = false;

            cbxPassword.TextChanged += ValidateInput;
            ctbxConfirmPassword.TextChanged += ValidateInput;
        }

        private void ValidateInput(object sender, EventArgs e)
        {
            rbConfirm.Enabled = !string.IsNullOrEmpty(cbxPassword.Text) &&
                                !string.IsNullOrEmpty(ctbxConfirmPassword.Text);
        }

        private void ResetPassword_Shown(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item.Visible)
                {
                    animator.Show(item);
                }
            }
        }

        private async void rbConfirm_Click(object sender, EventArgs e)
        {
            if (cbxPassword.Text != ctbxConfirmPassword.Text)
            {
                RJMessageBox.Show("Passwords do not match");
                return;
            }

            // Disable inputs and start animation
            cbxPassword.Enabled = false;
            ctbxConfirmPassword.Enabled = false;
            rbConfirm.Enabled = false;
            animator.Hide(rbConfirm, true, Animation.HorizSlide);
            animator.Show(lbResettingPassword);

            await Task.Delay(2000);

            try
            {
                if (_employeeController.ChangePassword(_email, ctbxConfirmPassword.Text))
                {
                    RJMessageBox.Show("Password reset was successful");
                    ProceedToLogin();
                }
                else
                {
                    ResetPasswordInputs();
                }
            }
            catch (Exception ex)
            {
                RJMessageBox.Show(ex.Message);
                ResetPasswordInputs();
            }
        }

        private void ResetPasswordInputs()
        {
            animator.Hide(lbResettingPassword, true);
            animator.Show(rbConfirm, true, Animation.HorizSlide);
            cbxPassword.Enabled = true;
            ctbxConfirmPassword.Enabled = true;
            rbConfirm.Enabled = true;
        }

        private void ProceedToLogin()
        {
            animator.Hide(lbResettingPassword, true);
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void FadeIn_Tick(object sender, EventArgs e)
        {
            Opacity += 0.05;
            if (Opacity == 1)
            {
                tmrFadeIn.Stop();
                tmrFadeIn.Enabled = false;
                tmrFadeIn.Tick -= FadeIn_Tick;
            }
        }

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

                // WS_MINIMIZEBOX   : allows minimizing the software from the taskbar
                // WS_EX_COMPOSITED : paints bottom-to-top. Reduces flicker greatly

                cp.Style |= WS_MINIMIZEBOX;
                cp.ExStyle |= WS_EX_COMPOSITED;

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
                        RecoverContainer.TitleBarTextColor = Color.DarkGray;
                    else
                        RecoverContainer.TitleBarTextColor = Color.Gainsboro;
                    break;
            }
            base.WndProc(ref m);
        }
    }
}
