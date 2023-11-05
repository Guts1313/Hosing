namespace DesktopAppMediaBazaar
{
    partial class DashboardManager
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
            customControlBox1 = new CustomElements.Controls.CustomControlBox();
            LogInContainer = new CustomElements.Controls.CustomContainer();
            panel2 = new Panel();
            panelChildForm = new CustomElements.RoundPanel();
            leftPanel = new CustomElements.Controls.CustomPanelV2();
            btnLogout = new CustomElements.NoHoverButton();
            btnShifts = new Button();
            btnEmployees = new Button();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            LogInContainer.SuspendLayout();
            panel2.SuspendLayout();
            leftPanel.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // customControlBox1
            // 
            customControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            customControlBox1.BackColor = Color.Transparent;
            customControlBox1.EnableMaximizeButton = false;
            customControlBox1.EnableMinimizeButton = true;
            customControlBox1.Location = new Point(1127, 0);
            customControlBox1.Name = "customControlBox1";
            customControlBox1.Size = new Size(139, 31);
            customControlBox1.TabIndex = 0;
            // 
            // LogInContainer
            // 
            LogInContainer.Controls.Add(panel2);
            LogInContainer.Controls.Add(leftPanel);
            LogInContainer.Controls.Add(customControlBox1);
            LogInContainer.Dock = DockStyle.Fill;
            LogInContainer.DrawIcon = false;
            LogInContainer.Font = new Font("Cascadia Code", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            LogInContainer.Location = new Point(0, 0);
            LogInContainer.MaximumSize = new Size(1266, 573);
            LogInContainer.MinimumSize = new Size(1266, 573);
            LogInContainer.Name = "LogInContainer";
            LogInContainer.Padding = new Padding(0, 31, 0, 0);
            LogInContainer.Size = new Size(1266, 573);
            LogInContainer.TabIndex = 0;
            LogInContainer.TextAlignment = CustomElements.Controls.CustomContainer.Alignment.Left;
            LogInContainer.TitleBarTextColor = Color.Gainsboro;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(156, 84, 213);
            panel2.Controls.Add(panelChildForm);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(225, 31);
            panel2.Name = "panel2";
            panel2.Size = new Size(1041, 542);
            panel2.TabIndex = 2;
            // 
            // panelChildForm
            // 
            panelChildForm.BackColor = Color.FromArgb(156, 84, 213);
            panelChildForm.BorderColor = Color.White;
            panelChildForm.BorderWidth = 5;
            panelChildForm.FillColor = Color.FromArgb(229, 229, 229);
            panelChildForm.IsBorder = false;
            panelChildForm.IsFill = true;
            panelChildForm.Location = new Point(-6, 0);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Radius = 20;
            panelChildForm.Size = new Size(1047, 542);
            panelChildForm.TabIndex = 3;
            // 
            // leftPanel
            // 
            leftPanel.Controls.Add(pictureBox2);
            leftPanel.Controls.Add(btnLogout);
            leftPanel.Controls.Add(btnShifts);
            leftPanel.Controls.Add(btnEmployees);
            leftPanel.Controls.Add(panelLogo);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.ForeColor = Color.FromArgb(250, 250, 250);
            leftPanel.Location = new Point(0, 31);
            leftPanel.Name = "leftPanel";
            leftPanel.Side = CustomElements.Controls.CustomPanelV2.PanelSide.Left;
            leftPanel.Size = new Size(225, 542);
            leftPanel.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btnLogout.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Cascadia Code", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.FromArgb(250, 250, 250);
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 497);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(225, 45);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "     Log Out";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnShifts
            // 
            btnShifts.Dock = DockStyle.Top;
            btnShifts.FlatAppearance.BorderSize = 0;
            btnShifts.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            btnShifts.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            btnShifts.FlatStyle = FlatStyle.Flat;
            btnShifts.Font = new Font("Cascadia Code", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnShifts.ForeColor = Color.FromArgb(250, 250, 250);
            btnShifts.Image = Properties.Resources.shifts;
            btnShifts.ImageAlign = ContentAlignment.MiddleLeft;
            btnShifts.Location = new Point(0, 137);
            btnShifts.Name = "btnShifts";
            btnShifts.Padding = new Padding(5, 0, 0, 0);
            btnShifts.Size = new Size(225, 45);
            btnShifts.TabIndex = 28;
            btnShifts.Text = "  Shifts";
            btnShifts.TextAlign = ContentAlignment.MiddleLeft;
            btnShifts.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnShifts.UseVisualStyleBackColor = true;
            btnShifts.Click += btnShifts_Click;
            // 
            // btnEmployees
            // 
            btnEmployees.Dock = DockStyle.Top;
            btnEmployees.FlatAppearance.BorderSize = 0;
            btnEmployees.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            btnEmployees.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            btnEmployees.FlatStyle = FlatStyle.Flat;
            btnEmployees.Font = new Font("Cascadia Code", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmployees.ForeColor = Color.FromArgb(250, 250, 250);
            btnEmployees.Image = Properties.Resources.Employees;
            btnEmployees.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmployees.Location = new Point(0, 92);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Padding = new Padding(5, 0, 0, 0);
            btnEmployees.Size = new Size(225, 45);
            btnEmployees.TabIndex = 24;
            btnEmployees.Text = "  Employees";
            btnEmployees.TextAlign = ContentAlignment.MiddleLeft;
            btnEmployees.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmployees.UseVisualStyleBackColor = true;
            btnEmployees.Click += btnEmployees_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(225, 92);
            panelLogo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(156, 84, 213);
            pictureBox1.Image = Properties.Resources.LOGO;
            pictureBox1.Location = new Point(80, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Logout;
            pictureBox2.Location = new Point(11, 507);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 31;
            pictureBox2.TabStop = false;
            // 
            // DashboardManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1266, 573);
            Controls.Add(LogInContainer);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(2560, 1440);
            MinimumSize = new Size(1266, 573);
            Name = "DashboardManager";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            TransparencyKey = Color.Fuchsia;
            LogInContainer.ResumeLayout(false);
            panel2.ResumeLayout(false);
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CustomElements.Controls.CustomControlBox customControlBox1;
        private CustomElements.Controls.CustomContainer LogInContainer;
        private CustomElements.Controls.CustomPanelV2 leftPanel;
        private Panel panelLogo;
        private PictureBox pictureBox1;
        private Button btnShifts;
        private Button btnEmployees;
        private Panel panel2;
        private CustomElements.RoundPanel panelChildForm;
        private CustomElements.NoHoverButton btnLogout;
        private PictureBox pictureBox2;
    }
}