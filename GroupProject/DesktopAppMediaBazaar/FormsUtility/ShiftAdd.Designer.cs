using housing.CustomElements;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace DesktopAppMediaBazaar.FormsUtility
{
    partial class ShiftAdd
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
            panelButtons = new Panel();
            label1 = new Label();
            Calendar = new CustomElements.CustomDatePicker();
            panel1 = new Panel();
            label3 = new Label();
            label12 = new Label();
            label11 = new Label();
            tbxName = new RoundTextBox();
            cklMorning = new CustomElements.CustomCheckBox();
            cklAfternoon = new CustomElements.CustomCheckBox();
            label6 = new Label();
            label5 = new Label();
            cklEvening = new CustomElements.CustomCheckBox();
            label4 = new Label();
            cbxDepartment = new CustomElements.CustomComboBox();
            roundPanelListBox1 = new CustomElements.RoundPanelListBox();
            lbxEmployees = new ListBox();
            label7 = new Label();
            label2 = new Label();
            lbFormTitle = new Label();
            btnClose = new Button();
            btnSave = new CustomElements.RoundButton();
            lbName = new Label();
            panelBody = new Panel();
            panelButtons.SuspendLayout();
            panel1.SuspendLayout();
            roundPanelListBox1.SuspendLayout();
            panelBody.SuspendLayout();
            SuspendLayout();
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.FromArgb(156, 84, 213);
            panelButtons.Controls.Add(label1);
            panelButtons.Controls.Add(Calendar);
            panelButtons.Controls.Add(panel1);
            panelButtons.Controls.Add(roundPanelListBox1);
            panelButtons.Controls.Add(label7);
            panelButtons.Controls.Add(label2);
            panelButtons.Controls.Add(lbFormTitle);
            panelButtons.Controls.Add(btnClose);
            panelButtons.Controls.Add(btnSave);
            panelButtons.Controls.Add(lbName);
            panelButtons.Location = new Point(3, 3);
            panelButtons.Margin = new Padding(4, 3, 4, 3);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(890, 310);
            panelButtons.TabIndex = 4;
            panelButtons.MouseDown += panelTitleBar_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(156, 84, 213);
            label1.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(229, 229, 229);
            label1.Location = new Point(38, 206);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
            label1.TabIndex = 44;
            label1.Text = "Date:";
            // 
            // Calendar
            // 
            Calendar.BorderColor = Color.FromArgb(156, 84, 213);
            Calendar.BorderSize = 2;
            Calendar.CalendarFont = new Font("Cascadia Code", 10F, FontStyle.Bold, GraphicsUnit.Point);
            Calendar.CalendarForeColor = Color.FromArgb(156, 84, 213);
            Calendar.CalendarMonthBackground = Color.FromArgb(156, 84, 213);
            Calendar.CalendarTitleBackColor = Color.FromArgb(229, 229, 229);
            Calendar.CalendarTitleForeColor = Color.FromArgb(156, 84, 213);
            Calendar.CustomFormat = "MMM dd, yyy";
            Calendar.Font = new Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Calendar.Location = new Point(125, 202);
            Calendar.MinimumSize = new Size(0, 35);
            Calendar.Name = "Calendar";
            Calendar.Size = new Size(201, 35);
            Calendar.SkinColor = Color.FromArgb(156, 84, 213);
            Calendar.TabIndex = 45;
            Calendar.TextColor = Color.FromArgb(229, 229, 229);
            Calendar.Value = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(tbxName);
            panel1.Controls.Add(cklMorning);
            panel1.Controls.Add(cklAfternoon);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cklEvening);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cbxDepartment);
            panel1.Location = new Point(135, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(286, 176);
            panel1.TabIndex = 43;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(20, 115);
            label3.Name = "label3";
            label3.Size = new Size(63, 16);
            label3.TabIndex = 55;
            label3.Text = "8am-16pm";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(109, 115);
            label12.Name = "label12";
            label12.Size = new Size(63, 16);
            label12.TabIndex = 54;
            label12.Text = "16pm-2am";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(198, 115);
            label11.Name = "label11";
            label11.Size = new Size(56, 16);
            label11.TabIndex = 53;
            label11.Text = "2am-8am";
            // 
            // tbxName
            // 
            tbxName.BackColor = Color.FromArgb(229, 229, 229);
            tbxName.BorderColor = Color.FromArgb(229, 229, 229);
            tbxName.BorderFocusColor = Color.FromArgb(229, 229, 229);
            tbxName.BorderRadius = 14;
            tbxName.BorderSize = 2;
            tbxName.Font = new Font("Cascadia Code", 10F, FontStyle.Bold, GraphicsUnit.Point);
            tbxName.ForeColor = Color.FromArgb(127, 131, 140);
            tbxName.Location = new Point(16, 13);
            tbxName.Margin = new Padding(4);
            tbxName.Multiline = false;
            tbxName.Name = "tbxName";
            tbxName.Padding = new Padding(10, 7, 10, 7);
            tbxName.PasswordChar = false;
            tbxName.PlaceholderColor = Color.FromArgb(127, 131, 140);
            tbxName.PlaceholderText = "";
            tbxName.Size = new Size(250, 33);
            tbxName.TabIndex = 52;
            tbxName.Texts = "";
            tbxName.UnderlinedStyle = false;
            tbxName._TextChanged += tbxName__TextChanged_1;
            // 
            // cklMorning
            // 
            cklMorning.AutoSize = true;
            cklMorning.Location = new Point(28, 138);
            cklMorning.MinimumSize = new Size(45, 22);
            cklMorning.Name = "cklMorning";
            cklMorning.OffBackColor = Color.FromArgb(229, 229, 229);
            cklMorning.OffToggleColor = Color.FromArgb(156, 84, 213);
            cklMorning.OnBackColor = Color.FromArgb(229, 229, 229);
            cklMorning.OnToggleColor = Color.FromArgb(156, 84, 213);
            cklMorning.Size = new Size(45, 22);
            cklMorning.TabIndex = 51;
            cklMorning.UseVisualStyleBackColor = true;
            // 
            // cklAfternoon
            // 
            cklAfternoon.AutoSize = true;
            cklAfternoon.Location = new Point(118, 138);
            cklAfternoon.MinimumSize = new Size(45, 22);
            cklAfternoon.Name = "cklAfternoon";
            cklAfternoon.OffBackColor = Color.FromArgb(229, 229, 229);
            cklAfternoon.OffToggleColor = Color.FromArgb(156, 84, 213);
            cklAfternoon.OnBackColor = Color.FromArgb(229, 229, 229);
            cklAfternoon.OnToggleColor = Color.FromArgb(156, 84, 213);
            cklAfternoon.Size = new Size(45, 22);
            cklAfternoon.TabIndex = 50;
            cklAfternoon.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(229, 229, 229);
            label6.Location = new Point(191, 94);
            label6.Name = "label6";
            label6.Size = new Size(73, 21);
            label6.TabIndex = 49;
            label6.Text = "Evening";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(229, 229, 229);
            label5.Location = new Point(94, 94);
            label5.Name = "label5";
            label5.Size = new Size(91, 21);
            label5.TabIndex = 48;
            label5.Text = "Afternoon";
            // 
            // cklEvening
            // 
            cklEvening.AutoSize = true;
            cklEvening.Location = new Point(205, 138);
            cklEvening.MinimumSize = new Size(45, 22);
            cklEvening.Name = "cklEvening";
            cklEvening.OffBackColor = Color.FromArgb(229, 229, 229);
            cklEvening.OffToggleColor = Color.FromArgb(156, 84, 213);
            cklEvening.OnBackColor = Color.FromArgb(229, 229, 229);
            cklEvening.OnToggleColor = Color.FromArgb(156, 84, 213);
            cklEvening.Size = new Size(45, 22);
            cklEvening.TabIndex = 47;
            cklEvening.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(229, 229, 229);
            label4.Location = new Point(15, 94);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 46;
            label4.Text = "Morning";
            // 
            // cbxDepartment
            // 
            cbxDepartment.BackColor = Color.FromArgb(229, 229, 229);
            cbxDepartment.BorderColor = Color.FromArgb(229, 229, 229);
            cbxDepartment.BorderSize = 1;
            cbxDepartment.CornerRadius = 15;
            cbxDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxDepartment.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbxDepartment.ForeColor = Color.FromArgb(116, 120, 129);
            cbxDepartment.IconColor = Color.FromArgb(156, 84, 213);
            cbxDepartment.ListBackColor = Color.FromArgb(229, 229, 229);
            cbxDepartment.ListTextColor = Color.FromArgb(156, 84, 213);
            cbxDepartment.Location = new Point(16, 58);
            cbxDepartment.MinimumSize = new Size(200, 30);
            cbxDepartment.Name = "cbxDepartment";
            cbxDepartment.Padding = new Padding(1);
            cbxDepartment.Size = new Size(250, 33);
            cbxDepartment.TabIndex = 45;
            cbxDepartment.Texts = "";
            // 
            // roundPanelListBox1
            // 
            roundPanelListBox1.BackColor = Color.FromArgb(229, 229, 229);
            roundPanelListBox1.Controls.Add(lbxEmployees);
            roundPanelListBox1.Location = new Point(428, 51);
            roundPanelListBox1.Margin = new Padding(4, 3, 4, 3);
            roundPanelListBox1.Name = "roundPanelListBox1";
            roundPanelListBox1.Size = new Size(415, 176);
            roundPanelListBox1.TabIndex = 36;
            // 
            // lbxEmployees
            // 
            lbxEmployees.BackColor = Color.FromArgb(229, 229, 229);
            lbxEmployees.BorderStyle = BorderStyle.None;
            lbxEmployees.Font = new Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbxEmployees.ForeColor = Color.FromArgb(127, 131, 140);
            lbxEmployees.FormattingEnabled = true;
            lbxEmployees.ItemHeight = 17;
            lbxEmployees.Location = new Point(0, 7);
            lbxEmployees.Margin = new Padding(4, 3, 4, 3);
            lbxEmployees.Name = "lbxEmployees";
            lbxEmployees.Size = new Size(424, 170);
            lbxEmployees.TabIndex = 0;
            lbxEmployees.SelectedIndexChanged += lbxEmployees_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(229, 229, 229);
            label7.Location = new Point(38, 139);
            label7.Name = "label7";
            label7.Size = new Size(73, 21);
            label7.TabIndex = 35;
            label7.Text = "Shifts:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(229, 229, 229);
            label2.Location = new Point(38, 100);
            label2.Name = "label2";
            label2.Size = new Size(109, 21);
            label2.TabIndex = 25;
            label2.Text = "Department:";
            // 
            // lbFormTitle
            // 
            lbFormTitle.AutoSize = true;
            lbFormTitle.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbFormTitle.ForeColor = Color.FromArgb(229, 229, 229);
            lbFormTitle.Location = new Point(8, 12);
            lbFormTitle.Margin = new Padding(4, 0, 4, 0);
            lbFormTitle.Name = "lbFormTitle";
            lbFormTitle.Size = new Size(42, 16);
            lbFormTitle.TabIndex = 14;
            lbFormTitle.Text = "Title";
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(229, 229, 229);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.ForeColor = Color.FromArgb(229, 229, 229);
            btnClose.Location = new Point(843, 0);
            btnClose.Margin = new Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(47, 38);
            btnClose.TabIndex = 13;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(229, 229, 229);
            btnSave.BackgroundColor = Color.FromArgb(229, 229, 229);
            btnSave.BorderColor = Color.White;
            btnSave.BorderRadius = 14;
            btnSave.BorderSize = 0;
            btnSave.ClickedColor = Color.White;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Cascadia Code", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.FromArgb(127, 131, 140);
            btnSave.Location = new Point(38, 246);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(810, 43);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.TextColor = Color.FromArgb(127, 131, 140);
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbName.ForeColor = Color.FromArgb(229, 229, 229);
            lbName.Location = new Point(38, 56);
            lbName.Name = "lbName";
            lbName.Size = new Size(55, 21);
            lbName.TabIndex = 5;
            lbName.Text = "Name:";
            // 
            // panelBody
            // 
            panelBody.BackColor = Color.FromArgb(229, 229, 229);
            panelBody.Controls.Add(panelButtons);
            panelBody.Dock = DockStyle.Fill;
            panelBody.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            panelBody.Location = new Point(0, 0);
            panelBody.Margin = new Padding(4, 3, 4, 3);
            panelBody.Name = "panelBody";
            panelBody.Padding = new Padding(13, 14, 0, 0);
            panelBody.Size = new Size(897, 317);
            panelBody.TabIndex = 6;
            // 
            // ShiftAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 229, 229);
            ClientSize = new Size(897, 317);
            Controls.Add(panelBody);
            Font = new Font("Cascadia Code", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ShiftAdd";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ShiftAdd";
            panelButtons.ResumeLayout(false);
            panelButtons.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            roundPanelListBox1.ResumeLayout(false);
            panelBody.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelButtons;
        private Label lbFormTitle;
        private Button btnClose;
        private CustomElements.RoundButton btnSave;
        private Label lbEmail;
        private Label lbName;
        private Panel panelBody;
        private Label label1;
        private Label label3;
        private Label label2;
        private CustomElements.RoundLabel lbRegisterDate;
        private Label label7;
        private CustomElements.RoundPanelListBox roundPanelListBox1;
        private ListBox lbxEmployees;
        private CustomElements.CustomRadioButton rbtnAll;
        private CustomElements.CustomRadioButton rbtnFuture;
        private CustomElements.CustomRadioButton rbtnPast;
        private CustomElements.Controls.CustomLabelV2 customLabelV21;
        private Label label8;
        private RoundTextBox tbxSalary;
        private Panel panel1;
        private CustomElements.CustomCheckBox cklMorning;
        private CustomElements.CustomCheckBox cklAfternoon;
        private Label label6;
        private Label label5;
        private CustomElements.CustomCheckBox cklEvening;
        private Label label4;
        private CustomElements.CustomComboBox cbxDepartment;
        private CustomElements.CustomDatePicker Calendar;
        private RoundTextBox tbxUsername;
        private RoundTextBox tbxPhone;
        private RoundTextBox tbxName;
        private Label label11;
        private Label label12;
    }
}