namespace DesktopAppMediaBazaar
{
    partial class ResetPassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPassword));
            RecoverContainer = new CustomElements.Controls.CustomContainer();
            customPanelV22 = new CustomElements.Controls.CustomPanelV2();
            pictureBox1 = new PictureBox();
            customPanelV21 = new CustomElements.Controls.CustomPanelV2();
            rbConfirm = new CustomElements.Controls.CustomButtonV2();
            ctbxConfirmPassword = new CustomElements.Controls.CustomTextBoxV2();
            cbxPassword = new CustomElements.Controls.CustomTextBoxV2();
            customTitleLabel4 = new CustomElements.Controls.CustomTitleLabel();
            lbResettingPassword = new CustomElements.Controls.CustomLabelV2();
            tbxEmail = new CustomElements.Controls.CustomTextBoxV2();
            customControlBox1 = new CustomElements.Controls.CustomControlBox();
            RecoverContainer.SuspendLayout();
            customPanelV22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            customPanelV21.SuspendLayout();
            SuspendLayout();
            // 
            // RecoverContainer
            // 
            RecoverContainer.BackColor = Color.FromArgb(250, 250, 250);
            RecoverContainer.Controls.Add(customPanelV22);
            RecoverContainer.Controls.Add(customPanelV21);
            RecoverContainer.Controls.Add(customControlBox1);
            RecoverContainer.Dock = DockStyle.Fill;
            RecoverContainer.DrawIcon = false;
            RecoverContainer.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            RecoverContainer.Location = new Point(0, 0);
            RecoverContainer.MinimumSize = new Size(100, 42);
            RecoverContainer.Name = "RecoverContainer";
            RecoverContainer.Padding = new Padding(0, 31, 0, 0);
            RecoverContainer.Size = new Size(453, 338);
            RecoverContainer.TabIndex = 1;
            RecoverContainer.TextAlignment = CustomElements.Controls.CustomContainer.Alignment.Left;
            RecoverContainer.TitleBarTextColor = Color.Gainsboro;
            // 
            // customPanelV22
            // 
            customPanelV22.Controls.Add(pictureBox1);
            customPanelV22.Dock = DockStyle.Left;
            customPanelV22.ForeColor = Color.FromArgb(250, 250, 250);
            customPanelV22.Location = new Point(0, 31);
            customPanelV22.Name = "customPanelV22";
            customPanelV22.Side = CustomElements.Controls.CustomPanelV2.PanelSide.Left;
            customPanelV22.Size = new Size(169, 307);
            customPanelV22.TabIndex = 16;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(156, 84, 213);
            pictureBox1.Image = Properties.Resources.LOGO;
            pictureBox1.Location = new Point(52, 121);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // customPanelV21
            // 
            customPanelV21.Controls.Add(rbConfirm);
            customPanelV21.Controls.Add(ctbxConfirmPassword);
            customPanelV21.Controls.Add(cbxPassword);
            customPanelV21.Controls.Add(customTitleLabel4);
            customPanelV21.Controls.Add(lbResettingPassword);
            customPanelV21.Controls.Add(tbxEmail);
            customPanelV21.Dock = DockStyle.Right;
            customPanelV21.ForeColor = Color.FromArgb(250, 250, 250);
            customPanelV21.Location = new Point(164, 31);
            customPanelV21.Name = "customPanelV21";
            customPanelV21.Side = CustomElements.Controls.CustomPanelV2.PanelSide.Right;
            customPanelV21.Size = new Size(289, 307);
            customPanelV21.TabIndex = 15;
            // 
            // rbConfirm
            // 
            rbConfirm.BackColor = Color.Transparent;
            rbConfirm.DialogResult = DialogResult.None;
            rbConfirm.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rbConfirm.Location = new Point(-2, 219);
            rbConfirm.MinimumSize = new Size(144, 47);
            rbConfirm.Name = "rbConfirm";
            rbConfirm.Radius = 20;
            rbConfirm.Size = new Size(214, 47);
            rbConfirm.TabIndex = 29;
            rbConfirm.Text = "RESET";
            rbConfirm.Click += rbConfirm_Click;
            // 
            // ctbxConfirmPassword
            // 
            ctbxConfirmPassword.BackColor = Color.FromArgb(229, 229, 229);
            ctbxConfirmPassword.ColorBordersOnEnter = true;
            ctbxConfirmPassword.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ctbxConfirmPassword.ForeColor = Color.FromArgb(127, 131, 140);
            ctbxConfirmPassword.Image = null;
            ctbxConfirmPassword.Location = new Point(2, 157);
            ctbxConfirmPassword.MaxLength = 64;
            ctbxConfirmPassword.Multiline = false;
            ctbxConfirmPassword.Name = "ctbxConfirmPassword";
            ctbxConfirmPassword.ReadOnly = false;
            ctbxConfirmPassword.ShortcutsEnabled = true;
            ctbxConfirmPassword.ShowBottomBorder = true;
            ctbxConfirmPassword.ShowTopBorder = false;
            ctbxConfirmPassword.Size = new Size(286, 46);
            ctbxConfirmPassword.TabIndex = 28;
            ctbxConfirmPassword.TextAlignment = HorizontalAlignment.Left;
            ctbxConfirmPassword.UseSystemPasswordChar = true;
            ctbxConfirmPassword.Watermark = "Confirm Password";
            ctbxConfirmPassword.WatermarkColor = Color.FromArgb(116, 120, 129);
            // 
            // cbxPassword
            // 
            cbxPassword.BackColor = Color.FromArgb(229, 229, 229);
            cbxPassword.ColorBordersOnEnter = true;
            cbxPassword.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbxPassword.ForeColor = Color.FromArgb(127, 131, 140);
            cbxPassword.Image = null;
            cbxPassword.Location = new Point(3, 109);
            cbxPassword.MaxLength = 64;
            cbxPassword.Multiline = false;
            cbxPassword.Name = "cbxPassword";
            cbxPassword.ReadOnly = false;
            cbxPassword.ShortcutsEnabled = true;
            cbxPassword.ShowBottomBorder = false;
            cbxPassword.ShowTopBorder = true;
            cbxPassword.Size = new Size(286, 46);
            cbxPassword.TabIndex = 27;
            cbxPassword.TextAlignment = HorizontalAlignment.Left;
            cbxPassword.UseSystemPasswordChar = true;
            cbxPassword.Watermark = "New Password";
            cbxPassword.WatermarkColor = Color.FromArgb(116, 120, 129);
            // 
            // customTitleLabel4
            // 
            customTitleLabel4.BackColor = Color.Transparent;
            customTitleLabel4.Font = new Font("Cascadia Code SemiLight", 18F, FontStyle.Regular, GraphicsUnit.Point);
            customTitleLabel4.ForeColor = Color.FromArgb(110, 110, 110);
            customTitleLabel4.Location = new Point(16, 66);
            customTitleLabel4.Name = "customTitleLabel4";
            customTitleLabel4.Side = CustomElements.Controls.CustomTitleLabel.PanelSide.RightPanel;
            customTitleLabel4.Size = new Size(222, 34);
            customTitleLabel4.TabIndex = 26;
            customTitleLabel4.Text = "RESET PASSWORD";
            customTitleLabel4.TextAlign = ContentAlignment.MiddleCenter;
            customTitleLabel4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            customTitleLabel4.UseCompatibleTextRendering = true;
            // 
            // lbResettingPassword
            // 
            lbResettingPassword.BackColor = Color.Transparent;
            lbResettingPassword.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbResettingPassword.ForeColor = Color.FromArgb(114, 118, 127);
            lbResettingPassword.Image = (Image)resources.GetObject("lbResettingPassword.Image");
            lbResettingPassword.ImageAlign = ContentAlignment.MiddleLeft;
            lbResettingPassword.Location = new Point(22, 226);
            lbResettingPassword.Name = "lbResettingPassword";
            lbResettingPassword.Size = new Size(190, 22);
            lbResettingPassword.TabIndex = 22;
            lbResettingPassword.Text = "Resetting Password ...";
            lbResettingPassword.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tbxEmail
            // 
            tbxEmail.BackColor = Color.FromArgb(229, 229, 229);
            tbxEmail.ColorBordersOnEnter = true;
            tbxEmail.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbxEmail.ForeColor = Color.FromArgb(127, 131, 140);
            tbxEmail.Image = null;
            tbxEmail.Location = new Point(3, 109);
            tbxEmail.MaxLength = 64;
            tbxEmail.Multiline = false;
            tbxEmail.Name = "tbxEmail";
            tbxEmail.ReadOnly = false;
            tbxEmail.ShortcutsEnabled = true;
            tbxEmail.ShowBottomBorder = true;
            tbxEmail.ShowTopBorder = true;
            tbxEmail.Size = new Size(286, 46);
            tbxEmail.TabIndex = 21;
            tbxEmail.TextAlignment = HorizontalAlignment.Left;
            tbxEmail.UseSystemPasswordChar = false;
            tbxEmail.Watermark = "Email";
            tbxEmail.WatermarkColor = Color.FromArgb(116, 120, 129);
            // 
            // customControlBox1
            // 
            customControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            customControlBox1.BackColor = Color.Transparent;
            customControlBox1.EnableMaximizeButton = false;
            customControlBox1.EnableMinimizeButton = true;
            customControlBox1.Location = new Point(314, 0);
            customControlBox1.Name = "customControlBox1";
            customControlBox1.Size = new Size(139, 31);
            customControlBox1.TabIndex = 14;
            // 
            // ResetPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 338);
            Controls.Add(RecoverContainer);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(1920, 1080);
            Name = "ResetPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ResetPassword";
            TransparencyKey = Color.Fuchsia;
            Shown += ResetPassword_Shown;
            RecoverContainer.ResumeLayout(false);
            customPanelV22.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            customPanelV21.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CustomElements.Controls.CustomContainer RecoverContainer;
        private CustomElements.Controls.CustomPanelV2 customPanelV22;
        private PictureBox pictureBox1;
        private CustomElements.Controls.CustomPanelV2 customPanelV21;
        private CustomElements.Controls.CustomTextBoxV2 ctbxConfirmPassword;
        private CustomElements.Controls.CustomTextBoxV2 cbxPassword;
        private CustomElements.Controls.CustomTitleLabel customTitleLabel4;
        private CustomElements.Controls.CustomLabelV2 lbResettingPassword;
        private CustomElements.Controls.CustomTextBoxV2 tbxEmail;
        private CustomElements.Controls.CustomControlBox customControlBox1;
        private CustomElements.Controls.CustomButtonV2 rbConfirm;
    }
}