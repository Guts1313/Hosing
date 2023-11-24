using AnimatorNS;
using BussinessLayer.Controllers;
using DataAccessLayer.DAL;
using DesktopAppMediaBazaar.CustomElements;
using DesktopAppMediaBazaar.CustomElements.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace DesktopAppMediaBazaar
{
    public partial class ForgotPassword : Form
    {
        private EmailSendController emailSendController;
        private EmployeeController employeeController;

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

        public ForgotPassword()
        {
            InitializeComponent();
            employeeController = new EmployeeController(new DALEmployeeController());

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

            tbxCode.Visible = false;
            lbCodeInfo.Visible = false;
            lbSendingCode.Visible = false;
            rbCode.Visible = false;

            // Initially disable the send email and enter code buttons
            rbSendEmail.Enabled = false;
            rbCode.Enabled = false;

            tbxEmail.TextChanged += ValidateInput;
            tbxCode.TextChanged += ValidateInput;
        }

        private void ValidateInput(object sender, EventArgs e)
        {
            rbSendEmail.Enabled = !string.IsNullOrEmpty(tbxEmail.Text);
            rbCode.Enabled = !string.IsNullOrEmpty(tbxCode.Text);
        }

        private void ForgotPassword_Shown(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item.Visible)
                {
                    animator.Show(item);
                }
            }
        }

        private async void rbSendEmail_Click(object sender, EventArgs e)
        {
            if (tbxEmail.Text == string.Empty)
            {
                RJMessageBox.Show("Enter email address");
                return;
            }

            if (!employeeController.FindEmail(tbxEmail.Text))
            {
                RJMessageBox.Show("Email does not exist");
                return;
            }

            // Disable inputs and start animation
            tbxEmail.Enabled = false;
            rbSendEmail.Enabled = false;
            animator.Hide(rbSendEmail, true, Animation.HorizSlide);
            animator.Show(lbSendingEmail);

            await Task.Delay(2000);

            try
            {
                emailSendController = new EmailSendController(tbxEmail.Text);
                if (emailSendController.SendEmail())
                {
                    RJMessageBox.Show("Email sent successfully");
                    SwitchToCodeInput();
                }
                else
                {
                    ResetEmailInput();
                }
            }
            catch (Exception ex)
            {
                RJMessageBox.Show(ex.Message);
                ResetEmailInput();
            }
        }

        private void ResetEmailInput()
        {
            animator.Hide(lbSendingEmail, true);
            animator.Show(rbSendEmail, true, Animation.HorizSlide);
            tbxEmail.Enabled = true;
            rbSendEmail.Enabled = true;
        }

        private void SwitchToCodeInput()
        {
            // Hide email related elements
            animator.Hide(tbxEmail);
            animator.Hide(lbEmailInfo);
            animator.Hide(lbSendingEmail);

            // Make code-related elements visible
            tbxCode.Visible = true;
            lbCodeInfo.Visible = true;
            rbCode.Visible = true;

            // Ensure lbSendingCode is hidden before showing rbCode
            animator.HideSync(lbSendingCode);  // Hide lbSendingCode immediately
            animator.ShowSync(rbCode);         // Show rbCode immediately after hiding lbSendingCode

            // Show other code-related elements with animation
            animator.Show(tbxCode);
            animator.Show(lbCodeInfo);
            animator.Show(lbSendingCode);
        }


        private async void rbEnterCode_Click(object sender, EventArgs e)
        {
            if (tbxCode.Text == string.Empty)
            {
                RJMessageBox.Show("Enter code");
                return;
            }

            if (!int.TryParse(tbxCode.Text, out int code))
            {
                RJMessageBox.Show("Invalid code");
                return;
            }

            tbxCode.Enabled = false;
            rbCode.Enabled = false;
            animator.Hide(rbCode, true, Animation.HorizSlide);
            animator.Show(lbSendingCode);

            await Task.Delay(2000);

            if (!emailSendController.CheckCode(code))
            {
                RJMessageBox.Show("Wrong code");
                ResetCodeInput();
                return;
            }

            ProceedToResetPassword();
        }

        private void ResetCodeInput()
        {
            animator.Hide(lbSendingCode, true);
            animator.Show(rbCode, true, Animation.HorizSlide);
            tbxCode.Enabled = true;
            rbCode.Enabled = true;
        }

        private void ProceedToResetPassword()
        {
            animator.Hide(lbSendingCode, true);
            ResetPassword resetPassword = new ResetPassword(tbxEmail.Text);
            this.Hide();
            resetPassword.ShowDialog();
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
