using housing.CustomElements;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace DesktopAppMediaBazaar.ChildFormsUtility
{
    partial class AnnouncementsAddEdit
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
            label2 = new Label();
            endDate = new CustomElements.CustomDatePicker();
            startDate = new CustomElements.CustomDatePicker();
            label1 = new Label();
            lbFormTitle = new Label();
            btnClose = new Button();
            btnSave = new CustomElements.RoundButton();
            lbEmail = new Label();
            tbxDescription = new RoundTextBox();
            lbUsername = new Label();
            tbxTitle = new RoundTextBox();
            panelBody = new Panel();
            panelButtons.SuspendLayout();
            panelBody.SuspendLayout();
            SuspendLayout();
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.FromArgb(156, 84, 213);
            panelButtons.Controls.Add(label2);
            panelButtons.Controls.Add(endDate);
            panelButtons.Controls.Add(startDate);
            panelButtons.Controls.Add(label1);
            panelButtons.Controls.Add(lbFormTitle);
            panelButtons.Controls.Add(btnClose);
            panelButtons.Controls.Add(btnSave);
            panelButtons.Controls.Add(lbEmail);
            panelButtons.Controls.Add(tbxDescription);
            panelButtons.Controls.Add(lbUsername);
            panelButtons.Controls.Add(tbxTitle);
            panelButtons.Location = new Point(3, 3);
            panelButtons.Margin = new Padding(4, 3, 4, 3);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(554, 327);
            panelButtons.TabIndex = 4;
            panelButtons.MouseDown += panelTitleBar_MouseDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(229, 229, 229);
            label2.Location = new Point(281, 222);
            label2.Name = "label2";
            label2.Size = new Size(64, 21);
            label2.TabIndex = 19;
            label2.Text = "Until:";
            // 
            // endDate
            // 
            endDate.BorderColor = Color.FromArgb(156, 84, 213);
            endDate.BorderSize = 2;
            endDate.CalendarFont = new Font("Cascadia Code", 10F, FontStyle.Bold, GraphicsUnit.Point);
            endDate.CustomFormat = "MMM dd, yyy";
            endDate.Font = new Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            endDate.Location = new Point(345, 217);
            endDate.MinDate = new DateTime(1753, 12, 31, 0, 0, 0, 0);
            endDate.MinimumSize = new Size(0, 35);
            endDate.Name = "endDate";
            endDate.Size = new Size(181, 35);
            endDate.SkinColor = Color.FromArgb(156, 84, 213);
            endDate.TabIndex = 18;
            endDate.TextColor = Color.FromArgb(229, 229, 229);
            endDate.Value = new DateTime(2024, 12, 31, 0, 0, 0, 0);
            // 
            // startDate
            // 
            startDate.BorderColor = Color.FromArgb(156, 84, 213);
            startDate.BorderSize = 2;
            startDate.CalendarFont = new Font("Cascadia Code", 10F, FontStyle.Bold, GraphicsUnit.Point);
            startDate.CustomFormat = "MMM dd, yyy";
            startDate.Font = new Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            startDate.Location = new Point(88, 217);
            startDate.MinimumSize = new Size(0, 35);
            startDate.Name = "startDate";
            startDate.Size = new Size(181, 35);
            startDate.SkinColor = Color.FromArgb(156, 84, 213);
            startDate.TabIndex = 17;
            startDate.TextColor = Color.FromArgb(229, 229, 229);
            startDate.Value = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(229, 229, 229);
            label1.Location = new Point(38, 222);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
            label1.TabIndex = 15;
            label1.Text = "Date:";
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
            btnClose.Location = new Point(507, 0);
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
            btnSave.Location = new Point(38, 258);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(473, 43);
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
            lbEmail.Size = new Size(55, 21);
            lbEmail.TabIndex = 7;
            lbEmail.Text = "Desc:";
            // 
            // tbxDescription
            // 
            tbxDescription.BackColor = Color.FromArgb(229, 229, 229);
            tbxDescription.BorderColor = Color.FromArgb(229, 229, 229);
            tbxDescription.BorderFocusColor = Color.FromArgb(229, 229, 229);
            tbxDescription.BorderRadius = 14;
            tbxDescription.BorderSize = 2;
            tbxDescription.Font = new Font("Cascadia Code", 10F, FontStyle.Bold, GraphicsUnit.Point);
            tbxDescription.ForeColor = Color.FromArgb(127, 131, 140);
            tbxDescription.Location = new Point(110, 92);
            tbxDescription.Margin = new Padding(4);
            tbxDescription.Multiline = true;
            tbxDescription.Name = "tbxDescription";
            tbxDescription.Padding = new Padding(10, 7, 10, 7);
            tbxDescription.PasswordChar = false;
            tbxDescription.PlaceholderColor = Color.FromArgb(127, 131, 140);
            tbxDescription.PlaceholderText = "";
            tbxDescription.Size = new Size(400, 120);
            tbxDescription.TabIndex = 6;
            tbxDescription.Texts = "";
            tbxDescription.UnderlinedStyle = false;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbUsername.ForeColor = Color.FromArgb(229, 229, 229);
            lbUsername.Location = new Point(38, 56);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(64, 21);
            lbUsername.TabIndex = 5;
            lbUsername.Text = "Title:";
            // 
            // tbxTitle
            // 
            tbxTitle.BackColor = Color.FromArgb(229, 229, 229);
            tbxTitle.BorderColor = Color.FromArgb(229, 229, 229);
            tbxTitle.BorderFocusColor = Color.FromArgb(229, 229, 229);
            tbxTitle.BorderRadius = 14;
            tbxTitle.BorderSize = 2;
            tbxTitle.Font = new Font("Cascadia Code", 10F, FontStyle.Bold, GraphicsUnit.Point);
            tbxTitle.ForeColor = Color.FromArgb(127, 131, 140);
            tbxTitle.Location = new Point(110, 51);
            tbxTitle.Margin = new Padding(4);
            tbxTitle.Multiline = false;
            tbxTitle.Name = "tbxTitle";
            tbxTitle.Padding = new Padding(10, 7, 10, 7);
            tbxTitle.PasswordChar = false;
            tbxTitle.PlaceholderColor = Color.FromArgb(127, 131, 140);
            tbxTitle.PlaceholderText = "";
            tbxTitle.Size = new Size(400, 33);
            tbxTitle.TabIndex = 4;
            tbxTitle.Texts = "";
            tbxTitle.UnderlinedStyle = false;
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
            panelBody.Size = new Size(560, 333);
            panelBody.TabIndex = 6;
            // 
            // AnnouncementsAddEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 229, 229);
            ClientSize = new Size(560, 333);
            Controls.Add(panelBody);
            Font = new Font("Cascadia Code", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AnnouncementsAddEdit";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User_Add_Edit";
            panelButtons.ResumeLayout(false);
            panelButtons.PerformLayout();
            panelBody.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelButtons;
        private Label lbFormTitle;
        private Button btnClose;
        private CustomElements.RoundButton btnSave;
        private Label lbEmail;
        private RoundTextBox tbxDescription;
        private Label lbUsername;
        private RoundTextBox tbxTitle;
        private Panel panelBody;
        private Label label1;
        private CustomElements.CustomDatePicker startDate;
        private CustomElements.CustomDatePicker endDate;
        private Label label2;
    }
}