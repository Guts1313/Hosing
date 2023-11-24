namespace DesktopAppMediaBazaar
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            RecoverContainer = new CustomElements.Controls.CustomContainer();
            customPanelV22 = new CustomElements.Controls.CustomPanelV2();
            pictureBox1 = new PictureBox();
            customPanelV21 = new CustomElements.Controls.CustomPanelV2();
            lbCodeInfo = new CustomElements.Controls.CustomLabelV2();
            lbSendingCode = new CustomElements.Controls.CustomLabelV2();
            tbxCode = new CustomElements.Controls.CustomTextBoxV2();
            customTitleLabel4 = new CustomElements.Controls.CustomTitleLabel();
            lbEmailInfo = new CustomElements.Controls.CustomLabelV2();
            rbSendEmail = new CustomElements.Controls.CustomButtonV2();
            lbSendingEmail = new CustomElements.Controls.CustomLabelV2();
            tbxEmail = new CustomElements.Controls.CustomTextBoxV2();
            customControlBox1 = new CustomElements.Controls.CustomControlBox();
            rbCode = new CustomElements.Controls.CustomButtonV2();
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
            RecoverContainer.TabIndex = 0;
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
            customPanelV21.Controls.Add(lbCodeInfo);
            customPanelV21.Controls.Add(rbCode);
            customPanelV21.Controls.Add(lbSendingCode);
            customPanelV21.Controls.Add(tbxCode);
            customPanelV21.Controls.Add(customTitleLabel4);
            customPanelV21.Controls.Add(lbEmailInfo);
            customPanelV21.Controls.Add(rbSendEmail);
            customPanelV21.Controls.Add(lbSendingEmail);
            customPanelV21.Controls.Add(tbxEmail);
            customPanelV21.Dock = DockStyle.Right;
            customPanelV21.ForeColor = Color.FromArgb(250, 250, 250);
            customPanelV21.Location = new Point(164, 31);
            customPanelV21.Name = "customPanelV21";
            customPanelV21.Side = CustomElements.Controls.CustomPanelV2.PanelSide.Right;
            customPanelV21.Size = new Size(289, 307);
            customPanelV21.TabIndex = 15;
            // 
            // lbCodeInfo
            // 
            lbCodeInfo.BackColor = Color.Transparent;
            lbCodeInfo.Font = new Font("Cascadia Code SemiLight", 8.3F, FontStyle.Regular, GraphicsUnit.Point);
            lbCodeInfo.ForeColor = Color.FromArgb(114, 118, 127);
            lbCodeInfo.Location = new Point(23, 167);
            lbCodeInfo.Name = "lbCodeInfo";
            lbCodeInfo.Size = new Size(253, 38);
            lbCodeInfo.TabIndex = 33;
            lbCodeInfo.Text = "Please enter the code you received in your email to proceed.";
            // 
            // lbSendingCode
            // 
            lbSendingCode.BackColor = Color.Transparent;
            lbSendingCode.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbSendingCode.ForeColor = Color.FromArgb(114, 118, 127);
            lbSendingCode.Image = (Image)resources.GetObject("lbSendingCode.Image");
            lbSendingCode.ImageAlign = ContentAlignment.MiddleLeft;
            lbSendingCode.Location = new Point(22, 230);
            lbSendingCode.Name = "lbSendingCode";
            lbSendingCode.Size = new Size(166, 22);
            lbSendingCode.TabIndex = 29;
            lbSendingCode.Text = "Validating Code ...";
            lbSendingCode.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tbxCode
            // 
            tbxCode.BackColor = Color.FromArgb(229, 229, 229);
            tbxCode.ColorBordersOnEnter = true;
            tbxCode.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbxCode.ForeColor = Color.FromArgb(127, 131, 140);
            tbxCode.Image = null;
            tbxCode.Location = new Point(3, 113);
            tbxCode.MaxLength = 64;
            tbxCode.Multiline = false;
            tbxCode.Name = "tbxCode";
            tbxCode.ReadOnly = false;
            tbxCode.ShortcutsEnabled = true;
            tbxCode.ShowBottomBorder = true;
            tbxCode.ShowTopBorder = true;
            tbxCode.Size = new Size(286, 46);
            tbxCode.TabIndex = 27;
            tbxCode.TextAlignment = HorizontalAlignment.Left;
            tbxCode.UseSystemPasswordChar = false;
            tbxCode.Watermark = "Code";
            tbxCode.WatermarkColor = Color.FromArgb(116, 120, 129);
            // 
            // customTitleLabel4
            // 
            customTitleLabel4.BackColor = Color.Transparent;
            customTitleLabel4.Font = new Font("Cascadia Code SemiLight", 18F, FontStyle.Regular, GraphicsUnit.Point);
            customTitleLabel4.ForeColor = Color.FromArgb(110, 110, 110);
            customTitleLabel4.Location = new Point(15, 70);
            customTitleLabel4.Name = "customTitleLabel4";
            customTitleLabel4.Side = CustomElements.Controls.CustomTitleLabel.PanelSide.RightPanel;
            customTitleLabel4.Size = new Size(241, 34);
            customTitleLabel4.TabIndex = 26;
            customTitleLabel4.Text = "RECOVER ACCOUNT";
            customTitleLabel4.TextAlign = ContentAlignment.MiddleCenter;
            customTitleLabel4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            customTitleLabel4.UseCompatibleTextRendering = true;
            // 
            // lbEmailInfo
            // 
            lbEmailInfo.BackColor = Color.Transparent;
            lbEmailInfo.Font = new Font("Cascadia Code SemiLight", 8.3F, FontStyle.Regular, GraphicsUnit.Point);
            lbEmailInfo.ForeColor = Color.FromArgb(114, 118, 127);
            lbEmailInfo.Location = new Point(24, 167);
            lbEmailInfo.Name = "lbEmailInfo";
            lbEmailInfo.Size = new Size(253, 38);
            lbEmailInfo.TabIndex = 25;
            lbEmailInfo.Text = "A code will be generated and sent to your email.";
            // 
            // rbSendEmail
            // 
            rbSendEmail.BackColor = Color.Transparent;
            rbSendEmail.DialogResult = DialogResult.None;
            rbSendEmail.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rbSendEmail.Location = new Point(-2, 219);
            rbSendEmail.MinimumSize = new Size(144, 47);
            rbSendEmail.Name = "rbSendEmail";
            rbSendEmail.Radius = 20;
            rbSendEmail.Size = new Size(190, 47);
            rbSendEmail.TabIndex = 24;
            rbSendEmail.Text = "SEND EMAIL";
            rbSendEmail.Click += rbSendEmail_Click;
            // 
            // lbSendingEmail
            // 
            lbSendingEmail.BackColor = Color.Transparent;
            lbSendingEmail.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbSendingEmail.ForeColor = Color.FromArgb(114, 118, 127);
            lbSendingEmail.Image = (Image)resources.GetObject("lbSendingEmail.Image");
            lbSendingEmail.ImageAlign = ContentAlignment.MiddleLeft;
            lbSendingEmail.Location = new Point(22, 230);
            lbSendingEmail.Name = "lbSendingEmail";
            lbSendingEmail.Size = new Size(155, 22);
            lbSendingEmail.TabIndex = 22;
            lbSendingEmail.Text = "Sending Email ...";
            lbSendingEmail.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tbxEmail
            // 
            tbxEmail.BackColor = Color.FromArgb(229, 229, 229);
            tbxEmail.ColorBordersOnEnter = true;
            tbxEmail.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbxEmail.ForeColor = Color.FromArgb(127, 131, 140);
            tbxEmail.Image = null;
            tbxEmail.Location = new Point(3, 113);
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
            // rbCode
            // 
            rbCode.BackColor = Color.Transparent;
            rbCode.DialogResult = DialogResult.None;
            rbCode.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rbCode.Location = new Point(-5, 219);
            rbCode.MinimumSize = new Size(144, 47);
            rbCode.Name = "rbCode";
            rbCode.Radius = 20;
            rbCode.Size = new Size(193, 47);
            rbCode.TabIndex = 32;
            rbCode.Text = "VALIDATE CODE";
            rbCode.Click += rbEnterCode_Click;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 338);
            Controls.Add(RecoverContainer);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(1920, 1080);
            Name = "ForgotPassword";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ForgotPassword";
            TransparencyKey = Color.Fuchsia;
            Shown += ForgotPassword_Shown;
            RecoverContainer.ResumeLayout(false);
            customPanelV22.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            customPanelV21.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CustomElements.Controls.CustomContainer RecoverContainer;
        private CustomElements.Controls.CustomControlBox customControlBox1;
        private CustomElements.Controls.CustomPanelV2 customPanelV21;
        private CustomElements.Controls.CustomTextBoxV2 tbxEmail;
        private CustomElements.Controls.CustomPanelV2 customPanelV22;
        private CustomElements.Controls.CustomLabelV2 lbSendingEmail;
        private CustomElements.Controls.CustomButtonV2 rbSendEmail;
        private CustomElements.Controls.CustomLabelV2 lbEmailInfo;
        private CustomElements.Controls.CustomTitleLabel customTitleLabel4;
        private PictureBox pictureBox1;
        private CustomElements.Controls.CustomTextBoxV2 tbxCode;
        private CustomElements.Controls.CustomLabelV2 lbSendingCode;
        private CustomElements.Controls.CustomLabelV2 lbCodeInfo;
        private CustomElements.Controls.CustomButtonV2 rbCode;
    }
}