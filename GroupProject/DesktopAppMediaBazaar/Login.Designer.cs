namespace DesktopAppMediaBazaar
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            LogInContainer = new CustomElements.Controls.CustomContainer();
            rightPanel = new CustomElements.Controls.CustomPanelV2();
            btnEmail = new CustomElements.Controls.CustomLinkLabel();
            customLabelV22 = new CustomElements.Controls.CustomLabelV2();
            customLabelV21 = new CustomElements.Controls.CustomLabelV2();
            btnForgot = new CustomElements.Controls.CustomLinkLabel();
            btnLogin = new CustomElements.Controls.CustomButtonV2();
            lbLoggingIn = new CustomElements.Controls.CustomLabelV2();
            tbxPassword = new CustomElements.Controls.CustomTextBoxV2();
            tbxUsername = new CustomElements.Controls.CustomTextBoxV2();
            customTitleLabel4 = new CustomElements.Controls.CustomTitleLabel();
            leftPanel = new CustomElements.Controls.CustomPanelV2();
            pictureBox1 = new PictureBox();
            customTitleLabel3 = new CustomElements.Controls.CustomTitleLabel();
            customTitleLabel1 = new CustomElements.Controls.CustomTitleLabel();
            customControlBox1 = new CustomElements.Controls.CustomControlBox();
            LogInContainer.SuspendLayout();
            rightPanel.SuspendLayout();
            leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LogInContainer
            // 
            LogInContainer.Controls.Add(rightPanel);
            LogInContainer.Controls.Add(leftPanel);
            LogInContainer.Controls.Add(customControlBox1);
            LogInContainer.Dock = DockStyle.Fill;
            LogInContainer.DrawIcon = false;
            LogInContainer.Font = new Font("Cascadia Code", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            LogInContainer.Location = new Point(0, 0);
            LogInContainer.MinimumSize = new Size(100, 42);
            LogInContainer.Name = "LogInContainer";
            LogInContainer.Padding = new Padding(0, 31, 0, 0);
            LogInContainer.Size = new Size(700, 515);
            LogInContainer.TabIndex = 0;
            LogInContainer.TextAlignment = CustomElements.Controls.CustomContainer.Alignment.Left;
            LogInContainer.TitleBarTextColor = Color.Gainsboro;
            // 
            // rightPanel
            // 
            rightPanel.Controls.Add(btnEmail);
            rightPanel.Controls.Add(customLabelV22);
            rightPanel.Controls.Add(customLabelV21);
            rightPanel.Controls.Add(btnForgot);
            rightPanel.Controls.Add(btnLogin);
            rightPanel.Controls.Add(lbLoggingIn);
            rightPanel.Controls.Add(tbxPassword);
            rightPanel.Controls.Add(tbxUsername);
            rightPanel.Controls.Add(customTitleLabel4);
            rightPanel.Dock = DockStyle.Left;
            rightPanel.ForeColor = Color.FromArgb(250, 250, 250);
            rightPanel.Location = new Point(350, 31);
            rightPanel.Name = "rightPanel";
            rightPanel.Side = CustomElements.Controls.CustomPanelV2.PanelSide.Right;
            rightPanel.Size = new Size(350, 484);
            rightPanel.TabIndex = 2;
            // 
            // btnEmail
            // 
            btnEmail.ActiveLinkColor = Color.FromArgb(70, 41, 100);
            btnEmail.AutoSize = true;
            btnEmail.BackColor = Color.Transparent;
            btnEmail.Font = new Font("Segoe UI", 8.3F, FontStyle.Regular, GraphicsUnit.Point);
            btnEmail.LinkBehavior = LinkBehavior.NeverUnderline;
            btnEmail.LinkColor = Color.FromArgb(156, 84, 213);
            btnEmail.Location = new Point(51, 444);
            btnEmail.Name = "btnEmail";
            btnEmail.Size = new Size(113, 15);
            btnEmail.TabIndex = 8;
            btnEmail.TabStop = true;
            btnEmail.Text = "admin@bazaar.com";
            btnEmail.VisitedLinkColor = Color.FromArgb(70, 41, 100);
            // 
            // customLabelV22
            // 
            customLabelV22.BackColor = Color.Transparent;
            customLabelV22.Font = new Font("Cascadia Code SemiLight", 8.3F, FontStyle.Regular, GraphicsUnit.Point);
            customLabelV22.ForeColor = Color.FromArgb(114, 118, 127);
            customLabelV22.Location = new Point(32, 411);
            customLabelV22.Name = "customLabelV22";
            customLabelV22.Size = new Size(290, 55);
            customLabelV22.TabIndex = 7;
            customLabelV22.Text = "To obtain access to this app or for any questions about its use, submit an email to";
            // 
            // customLabelV21
            // 
            customLabelV21.AutoSize = true;
            customLabelV21.BackColor = Color.Transparent;
            customLabelV21.Font = new Font("Cascadia Code SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            customLabelV21.ForeColor = Color.FromArgb(114, 118, 127);
            customLabelV21.Location = new Point(32, 391);
            customLabelV21.Name = "customLabelV21";
            customLabelV21.Size = new Size(56, 16);
            customLabelV21.TabIndex = 6;
            customLabelV21.Text = "Support";
            // 
            // btnForgot
            // 
            btnForgot.ActiveLinkColor = Color.FromArgb(70, 41, 100);
            btnForgot.AutoSize = true;
            btnForgot.BackColor = Color.Transparent;
            btnForgot.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnForgot.LinkBehavior = LinkBehavior.NeverUnderline;
            btnForgot.LinkColor = Color.FromArgb(156, 84, 213);
            btnForgot.Location = new Point(155, 329);
            btnForgot.Name = "btnForgot";
            btnForgot.Size = new Size(112, 16);
            btnForgot.TabIndex = 5;
            btnForgot.Text = "Forgot Password";
            btnForgot.VisitedLinkColor = Color.FromArgb(70, 41, 100);
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.DialogResult = DialogResult.None;
            btnLogin.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(-7, 314);
            btnLogin.MinimumSize = new Size(144, 47);
            btnLogin.Name = "btnLogin";
            btnLogin.Radius = 20;
            btnLogin.Size = new Size(151, 47);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "LOGIN";
            btnLogin.Click += btnLogin_Click;
            // 
            // lbLoggingIn
            // 
            lbLoggingIn.BackColor = Color.Transparent;
            lbLoggingIn.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbLoggingIn.ForeColor = Color.FromArgb(114, 118, 127);
            lbLoggingIn.Image = (Image)resources.GetObject("lbLoggingIn.Image");
            lbLoggingIn.ImageAlign = ContentAlignment.MiddleLeft;
            lbLoggingIn.Location = new Point(17, 325);
            lbLoggingIn.Name = "lbLoggingIn";
            lbLoggingIn.Size = new Size(127, 22);
            lbLoggingIn.TabIndex = 3;
            lbLoggingIn.Text = "Logging in...";
            lbLoggingIn.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tbxPassword
            // 
            tbxPassword.BackColor = Color.FromArgb(229, 229, 229);
            tbxPassword.ColorBordersOnEnter = true;
            tbxPassword.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbxPassword.ForeColor = Color.FromArgb(127, 131, 140);
            tbxPassword.Image = null;
            tbxPassword.Location = new Point(0, 243);
            tbxPassword.MaxLength = 30;
            tbxPassword.Multiline = false;
            tbxPassword.Name = "tbxPassword";
            tbxPassword.ReadOnly = false;
            tbxPassword.ShortcutsEnabled = true;
            tbxPassword.ShowBottomBorder = true;
            tbxPassword.ShowTopBorder = false;
            tbxPassword.Size = new Size(350, 46);
            tbxPassword.TabIndex = 2;
            tbxPassword.TextAlignment = HorizontalAlignment.Left;
            tbxPassword.UseSystemPasswordChar = true;
            tbxPassword.Watermark = "Password";
            tbxPassword.WatermarkColor = Color.FromArgb(116, 120, 129);
            // 
            // tbxUsername
            // 
            tbxUsername.BackColor = Color.FromArgb(229, 229, 229);
            tbxUsername.ColorBordersOnEnter = true;
            tbxUsername.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbxUsername.ForeColor = Color.FromArgb(127, 131, 140);
            tbxUsername.Image = null;
            tbxUsername.Location = new Point(0, 193);
            tbxUsername.MaxLength = 64;
            tbxUsername.Multiline = false;
            tbxUsername.Name = "tbxUsername";
            tbxUsername.ReadOnly = false;
            tbxUsername.ShortcutsEnabled = true;
            tbxUsername.ShowBottomBorder = false;
            tbxUsername.ShowTopBorder = true;
            tbxUsername.Size = new Size(350, 46);
            tbxUsername.TabIndex = 1;
            tbxUsername.TextAlignment = HorizontalAlignment.Left;
            tbxUsername.UseSystemPasswordChar = false;
            tbxUsername.Watermark = "Username";
            tbxUsername.WatermarkColor = Color.FromArgb(116, 120, 129);
            // 
            // customTitleLabel4
            // 
            customTitleLabel4.BackColor = Color.Transparent;
            customTitleLabel4.Font = new Font("Cascadia Code SemiLight", 18F, FontStyle.Regular, GraphicsUnit.Point);
            customTitleLabel4.ForeColor = Color.FromArgb(110, 110, 110);
            customTitleLabel4.Location = new Point(12, 148);
            customTitleLabel4.Name = "customTitleLabel4";
            customTitleLabel4.Side = CustomElements.Controls.CustomTitleLabel.PanelSide.RightPanel;
            customTitleLabel4.Size = new Size(241, 34);
            customTitleLabel4.TabIndex = 0;
            customTitleLabel4.Text = "ACCOUNT DETAILS";
            customTitleLabel4.TextAlign = ContentAlignment.MiddleCenter;
            customTitleLabel4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            customTitleLabel4.UseCompatibleTextRendering = true;
            // 
            // leftPanel
            // 
            leftPanel.Controls.Add(pictureBox1);
            leftPanel.Controls.Add(customTitleLabel3);
            leftPanel.Controls.Add(customTitleLabel1);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.ForeColor = Color.FromArgb(250, 250, 250);
            leftPanel.Location = new Point(0, 31);
            leftPanel.Name = "leftPanel";
            leftPanel.Side = CustomElements.Controls.CustomPanelV2.PanelSide.Left;
            leftPanel.Size = new Size(350, 484);
            leftPanel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(156, 84, 213);
            pictureBox1.Image = Properties.Resources.LOGO;
            pictureBox1.Location = new Point(144, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // customTitleLabel3
            // 
            customTitleLabel3.BackColor = Color.Transparent;
            customTitleLabel3.Font = new Font("Cascadia Code", 13.25F, FontStyle.Italic, GraphicsUnit.Point);
            customTitleLabel3.ForeColor = Color.FromArgb(250, 250, 250);
            customTitleLabel3.Location = new Point(0, 245);
            customTitleLabel3.Name = "customTitleLabel3";
            customTitleLabel3.Side = CustomElements.Controls.CustomTitleLabel.PanelSide.LeftPanel;
            customTitleLabel3.Size = new Size(350, 32);
            customTitleLabel3.TabIndex = 5;
            customTitleLabel3.Text = "ACCESS PORTAL";
            customTitleLabel3.TextAlign = ContentAlignment.MiddleCenter;
            customTitleLabel3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            customTitleLabel3.UseCompatibleTextRendering = true;
            // 
            // customTitleLabel1
            // 
            customTitleLabel1.BackColor = Color.Transparent;
            customTitleLabel1.Font = new Font("Cascadia Code", 20.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            customTitleLabel1.ForeColor = Color.FromArgb(250, 250, 250);
            customTitleLabel1.Location = new Point(0, 209);
            customTitleLabel1.Name = "customTitleLabel1";
            customTitleLabel1.Side = CustomElements.Controls.CustomTitleLabel.PanelSide.LeftPanel;
            customTitleLabel1.Size = new Size(350, 48);
            customTitleLabel1.TabIndex = 0;
            customTitleLabel1.Text = "MEDIA BAZAAR";
            customTitleLabel1.TextAlign = ContentAlignment.MiddleCenter;
            customTitleLabel1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            customTitleLabel1.UseCompatibleTextRendering = true;
            // 
            // customControlBox1
            // 
            customControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            customControlBox1.BackColor = Color.Transparent;
            customControlBox1.EnableMaximizeButton = false;
            customControlBox1.EnableMinimizeButton = true;
            customControlBox1.Location = new Point(561, 0);
            customControlBox1.Name = "customControlBox1";
            customControlBox1.Size = new Size(139, 31);
            customControlBox1.TabIndex = 0;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 515);
            Controls.Add(LogInContainer);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(2560, 1440);
            MinimumSize = new Size(100, 42);
            Name = "LoginForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            TransparencyKey = Color.Fuchsia;
            FormClosing += LoginForm_FormClosing;
            Shown += LoginForm_Shown;
            LogInContainer.ResumeLayout(false);
            rightPanel.ResumeLayout(false);
            rightPanel.PerformLayout();
            leftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CustomElements.Controls.CustomContainer LogInContainer;
        private CustomElements.Controls.CustomPanelV2 rightPanel;
        private CustomElements.Controls.CustomPanelV2 leftPanel;
        private CustomElements.Controls.CustomControlBox customControlBox1;
        private CustomElements.Controls.CustomTitleLabel customTitleLabel1;
        private CustomElements.Controls.CustomTitleLabel customTitleLabel3;
        private CustomElements.Controls.CustomTitleLabel customTitleLabel4;
        private CustomElements.Controls.CustomTextBoxV2 tbxUsername;
        private CustomElements.Controls.CustomTextBoxV2 tbxPassword;
        private CustomElements.Controls.CustomLabelV2 lbLoggingIn;
        private CustomElements.Controls.CustomLinkLabel btnForgot;
        private CustomElements.Controls.CustomLabelV2 customLabelV21;
        private CustomElements.Controls.CustomLinkLabel btnEmail;
        private CustomElements.Controls.CustomLabelV2 customLabelV22;
        private CustomElements.Controls.CustomButtonV2 btnLogin;
        private PictureBox pictureBox1;
    }
}