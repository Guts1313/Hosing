namespace DesktopAppMediaBazaar.ChildForms
{
    partial class AnnouncementsForm
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
            panel1 = new Panel();
            btnDelete = new CustomElements.RoundButton();
            btnEdit = new CustomElements.RoundButton();
            btnAdd = new CustomElements.RoundButton();
            roundPanelListBox1 = new CustomElements.RoundPanelListBox();
            lbAnnouncements = new ListBox();
            rbtnAll = new CustomElements.CustomRadioButton();
            rbtnFuture = new CustomElements.CustomRadioButton();
            rbtnCurrent = new CustomElements.CustomRadioButton();
            rbtnPast = new CustomElements.CustomRadioButton();
            customLabelV21 = new CustomElements.Controls.CustomLabelV2();
            roundPanel1.SuspendLayout();
            panel1.SuspendLayout();
            roundPanelListBox1.SuspendLayout();
            SuspendLayout();
            // 
            // roundPanel1
            // 
            roundPanel1.BackColor = Color.FromArgb(156, 84, 213);
            roundPanel1.BorderColor = Color.White;
            roundPanel1.BorderWidth = 5;
            roundPanel1.Controls.Add(panel1);
            roundPanel1.Controls.Add(roundPanelListBox1);
            roundPanel1.Controls.Add(rbtnAll);
            roundPanel1.Controls.Add(rbtnFuture);
            roundPanel1.Controls.Add(rbtnCurrent);
            roundPanel1.Controls.Add(rbtnPast);
            roundPanel1.Controls.Add(customLabelV21);
            roundPanel1.Dock = DockStyle.Fill;
            roundPanel1.FillColor = Color.FromArgb(229, 229, 229);
            roundPanel1.IsBorder = false;
            roundPanel1.IsFill = true;
            roundPanel1.Location = new Point(0, 0);
            roundPanel1.Margin = new Padding(4, 3, 4, 3);
            roundPanel1.Name = "roundPanel1";
            roundPanel1.Radius = 20;
            roundPanel1.Size = new Size(1041, 542);
            roundPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(229, 229, 229);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnAdd);
            panel1.Location = new Point(756, 409);
            panel1.Name = "panel1";
            panel1.Size = new Size(243, 97);
            panel1.TabIndex = 14;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(229, 229, 229);
            btnDelete.BackgroundColor = Color.FromArgb(229, 229, 229);
            btnDelete.BorderColor = Color.FromArgb(156, 84, 213);
            btnDelete.BorderRadius = 15;
            btnDelete.BorderSize = 2;
            btnDelete.ClickedColor = Color.FromArgb(156, 84, 213);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Cascadia Code", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.FromArgb(156, 84, 213);
            btnDelete.Location = new Point(3, 49);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(240, 40);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.TextColor = Color.FromArgb(156, 84, 213);
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(156, 84, 213);
            btnEdit.BackgroundColor = Color.FromArgb(156, 84, 213);
            btnEdit.BorderColor = Color.FromArgb(156, 84, 213);
            btnEdit.BorderRadius = 15;
            btnEdit.BorderSize = 0;
            btnEdit.ClickedColor = Color.FromArgb(156, 84, 213);
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Cascadia Code", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.FromArgb(229, 229, 229);
            btnEdit.Location = new Point(126, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(117, 40);
            btnEdit.TabIndex = 14;
            btnEdit.Text = "Edit";
            btnEdit.TextColor = Color.FromArgb(229, 229, 229);
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
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
            btnAdd.Click += btnAdd_Click;
            // 
            // roundPanelListBox1
            // 
            roundPanelListBox1.BackColor = Color.FromArgb(156, 84, 213);
            roundPanelListBox1.Controls.Add(lbAnnouncements);
            roundPanelListBox1.Location = new Point(52, 50);
            roundPanelListBox1.Margin = new Padding(4, 3, 4, 3);
            roundPanelListBox1.Name = "roundPanelListBox1";
            roundPanelListBox1.Size = new Size(947, 337);
            roundPanelListBox1.TabIndex = 12;
            // 
            // lbAnnouncements
            // 
            lbAnnouncements.BackColor = Color.FromArgb(156, 84, 213);
            lbAnnouncements.BorderStyle = BorderStyle.None;
            lbAnnouncements.Font = new Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbAnnouncements.ForeColor = Color.FromArgb(229, 229, 229);
            lbAnnouncements.FormattingEnabled = true;
            lbAnnouncements.ItemHeight = 17;
            lbAnnouncements.Location = new Point(6, 7);
            lbAnnouncements.Margin = new Padding(4, 3, 4, 3);
            lbAnnouncements.Name = "lbAnnouncements";
            lbAnnouncements.Size = new Size(941, 323);
            lbAnnouncements.TabIndex = 0;
            lbAnnouncements.SelectedIndexChanged += lbAnnouncements_SelectedIndexChanged;
            lbAnnouncements.MouseDoubleClick += lbAnnouncements_MouseDoubleClick;
            // 
            // rbtnAll
            // 
            rbtnAll.AutoSize = true;
            rbtnAll.BackColor = Color.FromArgb(229, 229, 229);
            rbtnAll.CheckedColor = Color.FromArgb(156, 64, 213);
            rbtnAll.Font = new Font("Cascadia Code", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rbtnAll.ForeColor = Color.FromArgb(114, 118, 127);
            rbtnAll.Location = new Point(329, 435);
            rbtnAll.Margin = new Padding(4, 3, 4, 3);
            rbtnAll.MinimumSize = new Size(0, 21);
            rbtnAll.Name = "rbtnAll";
            rbtnAll.Padding = new Padding(10, 0, 0, 0);
            rbtnAll.Size = new Size(60, 21);
            rbtnAll.TabIndex = 11;
            rbtnAll.TabStop = true;
            rbtnAll.Text = "All";
            rbtnAll.UnCheckedColor = Color.FromArgb(156, 64, 213);
            rbtnAll.UseVisualStyleBackColor = false;
            rbtnAll.CheckedChanged += rBtnAll_CheckedChanged;
            // 
            // rbtnFuture
            // 
            rbtnFuture.AutoSize = true;
            rbtnFuture.BackColor = Color.FromArgb(229, 229, 229);
            rbtnFuture.CheckedColor = Color.FromArgb(156, 64, 213);
            rbtnFuture.Font = new Font("Cascadia Code", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rbtnFuture.ForeColor = Color.FromArgb(114, 118, 127);
            rbtnFuture.Location = new Point(237, 435);
            rbtnFuture.Margin = new Padding(4, 3, 4, 3);
            rbtnFuture.MinimumSize = new Size(0, 21);
            rbtnFuture.Name = "rbtnFuture";
            rbtnFuture.Padding = new Padding(10, 0, 0, 0);
            rbtnFuture.Size = new Size(84, 21);
            rbtnFuture.TabIndex = 10;
            rbtnFuture.TabStop = true;
            rbtnFuture.Text = "Future";
            rbtnFuture.UnCheckedColor = Color.FromArgb(156, 64, 213);
            rbtnFuture.UseVisualStyleBackColor = false;
            rbtnFuture.CheckedChanged += rBtnFuture_CheckedChanged;
            // 
            // rbtnCurrent
            // 
            rbtnCurrent.AutoSize = true;
            rbtnCurrent.BackColor = Color.FromArgb(229, 229, 229);
            rbtnCurrent.CheckedColor = Color.FromArgb(156, 64, 213);
            rbtnCurrent.Font = new Font("Cascadia Code", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rbtnCurrent.ForeColor = Color.FromArgb(114, 118, 127);
            rbtnCurrent.Location = new Point(137, 435);
            rbtnCurrent.Margin = new Padding(4, 3, 4, 3);
            rbtnCurrent.MinimumSize = new Size(0, 21);
            rbtnCurrent.Name = "rbtnCurrent";
            rbtnCurrent.Padding = new Padding(10, 0, 0, 0);
            rbtnCurrent.Size = new Size(92, 21);
            rbtnCurrent.TabIndex = 9;
            rbtnCurrent.TabStop = true;
            rbtnCurrent.Text = "Current";
            rbtnCurrent.UnCheckedColor = Color.FromArgb(156, 64, 213);
            rbtnCurrent.UseVisualStyleBackColor = false;
            rbtnCurrent.CheckedChanged += rBtnCurrent_CheckedChanged;
            // 
            // rbtnPast
            // 
            rbtnPast.AutoSize = true;
            rbtnPast.BackColor = Color.FromArgb(229, 229, 229);
            rbtnPast.CheckedColor = Color.FromArgb(156, 64, 213);
            rbtnPast.Font = new Font("Cascadia Code", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rbtnPast.ForeColor = Color.FromArgb(114, 118, 127);
            rbtnPast.Location = new Point(63, 435);
            rbtnPast.Margin = new Padding(4, 3, 4, 3);
            rbtnPast.MinimumSize = new Size(0, 21);
            rbtnPast.Name = "rbtnPast";
            rbtnPast.Padding = new Padding(10, 0, 0, 0);
            rbtnPast.Size = new Size(68, 21);
            rbtnPast.TabIndex = 8;
            rbtnPast.TabStop = true;
            rbtnPast.Text = "Past";
            rbtnPast.UnCheckedColor = Color.FromArgb(156, 64, 213);
            rbtnPast.UseVisualStyleBackColor = false;
            rbtnPast.CheckedChanged += rBtnPast_CheckedChanged;
            // 
            // customLabelV21
            // 
            customLabelV21.AutoSize = true;
            customLabelV21.BackColor = Color.Transparent;
            customLabelV21.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            customLabelV21.ForeColor = Color.FromArgb(114, 118, 127);
            customLabelV21.Location = new Point(58, 403);
            customLabelV21.Margin = new Padding(4, 0, 4, 0);
            customLabelV21.Name = "customLabelV21";
            customLabelV21.Size = new Size(145, 21);
            customLabelV21.TabIndex = 7;
            customLabelV21.Text = "Filter by date:";
            // 
            // AnnouncementsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 542);
            Controls.Add(roundPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "AnnouncementsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Announcements";
            Load += AnnouncementsForm_Load;
            roundPanel1.ResumeLayout(false);
            roundPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            roundPanelListBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CustomElements.RoundPanel roundPanel1;
        private CustomElements.Controls.CustomLabelV2 customLabelV21;
        private CustomElements.CustomRadioButton rbtnPast;
        private CustomElements.RoundPanelListBox roundPanelListBox1;
        private CustomElements.CustomRadioButton rbtnAll;
        private CustomElements.CustomRadioButton rbtnFuture;
        private CustomElements.CustomRadioButton rbtnCurrent;
        private ListBox lbAnnouncements;
        private Panel panel1;
        private CustomElements.RoundButton btnDelete;
        private CustomElements.RoundButton btnEdit;
        private CustomElements.RoundButton btnAdd;
    }
}