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
            roundPanelListBox1 = new CustomElements.RoundPanelListBox();
            lbVacation = new ListBox();
            roundPanel1.SuspendLayout();
            panel2.SuspendLayout();
            roundPanelListBox1.SuspendLayout();
            SuspendLayout();
            // 
            // roundPanel1
            // 
            roundPanel1.BackColor = Color.FromArgb(156, 84, 213);
            roundPanel1.BorderColor = Color.White;
            roundPanel1.BorderWidth = 5;
            roundPanel1.Controls.Add(panel2);
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
            panel2.Controls.Add(btnViewDetails);
            panel2.Controls.Add(btnReject);
            panel2.Controls.Add(btnApprove);
            panel2.Location = new Point(756, 409);
            panel2.Name = "panel2";
            panel2.Size = new Size(243, 97);
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
            btnViewDetails.Location = new Point(3, 49);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Size = new Size(240, 40);
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
            btnReject.Size = new Size(117, 40);
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
            btnApprove.Size = new Size(117, 40);
            btnApprove.TabIndex = 13;
            btnApprove.Text = "Approve";
            btnApprove.TextColor = Color.FromArgb(229, 229, 229);
            btnApprove.UseVisualStyleBackColor = false;
            btnApprove.Click += btnApprove_Click;
            // 
            // roundPanelListBox1
            // 
            roundPanelListBox1.BackColor = Color.FromArgb(156, 84, 213);
            roundPanelListBox1.Controls.Add(lbVacation);
            roundPanelListBox1.Location = new Point(52, 50);
            roundPanelListBox1.Margin = new Padding(4, 3, 4, 3);
            roundPanelListBox1.Name = "roundPanelListBox1";
            roundPanelListBox1.Size = new Size(947, 337);
            roundPanelListBox1.TabIndex = 12;
            // 
            // lbVacation
            // 
            lbVacation.BackColor = Color.FromArgb(156, 84, 213);
            lbVacation.BorderStyle = BorderStyle.None;
            lbVacation.Font = new Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbVacation.ForeColor = Color.FromArgb(229, 229, 229);
            lbVacation.FormattingEnabled = true;
            lbVacation.ItemHeight = 17;
            lbVacation.Location = new Point(6, 7);
            lbVacation.Margin = new Padding(4, 3, 4, 3);
            lbVacation.Name = "lbVacation";
            lbVacation.Size = new Size(941, 323);
            lbVacation.TabIndex = 0;
            lbVacation.SelectedIndexChanged += lbVacation_SelectedIndexChanged;
            lbVacation.DoubleClick += lbVacation_DoubleClick;
            // 
            // Vacations
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 542);
            Controls.Add(roundPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Vacations";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Vacation";
            roundPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            roundPanelListBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CustomElements.RoundPanel roundPanel1;
        private CustomElements.RoundPanelListBox roundPanelListBox1;
        private ListBox lbVacation;
        private Panel panel2;
        private CustomElements.RoundButton btnReject;
        private CustomElements.RoundButton btnApprove;
        private CustomElements.RoundButton btnViewDetails;
    }
}