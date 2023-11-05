
using AnimatorNS;
using System.Drawing;
using System.Security.Permissions;
using BussinessLayer.Controllers;
using DataAccessLayer;
using DataAccessLayer.DAL;
using DataItems.LogicItems;
using DesktopAppMediaBazaar.CustomElements.Classes;
using Timer = System.Windows.Forms.Timer;
using System.Xml.Linq;
using DesktopAppMediaBazaar.CustomElements;

namespace DesktopAppMediaBazaar
{
    public partial class Login : Form
    {
        #region Fields

        private readonly Timer tmrFadeIn;
        private bool aeroShadow;
        private Animator animator;

        public EmployeeController EmployeeController { get; private set; } = new(new DALEmployeeController());
        public Employee? LoggedInEmployee { get; private set; } = null;

        #endregion
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
        #region Form Events

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmrFadeIn.Tick -= FadeIn_Tick;
            tbxUsername.TextChanged -= ValidateInput;
            tbxPassword.TextChanged -= ValidateInput;
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            foreach (Control item in rightPanel.Controls)
            {
                if (item.Visible != true)
                {
                    animator.Show(item);
                }
            };
        }
        private void btnForgot_GotFocus(object sender, EventArgs e)
        {
            tbxUsername.Focus();
        }
        #endregion

        public Login()
        {
            InitializeComponent();

            animator = new Animator();
            animator.AnimationType = AnimatorNS.AnimationType.Transparent;
            animator.Interval = 8;
            animator.MaxAnimationTime = 1000;
            animator.TimeStep = 0.02F;

            btnLogin.Enabled = false;
            tbxUsername.TextChanged += ValidateInput;
            tbxPassword.TextChanged += ValidateInput;

            Opacity = 0;

            tmrFadeIn = new Timer
            {
                Interval = 1,
                Enabled = true,
            };

            tmrFadeIn.Tick += FadeIn_Tick;

            btnForgot.TabStop = false;
            btnForgot.GotFocus += btnForgot_GotFocus;

            btnEmail.TabStop = false;
            btnForgot.GotFocus += btnForgot_GotFocus;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            tbxUsername.Enabled = false;
            tbxPassword.Enabled = false;
            btnLogin.Enabled = false;

            animator.Hide(btnLogin, true, AnimatorNS.Animation.HorizSlide);
            animator.Show(lbLoggingIn);
            await Task.Delay(2000);

            string username = tbxUsername.Text;
            string password = tbxPassword.Text;

            var employee = EmployeeController.Login(username, password);
            if (employee == null)
            {
                animator.Hide(lbLoggingIn, true);
                animator.Show(btnLogin, true, AnimatorNS.Animation.HorizSlide);

                RJMessageBox.Show("Incorrect login details, try again.");

                tbxUsername.Enabled = true;
                tbxPassword.Enabled = true;
                btnLogin.Enabled = true;
            }
            else
            {
                LoggedInEmployee = employee;

                Form nextForm = null;
                if (EmployeeController.IsAdmin(LoggedInEmployee))
                {
                    nextForm = new Dashboard(LoggedInEmployee);
                }
                else if (EmployeeController.IsManager(LoggedInEmployee))
                {
                    nextForm = new DashboardManager(LoggedInEmployee);
                }
                else
                {
                    RJMessageBox.Show("You do not have permission to access the application.");
                }

                if (nextForm != null)
                {
                    animator.Hide(lbLoggingIn, true);
                    RJMessageBox.Show($"Welcome back, {LoggedInEmployee.Username}!", "", MessageBoxButtons.OK);
                    this.Hide();
                    nextForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    animator.Hide(lbLoggingIn, true);
                    animator.Show(btnLogin, true, AnimatorNS.Animation.HorizSlide);

                    tbxUsername.Enabled = true;
                    tbxPassword.Enabled = true;
                    btnLogin.Enabled = true;
                }
            }
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

        private void ValidateInput(object sender, EventArgs e)
        {
            btnLogin.Enabled = !(tbxUsername.Text == string.Empty ||
                                 tbxPassword.Text == string.Empty);
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
                        LogInContainer.TitleBarTextColor = Color.DarkGray;
                    else
                        LogInContainer.TitleBarTextColor = Color.Gainsboro;
                    break;
            }
            base.WndProc(ref m);
        }
    }
}