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
            clblNewPass = new CustomElements.Controls.CustomLabelV2();
            clblConfirmPass = new CustomElements.Controls.CustomLabelV2();
            ctbxNewPassword = new CustomElements.Controls.CustomTextBoxV2();
            ctbxConfirmPassword = new CustomElements.Controls.CustomTextBoxV2();
            rbConfirm = new CustomElements.RoundButton();
            SuspendLayout();
            // 
            // clblNewPass
            // 
            clblNewPass.AutoSize = true;
            clblNewPass.BackColor = Color.Transparent;
            clblNewPass.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            clblNewPass.ForeColor = Color.FromArgb(114, 118, 127);
            clblNewPass.Location = new Point(199, 45);
            clblNewPass.Name = "clblNewPass";
            clblNewPass.Size = new Size(104, 20);
            clblNewPass.TabIndex = 0;
            clblNewPass.Text = "New Password";
            // 
            // clblConfirmPass
            // 
            clblConfirmPass.AutoSize = true;
            clblConfirmPass.BackColor = Color.Transparent;
            clblConfirmPass.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            clblConfirmPass.ForeColor = Color.FromArgb(114, 118, 127);
            clblConfirmPass.Location = new Point(176, 201);
            clblConfirmPass.Name = "clblConfirmPass";
            clblConfirmPass.Size = new Size(127, 20);
            clblConfirmPass.TabIndex = 1;
            clblConfirmPass.Text = "Confirm Password";
            // 
            // ctbxNewPassword
            // 
            ctbxNewPassword.BackColor = Color.FromArgb(229, 229, 229);
            ctbxNewPassword.ColorBordersOnEnter = true;
            ctbxNewPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ctbxNewPassword.ForeColor = Color.FromArgb(229, 229, 229);
            ctbxNewPassword.Image = null;
            ctbxNewPassword.Location = new Point(48, 68);
            ctbxNewPassword.MaxLength = 32767;
            ctbxNewPassword.Multiline = false;
            ctbxNewPassword.Name = "ctbxNewPassword";
            ctbxNewPassword.ReadOnly = false;
            ctbxNewPassword.ShortcutsEnabled = true;
            ctbxNewPassword.ShowBottomBorder = true;
            ctbxNewPassword.ShowTopBorder = true;
            ctbxNewPassword.Size = new Size(388, 55);
            ctbxNewPassword.TabIndex = 2;
            ctbxNewPassword.TextAlignment = HorizontalAlignment.Left;
            ctbxNewPassword.UseSystemPasswordChar = false;
            ctbxNewPassword.Watermark = "";
            ctbxNewPassword.WatermarkColor = Color.FromArgb(229, 229, 229);
            // 
            // ctbxConfirmPassword
            // 
            ctbxConfirmPassword.BackColor = Color.FromArgb(229, 229, 229);
            ctbxConfirmPassword.ColorBordersOnEnter = true;
            ctbxConfirmPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ctbxConfirmPassword.ForeColor = Color.FromArgb(229, 229, 229);
            ctbxConfirmPassword.Image = null;
            ctbxConfirmPassword.Location = new Point(48, 224);
            ctbxConfirmPassword.MaxLength = 32767;
            ctbxConfirmPassword.Multiline = false;
            ctbxConfirmPassword.Name = "ctbxConfirmPassword";
            ctbxConfirmPassword.ReadOnly = false;
            ctbxConfirmPassword.ShortcutsEnabled = true;
            ctbxConfirmPassword.ShowBottomBorder = true;
            ctbxConfirmPassword.ShowTopBorder = true;
            ctbxConfirmPassword.Size = new Size(388, 55);
            ctbxConfirmPassword.TabIndex = 3;
            ctbxConfirmPassword.TextAlignment = HorizontalAlignment.Left;
            ctbxConfirmPassword.UseSystemPasswordChar = false;
            ctbxConfirmPassword.Watermark = "";
            ctbxConfirmPassword.WatermarkColor = Color.FromArgb(229, 229, 229);
            // 
            // rbConfirm
            // 
            rbConfirm.BackColor = Color.MediumSlateBlue;
            rbConfirm.BackgroundColor = Color.MediumSlateBlue;
            rbConfirm.BorderColor = Color.FromArgb(231, 34, 83);
            rbConfirm.BorderRadius = 0;
            rbConfirm.BorderSize = 0;
            rbConfirm.ClickedColor = Color.FromArgb(231, 34, 83);
            rbConfirm.FlatAppearance.BorderSize = 0;
            rbConfirm.FlatStyle = FlatStyle.Flat;
            rbConfirm.ForeColor = Color.White;
            rbConfirm.Location = new Point(149, 308);
            rbConfirm.Name = "rbConfirm";
            rbConfirm.Size = new Size(192, 50);
            rbConfirm.TabIndex = 4;
            rbConfirm.Text = "Confirm";
            rbConfirm.TextColor = Color.White;
            rbConfirm.UseVisualStyleBackColor = false;
            rbConfirm.Click += rbConfirm_Click;
            // 
            // ResetPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 385);
            Controls.Add(rbConfirm);
            Controls.Add(ctbxConfirmPassword);
            Controls.Add(ctbxNewPassword);
            Controls.Add(clblConfirmPass);
            Controls.Add(clblNewPass);
            Name = "ResetPassword";
            Text = "ResetPassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomElements.Controls.CustomLabelV2 clblNewPass;
        private CustomElements.Controls.CustomLabelV2 clblConfirmPass;
        private CustomElements.Controls.CustomTextBoxV2 ctbxNewPassword;
        private CustomElements.Controls.CustomTextBoxV2 ctbxConfirmPassword;
        private CustomElements.RoundButton rbConfirm;
    }
}