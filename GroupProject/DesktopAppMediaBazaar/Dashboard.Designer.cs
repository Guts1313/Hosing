namespace DesktopAppMediaBazaar
{
    partial class Dashboard
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
            pictureBox2 = new PictureBox();
            btnLogout = new CustomElements.NoHoverButton();
            panelInformation2 = new Panel();
            btnVacations = new Button();
            btnShifts = new Button();
            btnTimesheet = new Button();
            panelInformation = new Panel();
            btnDepartments = new Button();
            btnEmployee = new Button();
            btnBusiness = new Button();
            btnAnnouncements = new Button();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            LogInContainer.SuspendLayout();
            panel2.SuspendLayout();
            leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelInformation2.SuspendLayout();
            panelInformation.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // customControlBox1
            // 
            customControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            customControlBox1.BackColor = Color.Transparent;
            customControlBox1.EnableMaximizeButton = false;
            customControlBox1.EnableMinimizeButton = true;
            customControlBox1.Location = new Point(1288, 0);
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
            LogInContainer.Margin = new Padding(3, 4, 3, 4);
            LogInContainer.MaximumSize = new Size(1447, 764);
            LogInContainer.MinimumSize = new Size(1447, 764);
            LogInContainer.Name = "LogInContainer";
            LogInContainer.Padding = new Padding(0, 41, 0, 0);
            LogInContainer.Size = new Size(1447, 764);
            LogInContainer.TabIndex = 0;
            LogInContainer.TextAlignment = CustomElements.Controls.CustomContainer.Alignment.Left;
            LogInContainer.TitleBarTextColor = Color.Gainsboro;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(156, 84, 213);
            panel2.Controls.Add(panelChildForm);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(257, 41);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1190, 723);
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
            panelChildForm.Location = new Point(-7, 0);
            panelChildForm.Margin = new Padding(3, 4, 3, 4);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Radius = 20;
            panelChildForm.Size = new Size(1197, 723);
            panelChildForm.TabIndex = 3;
            // 
            // leftPanel
            // 
            leftPanel.Controls.Add(pictureBox2);
            leftPanel.Controls.Add(btnLogout);
            leftPanel.Controls.Add(panelInformation2);
            leftPanel.Controls.Add(btnTimesheet);
            leftPanel.Controls.Add(panelInformation);
            leftPanel.Controls.Add(btnBusiness);
            leftPanel.Controls.Add(btnAnnouncements);
            leftPanel.Controls.Add(panelLogo);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.ForeColor = Color.FromArgb(250, 250, 250);
            leftPanel.Location = new Point(0, 41);
            leftPanel.Margin = new Padding(3, 4, 3, 4);
            leftPanel.Name = "leftPanel";
            leftPanel.Side = CustomElements.Controls.CustomPanelV2.PanelSide.Left;
            leftPanel.Size = new Size(257, 723);
            leftPanel.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Logout;
            pictureBox2.Location = new Point(13, 676);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 30;
            pictureBox2.TabStop = false;
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
            btnLogout.Location = new Point(0, 663);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(257, 60);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "     Log Out";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // panelInformation2
            // 
            panelInformation2.BackColor = Color.FromArgb(124, 75, 163);
            panelInformation2.Controls.Add(btnVacations);
            panelInformation2.Controls.Add(btnShifts);
            panelInformation2.Dock = DockStyle.Top;
            panelInformation2.Location = new Point(0, 424);
            panelInformation2.Margin = new Padding(3, 4, 3, 4);
            panelInformation2.Name = "panelInformation2";
            panelInformation2.Size = new Size(257, 121);
            panelInformation2.TabIndex = 29;
            // 
            // btnVacations
            // 
            btnVacations.BackColor = Color.FromArgb(124, 75, 163);
            btnVacations.Dock = DockStyle.Top;
            btnVacations.FlatAppearance.BorderSize = 0;
            btnVacations.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            btnVacations.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            btnVacations.FlatStyle = FlatStyle.Flat;
            btnVacations.Font = new Font("Cascadia Code", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVacations.ForeColor = Color.FromArgb(250, 250, 250);
            btnVacations.Image = Properties.Resources.Vacations;
            btnVacations.ImageAlign = ContentAlignment.MiddleLeft;
            btnVacations.Location = new Point(0, 60);
            btnVacations.Margin = new Padding(3, 4, 3, 4);
            btnVacations.Name = "btnVacations";
            btnVacations.Padding = new Padding(6, 0, 0, 0);
            btnVacations.Size = new Size(257, 60);
            btnVacations.TabIndex = 30;
            btnVacations.Text = "  Vacations";
            btnVacations.TextAlign = ContentAlignment.MiddleLeft;
            btnVacations.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVacations.UseVisualStyleBackColor = false;
            btnVacations.Click += btnVacations_Click;
            // 
            // btnShifts
            // 
            btnShifts.BackColor = Color.FromArgb(124, 75, 163);
            btnShifts.Dock = DockStyle.Top;
            btnShifts.FlatAppearance.BorderSize = 0;
            btnShifts.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            btnShifts.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            btnShifts.FlatStyle = FlatStyle.Flat;
            btnShifts.Font = new Font("Cascadia Code", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnShifts.ForeColor = Color.FromArgb(250, 250, 250);
            btnShifts.Image = Properties.Resources.shifts;
            btnShifts.ImageAlign = ContentAlignment.MiddleLeft;
            btnShifts.Location = new Point(0, 0);
            btnShifts.Margin = new Padding(3, 4, 3, 4);
            btnShifts.Name = "btnShifts";
            btnShifts.Padding = new Padding(6, 0, 0, 0);
            btnShifts.Size = new Size(257, 60);
            btnShifts.TabIndex = 23;
            btnShifts.Text = "  Shifts";
            btnShifts.TextAlign = ContentAlignment.MiddleLeft;
            btnShifts.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnShifts.UseVisualStyleBackColor = false;
            btnShifts.Click += btnShifts_Click;
            // 
            // btnTimesheet
            // 
            btnTimesheet.Dock = DockStyle.Top;
            btnTimesheet.FlatAppearance.BorderSize = 0;
            btnTimesheet.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            btnTimesheet.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            btnTimesheet.FlatStyle = FlatStyle.Flat;
            btnTimesheet.Font = new Font("Cascadia Code", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnTimesheet.ForeColor = Color.FromArgb(250, 250, 250);
            btnTimesheet.Image = Properties.Resources.Timesheet;
            btnTimesheet.ImageAlign = ContentAlignment.MiddleLeft;
            btnTimesheet.Location = new Point(0, 364);
            btnTimesheet.Margin = new Padding(3, 4, 3, 4);
            btnTimesheet.Name = "btnTimesheet";
            btnTimesheet.Padding = new Padding(6, 0, 0, 0);
            btnTimesheet.Size = new Size(257, 60);
            btnTimesheet.TabIndex = 28;
            btnTimesheet.Text = "  Timesheet";
            btnTimesheet.TextAlign = ContentAlignment.MiddleLeft;
            btnTimesheet.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTimesheet.UseVisualStyleBackColor = true;
            btnTimesheet.Click += btnTimesheet_Click;
            // 
            // panelInformation
            // 
            panelInformation.BackColor = Color.FromArgb(124, 75, 163);
            panelInformation.Controls.Add(btnDepartments);
            panelInformation.Controls.Add(btnEmployee);
            panelInformation.Dock = DockStyle.Top;
            panelInformation.Location = new Point(0, 243);
            panelInformation.Margin = new Padding(3, 4, 3, 4);
            panelInformation.Name = "panelInformation";
            panelInformation.Size = new Size(257, 121);
            panelInformation.TabIndex = 27;
            // 
            // btnDepartments
            // 
            btnDepartments.BackColor = Color.FromArgb(124, 75, 163);
            btnDepartments.Dock = DockStyle.Top;
            btnDepartments.FlatAppearance.BorderSize = 0;
            btnDepartments.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            btnDepartments.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            btnDepartments.FlatStyle = FlatStyle.Flat;
            btnDepartments.Font = new Font("Cascadia Code", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDepartments.ForeColor = Color.FromArgb(250, 250, 250);
            btnDepartments.Image = Properties.Resources.Departments;
            btnDepartments.ImageAlign = ContentAlignment.MiddleLeft;
            btnDepartments.Location = new Point(0, 60);
            btnDepartments.Margin = new Padding(3, 4, 3, 4);
            btnDepartments.Name = "btnDepartments";
            btnDepartments.Padding = new Padding(6, 0, 0, 0);
            btnDepartments.Size = new Size(257, 60);
            btnDepartments.TabIndex = 27;
            btnDepartments.Text = "  Departments";
            btnDepartments.TextAlign = ContentAlignment.MiddleLeft;
            btnDepartments.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDepartments.UseVisualStyleBackColor = false;
            btnDepartments.Click += btnDepartments_Click;
            // 
            // btnEmployee
            // 
            btnEmployee.BackColor = Color.FromArgb(124, 75, 163);
            btnEmployee.Dock = DockStyle.Top;
            btnEmployee.FlatAppearance.BorderSize = 0;
            btnEmployee.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            btnEmployee.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            btnEmployee.FlatStyle = FlatStyle.Flat;
            btnEmployee.Font = new Font("Cascadia Code", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmployee.ForeColor = Color.FromArgb(250, 250, 250);
            btnEmployee.Image = Properties.Resources.Employees;
            btnEmployee.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmployee.Location = new Point(0, 0);
            btnEmployee.Margin = new Padding(3, 4, 3, 4);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Padding = new Padding(6, 0, 0, 0);
            btnEmployee.Size = new Size(257, 60);
            btnEmployee.TabIndex = 23;
            btnEmployee.Text = "  Employees";
            btnEmployee.TextAlign = ContentAlignment.MiddleLeft;
            btnEmployee.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmployee.UseVisualStyleBackColor = false;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // btnBusiness
            // 
            btnBusiness.Dock = DockStyle.Top;
            btnBusiness.FlatAppearance.BorderSize = 0;
            btnBusiness.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            btnBusiness.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            btnBusiness.FlatStyle = FlatStyle.Flat;
            btnBusiness.Font = new Font("Cascadia Code", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBusiness.ForeColor = Color.FromArgb(250, 250, 250);
            btnBusiness.Image = Properties.Resources.Business;
            btnBusiness.ImageAlign = ContentAlignment.MiddleLeft;
            btnBusiness.Location = new Point(0, 183);
            btnBusiness.Margin = new Padding(3, 4, 3, 4);
            btnBusiness.Name = "btnBusiness";
            btnBusiness.Padding = new Padding(6, 0, 0, 0);
            btnBusiness.Size = new Size(257, 60);
            btnBusiness.TabIndex = 24;
            btnBusiness.Text = "  Business";
            btnBusiness.TextAlign = ContentAlignment.MiddleLeft;
            btnBusiness.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBusiness.UseVisualStyleBackColor = true;
            btnBusiness.Click += btnBusiness_Click;
            // 
            // btnAnnouncements
            // 
            btnAnnouncements.Dock = DockStyle.Top;
            btnAnnouncements.FlatAppearance.BorderSize = 0;
            btnAnnouncements.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            btnAnnouncements.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            btnAnnouncements.FlatStyle = FlatStyle.Flat;
            btnAnnouncements.Font = new Font("Cascadia Code", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAnnouncements.ForeColor = Color.FromArgb(250, 250, 250);
            btnAnnouncements.Image = Properties.Resources.Announcements;
            btnAnnouncements.ImageAlign = ContentAlignment.MiddleLeft;
            btnAnnouncements.Location = new Point(0, 123);
            btnAnnouncements.Margin = new Padding(3, 4, 3, 4);
            btnAnnouncements.Name = "btnAnnouncements";
            btnAnnouncements.Padding = new Padding(6, 0, 0, 0);
            btnAnnouncements.Size = new Size(257, 60);
            btnAnnouncements.TabIndex = 17;
            btnAnnouncements.Text = "  Announcements";
            btnAnnouncements.TextAlign = ContentAlignment.MiddleLeft;
            btnAnnouncements.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAnnouncements.UseVisualStyleBackColor = true;
            btnAnnouncements.Click += btnAnnouncements_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(3, 4, 3, 4);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(257, 123);
            panelLogo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(156, 84, 213);
            pictureBox1.Image = Properties.Resources.LOGO;
            pictureBox1.Location = new Point(91, 19);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1447, 764);
            Controls.Add(LogInContainer);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(2926, 1920);
            MinimumSize = new Size(1447, 764);
            Name = "Dashboard";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            TransparencyKey = Color.Fuchsia;
            LogInContainer.ResumeLayout(false);
            panel2.ResumeLayout(false);
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelInformation2.ResumeLayout(false);
            panelInformation.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CustomElements.Controls.CustomControlBox customControlBox1;
        private CustomElements.Controls.CustomContainer LogInContainer;
        private CustomElements.Controls.CustomPanelV2 leftPanel;
        private Button btnAnnouncements;
        private Panel panelLogo;
        private PictureBox pictureBox1;
        private Panel panelInformation2;
        private Button btnShifts;
        private Button btnTimesheet;
        private Panel panelInformation;
        private Button btnEmployee;
        private Button btnBusiness;
        private Panel panel2;
        private CustomElements.RoundPanel panelChildForm;
        private Button btnVacations;
        private CustomElements.NoHoverButton btnLogout;
        private Button btnDepartments;
        private PictureBox pictureBox2;
    }
}