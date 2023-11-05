namespace DesktopAppMediaBazaar.Forms

{
    partial class Departments
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
            panel2 = new Panel();
            btnDelete = new CustomElements.RoundButton();
            btnAdd = new CustomElements.RoundButton();
            panel1 = new Panel();
            customLabelV21 = new CustomElements.Controls.CustomLabelV2();
            tbxName = new housing.CustomElements.RoundTextBox();
            roundPanelListBox1 = new CustomElements.RoundPanelListBox();
            lbDepartments = new ListBox();
            roundPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            roundPanelListBox1.SuspendLayout();
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
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(229, 229, 229);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnAdd);
            panel2.Location = new Point(756, 409);
            panel2.Name = "panel2";
            panel2.Size = new Size(243, 97);
            panel2.TabIndex = 16;
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
            btnDelete.Location = new Point(126, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(117, 40);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.TextColor = Color.FromArgb(229, 229, 229);
            btnDelete.UseVisualStyleBackColor = false;
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
            btnAdd.Location = new Point(3, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(117, 40);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add";
            btnAdd.TextColor = Color.FromArgb(229, 229, 229);
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(229, 229, 229);
            panel1.Controls.Add(customLabelV21);
            panel1.Controls.Add(tbxName);
            panel1.Location = new Point(58, 403);
            panel1.Name = "panel1";
            panel1.Size = new Size(680, 97);
            panel1.TabIndex = 14;
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
            customLabelV21.Size = new Size(145, 21);
            customLabelV21.TabIndex = 15;
            customLabelV21.Text = "Add Department:";
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
            // 
            // roundPanelListBox1
            // 
            roundPanelListBox1.BackColor = Color.FromArgb(156, 84, 213);
            roundPanelListBox1.Controls.Add(lbDepartments);
            roundPanelListBox1.Location = new Point(52, 50);
            roundPanelListBox1.Margin = new Padding(4, 3, 4, 3);
            roundPanelListBox1.Name = "roundPanelListBox1";
            roundPanelListBox1.Size = new Size(947, 337);
            roundPanelListBox1.TabIndex = 12;
            // 
            // lbDepartments
            // 
            lbDepartments.BackColor = Color.FromArgb(156, 84, 213);
            lbDepartments.BorderStyle = BorderStyle.None;
            lbDepartments.Font = new Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbDepartments.ForeColor = Color.FromArgb(229, 229, 229);
            lbDepartments.FormattingEnabled = true;
            lbDepartments.ItemHeight = 17;
            lbDepartments.Location = new Point(6, 7);
            lbDepartments.Margin = new Padding(4, 3, 4, 3);
            lbDepartments.Name = "lbDepartments";
            lbDepartments.Size = new Size(941, 323);
            lbDepartments.TabIndex = 0;
            // 
            // Departments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 542);
            Controls.Add(roundPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Departments";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Departments";
            roundPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            roundPanelListBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CustomElements.RoundPanel roundPanel1;
        private Panel panel1;
        private CustomElements.RoundPanelListBox roundPanelListBox1;
        private ListBox lbDepartments;
        private CustomElements.Controls.CustomLabelV2 customLabelV21;
        private housing.CustomElements.RoundTextBox tbxName;
        private Panel panel2;
        private CustomElements.RoundButton btnDelete;
        private CustomElements.RoundButton btnAdd;
    }
}