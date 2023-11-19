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
            rbSendEmail = new CustomElements.RoundButton();
            rbEnterCode = new CustomElements.RoundButton();
            tbxEmail = new CustomElements.Controls.CustomTextBoxV2();
            tbxCode = new CustomElements.Controls.CustomTextBoxV2();
            lblEmail = new CustomElements.Controls.CustomLabelV2();
            lblInfo = new CustomElements.Controls.CustomLabelV2();
            lblCode = new CustomElements.Controls.CustomLabelV2();
            SuspendLayout();
            // 
            // rbSendEmail
            // 
            rbSendEmail.BackColor = Color.MediumSlateBlue;
            rbSendEmail.BackgroundColor = Color.MediumSlateBlue;
            rbSendEmail.BorderColor = Color.FromArgb(231, 34, 83);
            rbSendEmail.BorderRadius = 0;
            rbSendEmail.BorderSize = 0;
            rbSendEmail.ClickedColor = Color.FromArgb(231, 34, 83);
            rbSendEmail.FlatAppearance.BorderSize = 0;
            rbSendEmail.FlatStyle = FlatStyle.Flat;
            rbSendEmail.ForeColor = Color.White;
            rbSendEmail.Location = new Point(171, 115);
            rbSendEmail.Name = "rbSendEmail";
            rbSendEmail.Size = new Size(188, 50);
            rbSendEmail.TabIndex = 0;
            rbSendEmail.Text = "Send Email";
            rbSendEmail.TextColor = Color.White;
            rbSendEmail.UseVisualStyleBackColor = false;
            rbSendEmail.Click += rbSendEmail_Click;
            // 
            // rbEnterCode
            // 
            rbEnterCode.BackColor = Color.MediumSlateBlue;
            rbEnterCode.BackgroundColor = Color.MediumSlateBlue;
            rbEnterCode.BorderColor = Color.FromArgb(231, 34, 83);
            rbEnterCode.BorderRadius = 0;
            rbEnterCode.BorderSize = 0;
            rbEnterCode.ClickedColor = Color.FromArgb(231, 34, 83);
            rbEnterCode.FlatAppearance.BorderSize = 0;
            rbEnterCode.FlatStyle = FlatStyle.Flat;
            rbEnterCode.ForeColor = Color.White;
            rbEnterCode.Location = new Point(171, 388);
            rbEnterCode.Name = "rbEnterCode";
            rbEnterCode.Size = new Size(188, 50);
            rbEnterCode.TabIndex = 1;
            rbEnterCode.Text = "Enter Code";
            rbEnterCode.TextColor = Color.White;
            rbEnterCode.UseVisualStyleBackColor = false;
            rbEnterCode.Click += rbEnterCode_Click;
            // 
            // tbxEmail
            // 
            tbxEmail.BackColor = Color.FromArgb(229, 229, 229);
            tbxEmail.ColorBordersOnEnter = true;
            tbxEmail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbxEmail.ForeColor = Color.FromArgb(229, 229, 229);
            tbxEmail.Image = null;
            tbxEmail.Location = new Point(72, 54);
            tbxEmail.MaxLength = 32767;
            tbxEmail.Multiline = false;
            tbxEmail.Name = "tbxEmail";
            tbxEmail.ReadOnly = false;
            tbxEmail.ShortcutsEnabled = true;
            tbxEmail.ShowBottomBorder = true;
            tbxEmail.ShowTopBorder = true;
            tbxEmail.Size = new Size(375, 55);
            tbxEmail.TabIndex = 2;
            tbxEmail.TextAlignment = HorizontalAlignment.Left;
            tbxEmail.UseSystemPasswordChar = false;
            tbxEmail.Watermark = "";
            tbxEmail.WatermarkColor = Color.FromArgb(229, 229, 229);
            // 
            // tbxCode
            // 
            tbxCode.BackColor = Color.FromArgb(229, 229, 229);
            tbxCode.ColorBordersOnEnter = true;
            tbxCode.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbxCode.ForeColor = Color.FromArgb(229, 229, 229);
            tbxCode.Image = null;
            tbxCode.Location = new Point(72, 327);
            tbxCode.MaxLength = 32767;
            tbxCode.Multiline = false;
            tbxCode.Name = "tbxCode";
            tbxCode.ReadOnly = false;
            tbxCode.ShortcutsEnabled = true;
            tbxCode.ShowBottomBorder = true;
            tbxCode.ShowTopBorder = true;
            tbxCode.Size = new Size(375, 55);
            tbxCode.TabIndex = 3;
            tbxCode.TextAlignment = HorizontalAlignment.Left;
            tbxCode.UseSystemPasswordChar = false;
            tbxCode.Watermark = "";
            tbxCode.WatermarkColor = Color.FromArgb(229, 229, 229);
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.ForeColor = Color.FromArgb(114, 118, 127);
            lblEmail.Location = new Point(218, 31);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(84, 20);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Enter Email";
            // 
            // lblInfo
            // 
            lblInfo.AllowDrop = true;
            lblInfo.AutoSize = true;
            lblInfo.BackColor = Color.Transparent;
            lblInfo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblInfo.ForeColor = Color.FromArgb(114, 118, 127);
            lblInfo.Location = new Point(72, 196);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(373, 40);
            lblInfo.TabIndex = 5;
            lblInfo.Text = "We will send you an email with a generated code. \r\nAfter you receive the email enter the code down below";
            lblInfo.Click += lblInfo_Click;
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.BackColor = Color.Transparent;
            lblCode.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCode.ForeColor = Color.FromArgb(114, 118, 127);
            lblCode.Location = new Point(220, 304);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(82, 20);
            lblCode.TabIndex = 6;
            lblCode.Text = "Enter Code";
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 450);
            Controls.Add(lblCode);
            Controls.Add(lblInfo);
            Controls.Add(lblEmail);
            Controls.Add(tbxCode);
            Controls.Add(tbxEmail);
            Controls.Add(rbEnterCode);
            Controls.Add(rbSendEmail);
            Name = "ForgotPassword";
            Text = "ForgotPassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomElements.RoundButton rbSendEmail;
        private CustomElements.RoundButton rbEnterCode;
        private CustomElements.Controls.CustomTextBoxV2 tbxEmail;
        private CustomElements.Controls.CustomTextBoxV2 tbxCode;
        private CustomElements.Controls.CustomLabelV2 lblEmail;
        private CustomElements.Controls.CustomLabelV2 lblInfo;
        private CustomElements.Controls.CustomLabelV2 lblCode;
    }
}