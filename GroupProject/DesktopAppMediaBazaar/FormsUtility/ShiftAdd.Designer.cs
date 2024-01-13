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
            roundPanelListBox1 = new CustomElements.RoundPanelListBox();
            lbxEmployees = new ListBox();
            label7 = new Label();
            lbFormTitle = new Label();
            btnClose = new Button();
            btnSave = new CustomElements.RoundButton();
            lbName = new Label();
            panelBody = new Panel();
            label2 = new Label();
            label8 = new Label();
            label9 = new Label();
            cklEarlyMorning = new CustomElements.CustomCheckBox();
            cklEarlyAfternoon = new CustomElements.CustomCheckBox();
            label10 = new Label();
            label13 = new Label();
            cklEarlyEvening = new CustomElements.CustomCheckBox();
            label14 = new Label();
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
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(cklEarlyMorning);
            panel1.Controls.Add(cklEarlyAfternoon);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(cklEarlyEvening);
            panel1.Controls.Add(label14);
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
            label3.Location = new Point(12, 126);
            label3.Name = "label3";
            label3.Size = new Size(70, 16);
            label3.TabIndex = 55;
            label3.Text = "12am-16pm";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(102, 126);
            label12.Name = "label12";
            label12.Size = new Size(63, 16);
            label12.TabIndex = 54;
            label12.Text = "20pm-0am";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(195, 126);
            label11.Name = "label11";
            label11.Size = new Size(56, 16);
            label11.TabIndex = 53;
            label11.Text = "4am-8am";
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
            cklMorning.Location = new Point(24, 142);
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
            cklAfternoon.Location = new Point(114, 142);
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
            label6.Location = new Point(189, 105);
            label6.Name = "label6";
            label6.Size = new Size(73, 21);
            label6.TabIndex = 49;
            label6.Text = "L. Eve.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(229, 229, 229);
            label5.Location = new Point(99, 105);
            label5.Name = "label5";
            label5.Size = new Size(73, 21);
            label5.TabIndex = 48;
            label5.Text = "L. Aft.";
            // 
            // cklEvening
            // 
            cklEvening.AutoSize = true;
            cklEvening.Location = new Point(201, 142);
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
            label4.Location = new Point(12, 105);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 46;
            label4.Text = "L. Mor.";
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
            label7.Location = new Point(38, 111);
            label7.Name = "label7";
            label7.Size = new Size(73, 21);
            label7.TabIndex = 35;
            label7.Text = "Shifts:";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(18, 67);
            label2.Name = "label2";
            label2.Size = new Size(63, 16);
            label2.TabIndex = 64;
            label2.Text = "8am-12am";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(102, 67);
            label8.Name = "label8";
            label8.Size = new Size(70, 16);
            label8.TabIndex = 63;
            label8.Text = "16pm-20pm";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(196, 67);
            label9.Name = "label9";
            label9.Size = new Size(56, 16);
            label9.TabIndex = 62;
            label9.Text = "0am-4am";
            // 
            // cklEarlyMorning
            // 
            cklEarlyMorning.AutoSize = true;
            cklEarlyMorning.Location = new Point(24, 83);
            cklEarlyMorning.MinimumSize = new Size(45, 22);
            cklEarlyMorning.Name = "cklEarlyMorning";
            cklEarlyMorning.OffBackColor = Color.FromArgb(229, 229, 229);
            cklEarlyMorning.OffToggleColor = Color.FromArgb(156, 84, 213);
            cklEarlyMorning.OnBackColor = Color.FromArgb(229, 229, 229);
            cklEarlyMorning.OnToggleColor = Color.FromArgb(156, 84, 213);
            cklEarlyMorning.Size = new Size(45, 22);
            cklEarlyMorning.TabIndex = 61;
            cklEarlyMorning.UseVisualStyleBackColor = true;
            // 
            // cklEarlyAfternoon
            // 
            cklEarlyAfternoon.AutoSize = true;
            cklEarlyAfternoon.Location = new Point(114, 83);
            cklEarlyAfternoon.MinimumSize = new Size(45, 22);
            cklEarlyAfternoon.Name = "cklEarlyAfternoon";
            cklEarlyAfternoon.OffBackColor = Color.FromArgb(229, 229, 229);
            cklEarlyAfternoon.OffToggleColor = Color.FromArgb(156, 84, 213);
            cklEarlyAfternoon.OnBackColor = Color.FromArgb(229, 229, 229);
            cklEarlyAfternoon.OnToggleColor = Color.FromArgb(156, 84, 213);
            cklEarlyAfternoon.Size = new Size(45, 22);
            cklEarlyAfternoon.TabIndex = 60;
            cklEarlyAfternoon.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(229, 229, 229);
            label10.Location = new Point(190, 46);
            label10.Name = "label10";
            label10.Size = new Size(73, 21);
            label10.TabIndex = 59;
            label10.Text = "E. Eve.";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(229, 229, 229);
            label13.Location = new Point(102, 46);
            label13.Name = "label13";
            label13.Size = new Size(73, 21);
            label13.TabIndex = 58;
            label13.Text = "E. Aft.";
            // 
            // cklEarlyEvening
            // 
            cklEarlyEvening.AutoSize = true;
            cklEarlyEvening.Location = new Point(201, 83);
            cklEarlyEvening.MinimumSize = new Size(45, 22);
            cklEarlyEvening.Name = "cklEarlyEvening";
            cklEarlyEvening.OffBackColor = Color.FromArgb(229, 229, 229);
            cklEarlyEvening.OffToggleColor = Color.FromArgb(156, 84, 213);
            cklEarlyEvening.OnBackColor = Color.FromArgb(229, 229, 229);
            cklEarlyEvening.OnToggleColor = Color.FromArgb(156, 84, 213);
            cklEarlyEvening.Size = new Size(45, 22);
            cklEarlyEvening.TabIndex = 57;
            cklEarlyEvening.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(229, 229, 229);
            label14.Location = new Point(15, 46);
            label14.Name = "label14";
            label14.Size = new Size(73, 21);
            label14.TabIndex = 56;
            label14.Text = "E. Mor.";
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
        private CustomElements.CustomDatePicker Calendar;
        private RoundTextBox tbxUsername;
        private RoundTextBox tbxPhone;
        private RoundTextBox tbxName;
        private Label label11;
        private Label label12;
        private Label label2;
        private Label label9;
        private CustomElements.CustomCheckBox cklEarlyMorning;
        private CustomElements.CustomCheckBox cklEarlyAfternoon;
        private Label label10;
        private Label label13;
        private CustomElements.CustomCheckBox cklEarlyEvening;
        private Label label14;
    }
}