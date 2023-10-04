namespace DesktopAppMediaBazaar
{
    partial class AdminShiftsForm
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
            buttonSearch = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            flowLayoutPanelMorning = new FlowLayoutPanel();
            monthCalendar1 = new MonthCalendar();
            comboBoxDepartment = new ComboBox();
            flowLayoutPanelAfternoon = new FlowLayoutPanel();
            flowLayoutPanelEvening = new FlowLayoutPanel();
            lblSelectedDate = new Label();
            label5 = new Label();
            btnAddMorning = new Button();
            label6 = new Label();
            btnAddAfternoon = new Button();
            btnAddEvening = new Button();
            btnRefresh = new Button();
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
            label1.Location = new Point(804, 21);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(149, 32);
            label1.TabIndex = 3;
            label1.Text = "Shifts Page";
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.RoyalBlue;
            buttonSearch.FlatStyle = FlatStyle.Flat;
            buttonSearch.Font = new Font("Century Gothic", 13.125F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSearch.ForeColor = Color.White;
            buttonSearch.Location = new Point(441, 341);
            buttonSearch.Margin = new Padding(2, 1, 2, 1);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(195, 49);
            buttonSearch.TabIndex = 16;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(744, 91);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 23);
            label2.TabIndex = 6;
            label2.Text = "Morning";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(939, 86);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(106, 23);
            label3.TabIndex = 7;
            label3.Text = "Afternoon";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(1168, 86);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(86, 23);
            label4.TabIndex = 8;
            label4.Text = "Evening";
            // 
            // flowLayoutPanelMorning
            // 
            flowLayoutPanelMorning.AutoScroll = true;
            flowLayoutPanelMorning.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelMorning.Font = new Font("Century Gothic", 13.125F, FontStyle.Regular, GraphicsUnit.Point);
            flowLayoutPanelMorning.Location = new Point(711, 177);
            flowLayoutPanelMorning.Margin = new Padding(2, 1, 2, 1);
            flowLayoutPanelMorning.Name = "flowLayoutPanelMorning";
            flowLayoutPanelMorning.Size = new Size(156, 375);
            flowLayoutPanelMorning.TabIndex = 9;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Font = new Font("Century Gothic", 13.125F, FontStyle.Regular, GraphicsUnit.Point);
            monthCalendar1.Location = new Point(441, 163);
            monthCalendar1.Margin = new Padding(5, 4, 5, 4);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 10;
            monthCalendar1.DateChanged += monthCalendar1_DateSelected;
            // 
            // comboBoxDepartment
            // 
            comboBoxDepartment.Font = new Font("Century Gothic", 13.125F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxDepartment.FormattingEnabled = true;
            comboBoxDepartment.Location = new Point(505, 85);
            comboBoxDepartment.Margin = new Padding(2, 1, 2, 1);
            comboBoxDepartment.Name = "comboBoxDepartment";
            comboBoxDepartment.Size = new Size(192, 29);
            comboBoxDepartment.TabIndex = 11;
            comboBoxDepartment.SelectedIndexChanged += comboBoxDepartment_SelectedIndexChanged;
            // 
            // flowLayoutPanelAfternoon
            // 
            flowLayoutPanelAfternoon.AutoScroll = true;
            flowLayoutPanelAfternoon.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelAfternoon.Font = new Font("Century Gothic", 13.125F, FontStyle.Regular, GraphicsUnit.Point);
            flowLayoutPanelAfternoon.Location = new Point(921, 177);
            flowLayoutPanelAfternoon.Margin = new Padding(2, 1, 2, 1);
            flowLayoutPanelAfternoon.Name = "flowLayoutPanelAfternoon";
            flowLayoutPanelAfternoon.Size = new Size(156, 375);
            flowLayoutPanelAfternoon.TabIndex = 10;
            // 
            // flowLayoutPanelEvening
            // 
            flowLayoutPanelEvening.AutoScroll = true;
            flowLayoutPanelEvening.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelEvening.Font = new Font("Century Gothic", 13.125F, FontStyle.Regular, GraphicsUnit.Point);
            flowLayoutPanelEvening.Location = new Point(1142, 177);
            flowLayoutPanelEvening.Margin = new Padding(2, 1, 2, 1);
            flowLayoutPanelEvening.Name = "flowLayoutPanelEvening";
            flowLayoutPanelEvening.Size = new Size(156, 375);
            flowLayoutPanelEvening.TabIndex = 10;
            // 
            // lblSelectedDate
            // 
            lblSelectedDate.AutoSize = true;
            lblSelectedDate.Font = new Font("Century Gothic", 13.125F, FontStyle.Bold, GraphicsUnit.Point);
            lblSelectedDate.Location = new Point(441, 123);
            lblSelectedDate.Margin = new Padding(2, 0, 2, 0);
            lblSelectedDate.Name = "lblSelectedDate";
            lblSelectedDate.Size = new Size(0, 22);
            lblSelectedDate.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 13.125F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(373, 86);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(123, 21);
            label5.TabIndex = 17;
            label5.Text = "Department:";
            // 
            // btnAddMorning
            // 
            btnAddMorning.BackColor = Color.SeaGreen;
            btnAddMorning.FlatStyle = FlatStyle.Flat;
            btnAddMorning.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddMorning.ForeColor = Color.White;
            btnAddMorning.Location = new Point(711, 123);
            btnAddMorning.Margin = new Padding(2, 1, 2, 1);
            btnAddMorning.Name = "btnAddMorning";
            btnAddMorning.Size = new Size(156, 38);
            btnAddMorning.TabIndex = 18;
            btnAddMorning.Text = "Add";
            btnAddMorning.UseVisualStyleBackColor = false;
            btnAddMorning.Click += btnAddMorning_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 13.125F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(373, 123);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(51, 21);
            label6.TabIndex = 22;
            label6.Text = "Day:";
            // 
            // btnAddAfternoon
            // 
            btnAddAfternoon.BackColor = Color.SeaGreen;
            btnAddAfternoon.FlatStyle = FlatStyle.Flat;
            btnAddAfternoon.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddAfternoon.ForeColor = Color.White;
            btnAddAfternoon.Location = new Point(921, 119);
            btnAddAfternoon.Margin = new Padding(2, 1, 2, 1);
            btnAddAfternoon.Name = "btnAddAfternoon";
            btnAddAfternoon.Size = new Size(156, 38);
            btnAddAfternoon.TabIndex = 23;
            btnAddAfternoon.Text = "Add";
            btnAddAfternoon.UseVisualStyleBackColor = false;
            btnAddAfternoon.Click += btnAddAfternoon_Click;
            // 
            // btnAddEvening
            // 
            btnAddEvening.BackColor = Color.SeaGreen;
            btnAddEvening.FlatStyle = FlatStyle.Flat;
            btnAddEvening.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddEvening.ForeColor = Color.White;
            btnAddEvening.Location = new Point(1142, 119);
            btnAddEvening.Margin = new Padding(2, 1, 2, 1);
            btnAddEvening.Name = "btnAddEvening";
            btnAddEvening.Size = new Size(156, 38);
            btnAddEvening.TabIndex = 25;
            btnAddEvening.Text = "Add";
            btnAddEvening.UseVisualStyleBackColor = false;
            btnAddEvening.Click += btnAddEvening_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.LightSeaGreen;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Century Gothic", 16.875F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(640, 341);
            btnRefresh.Margin = new Padding(2, 1, 2, 1);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(49, 49);
            btnRefresh.TabIndex = 27;
            btnRefresh.Text = "🔄";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
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
            panel1.TabIndex = 28;
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
            // AdminShiftsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1584, 918);
            Controls.Add(panel1);
            Controls.Add(btnRefresh);
            Controls.Add(btnAddEvening);
            Controls.Add(btnAddAfternoon);
            Controls.Add(label6);
            Controls.Add(btnAddMorning);
            Controls.Add(label5);
            Controls.Add(buttonSearch);
            Controls.Add(lblSelectedDate);
            Controls.Add(flowLayoutPanelEvening);
            Controls.Add(flowLayoutPanelAfternoon);
            Controls.Add(comboBoxDepartment);
            Controls.Add(monthCalendar1);
            Controls.Add(flowLayoutPanelMorning);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2, 1, 2, 1);
            Name = "AdminShiftsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminShiftsForm";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private FlowLayoutPanel flowLayoutPanelMorning;
        private MonthCalendar monthCalendar1;
        private ComboBox comboBoxDepartment;
        private FlowLayoutPanel flowLayoutPanelAfternoon;
        private FlowLayoutPanel flowLayoutPanelEvening;
        private Label lblSelectedDate;
        private Button buttonSearch;
        private Label label5;
        private Button btnAddMorning;
        private Label label6;
        private Button btnAddAfternoon;
        private Button btnAddEvening;
        private Button btnRefresh;
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
