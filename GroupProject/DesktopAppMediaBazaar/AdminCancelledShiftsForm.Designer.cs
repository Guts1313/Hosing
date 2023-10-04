namespace DesktopAppMediaBazaar
{
    partial class AdminCancelledShiftsForm
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
            label1 = new Label();
            lbxCancelledShifts = new ListBox();
            labelShift = new Label();
            labelReason = new Label();
            labelNewEmp = new Label();
            btnAssign = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnMarkViewed = new Button();
            labelAssignedEmpName = new Label();
            labelStatus = new Label();
            label7 = new Label();
            panel1 = new Panel();
            buttonVacations = new Button();
            btnHome = new Button();
            btnCancelledShifts = new Button();
            btnLogout = new Button();
            btnDepartments = new Button();
            btnEmployees = new Button();
            btnShifts = new Button();
            label2 = new Label();
            label8 = new Label();
            label9 = new Label();
            rbtnPast = new RadioButton();
            rbtnCurrent = new RadioButton();
            rbtnSent = new RadioButton();
            rbtnViewed = new RadioButton();
            rbtnAssigned = new RadioButton();
            rbtnNotAssigned = new RadioButton();
            btnShowAll = new Button();
            label10 = new Label();
            label11 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 19.125F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(586, 22);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(292, 32);
            label1.TabIndex = 10;
            label1.Text = "Cancelled Shifts Page";
            // 
            // lbxCancelledShifts
            // 
            lbxCancelledShifts.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbxCancelledShifts.FormattingEnabled = true;
            lbxCancelledShifts.ItemHeight = 21;
            lbxCancelledShifts.Location = new Point(288, 84);
            lbxCancelledShifts.Margin = new Padding(2, 1, 2, 1);
            lbxCancelledShifts.Name = "lbxCancelledShifts";
            lbxCancelledShifts.Size = new Size(590, 739);
            lbxCancelledShifts.TabIndex = 17;
            lbxCancelledShifts.SelectedIndexChanged += lbxCancelledShifts_SelectedIndexChanged;
            // 
            // labelShift
            // 
            labelShift.AutoSize = true;
            labelShift.Font = new Font("Century Gothic", 14.14286F, FontStyle.Bold, GraphicsUnit.Point);
            labelShift.Location = new Point(993, 309);
            labelShift.Margin = new Padding(2, 0, 2, 0);
            labelShift.Name = "labelShift";
            labelShift.Size = new Size(0, 23);
            labelShift.TabIndex = 14;
            // 
            // labelReason
            // 
            labelReason.AutoSize = true;
            labelReason.Font = new Font("Century Gothic", 14.14286F, FontStyle.Bold, GraphicsUnit.Point);
            labelReason.Location = new Point(996, 444);
            labelReason.Margin = new Padding(2, 0, 2, 0);
            labelReason.Name = "labelReason";
            labelReason.Size = new Size(0, 23);
            labelReason.TabIndex = 13;
            // 
            // labelNewEmp
            // 
            labelNewEmp.AutoSize = true;
            labelNewEmp.Font = new Font("Century Gothic", 14.14286F, FontStyle.Bold, GraphicsUnit.Point);
            labelNewEmp.Location = new Point(1160, 401);
            labelNewEmp.Margin = new Padding(2, 0, 2, 0);
            labelNewEmp.Name = "labelNewEmp";
            labelNewEmp.Size = new Size(0, 23);
            labelNewEmp.TabIndex = 12;
            // 
            // btnAssign
            // 
            btnAssign.BackColor = Color.DodgerBlue;
            btnAssign.FlatStyle = FlatStyle.Flat;
            btnAssign.Font = new Font("Century Gothic", 14.14286F, FontStyle.Regular, GraphicsUnit.Point);
            btnAssign.ForeColor = Color.White;
            btnAssign.Location = new Point(1111, 524);
            btnAssign.Margin = new Padding(2, 1, 2, 1);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new Size(260, 57);
            btnAssign.TabIndex = 8;
            btnAssign.Text = "Assign a new employee";
            btnAssign.UseVisualStyleBackColor = false;
            btnAssign.Visible = false;
            btnAssign.Click += btnAssign_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 14.14286F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(898, 444);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(83, 22);
            label6.TabIndex = 6;
            label6.Text = "Reason:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 14.14286F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(898, 400);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(224, 22);
            label5.TabIndex = 5;
            label5.Text = "New employee's name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14.14286F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(898, 354);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(264, 22);
            label4.TabIndex = 3;
            label4.Text = "Assigned employee's name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.14286F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(898, 309);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(81, 22);
            label3.TabIndex = 1;
            label3.Text = "Shift on:";
            // 
            // btnMarkViewed
            // 
            btnMarkViewed.BackColor = Color.LimeGreen;
            btnMarkViewed.FlatStyle = FlatStyle.Flat;
            btnMarkViewed.Font = new Font("Century Gothic", 14.14286F, FontStyle.Regular, GraphicsUnit.Point);
            btnMarkViewed.ForeColor = Color.White;
            btnMarkViewed.Location = new Point(898, 524);
            btnMarkViewed.Margin = new Padding(2, 1, 2, 1);
            btnMarkViewed.Name = "btnMarkViewed";
            btnMarkViewed.Size = new Size(196, 57);
            btnMarkViewed.TabIndex = 9;
            btnMarkViewed.Text = "Mark as viewed";
            btnMarkViewed.UseVisualStyleBackColor = false;
            btnMarkViewed.Visible = false;
            btnMarkViewed.Click += btnMarkViewed_Click;
            // 
            // labelAssignedEmpName
            // 
            labelAssignedEmpName.AutoSize = true;
            labelAssignedEmpName.Font = new Font("Century Gothic", 14.14286F, FontStyle.Bold, GraphicsUnit.Point);
            labelAssignedEmpName.Location = new Point(1205, 354);
            labelAssignedEmpName.Margin = new Padding(2, 0, 2, 0);
            labelAssignedEmpName.Name = "labelAssignedEmpName";
            labelAssignedEmpName.Size = new Size(0, 23);
            labelAssignedEmpName.TabIndex = 17;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("Century Gothic", 14.14286F, FontStyle.Bold, GraphicsUnit.Point);
            labelStatus.Location = new Point(988, 486);
            labelStatus.Margin = new Padding(2, 0, 2, 0);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(0, 23);
            labelStatus.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 14.14286F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(898, 486);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(70, 22);
            label7.TabIndex = 15;
            label7.Text = "Status:";
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
            panel1.TabIndex = 18;
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
            btnCancelledShifts.Click += btnCancelledShifts_Click;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(898, 134);
            label2.Name = "label2";
            label2.Size = new Size(61, 22);
            label2.TabIndex = 19;
            label2.Text = "Date:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(1036, 135);
            label8.Name = "label8";
            label8.Size = new Size(70, 22);
            label8.TabIndex = 20;
            label8.Text = "Status:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(1184, 135);
            label9.Name = "label9";
            label9.Size = new Size(172, 22);
            label9.TabIndex = 21;
            label9.Text = "A new employee:";
            // 
            // rbtnPast
            // 
            rbtnPast.AutoSize = true;
            rbtnPast.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbtnPast.Location = new Point(903, 161);
            rbtnPast.Name = "rbtnPast";
            rbtnPast.Size = new Size(61, 25);
            rbtnPast.TabIndex = 22;
            rbtnPast.TabStop = true;
            rbtnPast.Text = "Past";
            rbtnPast.UseVisualStyleBackColor = true;
            rbtnPast.CheckedChanged += rbtnPast_CheckedChanged;
            rbtnPast.Click += rbtnPast_CheckedChanged;
            // 
            // rbtnCurrent
            // 
            rbtnCurrent.AutoSize = true;
            rbtnCurrent.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbtnCurrent.Location = new Point(903, 194);
            rbtnCurrent.Name = "rbtnCurrent";
            rbtnCurrent.Size = new Size(88, 25);
            rbtnCurrent.TabIndex = 23;
            rbtnCurrent.TabStop = true;
            rbtnCurrent.Text = "Current";
            rbtnCurrent.UseVisualStyleBackColor = true;
            rbtnCurrent.CheckedChanged += rbtnCurrent_CheckedChanged;
            rbtnCurrent.Click += rbtnCurrent_CheckedChanged;
            // 
            // rbtnSent
            // 
            rbtnSent.AutoSize = true;
            rbtnSent.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbtnSent.Location = new Point(1041, 162);
            rbtnSent.Name = "rbtnSent";
            rbtnSent.Size = new Size(63, 25);
            rbtnSent.TabIndex = 24;
            rbtnSent.TabStop = true;
            rbtnSent.Text = "Sent";
            rbtnSent.UseVisualStyleBackColor = true;
            rbtnSent.CheckedChanged += rbtnSent_CheckedChanged;
            rbtnSent.Click += rbtnSent_CheckedChanged;
            // 
            // rbtnViewed
            // 
            rbtnViewed.AutoSize = true;
            rbtnViewed.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbtnViewed.Location = new Point(1041, 194);
            rbtnViewed.Name = "rbtnViewed";
            rbtnViewed.Size = new Size(87, 25);
            rbtnViewed.TabIndex = 25;
            rbtnViewed.TabStop = true;
            rbtnViewed.Text = "Viewed";
            rbtnViewed.UseVisualStyleBackColor = true;
            rbtnViewed.CheckedChanged += rbtnViewed_CheckedChanged;
            rbtnViewed.Click += rbtnViewed_CheckedChanged;
            // 
            // rbtnAssigned
            // 
            rbtnAssigned.AutoSize = true;
            rbtnAssigned.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbtnAssigned.Location = new Point(1189, 161);
            rbtnAssigned.Name = "rbtnAssigned";
            rbtnAssigned.Size = new Size(98, 25);
            rbtnAssigned.TabIndex = 26;
            rbtnAssigned.TabStop = true;
            rbtnAssigned.Text = "Assigned";
            rbtnAssigned.UseVisualStyleBackColor = true;
            rbtnAssigned.CheckedChanged += rbtnAssigned_CheckedChanged;
            rbtnAssigned.Click += rbtnAssigned_CheckedChanged;
            // 
            // rbtnNotAssigned
            // 
            rbtnNotAssigned.AutoSize = true;
            rbtnNotAssigned.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbtnNotAssigned.Location = new Point(1189, 195);
            rbtnNotAssigned.Name = "rbtnNotAssigned";
            rbtnNotAssigned.Size = new Size(129, 25);
            rbtnNotAssigned.TabIndex = 27;
            rbtnNotAssigned.TabStop = true;
            rbtnNotAssigned.Text = "Not assigned";
            rbtnNotAssigned.UseVisualStyleBackColor = true;
            rbtnNotAssigned.CheckedChanged += rbtnNotAssigned_CheckedChanged;
            rbtnNotAssigned.Click += rbtnNotAssigned_CheckedChanged;
            // 
            // btnShowAll
            // 
            btnShowAll.BackColor = Color.RoyalBlue;
            btnShowAll.FlatStyle = FlatStyle.Flat;
            btnShowAll.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnShowAll.ForeColor = Color.White;
            btnShowAll.Location = new Point(1409, 146);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(113, 59);
            btnShowAll.TabIndex = 28;
            btnShowAll.Text = "Show all";
            btnShowAll.UseVisualStyleBackColor = false;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(893, 84);
            label10.Name = "label10";
            label10.Size = new Size(111, 30);
            label10.TabIndex = 29;
            label10.Text = "Filter by:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(893, 256);
            label11.Name = "label11";
            label11.Size = new Size(100, 30);
            label11.TabIndex = 30;
            label11.Text = "Details:";
            // 
            // AdminCancelledShiftsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1584, 918);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(btnShowAll);
            Controls.Add(rbtnNotAssigned);
            Controls.Add(rbtnAssigned);
            Controls.Add(rbtnViewed);
            Controls.Add(rbtnSent);
            Controls.Add(rbtnCurrent);
            Controls.Add(rbtnPast);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(btnAssign);
            Controls.Add(btnMarkViewed);
            Controls.Add(lbxCancelledShifts);
            Controls.Add(labelAssignedEmpName);
            Controls.Add(labelStatus);
            Controls.Add(label7);
            Controls.Add(labelReason);
            Controls.Add(label1);
            Controls.Add(labelShift);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(labelNewEmp);
            Margin = new Padding(2, 1, 2, 1);
            Name = "AdminCancelledShiftsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminCancelledShiftsForm";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ListBox lbxCancelledShifts;
        private Label labelReason;
        private Label labelNewEmp;
        private Button btnAssign;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label labelShift;
        private Button btnMarkViewed;
        private Label labelAssignedEmpName;
        private Label labelStatus;
        private Label label7;
        private Panel panel1;
        private Button buttonVacations;
        private Button btnHome;
        private Button btnCancelledShifts;
        private Button btnLogout;
        private Button btnDepartments;
        private Button btnEmployees;
        private Button btnShifts;
        private Label label2;
        private Label label8;
        private Label label9;
        private RadioButton rbtnPast;
        private RadioButton rbtnCurrent;
        private RadioButton rbtnSent;
        private RadioButton rbtnViewed;
        private RadioButton rbtnAssigned;
        private RadioButton rbtnNotAssigned;
        private Button btnShowAll;
        private Label label10;
        private Label label11;
    }
}
