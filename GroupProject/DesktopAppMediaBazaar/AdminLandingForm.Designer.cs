namespace DesktopAppMediaBazaar
{
    partial class AdminLandingForm
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
            labelWelcome = new Label();
            btnEdit = new Button();
            lbAnnouncements = new ListBox();
            lblTitle = new Label();
            lblDetails = new Label();
            lblStart = new Label();
            lblEndDate = new Label();
            btnDelete = new Button();
            btnCreate = new Button();
            tbTitle = new TextBox();
            tbDetails = new TextBox();
            btnSubmit = new Button();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
            rBtnPast = new RadioButton();
            rBtnFuture = new RadioButton();
            rBtnAll = new RadioButton();
            rBtnCurrent = new RadioButton();
            panel1 = new Panel();
            buttonVacations = new Button();
            btnHome = new Button();
            btnCancelledShifts = new Button();
            btnLogout = new Button();
            btnDepartments = new Button();
            btnEmployees = new Button();
            btnShifts = new Button();
            label2 = new Label();
            buttonCancel = new Button();
            label3 = new Label();
            radioButtonPast = new RadioButton();
            radioButtonCurrent = new RadioButton();
            radioButtonAll = new RadioButton();
            radioButtonFuture = new RadioButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Century Gothic", 19.125F, FontStyle.Regular, GraphicsUnit.Point);
            labelWelcome.Location = new Point(343, 55);
            labelWelcome.Margin = new Padding(2, 0, 2, 0);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(137, 32);
            labelWelcome.TabIndex = 0;
            labelWelcome.Text = "Welcome";
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Blue;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Century Gothic", 13.125F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(343, 597);
            btnEdit.Margin = new Padding(2, 1, 2, 1);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(148, 44);
            btnEdit.TabIndex = 20;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // lbAnnouncements
            // 
            lbAnnouncements.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbAnnouncements.FormattingEnabled = true;
            lbAnnouncements.ItemHeight = 21;
            lbAnnouncements.Location = new Point(343, 281);
            lbAnnouncements.Name = "lbAnnouncements";
            lbAnnouncements.Size = new Size(557, 277);
            lbAnnouncements.TabIndex = 21;
            lbAnnouncements.Click += listBox1_SelectedIndexChanged;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(937, 281);
            lblTitle.Margin = new Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(574, 23);
            lblTitle.TabIndex = 22;
            lblTitle.Text = "Title:";
            lblTitle.Visible = false;
            // 
            // lblDetails
            // 
            lblDetails.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblDetails.Location = new Point(937, 335);
            lblDetails.Margin = new Padding(2, 0, 2, 0);
            lblDetails.Name = "lblDetails";
            lblDetails.Size = new Size(574, 92);
            lblDetails.TabIndex = 23;
            lblDetails.Text = "Details:";
            lblDetails.Visible = false;
            // 
            // lblStart
            // 
            lblStart.AutoSize = true;
            lblStart.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblStart.Location = new Point(937, 433);
            lblStart.Margin = new Padding(2, 0, 2, 0);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(108, 22);
            lblStart.TabIndex = 24;
            lblStart.Text = "Start Date:";
            lblStart.Visible = false;
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblEndDate.Location = new Point(937, 491);
            lblEndDate.Margin = new Padding(2, 0, 2, 0);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(101, 22);
            lblEndDate.TabIndex = 25;
            lblEndDate.Text = "End Date:";
            lblEndDate.Visible = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Century Gothic", 13.125F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(515, 597);
            btnDelete.Margin = new Padding(2, 1, 2, 1);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(148, 44);
            btnDelete.TabIndex = 26;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.DarkSlateGray;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Century Gothic", 13.125F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(343, 651);
            btnCreate.Margin = new Padding(2, 1, 2, 1);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(320, 34);
            btnCreate.TabIndex = 27;
            btnCreate.Text = "Create Announcement";
            btnCreate.UseVisualStyleBackColor = false;
            //btnCreate.Click += btnCreate_Click;
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(1049, 279);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(250, 23);
            tbTitle.TabIndex = 28;
            tbTitle.Visible = false;
            // 
            // tbDetails
            // 
            tbDetails.Location = new Point(1049, 334);
            tbDetails.Multiline = true;
            tbDetails.Name = "tbDetails";
            tbDetails.Size = new Size(250, 93);
            tbDetails.TabIndex = 29;
            tbDetails.Visible = false;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.Blue;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Century Gothic", 13.125F, FontStyle.Regular, GraphicsUnit.Point);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(937, 532);
            btnSubmit.Margin = new Padding(2, 1, 2, 1);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(148, 44);
            btnSubmit.TabIndex = 32;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Visible = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(1049, 432);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 23);
            dateTimePicker1.TabIndex = 33;
            dateTimePicker1.Visible = false;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(1049, 490);
            dateTimePicker2.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 23);
            dateTimePicker2.TabIndex = 34;
            dateTimePicker2.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(343, 165);
            label1.Name = "label1";
            label1.Size = new Size(138, 23);
            label1.TabIndex = 35;
            label1.Text = "Filter by time:";
            // 
            // rBtnPast
            // 
            rBtnPast.AutoSize = true;
            rBtnPast.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rBtnPast.Location = new Point(615, 165);
            rBtnPast.Name = "rBtnPast";
            rBtnPast.Size = new Size(74, 27);
            rBtnPast.TabIndex = 36;
            rBtnPast.TabStop = true;
            rBtnPast.Text = "past";
            rBtnPast.UseVisualStyleBackColor = true;
            // 
            // rBtnFuture
            // 
            rBtnFuture.AutoSize = true;
            rBtnFuture.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rBtnFuture.Location = new Point(718, 165);
            rBtnFuture.Name = "rBtnFuture";
            rBtnFuture.Size = new Size(87, 27);
            rBtnFuture.TabIndex = 37;
            rBtnFuture.TabStop = true;
            rBtnFuture.Text = "future";
            rBtnFuture.UseVisualStyleBackColor = true;
            // 
            // rBtnAll
            // 
            rBtnAll.AutoSize = true;
            rBtnAll.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rBtnAll.Location = new Point(300, 300);
            rBtnAll.Name = "rBtnAll";
            rBtnAll.Size = new Size(55, 27);
            rBtnAll.TabIndex = 38;
            rBtnAll.TabStop = true;
            rBtnAll.Text = "all";
            rBtnAll.UseVisualStyleBackColor = true;
            // 
            // rBtnCurrent
            // 
            rBtnCurrent.AutoSize = true;
            rBtnCurrent.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rBtnCurrent.Location = new Point(487, 165);
            rBtnCurrent.Name = "rBtnCurrent";
            rBtnCurrent.Size = new Size(100, 27);
            rBtnCurrent.TabIndex = 39;
            rBtnCurrent.TabStop = true;
            rBtnCurrent.Text = "current";
            rBtnCurrent.UseVisualStyleBackColor = true;
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
            panel1.TabIndex = 35;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(343, 135);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(187, 24);
            label2.TabIndex = 36;
            label2.Text = "Announcements:";
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = SystemColors.GradientActiveCaption;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Century Gothic", 13.125F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.ForeColor = Color.Black;
            buttonCancel.Location = new Point(1151, 532);
            buttonCancel.Margin = new Padding(2, 1, 2, 1);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(148, 44);
            buttonCancel.TabIndex = 37;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Visible = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(343, 202);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(134, 22);
            label3.TabIndex = 38;
            label3.Text = "Filter by date:";
            // 
            // radioButtonPast
            // 
            radioButtonPast.AutoSize = true;
            radioButtonPast.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonPast.Location = new Point(343, 234);
            radioButtonPast.Name = "radioButtonPast";
            radioButtonPast.Size = new Size(66, 26);
            radioButtonPast.TabIndex = 39;
            radioButtonPast.TabStop = true;
            radioButtonPast.Text = "Past";
            radioButtonPast.UseVisualStyleBackColor = true;
            radioButtonPast.CheckedChanged += rBtnPast_CheckedChanged;
            // 
            // radioButtonCurrent
            // 
            radioButtonCurrent.AutoSize = true;
            radioButtonCurrent.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonCurrent.Location = new Point(415, 234);
            radioButtonCurrent.Name = "radioButtonCurrent";
            radioButtonCurrent.Size = new Size(98, 26);
            radioButtonCurrent.TabIndex = 40;
            radioButtonCurrent.TabStop = true;
            radioButtonCurrent.Text = "Current";
            radioButtonCurrent.UseVisualStyleBackColor = true;
            radioButtonCurrent.CheckedChanged += rBtnCurrent_CheckedChanged;
            // 
            // radioButtonAll
            // 
            radioButtonAll.AutoSize = true;
            radioButtonAll.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonAll.Location = new Point(611, 234);
            radioButtonAll.Name = "radioButtonAll";
            radioButtonAll.Size = new Size(49, 26);
            radioButtonAll.TabIndex = 42;
            radioButtonAll.TabStop = true;
            radioButtonAll.Text = "All";
            radioButtonAll.UseVisualStyleBackColor = true;
            radioButtonAll.CheckedChanged += rBtnAll_CheckedChanged;
            // 
            // radioButtonFuture
            // 
            radioButtonFuture.AutoSize = true;
            radioButtonFuture.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonFuture.Location = new Point(519, 234);
            radioButtonFuture.Name = "radioButtonFuture";
            radioButtonFuture.Size = new Size(86, 26);
            radioButtonFuture.TabIndex = 41;
            radioButtonFuture.TabStop = true;
            radioButtonFuture.Text = "Future";
            radioButtonFuture.UseVisualStyleBackColor = true;
            radioButtonFuture.CheckedChanged += rBtnFuture_CheckedChanged;
            // 
            // AdminLandingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1584, 918);
            Controls.Add(radioButtonAll);
            Controls.Add(radioButtonFuture);
            Controls.Add(radioButtonCurrent);
            Controls.Add(radioButtonPast);
            Controls.Add(label3);
            Controls.Add(buttonCancel);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnSubmit);
            Controls.Add(tbDetails);
            Controls.Add(tbTitle);
            Controls.Add(btnCreate);
            Controls.Add(btnDelete);
            Controls.Add(lblEndDate);
            Controls.Add(lblStart);
            Controls.Add(lblDetails);
            Controls.Add(lblTitle);
            Controls.Add(lbAnnouncements);
            Controls.Add(btnEdit);
            Controls.Add(labelWelcome);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2, 1, 2, 1);
            Name = "AdminLandingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminLandingPage";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelWelcome;
        private Button btnEdit;
        private ListBox lbAnnouncements;
        private Label lblTitle;
        private Label lblDetails;
        private Label lblStart;
        private Label lblEndDate;
        private Button btnDelete;
        private Button btnCreate;
        private TextBox tbTitle;
        private TextBox tbDetails;
        private Button btnSubmit;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button button1;
        private Label label1;
        private RadioButton rBtnPast;
        private RadioButton rBtnFuture;
        private RadioButton rBtnAll;
        private RadioButton rBtnCurrent;
        private Panel panel1;
        private Button buttonVacations;
        private Button btnHome;
        private Button btnCancelledShifts;
        private Button btnLogout;
        private Button btnDepartments;
        private Button btnEmployees;
        private Button btnShifts;
        private Label label2;
        private Button buttonCancel;
        private Label label3;
        private RadioButton radioButtonPast;
        private RadioButton radioButtonCurrent;
        private RadioButton radioButtonAll;
        private RadioButton radioButtonFuture;
    }
}