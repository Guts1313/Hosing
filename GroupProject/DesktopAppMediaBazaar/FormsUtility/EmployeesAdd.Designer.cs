using housing.CustomElements;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace DesktopAppMediaBazaar.FormsUtility
{
    partial class EmployeesAdd
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
            tbxPassword = new RoundTextBox();
            label10 = new Label();
            panel1 = new Panel();
            tbxName = new RoundTextBox();
            tbxUsername = new RoundTextBox();
            tbxPhone = new RoundTextBox();
            label9 = new Label();
            tbxEmail = new RoundTextBox();
            label8 = new Label();
            tbxSalary = new RoundTextBox();
            label7 = new Label();
            cklMorning = new CustomElements.CustomCheckBox();
            cklAfternoon = new CustomElements.CustomCheckBox();
            label6 = new Label();
            label5 = new Label();
            cklEvening = new CustomElements.CustomCheckBox();
            lbRegisterDate = new CustomElements.RoundLabel();
            label4 = new Label();
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
            panelBody.SuspendLayout();
            SuspendLayout();
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.FromArgb(156, 84, 213);
            panelButtons.Controls.Add(tbxPassword);
            panelButtons.Controls.Add(label10);
            panelButtons.Controls.Add(panel1);
            panelButtons.Controls.Add(label9);
            panelButtons.Controls.Add(tbxEmail);
            panelButtons.Controls.Add(label8);
            panelButtons.Controls.Add(tbxSalary);
            panelButtons.Controls.Add(label7);
            panelButtons.Controls.Add(cklMorning);
            panelButtons.Controls.Add(cklAfternoon);
            panelButtons.Controls.Add(label6);
            panelButtons.Controls.Add(label5);
            panelButtons.Controls.Add(cklEvening);
            panelButtons.Controls.Add(lbRegisterDate);
            panelButtons.Controls.Add(label4);
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
            panelButtons.Size = new Size(832, 320);
            panelButtons.TabIndex = 4;
            panelButtons.MouseDown += panelTitleBar_MouseDown;
            // 
            // tbxPassword
            // 
            tbxPassword.BackColor = Color.FromArgb(229, 229, 229);
            tbxPassword.BorderColor = Color.FromArgb(229, 229, 229);
            tbxPassword.BorderFocusColor = Color.FromArgb(229, 229, 229);
            tbxPassword.BorderRadius = 14;
            tbxPassword.BorderSize = 2;
            tbxPassword.Font = new Font("Cascadia Code", 10F, FontStyle.Bold, GraphicsUnit.Point);
            tbxPassword.ForeColor = Color.FromArgb(127, 131, 140);
            tbxPassword.Location = new Point(538, 212);
            tbxPassword.Margin = new Padding(4);
            tbxPassword.Multiline = false;
            tbxPassword.Name = "tbxPassword";
            tbxPassword.Padding = new Padding(10, 7, 10, 7);
            tbxPassword.PasswordChar = false;
            tbxPassword.PlaceholderColor = Color.FromArgb(127, 131, 140);
            tbxPassword.PlaceholderText = "";
            tbxPassword.Size = new Size(250, 33);
            tbxPassword.TabIndex = 47;
            tbxPassword.Texts = "";
            tbxPassword.UnderlinedStyle = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(229, 229, 229);
            label10.Location = new Point(422, 217);
            label10.Name = "label10";
            label10.Size = new Size(91, 21);
            label10.TabIndex = 46;
            label10.Text = "Password:";
            // 
            // panel1
            // 
            panel1.Controls.Add(tbxName);
            panel1.Controls.Add(tbxUsername);
            panel1.Controls.Add(tbxPhone);
            panel1.Location = new Point(135, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(286, 133);
            panel1.TabIndex = 45;
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
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(229, 229, 229);
            label9.Location = new Point(422, 177);
            label9.Name = "label9";
            label9.Size = new Size(64, 21);
            label9.TabIndex = 44;
            label9.Text = "Email:";
            // 
            // tbxEmail
            // 
            tbxEmail.BackColor = Color.FromArgb(229, 229, 229);
            tbxEmail.BorderColor = Color.FromArgb(229, 229, 229);
            tbxEmail.BorderFocusColor = Color.FromArgb(229, 229, 229);
            tbxEmail.BorderRadius = 14;
            tbxEmail.BorderSize = 2;
            tbxEmail.Font = new Font("Cascadia Code", 10F, FontStyle.Bold, GraphicsUnit.Point);
            tbxEmail.ForeColor = Color.FromArgb(127, 131, 140);
            tbxEmail.Location = new Point(538, 172);
            tbxEmail.Margin = new Padding(4);
            tbxEmail.Multiline = false;
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Padding = new Padding(10, 7, 10, 7);
            tbxEmail.PasswordChar = false;
            tbxEmail.PlaceholderColor = Color.FromArgb(127, 131, 140);
            tbxEmail.PlaceholderText = "";
            tbxEmail.Size = new Size(250, 33);
            tbxEmail.TabIndex = 43;
            tbxEmail.Texts = "";
            tbxEmail.UnderlinedStyle = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(229, 229, 229);
            label8.Location = new Point(422, 97);
            label8.Name = "label8";
            label8.Size = new Size(73, 21);
            label8.TabIndex = 42;
            label8.Text = "Salary:";
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
            tbxSalary.Location = new Point(538, 91);
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(229, 229, 229);
            label7.Location = new Point(37, 177);
            label7.Name = "label7";
            label7.Size = new Size(73, 21);
            label7.TabIndex = 35;
            label7.Text = "Shifts:";
            // 
            // cklMorning
            // 
            cklMorning.AutoSize = true;
            cklMorning.Location = new Point(165, 212);
            cklMorning.MinimumSize = new Size(45, 22);
            cklMorning.Name = "cklMorning";
            cklMorning.OffBackColor = Color.FromArgb(229, 229, 229);
            cklMorning.OffToggleColor = Color.FromArgb(156, 84, 213);
            cklMorning.OnBackColor = Color.FromArgb(156, 84, 213);
            cklMorning.OnToggleColor = Color.FromArgb(229, 229, 229);
            cklMorning.Size = new Size(45, 22);
            cklMorning.TabIndex = 34;
            cklMorning.UseVisualStyleBackColor = true;
            // 
            // cklAfternoon
            // 
            cklAfternoon.AutoSize = true;
            cklAfternoon.Location = new Point(255, 212);
            cklAfternoon.MinimumSize = new Size(45, 22);
            cklAfternoon.Name = "cklAfternoon";
            cklAfternoon.OffBackColor = Color.FromArgb(229, 229, 229);
            cklAfternoon.OffToggleColor = Color.FromArgb(156, 84, 213);
            cklAfternoon.OnBackColor = Color.FromArgb(156, 84, 213);
            cklAfternoon.OnToggleColor = Color.FromArgb(229, 229, 229);
            cklAfternoon.Size = new Size(45, 22);
            cklAfternoon.TabIndex = 33;
            cklAfternoon.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(229, 229, 229);
            label6.Location = new Point(330, 177);
            label6.Name = "label6";
            label6.Size = new Size(73, 21);
            label6.TabIndex = 32;
            label6.Text = "Evening";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(229, 229, 229);
            label5.Location = new Point(231, 177);
            label5.Name = "label5";
            label5.Size = new Size(91, 21);
            label5.TabIndex = 31;
            label5.Text = "Afternoon";
            // 
            // cklEvening
            // 
            cklEvening.AutoSize = true;
            cklEvening.Location = new Point(342, 212);
            cklEvening.MinimumSize = new Size(45, 22);
            cklEvening.Name = "cklEvening";
            cklEvening.OffBackColor = Color.FromArgb(229, 229, 229);
            cklEvening.OffToggleColor = Color.FromArgb(156, 84, 213);
            cklEvening.OnBackColor = Color.FromArgb(156, 84, 213);
            cklEvening.OnToggleColor = Color.FromArgb(229, 229, 229);
            cklEvening.Size = new Size(45, 22);
            cklEvening.TabIndex = 30;
            cklEvening.UseVisualStyleBackColor = true;
            // 
            // lbRegisterDate
            // 
            lbRegisterDate.Font = new Font("Cascadia Code", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbRegisterDate.ForeColor = Color.FromArgb(127, 131, 140);
            lbRegisterDate.Location = new Point(538, 51);
            lbRegisterDate.Name = "lbRegisterDate";
            lbRegisterDate.Size = new Size(250, 33);
            lbRegisterDate.TabIndex = 29;
            lbRegisterDate.Text = "RegisterDate";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(229, 229, 229);
            label4.Location = new Point(150, 177);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 28;
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
            cbxDepartment.Location = new Point(538, 132);
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
            label2.Location = new Point(422, 138);
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
            label1.Location = new Point(422, 56);
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
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(785, 0);
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
            btnSave.Location = new Point(38, 253);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(752, 43);
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
            panelBody.Size = new Size(838, 326);
            panelBody.TabIndex = 6;
            // 
            // EmployeesAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 229, 229);
            ClientSize = new Size(838, 326);
            Controls.Add(panelBody);
            Font = new Font("Cascadia Code", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            Margin = new Padding(3, 4, 3, 4);
            Name = "EmployeesAdd";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeesAdd";
            panelButtons.ResumeLayout(false);
            panelButtons.PerformLayout();
            panel1.ResumeLayout(false);
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
        private Label label4;
        private CustomElements.CustomCheckBox cklEvening;
        private Label label7;
        private CustomElements.CustomCheckBox cklMorning;
        private CustomElements.CustomCheckBox cklAfternoon;
        private Label label6;
        private Label label5;
        private Label label8;
        private RoundTextBox tbxSalary;
        private Label label9;
        private RoundTextBox tbxEmail;
        private Panel panel1;
        private RoundTextBox tbxName;
        private RoundTextBox tbxUsername;
        private RoundTextBox tbxPhone;
        private Label label10;
        private RoundTextBox tbxPassword;
    }
}