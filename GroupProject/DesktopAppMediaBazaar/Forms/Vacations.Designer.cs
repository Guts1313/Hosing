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
            roundPanelListBox2 = new CustomElements.RoundPanelListBox();
            dgvVacations = new DataGridView();
            panel2 = new Panel();
            btnViewDetails = new CustomElements.RoundButton();
            btnReject = new CustomElements.RoundButton();
            btnApprove = new CustomElements.RoundButton();
            roundPanel1.SuspendLayout();
            roundPanelListBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVacations).BeginInit();
            panel2.SuspendLayout();
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
            roundPanel1.Margin = new Padding(5, 4, 5, 4);
            roundPanel1.Name = "roundPanel1";
            roundPanel1.Radius = 20;
            roundPanel1.Size = new Size(1190, 722);
            roundPanel1.TabIndex = 4;
            roundPanel1.Paint += roundPanel1_Paint;
            // 
            // roundPanelListBox2
            // 
            roundPanelListBox2.BackColor = Color.FromArgb(156, 84, 213);
            roundPanelListBox2.Controls.Add(dgvVacations);
            roundPanelListBox2.Location = new Point(59, 66);
            roundPanelListBox2.Margin = new Padding(5, 4, 5, 4);
            roundPanelListBox2.Name = "roundPanelListBox2";
            roundPanelListBox2.Size = new Size(1082, 449);
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
            dgvVacations.Margin = new Padding(3, 4, 3, 4);
            dgvVacations.Name = "dgvVacations";
            dgvVacations.ReadOnly = true;
            dgvVacations.RowHeadersWidth = 62;
            dgvVacations.RowTemplate.Height = 28;
            dgvVacations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVacations.Size = new Size(1082, 449);
            dgvVacations.TabIndex = 2;
            dgvVacations.CellContentClick += dgvVacations_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(229, 229, 229);
            panel2.Controls.Add(btnViewDetails);
            panel2.Controls.Add(btnReject);
            panel2.Controls.Add(btnApprove);
            panel2.Location = new Point(864, 545);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(278, 129);
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
            btnViewDetails.Location = new Point(3, 65);
            btnViewDetails.Margin = new Padding(3, 4, 3, 4);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Size = new Size(274, 54);
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
            btnReject.Location = new Point(144, 4);
            btnReject.Margin = new Padding(3, 4, 3, 4);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(134, 54);
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
            btnApprove.Location = new Point(3, 4);
            btnApprove.Margin = new Padding(3, 4, 3, 4);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(134, 54);
            btnApprove.TabIndex = 13;
            btnApprove.Text = "Approve";
            btnApprove.TextColor = Color.FromArgb(229, 229, 229);
            btnApprove.UseVisualStyleBackColor = false;
            btnApprove.Click += btnApprove_Click;
            // 
            // Vacations
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1190, 722);
            Controls.Add(roundPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 4, 5, 4);
            Name = "Vacations";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Vacation";
            roundPanel1.ResumeLayout(false);
            roundPanelListBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVacations).EndInit();
            panel2.ResumeLayout(false);
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