namespace DesktopAppMediaBazaar
{
    partial class ManagerLandingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerLandingForm));
            labelWelcome = new Label();
            panel1 = new Panel();
            btnLogout = new Button();
            btnEmployees = new Button();
            btnShifts = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Century Gothic", 19F, FontStyle.Regular, GraphicsUnit.Point);
            labelWelcome.Location = new Point(260, 30);
            labelWelcome.Margin = new Padding(2, 0, 2, 0);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(137, 32);
            labelWelcome.TabIndex = 0;
            labelWelcome.Text = "Welcome";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnEmployees);
            panel1.Controls.Add(btnShifts);
            panel1.Location = new Point(1, 0);
            panel1.Margin = new Padding(2, 1, 2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(221, 685);
            panel1.TabIndex = 10;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Teal;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(-2, 327);
            btnLogout.Margin = new Padding(4, 3, 4, 3);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(226, 80);
            btnLogout.TabIndex = 14;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnEmployees
            // 
            btnEmployees.BackColor = Color.Teal;
            btnEmployees.FlatStyle = FlatStyle.Flat;
            btnEmployees.Font = new Font("Century Gothic", 13.125F, FontStyle.Regular, GraphicsUnit.Point);
            btnEmployees.ForeColor = Color.White;
            btnEmployees.Location = new Point(0, 125);
            btnEmployees.Margin = new Padding(2, 1, 2, 1);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(224, 77);
            btnEmployees.TabIndex = 1;
            btnEmployees.Text = "Employees";
            btnEmployees.UseVisualStyleBackColor = false;
            // 
            // btnShifts
            // 
            btnShifts.BackColor = Color.Teal;
            btnShifts.FlatStyle = FlatStyle.Flat;
            btnShifts.Font = new Font("Century Gothic", 13.125F, FontStyle.Regular, GraphicsUnit.Point);
            btnShifts.ForeColor = Color.White;
            btnShifts.Location = new Point(-2, 224);
            btnShifts.Margin = new Padding(2, 1, 2, 1);
            btnShifts.Name = "btnShifts";
            btnShifts.Size = new Size(226, 80);
            btnShifts.TabIndex = 2;
            btnShifts.Text = "Shifts";
            btnShifts.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(786, 129);
            pictureBox1.Margin = new Padding(2, 1, 2, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(453, 230);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(965, 383);
            pictureBox2.Margin = new Padding(2, 1, 2, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(352, 291);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(260, 453);
            pictureBox4.Margin = new Padding(2, 1, 2, 1);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(676, 197);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 16;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(247, 87);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(471, 23);
            label1.TabIndex = 17;
            label1.Text = "Here are some of the statistics of the company:";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(296, 144);
            pictureBox3.Margin = new Padding(2, 1, 2, 1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(448, 277);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            // 
            // ManagerLandingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1345, 687);
            Controls.Add(pictureBox3);
            Controls.Add(label1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(labelWelcome);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2, 1, 2, 1);
            Name = "ManagerLandingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManagerLandingForm";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelWelcome;
        private Panel panel1;
        private Button btnEmployees;
        private Button btnShifts;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private Label label1;
        private PictureBox pictureBox3;
        private Button btnLogout;
    }
}