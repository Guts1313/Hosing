namespace DesktopAppMediaBazaar
{
    partial class AdminDepartmentsForm
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
            lbDepartments = new ListBox();
            tbDepartmentName = new TextBox();
            btnAddDepartment = new Button();
            panel1 = new Panel();
            buttonVacations = new Button();
            btnHome = new Button();
            btnCancelledShifts = new Button();
            btnLogout = new Button();
            btnDepartments = new Button();
            btnEmployees = new Button();
            btnShifts = new Button();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbDepartments
            // 
            lbDepartments.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbDepartments.FormattingEnabled = true;
            lbDepartments.ItemHeight = 21;
            lbDepartments.Location = new Point(284, 127);
            lbDepartments.Name = "lbDepartments";
            lbDepartments.Size = new Size(406, 445);
            lbDepartments.TabIndex = 6;
            // 
            // tbDepartmentName
            // 
            tbDepartmentName.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbDepartmentName.Location = new Point(804, 213);
            tbDepartmentName.Name = "tbDepartmentName";
            tbDepartmentName.Size = new Size(209, 31);
            tbDepartmentName.TabIndex = 7;
            // 
            // btnAddDepartment
            // 
            btnAddDepartment.BackColor = Color.MediumSeaGreen;
            btnAddDepartment.FlatStyle = FlatStyle.Flat;
            btnAddDepartment.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddDepartment.ForeColor = Color.White;
            btnAddDepartment.Location = new Point(804, 266);
            btnAddDepartment.Margin = new Padding(2, 1, 2, 1);
            btnAddDepartment.Name = "btnAddDepartment";
            btnAddDepartment.Size = new Size(209, 63);
            btnAddDepartment.TabIndex = 12;
            btnAddDepartment.Text = "Add department";
            btnAddDepartment.UseVisualStyleBackColor = false;
            btnAddDepartment.Click += btnAddDepartment_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(buttonVacations);
            panel1.Controls.Add(btnHome);
            panel1.Controls.Add(btnCancelledShifts);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnDepartments);
            panel1.Controls.Add(btnEmployees);
            panel1.Controls.Add(btnShifts);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 923);
            panel1.TabIndex = 13;
            // 
            // buttonVacations
            // 
            buttonVacations.BackColor = Color.Teal;
            buttonVacations.FlatStyle = FlatStyle.Flat;
            buttonVacations.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonVacations.ForeColor = Color.White;
            buttonVacations.Location = new Point(6, 501);
            buttonVacations.Name = "buttonVacations";
            buttonVacations.Size = new Size(238, 75);
            buttonVacations.TabIndex = 19;
            buttonVacations.Text = "Vacations";
            buttonVacations.UseVisualStyleBackColor = false;
            buttonVacations.Click += buttonVacations_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Teal;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(6, 21);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(238, 75);
            btnHome.TabIndex = 18;
            btnHome.Text = "Announcements";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnCancelledShifts
            // 
            btnCancelledShifts.BackColor = Color.Teal;
            btnCancelledShifts.FlatStyle = FlatStyle.Flat;
            btnCancelledShifts.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelledShifts.ForeColor = Color.White;
            btnCancelledShifts.Location = new Point(6, 405);
            btnCancelledShifts.Name = "btnCancelledShifts";
            btnCancelledShifts.Size = new Size(238, 75);
            btnCancelledShifts.TabIndex = 15;
            btnCancelledShifts.Text = "Cancelled shifts";
            btnCancelledShifts.UseVisualStyleBackColor = false;
            //btnCancelledShifts.Click += btnCancelledShifts_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.IndianRed;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(6, 827);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(238, 75);
            btnLogout.TabIndex = 13;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnDepartments
            // 
            btnDepartments.BackColor = Color.Teal;
            btnDepartments.FlatStyle = FlatStyle.Flat;
            btnDepartments.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDepartments.ForeColor = Color.White;
            btnDepartments.Location = new Point(6, 213);
            btnDepartments.Name = "btnDepartments";
            btnDepartments.Size = new Size(238, 75);
            btnDepartments.TabIndex = 3;
            btnDepartments.Text = "Departments";
            btnDepartments.UseVisualStyleBackColor = false;
            btnDepartments.Click += btnDepartments_Click;
            // 
            // btnEmployees
            // 
            btnEmployees.BackColor = Color.Teal;
            btnEmployees.FlatStyle = FlatStyle.Flat;
            btnEmployees.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmployees.ForeColor = Color.White;
            btnEmployees.Location = new Point(6, 117);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(238, 75);
            btnEmployees.TabIndex = 1;
            btnEmployees.Text = "Employees";
            btnEmployees.UseVisualStyleBackColor = false;
            btnEmployees.Click += btnEmployees_Click;
            // 
            // btnShifts
            // 
            btnShifts.BackColor = Color.Teal;
            btnShifts.FlatStyle = FlatStyle.Flat;
            btnShifts.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnShifts.ForeColor = Color.White;
            btnShifts.Location = new Point(6, 309);
            btnShifts.Name = "btnShifts";
            btnShifts.Size = new Size(238, 75);
            btnShifts.TabIndex = 2;
            btnShifts.Text = "Shifts";
            btnShifts.UseVisualStyleBackColor = false;
            btnShifts.Click += btnShifts_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(704, 209);
            label1.Name = "label1";
            label1.Size = new Size(94, 30);
            label1.TabIndex = 14;
            label1.Text = "Name:";
            // 
            // button1
            // 
            button1.BackColor = Color.Firebrick;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(804, 405);
            button1.Margin = new Padding(2, 1, 2, 1);
            button1.Name = "button1";
            button1.Size = new Size(209, 63);
            button1.TabIndex = 15;
            button1.Text = "Remove selected department";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 19.125F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(762, 21);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(251, 32);
            label2.TabIndex = 16;
            label2.Text = "Departments Page";
            // 
            // AdminDepartmentsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1584, 918);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(btnAddDepartment);
            Controls.Add(tbDepartmentName);
            Controls.Add(lbDepartments);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AdminDepartmentsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Departments";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox lbDepartments;
        private TextBox tbDepartmentName;
        private Button btnAddDepartment;
        private Panel panel1;
        private Button buttonVacations;
        private Button btnHome;
        private Button btnCancelledShifts;
        private Button btnLogout;
        private Button btnDepartments;
        private Button btnEmployees;
        private Button btnShifts;
        private Label label1;
        private Button button1;
        private Label label2;
    }
}