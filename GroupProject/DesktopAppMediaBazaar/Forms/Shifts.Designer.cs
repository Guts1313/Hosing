namespace DesktopAppMediaBazaar.Forms

{
    partial class Shifts
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
            roundPanel1 = new CustomElements.RoundPanel();
            btnAutoShifts = new CustomElements.RoundButton();
            panel2 = new Panel();
            customLabelV21 = new CustomElements.Controls.CustomLabelV2();
            tbxName = new housing.CustomElements.RoundTextBox();
            panel1 = new Panel();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            earlyEveningCheckBox = new CustomElements.CustomCheckBox();
            earlyAfternoonCheckBox = new CustomElements.CustomCheckBox();
            earlyMorningCheckBox = new CustomElements.CustomCheckBox();
            label8 = new Label();
            label7 = new Label();
            label3 = new Label();
            morningCheckBox = new CustomElements.CustomCheckBox();
            afterNoonCheckBox = new CustomElements.CustomCheckBox();
            label6 = new Label();
            cbxDepartment = new CustomElements.CustomComboBox();
            label2 = new Label();
            label5 = new Label();
            eveningCheckBox = new CustomElements.CustomCheckBox();
            label4 = new Label();
            label1 = new Label();
            Calendar = new CustomElements.CustomDatePicker();
            btnSearch = new CustomElements.RoundButton();
            btnDelete = new CustomElements.RoundButton();
            btnAdd = new CustomElements.RoundButton();
            roundPanelListBox1 = new CustomElements.RoundPanelListBox();
            dataGridViewShifts = new DataGridView();
            roundPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            roundPanelListBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewShifts).BeginInit();
            SuspendLayout();
            // 
            // roundPanel1
            // 
            roundPanel1.BackColor = Color.FromArgb(156, 84, 213);
            roundPanel1.BorderColor = Color.White;
            roundPanel1.BorderWidth = 5;
            roundPanel1.Controls.Add(panel2);
            roundPanel1.Controls.Add(panel1);
            roundPanel1.Controls.Add(roundPanelListBox1);
            roundPanel1.Dock = DockStyle.Fill;
            roundPanel1.FillColor = Color.FromArgb(229, 229, 229);
            roundPanel1.IsBorder = false;
            roundPanel1.IsFill = true;
            roundPanel1.Location = new Point(0, 0);
            roundPanel1.Margin = new Padding(4, 3, 4, 3);
            roundPanel1.Name = "roundPanel1";
            roundPanel1.Radius = 20;
            roundPanel1.Size = new Size(1041, 542);
            roundPanel1.TabIndex = 4;
            // 
            // btnAutoShifts
            // 
            btnAutoShifts.BackColor = Color.FromArgb(156, 84, 213);
            btnAutoShifts.BackgroundColor = Color.FromArgb(156, 84, 213);
            btnAutoShifts.BorderColor = Color.FromArgb(156, 84, 213);
            btnAutoShifts.BorderRadius = 15;
            btnAutoShifts.BorderSize = 0;
            btnAutoShifts.ClickedColor = Color.FromArgb(156, 84, 213);
            btnAutoShifts.FlatAppearance.BorderSize = 0;
            btnAutoShifts.FlatStyle = FlatStyle.Flat;
            btnAutoShifts.Font = new Font("Cascadia Code", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAutoShifts.ForeColor = Color.FromArgb(229, 229, 229);
            btnAutoShifts.Location = new Point(0, 370);
            btnAutoShifts.Name = "btnAutoShifts";
            btnAutoShifts.Size = new Size(282, 40);
            btnAutoShifts.TabIndex = 44;
            btnAutoShifts.Text = "Generate Shifts Automatically";
            btnAutoShifts.TextColor = Color.FromArgb(229, 229, 229);
            btnAutoShifts.UseVisualStyleBackColor = false;
            btnAutoShifts.Click += btnAutoShifts_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(229, 229, 229);
            panel2.Controls.Add(customLabelV21);
            panel2.Controls.Add(tbxName);
            panel2.Location = new Point(58, 403);
            panel2.Name = "panel2";
            panel2.Size = new Size(648, 69);
            panel2.TabIndex = 29;
            // 
            // customLabelV21
            // 
            customLabelV21.AutoSize = true;
            customLabelV21.BackColor = Color.Transparent;
            customLabelV21.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            customLabelV21.ForeColor = Color.FromArgb(114, 118, 127);
            customLabelV21.Location = new Point(0, 0);
            customLabelV21.Margin = new Padding(4, 0, 4, 0);
            customLabelV21.Name = "customLabelV21";
            customLabelV21.Size = new Size(163, 21);
            customLabelV21.TabIndex = 15;
            customLabelV21.Text = "Search Employees:";
            // 
            // tbxName
            // 
            tbxName.BackColor = Color.FromArgb(215, 215, 215);
            tbxName.BorderColor = Color.FromArgb(156, 84, 213);
            tbxName.BorderFocusColor = Color.FromArgb(156, 84, 213);
            tbxName.BorderRadius = 10;
            tbxName.BorderSize = 3;
            tbxName.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbxName.ForeColor = Color.FromArgb(127, 131, 140);
            tbxName.Location = new Point(0, 25);
            tbxName.Margin = new Padding(4);
            tbxName.Multiline = false;
            tbxName.Name = "tbxName";
            tbxName.Padding = new Padding(10, 7, 10, 7);
            tbxName.PasswordChar = false;
            tbxName.PlaceholderColor = Color.FromArgb(127, 131, 140);
            tbxName.PlaceholderText = "< name >";
            tbxName.Size = new Size(240, 31);
            tbxName.TabIndex = 15;
            tbxName.Texts = "";
            tbxName.UnderlinedStyle = true;
            tbxName._TextChanged += tbxName__TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(229, 229, 229);
            panel1.Controls.Add(btnAutoShifts);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(earlyEveningCheckBox);
            panel1.Controls.Add(earlyAfternoonCheckBox);
            panel1.Controls.Add(earlyMorningCheckBox);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(morningCheckBox);
            panel1.Controls.Add(afterNoonCheckBox);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cbxDepartment);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(eveningCheckBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Calendar);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnAdd);
            panel1.Location = new Point(722, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(282, 422);
            panel1.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(114, 118, 127);
            label9.Location = new Point(207, 135);
            label9.Name = "label9";
            label9.Size = new Size(56, 16);
            label9.TabIndex = 52;
            label9.Text = "0am-4am";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(114, 118, 127);
            label10.Location = new Point(113, 135);
            label10.Name = "label10";
            label10.Size = new Size(70, 16);
            label10.TabIndex = 51;
            label10.Text = "16pm-20pm";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(114, 118, 127);
            label11.Location = new Point(29, 135);
            label11.Name = "label11";
            label11.Size = new Size(63, 16);
            label11.TabIndex = 50;
            label11.Text = "8am-12pm";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(114, 118, 127);
            label12.Location = new Point(201, 114);
            label12.Name = "label12";
            label12.Size = new Size(73, 21);
            label12.TabIndex = 49;
            label12.Text = "E. Eve.";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(114, 118, 127);
            label13.Location = new Point(113, 114);
            label13.Name = "label13";
            label13.Size = new Size(73, 21);
            label13.TabIndex = 48;
            label13.Text = "E. Aft.";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(114, 118, 127);
            label14.Location = new Point(26, 114);
            label14.Name = "label14";
            label14.Size = new Size(73, 21);
            label14.TabIndex = 47;
            label14.Text = "E. Mor.";
            // 
            // earlyEveningCheckBox
            // 
            earlyEveningCheckBox.AutoSize = true;
            earlyEveningCheckBox.Location = new Point(212, 151);
            earlyEveningCheckBox.MinimumSize = new Size(45, 22);
            earlyEveningCheckBox.Name = "earlyEveningCheckBox";
            earlyEveningCheckBox.OffBackColor = Color.FromArgb(156, 84, 213);
            earlyEveningCheckBox.OffToggleColor = Color.FromArgb(229, 229, 229);
            earlyEveningCheckBox.OnBackColor = Color.FromArgb(156, 84, 213);
            earlyEveningCheckBox.OnToggleColor = Color.FromArgb(229, 229, 229);
            earlyEveningCheckBox.Size = new Size(45, 22);
            earlyEveningCheckBox.TabIndex = 46;
            earlyEveningCheckBox.UseVisualStyleBackColor = true;
            earlyEveningCheckBox.CheckedChanged += earlyEveningCheckBox_CheckedChanged;
            // 
            // earlyAfternoonCheckBox
            // 
            earlyAfternoonCheckBox.AutoSize = true;
            earlyAfternoonCheckBox.Location = new Point(125, 151);
            earlyAfternoonCheckBox.MinimumSize = new Size(45, 22);
            earlyAfternoonCheckBox.Name = "earlyAfternoonCheckBox";
            earlyAfternoonCheckBox.OffBackColor = Color.FromArgb(156, 84, 213);
            earlyAfternoonCheckBox.OffToggleColor = Color.FromArgb(229, 229, 229);
            earlyAfternoonCheckBox.OnBackColor = Color.FromArgb(156, 84, 213);
            earlyAfternoonCheckBox.OnToggleColor = Color.FromArgb(229, 229, 229);
            earlyAfternoonCheckBox.Size = new Size(45, 22);
            earlyAfternoonCheckBox.TabIndex = 45;
            earlyAfternoonCheckBox.UseVisualStyleBackColor = true;
            earlyAfternoonCheckBox.CheckedChanged += earlyAfternoonCheckBox_CheckedChanged;
            // 
            // earlyMorningCheckBox
            // 
            earlyMorningCheckBox.AutoSize = true;
            earlyMorningCheckBox.Location = new Point(35, 151);
            earlyMorningCheckBox.MinimumSize = new Size(45, 22);
            earlyMorningCheckBox.Name = "earlyMorningCheckBox";
            earlyMorningCheckBox.OffBackColor = Color.FromArgb(156, 84, 213);
            earlyMorningCheckBox.OffToggleColor = Color.FromArgb(229, 229, 229);
            earlyMorningCheckBox.OnBackColor = Color.FromArgb(156, 84, 213);
            earlyMorningCheckBox.OnToggleColor = Color.FromArgb(229, 229, 229);
            earlyMorningCheckBox.Size = new Size(45, 22);
            earlyMorningCheckBox.TabIndex = 44;
            earlyMorningCheckBox.UseVisualStyleBackColor = true;
            earlyMorningCheckBox.CheckedChanged += earlyMorningCheckBox_CheckedChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(114, 118, 127);
            label8.Location = new Point(208, 201);
            label8.Name = "label8";
            label8.Size = new Size(56, 16);
            label8.TabIndex = 43;
            label8.Text = "4am-8am";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(114, 118, 127);
            label7.Location = new Point(116, 201);
            label7.Name = "label7";
            label7.Size = new Size(63, 16);
            label7.TabIndex = 42;
            label7.Text = "20pm-0am";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(114, 118, 127);
            label3.Location = new Point(24, 201);
            label3.Name = "label3";
            label3.Size = new Size(70, 16);
            label3.TabIndex = 41;
            label3.Text = "12am-16pm";
            // 
            // morningCheckBox
            // 
            morningCheckBox.AutoSize = true;
            morningCheckBox.Location = new Point(35, 218);
            morningCheckBox.MinimumSize = new Size(45, 22);
            morningCheckBox.Name = "morningCheckBox";
            morningCheckBox.OffBackColor = Color.FromArgb(156, 84, 213);
            morningCheckBox.OffToggleColor = Color.FromArgb(229, 229, 229);
            morningCheckBox.OnBackColor = Color.FromArgb(156, 84, 213);
            morningCheckBox.OnToggleColor = Color.FromArgb(229, 229, 229);
            morningCheckBox.Size = new Size(45, 22);
            morningCheckBox.TabIndex = 40;
            morningCheckBox.UseVisualStyleBackColor = true;
            morningCheckBox.CheckedChanged += morningCheckBox_CheckedChanged;
            // 
            // afterNoonCheckBox
            // 
            afterNoonCheckBox.AutoSize = true;
            afterNoonCheckBox.Location = new Point(125, 218);
            afterNoonCheckBox.MinimumSize = new Size(45, 22);
            afterNoonCheckBox.Name = "afterNoonCheckBox";
            afterNoonCheckBox.OffBackColor = Color.FromArgb(156, 84, 213);
            afterNoonCheckBox.OffToggleColor = Color.FromArgb(229, 229, 229);
            afterNoonCheckBox.OnBackColor = Color.FromArgb(156, 84, 213);
            afterNoonCheckBox.OnToggleColor = Color.FromArgb(229, 229, 229);
            afterNoonCheckBox.Size = new Size(45, 22);
            afterNoonCheckBox.TabIndex = 39;
            afterNoonCheckBox.UseVisualStyleBackColor = true;
            afterNoonCheckBox.CheckedChanged += afterNoonCheckBox_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(114, 118, 127);
            label6.Location = new Point(202, 180);
            label6.Name = "label6";
            label6.Size = new Size(73, 21);
            label6.TabIndex = 38;
            label6.Text = "L. Eve.";
            // 
            // cbxDepartment
            // 
            cbxDepartment.BackColor = Color.FromArgb(215, 215, 215);
            cbxDepartment.BorderColor = Color.FromArgb(229, 229, 229);
            cbxDepartment.BorderSize = 1;
            cbxDepartment.CornerRadius = 15;
            cbxDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxDepartment.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbxDepartment.ForeColor = Color.FromArgb(116, 120, 129);
            cbxDepartment.IconColor = Color.FromArgb(156, 84, 213);
            cbxDepartment.ListBackColor = Color.FromArgb(215, 215, 215);
            cbxDepartment.ListTextColor = Color.FromArgb(156, 84, 213);
            cbxDepartment.Location = new Point(21, 28);
            cbxDepartment.MinimumSize = new Size(200, 30);
            cbxDepartment.Name = "cbxDepartment";
            cbxDepartment.Padding = new Padding(1);
            cbxDepartment.Size = new Size(241, 33);
            cbxDepartment.TabIndex = 28;
            cbxDepartment.Texts = "";
            cbxDepartment.OnSelectedIndexChanged += cbxDepartment_OnSelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(229, 229, 229);
            label2.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(114, 118, 127);
            label2.Location = new Point(22, 0);
            label2.Name = "label2";
            label2.Size = new Size(109, 21);
            label2.TabIndex = 27;
            label2.Text = "Department:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(114, 118, 127);
            label5.Location = new Point(115, 180);
            label5.Name = "label5";
            label5.Size = new Size(73, 21);
            label5.TabIndex = 37;
            label5.Text = "L. Aft.";
            // 
            // eveningCheckBox
            // 
            eveningCheckBox.AutoSize = true;
            eveningCheckBox.Location = new Point(212, 218);
            eveningCheckBox.MinimumSize = new Size(45, 22);
            eveningCheckBox.Name = "eveningCheckBox";
            eveningCheckBox.OffBackColor = Color.FromArgb(156, 84, 213);
            eveningCheckBox.OffToggleColor = Color.FromArgb(229, 229, 229);
            eveningCheckBox.OnBackColor = Color.FromArgb(156, 84, 213);
            eveningCheckBox.OnToggleColor = Color.FromArgb(229, 229, 229);
            eveningCheckBox.Size = new Size(45, 22);
            eveningCheckBox.TabIndex = 36;
            eveningCheckBox.UseVisualStyleBackColor = true;
            eveningCheckBox.CheckedChanged += eveningCheckBox_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(114, 118, 127);
            label4.Location = new Point(24, 180);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 35;
            label4.Text = "L. Mor.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(114, 118, 127);
            label1.Location = new Point(21, 73);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
            label1.TabIndex = 29;
            label1.Text = "Date:";
            // 
            // Calendar
            // 
            Calendar.BorderColor = Color.FromArgb(229, 229, 229);
            Calendar.BorderSize = 2;
            Calendar.CalendarFont = new Font("Cascadia Code", 10F, FontStyle.Bold, GraphicsUnit.Point);
            Calendar.CalendarForeColor = Color.FromArgb(156, 84, 213);
            Calendar.CalendarMonthBackground = Color.FromArgb(229, 229, 229);
            Calendar.CalendarTitleBackColor = Color.FromArgb(156, 84, 213);
            Calendar.CalendarTitleForeColor = Color.FromArgb(156, 84, 213);
            Calendar.CustomFormat = "MMM dd, yyy";
            Calendar.Font = new Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Calendar.Location = new Point(66, 68);
            Calendar.MinimumSize = new Size(0, 35);
            Calendar.Name = "Calendar";
            Calendar.Size = new Size(201, 35);
            Calendar.SkinColor = Color.FromArgb(229, 229, 229);
            Calendar.TabIndex = 30;
            Calendar.TextColor = Color.FromArgb(114, 118, 127);
            Calendar.Value = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            Calendar.ValueChanged += Calendar_ValueChanged;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(229, 229, 229);
            btnSearch.BackgroundColor = Color.FromArgb(229, 229, 229);
            btnSearch.BorderColor = Color.FromArgb(156, 84, 213);
            btnSearch.BorderRadius = 15;
            btnSearch.BorderSize = 2;
            btnSearch.ClickedColor = Color.FromArgb(156, 84, 213);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Cascadia Code", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.FromArgb(156, 84, 213);
            btnSearch.Location = new Point(20, 298);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(240, 40);
            btnSearch.TabIndex = 16;
            btnSearch.Text = "Search by Date";
            btnSearch.TextColor = Color.FromArgb(156, 84, 213);
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(156, 84, 213);
            btnDelete.BackgroundColor = Color.FromArgb(156, 84, 213);
            btnDelete.BorderColor = Color.FromArgb(156, 84, 213);
            btnDelete.BorderRadius = 15;
            btnDelete.BorderSize = 0;
            btnDelete.ClickedColor = Color.FromArgb(156, 84, 213);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Cascadia Code", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.FromArgb(229, 229, 229);
            btnDelete.Location = new Point(143, 252);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(117, 40);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.TextColor = Color.FromArgb(229, 229, 229);
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(156, 84, 213);
            btnAdd.BackgroundColor = Color.FromArgb(156, 84, 213);
            btnAdd.BorderColor = Color.FromArgb(156, 84, 213);
            btnAdd.BorderRadius = 15;
            btnAdd.BorderSize = 0;
            btnAdd.ClickedColor = Color.FromArgb(156, 84, 213);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Cascadia Code", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.FromArgb(229, 229, 229);
            btnAdd.Location = new Point(20, 252);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(117, 40);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add";
            btnAdd.TextColor = Color.FromArgb(229, 229, 229);
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // roundPanelListBox1
            // 
            roundPanelListBox1.BackColor = Color.FromArgb(156, 84, 213);
            roundPanelListBox1.Controls.Add(dataGridViewShifts);
            roundPanelListBox1.Location = new Point(52, 50);
            roundPanelListBox1.Margin = new Padding(4, 3, 4, 3);
            roundPanelListBox1.Name = "roundPanelListBox1";
            roundPanelListBox1.Size = new Size(663, 337);
            roundPanelListBox1.TabIndex = 12;
            // 
            // dataGridViewShifts
            // 
            dataGridViewShifts.AllowUserToAddRows = false;
            dataGridViewShifts.AllowUserToDeleteRows = false;
            dataGridViewShifts.AllowUserToResizeColumns = false;
            dataGridViewShifts.AllowUserToResizeRows = false;
            dataGridViewShifts.BackgroundColor = Color.FromArgb(156, 84, 213);
            dataGridViewShifts.BorderStyle = BorderStyle.None;
            dataGridViewShifts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewShifts.GridColor = Color.FromArgb(11, 7, 17);
            dataGridViewShifts.Location = new Point(0, 0);
            dataGridViewShifts.Name = "dataGridViewShifts";
            dataGridViewShifts.ReadOnly = true;
            dataGridViewShifts.RowHeadersWidth = 62;
            dataGridViewShifts.RowTemplate.Height = 25;
            dataGridViewShifts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewShifts.Size = new Size(664, 337);
            dataGridViewShifts.TabIndex = 1;
            // 
            // Shifts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 542);
            Controls.Add(roundPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Shifts";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Shifts";
            roundPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            roundPanelListBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewShifts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CustomElements.RoundPanel roundPanel1;
        private CustomElements.RoundPanelListBox roundPanelListBox1;
        private CustomElements.RoundButton btnDelete;
        private CustomElements.RoundButton btnAdd;
        private CustomElements.RoundButton btnSearch;
        private Panel panel1;
        private CustomElements.CustomComboBox cbxDepartment;
        private Label label2;
        private CustomElements.CustomDatePicker Calendar;
        private Label label1;
        private CustomElements.CustomCheckBox morningCheckBox;
        private CustomElements.CustomCheckBox afterNoonCheckBox;
        private Label label6;
        private Label label5;
        private CustomElements.CustomCheckBox eveningCheckBox;
        private Label label4;
        private Panel panel2;
        private CustomElements.Controls.CustomLabelV2 customLabelV21;
        private housing.CustomElements.RoundTextBox tbxName;
        private Label label3;
        private Label label8;
        private Label label7;
        private CustomElements.RoundButton btnAutoShifts;
        private DataGridView dataGridViewShifts;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private CustomElements.CustomCheckBox earlyEveningCheckBox;
        private CustomElements.CustomCheckBox earlyAfternoonCheckBox;
        private CustomElements.CustomCheckBox earlyMorningCheckBox;
    }
}