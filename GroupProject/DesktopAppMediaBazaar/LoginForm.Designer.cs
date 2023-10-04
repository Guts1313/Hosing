namespace DesktopAppMediaBazaar
{
    partial class LoginForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txbUsername = new TextBox();
            txbPassword = new TextBox();
            btnLogin = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Century Gothic", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(-356, 211);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(1562, 52);
            label1.TabIndex = 0;
            label1.Text = "Login";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(269, 289);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(103, 21);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(277, 336);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(95, 21);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // txbUsername
            // 
            txbUsername.Font = new Font("Century Gothic", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txbUsername.Location = new Point(376, 286);
            txbUsername.Margin = new Padding(2, 1, 2, 1);
            txbUsername.Name = "txbUsername";
            txbUsername.Size = new Size(196, 29);
            txbUsername.TabIndex = 3;
            // 
            // txbPassword
            // 
            txbPassword.Font = new Font("Century Gothic", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txbPassword.Location = new Point(376, 333);
            txbPassword.Margin = new Padding(2, 1, 2, 1);
            txbPassword.Name = "txbPassword";
            txbPassword.PasswordChar = '*';
            txbPassword.Size = new Size(196, 29);
            txbPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(64, 64, 64);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(297, 398);
            btnLogin.Margin = new Padding(2, 1, 2, 1);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(250, 50);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Century Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(-356, 145);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(1562, 66);
            label4.TabIndex = 6;
            label4.Text = "Media Bazaar";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // LoginForm
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 591);
            Controls.Add(label4);
            Controls.Add(btnLogin);
            Controls.Add(txbPassword);
            Controls.Add(txbUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosing += LoginForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txbUsername;
        private TextBox txbPassword;
        private Button btnLogin;
        private Label label4;
    }
}