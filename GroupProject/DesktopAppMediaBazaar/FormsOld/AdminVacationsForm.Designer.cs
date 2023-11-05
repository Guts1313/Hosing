namespace DesktopAppMediaBazaar
{
    partial class AdminVacationsForm
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
            listBoxVacations = new ListBox();
            labelEmployee = new Label();
            labelStartDate = new Label();
            labelEndDate = new Label();
            labelReason = new Label();
            btnApprove = new Button();
            btnReject = new Button();
            labelStatus = new Label();
            panel1 = new Panel();
            buttonVacations = new Button();
            btnHome = new Button();
            btnCancelledShifts = new Button();
            btnLogout = new Button();
            btnDepartments = new Button();
            btnEmployees = new Button();
            btnShifts = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 19.125F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(664, 18);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(217, 32);
            label1.TabIndex = 6;
            label1.Text = "Vacations Page";
            // 
            // listBoxVacations
            // 
            listBoxVacations.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxVacations.FormattingEnabled = true;
            listBoxVacations.HorizontalScrollbar = true;
            listBoxVacations.ItemHeight = 22;
            listBoxVacations.Location = new Point(267, 116);
            listBoxVacations.Name = "listBoxVacations";
            listBoxVacations.Size = new Size(459, 400);
            listBoxVacations.TabIndex = 7;
            listBoxVacations.SelectedIndexChanged += listBoxVacations_SelectedIndexChanged;
            // 
            // labelEmployee
            // 
            labelEmployee.AutoSize = true;
            labelEmployee.Font = new Font("Century Gothic", 19.125F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmployee.Location = new Point(731, 116);
            labelEmployee.Margin = new Padding(2, 0, 2, 0);
            labelEmployee.Name = "labelEmployee";
            labelEmployee.Size = new Size(149, 32);
            labelEmployee.TabIndex = 8;
            labelEmployee.Text = "Employee:";
            labelEmployee.Visible = false;
            // 
            // labelStartDate
            // 
            labelStartDate.AutoSize = true;
            labelStartDate.Font = new Font("Century Gothic", 19.125F, FontStyle.Regular, GraphicsUnit.Point);
            labelStartDate.Location = new Point(731, 155);
            labelStartDate.Margin = new Padding(2, 0, 2, 0);
            labelStartDate.Name = "labelStartDate";
            labelStartDate.Size = new Size(144, 32);
            labelStartDate.TabIndex = 9;
            labelStartDate.Text = "Start date:";
            labelStartDate.Visible = false;
            // 
            // labelEndDate
            // 
            labelEndDate.AutoSize = true;
            labelEndDate.Font = new Font("Century Gothic", 19.125F, FontStyle.Regular, GraphicsUnit.Point);
            labelEndDate.Location = new Point(731, 194);
            labelEndDate.Margin = new Padding(2, 0, 2, 0);
            labelEndDate.Name = "labelEndDate";
            labelEndDate.Size = new Size(137, 32);
            labelEndDate.TabIndex = 10;
            labelEndDate.Text = "End date:";
            labelEndDate.Visible = false;
            // 
            // labelReason
            // 
            labelReason.Font = new Font("Century Gothic", 19.125F, FontStyle.Regular, GraphicsUnit.Point);
            labelReason.Location = new Point(732, 232);
            labelReason.Margin = new Padding(2, 0, 2, 0);
            labelReason.Name = "labelReason";
            labelReason.Size = new Size(471, 174);
            labelReason.TabIndex = 11;
            labelReason.Text = "Reason:\r\n";
            labelReason.Visible = false;
            // 
            // btnApprove
            // 
            btnApprove.BackColor = Color.SeaGreen;
            btnApprove.FlatStyle = FlatStyle.Flat;
            btnApprove.Font = new Font("Century Gothic", 19.125F, FontStyle.Regular, GraphicsUnit.Point);
            btnApprove.ForeColor = Color.White;
            btnApprove.Location = new Point(731, 410);
            btnApprove.Margin = new Padding(2, 1, 2, 1);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(144, 54);
            btnApprove.TabIndex = 19;
            btnApprove.Text = "Approve";
            btnApprove.UseVisualStyleBackColor = false;
            btnApprove.Visible = false;
            btnApprove.Click += btnApprove_Click;
            // 
            // btnReject
            // 
            btnReject.BackColor = Color.IndianRed;
            btnReject.FlatStyle = FlatStyle.Flat;
            btnReject.Font = new Font("Century Gothic", 19.125F, FontStyle.Regular, GraphicsUnit.Point);
            btnReject.ForeColor = Color.White;
            btnReject.Location = new Point(1058, 410);
            btnReject.Margin = new Padding(2, 1, 2, 1);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(144, 54);
            btnReject.TabIndex = 20;
            btnReject.Text = "Reject";
            btnReject.UseVisualStyleBackColor = false;
            btnReject.Visible = false;
            btnReject.Click += btnReject_Click;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("Century Gothic", 19.125F, FontStyle.Regular, GraphicsUnit.Point);
            labelStatus.Location = new Point(922, 423);
            labelStatus.Margin = new Padding(2, 0, 2, 0);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(101, 32);
            labelStatus.TabIndex = 21;
            labelStatus.Text = "Status: ";
            labelStatus.Visible = false;
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
            panel1.Size = new Size(250, 865);
            panel1.TabIndex = 22;
            // 
            // buttonVacations
            // 
            buttonVacations.BackColor = Color.Teal;
            buttonVacations.FlatStyle = FlatStyle.Flat;
            buttonVacations.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonVacations.ForeColor = Color.White;
            buttonVacations.Location = new Point(6, 470);
            buttonVacations.Name = "buttonVacations";
            buttonVacations.Size = new Size(238, 70);
            buttonVacations.TabIndex = 19;
            buttonVacations.Text = "Vacations";
            buttonVacations.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Teal;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(6, 20);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(238, 70);
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
            btnCancelledShifts.Location = new Point(6, 380);
            btnCancelledShifts.Name = "btnCancelledShifts";
            btnCancelledShifts.Size = new Size(238, 70);
            btnCancelledShifts.TabIndex = 15;
            btnCancelledShifts.Text = "Cancelled shifts";
            btnCancelledShifts.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.IndianRed;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(6, 775);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(238, 70);
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
            btnDepartments.Location = new Point(6, 200);
            btnDepartments.Name = "btnDepartments";
            btnDepartments.Size = new Size(238, 70);
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
            btnEmployees.Location = new Point(6, 110);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(238, 70);
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
            btnShifts.Location = new Point(6, 290);
            btnShifts.Name = "btnShifts";
            btnShifts.Size = new Size(238, 70);
            btnShifts.TabIndex = 2;
            btnShifts.Text = "Shifts";
            btnShifts.UseVisualStyleBackColor = false;
            btnShifts.Click += btnShifts_Click;
            // 
            // AdminVacationsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1584, 861);
            Controls.Add(panel1);
            Controls.Add(btnReject);
            Controls.Add(btnApprove);
            Controls.Add(labelReason);
            Controls.Add(labelEndDate);
            Controls.Add(labelStartDate);
            Controls.Add(labelEmployee);
            Controls.Add(listBoxVacations);
            Controls.Add(label1);
            Controls.Add(labelStatus);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2, 1, 2, 1);
            Name = "AdminVacationsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminVacations";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ListBox listBoxVacations;
        private Label labelEmployee;
        private Label labelStartDate;
        private Label labelEndDate;
        private Label labelReason;
        private Button btnApprove;
        private Button btnReject;
        private Label labelStatus;
        private Panel panel1;
        private Button buttonVacations;
        private Button btnHome;
        private Button btnCancelledShifts;
        private Button btnLogout;
        private Button btnDepartments;
        private Button btnEmployees;
        private Button btnShifts;
    }
}