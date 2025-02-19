﻿using housing.CustomElements;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace DesktopAppMediaBazaar.FormsUtility
{
    partial class EmployeeDetails
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
            label4 = new Label();
            panel1 = new Panel();
            tbxName = new RoundTextBox();
            tbxUsername = new RoundTextBox();
            tbxPhone = new RoundTextBox();
            label5 = new Label();
            label8 = new Label();
            label9 = new Label();
            tbxSalary = new RoundTextBox();
            cklEarlyMorning = new CustomElements.CustomCheckBox();
            rbtnAll = new CustomElements.CustomRadioButton();
            cklEarlyAfternoon = new CustomElements.CustomCheckBox();
            rbtnFuture = new CustomElements.CustomRadioButton();
            label10 = new Label();
            rbtnPast = new CustomElements.CustomRadioButton();
            label13 = new Label();
            cklEarlyEvening = new CustomElements.CustomCheckBox();
            customLabelV21 = new CustomElements.Controls.CustomLabelV2();
            label14 = new Label();
            roundPanelListBox1 = new CustomElements.RoundPanelListBox();
            lbxShifts = new ListBox();
            label6 = new Label();
            label7 = new Label();
            label12 = new Label();
            cklMorning = new CustomElements.CustomCheckBox();
            label11 = new Label();
            cklAfternoon = new CustomElements.CustomCheckBox();
            label15 = new Label();
            cklEvening = new CustomElements.CustomCheckBox();
            label16 = new Label();
            lbRegisterDate = new CustomElements.RoundLabel();
            label17 = new Label();
            cbxDepartment = new CustomElements.CustomComboBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            lbFormTitle = new Label();
            btnClose = new Button();
            btnSave = new CustomElements.RoundButton();
            lbEmail = new Label();
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
            panelButtons.Controls.Add(label4);
            panelButtons.Controls.Add(panel1);
            panelButtons.Controls.Add(label5);
            panelButtons.Controls.Add(label8);
            panelButtons.Controls.Add(label9);
            panelButtons.Controls.Add(tbxSalary);
            panelButtons.Controls.Add(cklEarlyMorning);
            panelButtons.Controls.Add(rbtnAll);
            panelButtons.Controls.Add(cklEarlyAfternoon);
            panelButtons.Controls.Add(rbtnFuture);
            panelButtons.Controls.Add(label10);
            panelButtons.Controls.Add(rbtnPast);
            panelButtons.Controls.Add(label13);
            panelButtons.Controls.Add(cklEarlyEvening);
            panelButtons.Controls.Add(customLabelV21);
            panelButtons.Controls.Add(label14);
            panelButtons.Controls.Add(roundPanelListBox1);
            panelButtons.Controls.Add(label6);
            panelButtons.Controls.Add(label7);
            panelButtons.Controls.Add(label12);
            panelButtons.Controls.Add(cklMorning);
            panelButtons.Controls.Add(label11);
            panelButtons.Controls.Add(cklAfternoon);
            panelButtons.Controls.Add(label15);
            panelButtons.Controls.Add(cklEvening);
            panelButtons.Controls.Add(label16);
            panelButtons.Controls.Add(lbRegisterDate);
            panelButtons.Controls.Add(label17);
            panelButtons.Controls.Add(cbxDepartment);
            panelButtons.Controls.Add(label2);
            panelButtons.Controls.Add(label1);
            panelButtons.Controls.Add(label3);
            panelButtons.Controls.Add(lbFormTitle);
            panelButtons.Controls.Add(btnClose);
            panelButtons.Controls.Add(btnSave);
            panelButtons.Controls.Add(lbEmail);
            panelButtons.Controls.Add(lbName);
            panelButtons.Location = new Point(3, 3);
            panelButtons.Margin = new Padding(4, 3, 4, 3);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(890, 464);
            panelButtons.TabIndex = 4;
            panelButtons.MouseDown += panelTitleBar_MouseDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(161, 305);
            label4.Name = "label4";
            label4.Size = new Size(63, 16);
            label4.TabIndex = 79;
            label4.Text = "8am-12am";
            // 
            // panel1
            // 
            panel1.Controls.Add(tbxName);
            panel1.Controls.Add(tbxUsername);
            panel1.Controls.Add(tbxPhone);
            panel1.Location = new Point(135, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(286, 133);
            panel1.TabIndex = 43;
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
            tbxName.TabIndex = 44;
            tbxName.Texts = "";
            tbxName.UnderlinedStyle = false;
            // 
            // tbxUsername
            // 
            tbxUsername.BackColor = Color.FromArgb(229, 229, 229);
            tbxUsername.BorderColor = Color.FromArgb(229, 229, 229);
            tbxUsername.BorderFocusColor = Color.FromArgb(229, 229, 229);
            tbxUsername.BorderRadius = 14;
            tbxUsername.BorderSize = 2;
            tbxUsername.Font = new Font("Cascadia Code", 10F, FontStyle.Bold, GraphicsUnit.Point);
            tbxUsername.ForeColor = Color.FromArgb(127, 131, 140);
            tbxUsername.Location = new Point(16, 54);
            tbxUsername.Margin = new Padding(4);
            tbxUsername.Multiline = false;
            tbxUsername.Name = "tbxUsername";
            tbxUsername.Padding = new Padding(10, 7, 10, 7);
            tbxUsername.PasswordChar = false;
            tbxUsername.PlaceholderColor = Color.FromArgb(127, 131, 140);
            tbxUsername.PlaceholderText = "";
            tbxUsername.Size = new Size(250, 33);
            tbxUsername.TabIndex = 43;
            tbxUsername.Texts = "";
            tbxUsername.UnderlinedStyle = false;
            // 
            // tbxPhone
            // 
            tbxPhone.BackColor = Color.FromArgb(229, 229, 229);
            tbxPhone.BorderColor = Color.FromArgb(229, 229, 229);
            tbxPhone.BorderFocusColor = Color.FromArgb(229, 229, 229);
            tbxPhone.BorderRadius = 14;
            tbxPhone.BorderSize = 2;
            tbxPhone.Font = new Font("Cascadia Code", 10F, FontStyle.Bold, GraphicsUnit.Point);
            tbxPhone.ForeColor = Color.FromArgb(127, 131, 140);
            tbxPhone.Location = new Point(16, 95);
            tbxPhone.Margin = new Padding(4);
            tbxPhone.Multiline = false;
            tbxPhone.Name = "tbxPhone";
            tbxPhone.Padding = new Padding(10, 7, 10, 7);
            tbxPhone.PasswordChar = false;
            tbxPhone.PlaceholderColor = Color.FromArgb(127, 131, 140);
            tbxPhone.PlaceholderText = "";
            tbxPhone.Size = new Size(250, 33);
            tbxPhone.TabIndex = 42;
            tbxPhone.Texts = "";
            tbxPhone.UnderlinedStyle = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(245, 305);
            label5.Name = "label5";
            label5.Size = new Size(70, 16);
            label5.TabIndex = 78;
            label5.Text = "16pm-20pm";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(229, 229, 229);
            label8.Location = new Point(38, 219);
            label8.Name = "label8";
            label8.Size = new Size(73, 21);
            label8.TabIndex = 42;
            label8.Text = "Salary:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(339, 305);
            label9.Name = "label9";
            label9.Size = new Size(56, 16);
            label9.TabIndex = 77;
            label9.Text = "0am-4am";
            // 
            // tbxSalary
            // 
            tbxSalary.BackColor = Color.FromArgb(229, 229, 229);
            tbxSalary.BorderColor = Color.FromArgb(229, 229, 229);
            tbxSalary.BorderFocusColor = Color.FromArgb(229, 229, 229);
            tbxSalary.BorderRadius = 14;
            tbxSalary.BorderSize = 2;
            tbxSalary.Font = new Font("Cascadia Code", 10F, FontStyle.Bold, GraphicsUnit.Point);
            tbxSalary.ForeColor = Color.FromArgb(127, 131, 140);
            tbxSalary.Location = new Point(154, 214);
            tbxSalary.Margin = new Padding(4);
            tbxSalary.Multiline = false;
            tbxSalary.Name = "tbxSalary";
            tbxSalary.Padding = new Padding(10, 7, 10, 7);
            tbxSalary.PasswordChar = false;
            tbxSalary.PlaceholderColor = Color.FromArgb(127, 131, 140);
            tbxSalary.PlaceholderText = "";
            tbxSalary.Size = new Size(250, 33);
            tbxSalary.TabIndex = 41;
            tbxSalary.Texts = "";
            tbxSalary.UnderlinedStyle = false;
            // 
            // cklEarlyMorning
            // 
            cklEarlyMorning.AutoSize = true;
            cklEarlyMorning.Location = new Point(167, 321);
            cklEarlyMorning.MinimumSize = new Size(45, 22);
            cklEarlyMorning.Name = "cklEarlyMorning";
            cklEarlyMorning.OffBackColor = Color.FromArgb(229, 229, 229);
            cklEarlyMorning.OffToggleColor = Color.FromArgb(156, 84, 213);
            cklEarlyMorning.OnBackColor = Color.FromArgb(229, 229, 229);
            cklEarlyMorning.OnToggleColor = Color.FromArgb(156, 84, 213);
            cklEarlyMorning.Size = new Size(45, 22);
            cklEarlyMorning.TabIndex = 76;
            cklEarlyMorning.UseVisualStyleBackColor = true;
            // 
            // rbtnAll
            // 
            rbtnAll.AutoSize = true;
            rbtnAll.BackColor = Color.FromArgb(156, 84, 213);
            rbtnAll.CheckedColor = Color.FromArgb(229, 229, 229);
            rbtnAll.Font = new Font("Cascadia Code", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rbtnAll.ForeColor = Color.FromArgb(229, 229, 229);
            rbtnAll.Location = new Point(606, 328);
            rbtnAll.Margin = new Padding(4, 3, 4, 3);
            rbtnAll.MinimumSize = new Size(0, 21);
            rbtnAll.Name = "rbtnAll";
            rbtnAll.Padding = new Padding(10, 0, 0, 0);
            rbtnAll.Size = new Size(60, 21);
            rbtnAll.TabIndex = 40;
            rbtnAll.TabStop = true;
            rbtnAll.Text = "All";
            rbtnAll.UnCheckedColor = Color.FromArgb(229, 229, 229);
            rbtnAll.UseVisualStyleBackColor = false;
            rbtnAll.CheckedChanged += rbtnAll_CheckedChanged;
            // 
            // cklEarlyAfternoon
            // 
            cklEarlyAfternoon.AutoSize = true;
            cklEarlyAfternoon.Location = new Point(257, 321);
            cklEarlyAfternoon.MinimumSize = new Size(45, 22);
            cklEarlyAfternoon.Name = "cklEarlyAfternoon";
            cklEarlyAfternoon.OffBackColor = Color.FromArgb(229, 229, 229);
            cklEarlyAfternoon.OffToggleColor = Color.FromArgb(156, 84, 213);
            cklEarlyAfternoon.OnBackColor = Color.FromArgb(229, 229, 229);
            cklEarlyAfternoon.OnToggleColor = Color.FromArgb(156, 84, 213);
            cklEarlyAfternoon.Size = new Size(45, 22);
            cklEarlyAfternoon.TabIndex = 75;
            cklEarlyAfternoon.UseVisualStyleBackColor = true;
            // 
            // rbtnFuture
            // 
            rbtnFuture.AutoSize = true;
            rbtnFuture.BackColor = Color.FromArgb(156, 84, 213);
            rbtnFuture.CheckedColor = Color.FromArgb(229, 229, 229);
            rbtnFuture.Font = new Font("Cascadia Code", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rbtnFuture.ForeColor = Color.FromArgb(229, 229, 229);
            rbtnFuture.Location = new Point(514, 328);
            rbtnFuture.Margin = new Padding(4, 3, 4, 3);
            rbtnFuture.MinimumSize = new Size(0, 21);
            rbtnFuture.Name = "rbtnFuture";
            rbtnFuture.Padding = new Padding(10, 0, 0, 0);
            rbtnFuture.Size = new Size(84, 21);
            rbtnFuture.TabIndex = 39;
            rbtnFuture.TabStop = true;
            rbtnFuture.Text = "Future";
            rbtnFuture.UnCheckedColor = Color.FromArgb(229, 229, 229);
            rbtnFuture.UseVisualStyleBackColor = false;
            rbtnFuture.CheckedChanged += rbtnFuture_CheckedChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(229, 229, 229);
            label10.Location = new Point(333, 288);
            label10.Name = "label10";
            label10.Size = new Size(73, 21);
            label10.TabIndex = 74;
            label10.Text = "E. Eve.";
            // 
            // rbtnPast
            // 
            rbtnPast.AutoSize = true;
            rbtnPast.BackColor = Color.FromArgb(156, 84, 213);
            rbtnPast.CheckedColor = Color.FromArgb(229, 229, 229);
            rbtnPast.Font = new Font("Cascadia Code", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rbtnPast.ForeColor = Color.FromArgb(229, 229, 229);
            rbtnPast.Location = new Point(440, 328);
            rbtnPast.Margin = new Padding(4, 3, 4, 3);
            rbtnPast.MinimumSize = new Size(0, 21);
            rbtnPast.Name = "rbtnPast";
            rbtnPast.Padding = new Padding(10, 0, 0, 0);
            rbtnPast.Size = new Size(68, 21);
            rbtnPast.TabIndex = 38;
            rbtnPast.TabStop = true;
            rbtnPast.Text = "Past";
            rbtnPast.UnCheckedColor = Color.FromArgb(229, 229, 229);
            rbtnPast.UseVisualStyleBackColor = false;
            rbtnPast.CheckedChanged += rbtnPast_CheckedChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(229, 229, 229);
            label13.Location = new Point(245, 288);
            label13.Name = "label13";
            label13.Size = new Size(73, 21);
            label13.TabIndex = 73;
            label13.Text = "E. Aft.";
            // 
            // cklEarlyEvening
            // 
            cklEarlyEvening.AutoSize = true;
            cklEarlyEvening.Location = new Point(344, 321);
            cklEarlyEvening.MinimumSize = new Size(45, 22);
            cklEarlyEvening.Name = "cklEarlyEvening";
            cklEarlyEvening.OffBackColor = Color.FromArgb(229, 229, 229);
            cklEarlyEvening.OffToggleColor = Color.FromArgb(156, 84, 213);
            cklEarlyEvening.OnBackColor = Color.FromArgb(229, 229, 229);
            cklEarlyEvening.OnToggleColor = Color.FromArgb(156, 84, 213);
            cklEarlyEvening.Size = new Size(45, 22);
            cklEarlyEvening.TabIndex = 72;
            cklEarlyEvening.UseVisualStyleBackColor = true;
            // 
            // customLabelV21
            // 
            customLabelV21.AutoSize = true;
            customLabelV21.BackColor = Color.Transparent;
            customLabelV21.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            customLabelV21.ForeColor = Color.FromArgb(229, 229, 229);
            customLabelV21.Location = new Point(437, 298);
            customLabelV21.Margin = new Padding(4, 0, 4, 0);
            customLabelV21.Name = "customLabelV21";
            customLabelV21.Size = new Size(145, 21);
            customLabelV21.TabIndex = 37;
            customLabelV21.Text = "Filter by date:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(229, 229, 229);
            label14.Location = new Point(158, 288);
            label14.Name = "label14";
            label14.Size = new Size(73, 21);
            label14.TabIndex = 71;
            label14.Text = "E. Mor.";
            // 
            // roundPanelListBox1
            // 
            roundPanelListBox1.BackColor = Color.FromArgb(229, 229, 229);
            roundPanelListBox1.Controls.Add(lbxShifts);
            roundPanelListBox1.Location = new Point(428, 51);
            roundPanelListBox1.Margin = new Padding(4, 3, 4, 3);
            roundPanelListBox1.Name = "roundPanelListBox1";
            roundPanelListBox1.Size = new Size(415, 237);
            roundPanelListBox1.TabIndex = 36;
            // 
            // lbxShifts
            // 
            lbxShifts.BackColor = Color.FromArgb(229, 229, 229);
            lbxShifts.BorderStyle = BorderStyle.None;
            lbxShifts.Font = new Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbxShifts.ForeColor = Color.FromArgb(127, 131, 140);
            lbxShifts.FormattingEnabled = true;
            lbxShifts.ItemHeight = 17;
            lbxShifts.Location = new Point(0, 7);
            lbxShifts.Margin = new Padding(4, 3, 4, 3);
            lbxShifts.Name = "lbxShifts";
            lbxShifts.Size = new Size(424, 221);
            lbxShifts.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(157, 364);
            label6.Name = "label6";
            label6.Size = new Size(70, 16);
            label6.TabIndex = 70;
            label6.Text = "12am-16pm";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(229, 229, 229);
            label7.Location = new Point(38, 298);
            label7.Name = "label7";
            label7.Size = new Size(73, 21);
            label7.TabIndex = 35;
            label7.Text = "Shifts:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(247, 364);
            label12.Name = "label12";
            label12.Size = new Size(63, 16);
            label12.TabIndex = 69;
            label12.Text = "20pm-0am";
            // 
            // cklMorning
            // 
            cklMorning.AutoSize = true;
            cklMorning.Location = new Point(168, 380);
            cklMorning.MinimumSize = new Size(45, 22);
            cklMorning.Name = "cklMorning";
            cklMorning.OffBackColor = Color.FromArgb(229, 229, 229);
            cklMorning.OffToggleColor = Color.FromArgb(156, 84, 213);
            cklMorning.OnBackColor = Color.FromArgb(229, 229, 229);
            cklMorning.OnToggleColor = Color.FromArgb(156, 84, 213);
            cklMorning.Size = new Size(45, 22);
            cklMorning.TabIndex = 34;
            cklMorning.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(340, 364);
            label11.Name = "label11";
            label11.Size = new Size(56, 16);
            label11.TabIndex = 68;
            label11.Text = "4am-8am";
            // 
            // cklAfternoon
            // 
            cklAfternoon.AutoSize = true;
            cklAfternoon.Location = new Point(258, 380);
            cklAfternoon.MinimumSize = new Size(45, 22);
            cklAfternoon.Name = "cklAfternoon";
            cklAfternoon.OffBackColor = Color.FromArgb(229, 229, 229);
            cklAfternoon.OffToggleColor = Color.FromArgb(156, 84, 213);
            cklAfternoon.OnBackColor = Color.FromArgb(229, 229, 229);
            cklAfternoon.OnToggleColor = Color.FromArgb(156, 84, 213);
            cklAfternoon.Size = new Size(45, 22);
            cklAfternoon.TabIndex = 33;
            cklAfternoon.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.FromArgb(229, 229, 229);
            label15.Location = new Point(334, 347);
            label15.Name = "label15";
            label15.Size = new Size(73, 21);
            label15.TabIndex = 67;
            label15.Text = "L. Eve.";
            // 
            // cklEvening
            // 
            cklEvening.AutoSize = true;
            cklEvening.Location = new Point(345, 380);
            cklEvening.MinimumSize = new Size(45, 22);
            cklEvening.Name = "cklEvening";
            cklEvening.OffBackColor = Color.FromArgb(229, 229, 229);
            cklEvening.OffToggleColor = Color.FromArgb(156, 84, 213);
            cklEvening.OnBackColor = Color.FromArgb(229, 229, 229);
            cklEvening.OnToggleColor = Color.FromArgb(156, 84, 213);
            cklEvening.Size = new Size(45, 22);
            cklEvening.TabIndex = 30;
            cklEvening.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.FromArgb(229, 229, 229);
            label16.Location = new Point(244, 347);
            label16.Name = "label16";
            label16.Size = new Size(73, 21);
            label16.TabIndex = 66;
            label16.Text = "L. Aft.";
            // 
            // lbRegisterDate
            // 
            lbRegisterDate.Font = new Font("Cascadia Code", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbRegisterDate.ForeColor = Color.FromArgb(127, 131, 140);
            lbRegisterDate.Location = new Point(154, 174);
            lbRegisterDate.Name = "lbRegisterDate";
            lbRegisterDate.Size = new Size(250, 33);
            lbRegisterDate.TabIndex = 29;
            lbRegisterDate.Text = "RegisterDate";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.FromArgb(229, 229, 229);
            label17.Location = new Point(157, 347);
            label17.Name = "label17";
            label17.Size = new Size(73, 21);
            label17.TabIndex = 65;
            label17.Text = "L. Mor.";
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
            cbxDepartment.Location = new Point(154, 255);
            cbxDepartment.MinimumSize = new Size(200, 30);
            cbxDepartment.Name = "cbxDepartment";
            cbxDepartment.Padding = new Padding(1);
            cbxDepartment.Size = new Size(250, 33);
            cbxDepartment.TabIndex = 26;
            cbxDepartment.Texts = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(229, 229, 229);
            label2.Location = new Point(38, 259);
            label2.Name = "label2";
            label2.Size = new Size(109, 21);
            label2.TabIndex = 25;
            label2.Text = "Department:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(229, 229, 229);
            label1.Location = new Point(38, 179);
            label1.Name = "label1";
            label1.Size = new Size(64, 21);
            label1.TabIndex = 23;
            label1.Text = "Since:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(229, 229, 229);
            label3.Location = new Point(38, 138);
            label3.Name = "label3";
            label3.Size = new Size(64, 21);
            label3.TabIndex = 21;
            label3.Text = "Phone:";
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
            btnSave.Location = new Point(38, 411);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(810, 43);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.TextColor = Color.FromArgb(127, 131, 140);
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbEmail.ForeColor = Color.FromArgb(229, 229, 229);
            lbEmail.Location = new Point(38, 97);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(91, 21);
            lbEmail.TabIndex = 7;
            lbEmail.Text = "Username:";
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
            panelBody.Size = new Size(897, 470);
            panelBody.TabIndex = 6;
            // 
            // EmployeeDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 229, 229);
            ClientSize = new Size(897, 470);
            Controls.Add(panelBody);
            Font = new Font("Cascadia Code", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            Margin = new Padding(3, 4, 3, 4);
            Name = "EmployeeDetails";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeDetails";
            panelButtons.ResumeLayout(false);
            panelButtons.PerformLayout();
            panel1.ResumeLayout(false);
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
        private CustomElements.CustomComboBox cbxDepartment;
        private Label label2;
        private CustomElements.RoundLabel lbRegisterDate;
        private CustomElements.CustomCheckBox cklEvening;
        private Label label7;
        private CustomElements.CustomCheckBox cklMorning;
        private CustomElements.CustomCheckBox cklAfternoon;
        private CustomElements.RoundPanelListBox roundPanelListBox1;
        private ListBox lbxShifts;
        private CustomElements.CustomRadioButton rbtnAll;
        private CustomElements.CustomRadioButton rbtnFuture;
        private CustomElements.CustomRadioButton rbtnPast;
        private CustomElements.Controls.CustomLabelV2 customLabelV21;
        private Label label8;
        private RoundTextBox tbxSalary;
        private Panel panel1;
        private RoundTextBox tbxName;
        private RoundTextBox tbxUsername;
        private RoundTextBox tbxPhone;
        private Label label4;
        private Label label5;
        private Label label9;
        private CustomElements.CustomCheckBox cklEarlyMorning;
        private CustomElements.CustomCheckBox cklEarlyAfternoon;
        private Label label10;
        private Label label13;
        private CustomElements.CustomCheckBox cklEarlyEvening;
        private Label label14;
        private Label label6;
        private Label label12;
        private Label label11;
        private Label label15;
        private Label label16;
        private Label label17;
    }
}