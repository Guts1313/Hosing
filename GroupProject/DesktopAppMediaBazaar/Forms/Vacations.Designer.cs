namespace DesktopAppMediaBazaar.Forms

{
    partial class Vacations
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
            btnViewDetails = new CustomElements.RoundButton();
            btnReject = new CustomElements.RoundButton();
            btnApprove = new CustomElements.RoundButton();
            roundPanelListBox2 = new CustomElements.RoundPanelListBox();
            dgvVacations = new DataGridView();
            roundPanel1.SuspendLayout();
            panel2.SuspendLayout();
            roundPanelListBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVacations).BeginInit();
            SuspendLayout();
            // 
            // roundPanel1
            // 
            roundPanel1.BackColor = Color.FromArgb(156, 84, 213);
            roundPanel1.BorderColor = Color.White;
            roundPanel1.BorderWidth = 5;
            roundPanel1.Controls.Add(roundPanelListBox2);
            roundPanel1.Controls.Add(panel2);
            roundPanel1.Dock = DockStyle.Fill;
            roundPanel1.FillColor = Color.FromArgb(229, 229, 229);
            roundPanel1.IsBorder = false;
            roundPanel1.IsFill = true;
            roundPanel1.Location = new Point(0, 0);
            roundPanel1.Margin = new Padding(4, 3, 4, 3);
            roundPanel1.Name = "roundPanel1";
            roundPanel1.Radius = 20;
            roundPanel1.Size = new Size(1041, 578);
            roundPanel1.TabIndex = 4;
            roundPanel1.Paint += roundPanel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(229, 229, 229);
            panel2.Controls.Add(btnViewDetails);
            panel2.Controls.Add(btnReject);
            panel2.Controls.Add(btnApprove);
            panel2.Location = new Point(756, 436);
            panel2.Name = "panel2";
            panel2.Size = new Size(243, 103);
            panel2.TabIndex = 16;
            // 
            // btnViewDetails
            // 
            btnViewDetails.BackColor = Color.FromArgb(229, 229, 229);
            btnViewDetails.BackgroundColor = Color.FromArgb(229, 229, 229);
            btnViewDetails.BorderColor = Color.FromArgb(156, 84, 213);
            btnViewDetails.BorderRadius = 15;
            btnViewDetails.BorderSize = 2;
            btnViewDetails.ClickedColor = Color.FromArgb(156, 84, 213);
            btnViewDetails.FlatAppearance.BorderSize = 0;
            btnViewDetails.FlatStyle = FlatStyle.Flat;
            btnViewDetails.Font = new Font("Cascadia Code", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnViewDetails.ForeColor = Color.FromArgb(156, 84, 213);
            btnViewDetails.Location = new Point(3, 52);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Size = new Size(240, 43);
            btnViewDetails.TabIndex = 16;
            btnViewDetails.Text = "View Details";
            btnViewDetails.TextColor = Color.FromArgb(156, 84, 213);
            btnViewDetails.UseVisualStyleBackColor = false;
            btnViewDetails.Click += btnViewDetails_Click;
            // 
            // btnReject
            // 
            btnReject.BackColor = Color.FromArgb(156, 84, 213);
            btnReject.BackgroundColor = Color.FromArgb(156, 84, 213);
            btnReject.BorderColor = Color.FromArgb(156, 84, 213);
            btnReject.BorderRadius = 15;
            btnReject.BorderSize = 0;
            btnReject.ClickedColor = Color.FromArgb(156, 84, 213);
            btnReject.FlatAppearance.BorderSize = 0;
            btnReject.FlatStyle = FlatStyle.Flat;
            btnReject.Font = new Font("Cascadia Code", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnReject.ForeColor = Color.FromArgb(229, 229, 229);
            btnReject.Location = new Point(126, 3);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(117, 43);
            btnReject.TabIndex = 14;
            btnReject.Text = "Reject";
            btnReject.TextColor = Color.FromArgb(229, 229, 229);
            btnReject.UseVisualStyleBackColor = false;
            btnReject.Click += btnReject_Click;
            // 
            // btnApprove
            // 
            btnApprove.BackColor = Color.FromArgb(156, 84, 213);
            btnApprove.BackgroundColor = Color.FromArgb(156, 84, 213);
            btnApprove.BorderColor = Color.FromArgb(156, 84, 213);
            btnApprove.BorderRadius = 15;
            btnApprove.BorderSize = 0;
            btnApprove.ClickedColor = Color.FromArgb(156, 84, 213);
            btnApprove.FlatAppearance.BorderSize = 0;
            btnApprove.FlatStyle = FlatStyle.Flat;
            btnApprove.Font = new Font("Cascadia Code", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnApprove.ForeColor = Color.FromArgb(229, 229, 229);
            btnApprove.Location = new Point(3, 3);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(117, 43);
            btnApprove.TabIndex = 13;
            btnApprove.Text = "Approve";
            btnApprove.TextColor = Color.FromArgb(229, 229, 229);
            btnApprove.UseVisualStyleBackColor = false;
            btnApprove.Click += btnApprove_Click;
            // 
            // roundPanelListBox2
            // 
            roundPanelListBox2.BackColor = Color.FromArgb(156, 84, 213);
            roundPanelListBox2.Controls.Add(dgvVacations);
            roundPanelListBox2.Location = new Point(52, 53);
            roundPanelListBox2.Margin = new Padding(4, 3, 4, 3);
            roundPanelListBox2.Name = "roundPanelListBox2";
            roundPanelListBox2.Size = new Size(947, 359);
            roundPanelListBox2.TabIndex = 17;
            // 
            // dgvVacations
            // 
            dgvVacations.AllowUserToAddRows = false;
            dgvVacations.AllowUserToDeleteRows = false;
            dgvVacations.AllowUserToResizeColumns = false;
            dgvVacations.AllowUserToResizeRows = false;
            dgvVacations.BackgroundColor = Color.FromArgb(156, 84, 213);
            dgvVacations.BorderStyle = BorderStyle.None;
            dgvVacations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVacations.GridColor = Color.FromArgb(11, 7, 17);
            dgvVacations.Location = new Point(0, 0);
            dgvVacations.Name = "dgvVacations";
            dgvVacations.ReadOnly = true;
            dgvVacations.RowHeadersWidth = 62;
            dgvVacations.RowTemplate.Height = 28;
            dgvVacations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVacations.Size = new Size(947, 359);
            dgvVacations.TabIndex = 2;
            // 
            // Vacations
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 578);
            Controls.Add(roundPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Vacations";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Vacation";
            roundPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            roundPanelListBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVacations).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CustomElements.RoundPanel roundPanel1;
        private Panel panel2;
        private CustomElements.RoundButton btnReject;
        private CustomElements.RoundButton btnApprove;
        private CustomElements.RoundButton btnViewDetails;
        private CustomElements.RoundPanelListBox roundPanelListBox2;
        private DataGridView dgvVacations;
    }
}