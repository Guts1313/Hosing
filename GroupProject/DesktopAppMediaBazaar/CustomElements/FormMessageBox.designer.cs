
namespace CustomMessageBox.Private
{
    partial class FormMessageBox
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
            panelTitleBar = new Panel();
            labelCaption = new Label();
            btnClose = new Button();
            panelBody = new Panel();
            labelMessage = new Label();
            pictureBoxIcon = new PictureBox();
            panelButtons = new Panel();
            button3 = new DesktopAppMediaBazaar.CustomElements.RoundButton();
            button2 = new DesktopAppMediaBazaar.CustomElements.RoundButton();
            button1 = new DesktopAppMediaBazaar.CustomElements.RoundButton();
            panelTitleBar.SuspendLayout();
            panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).BeginInit();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(156, 84, 213);
            panelTitleBar.Controls.Add(labelCaption);
            panelTitleBar.Controls.Add(btnClose);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(2, 2);
            panelTitleBar.Margin = new Padding(4, 3, 4, 3);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(404, 40);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // labelCaption
            // 
            labelCaption.AutoSize = true;
            labelCaption.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelCaption.ForeColor = Color.White;
            labelCaption.Location = new Point(10, 9);
            labelCaption.Margin = new Padding(4, 0, 4, 0);
            labelCaption.Name = "labelCaption";
            labelCaption.Size = new Size(91, 16);
            labelCaption.TabIndex = 4;
            labelCaption.Text = "labelCaption";
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(229, 229, 229);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(357, 0);
            btnClose.Margin = new Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(47, 40);
            btnClose.TabIndex = 3;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panelBody
            // 
            panelBody.BackColor = Color.FromArgb(229, 229, 229);
            panelBody.Controls.Add(labelMessage);
            panelBody.Controls.Add(pictureBoxIcon);
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(2, 42);
            panelBody.Margin = new Padding(4, 3, 4, 3);
            panelBody.Name = "panelBody";
            panelBody.Padding = new Padding(12, 12, 0, 0);
            panelBody.Size = new Size(404, 60);
            panelBody.TabIndex = 12;
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Font = new Font("Cascadia Code SemiLight", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelMessage.ForeColor = Color.FromArgb(110, 110, 110);
            labelMessage.Location = new Point(12, 12);
            labelMessage.Margin = new Padding(4, 0, 4, 0);
            labelMessage.MaximumSize = new Size(700, 0);
            labelMessage.Name = "labelMessage";
            labelMessage.Padding = new Padding(6, 6, 12, 17);
            labelMessage.Size = new Size(109, 39);
            labelMessage.TabIndex = 1;
            labelMessage.Text = "labelMessage";
            labelMessage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBoxIcon
            // 
            pictureBoxIcon.Location = new Point(0, 0);
            pictureBoxIcon.Margin = new Padding(4, 3, 4, 3);
            pictureBoxIcon.Name = "pictureBoxIcon";
            pictureBoxIcon.Size = new Size(117, 58);
            pictureBoxIcon.TabIndex = 2;
            pictureBoxIcon.TabStop = false;
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.FromArgb(156, 84, 213);
            panelButtons.Controls.Add(button3);
            panelButtons.Controls.Add(button2);
            panelButtons.Controls.Add(button1);
            panelButtons.Dock = DockStyle.Bottom;
            panelButtons.Location = new Point(2, 102);
            panelButtons.Margin = new Padding(4, 3, 4, 3);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(404, 69);
            panelButtons.TabIndex = 11;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(229, 229, 229);
            button3.BackgroundColor = Color.FromArgb(229, 229, 229);
            button3.BorderColor = Color.FromArgb(156, 84, 213);
            button3.BorderRadius = 15;
            button3.BorderSize = 0;
            button3.ClickedColor = Color.FromArgb(156, 84, 213);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Cascadia Mono", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(110, 110, 110);
            button3.Location = new Point(265, 14);
            button3.Name = "button3";
            button3.Size = new Size(117, 40);
            button3.TabIndex = 6;
            button3.Text = "button3";
            button3.TextColor = Color.FromArgb(110, 110, 110);
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(229, 229, 229);
            button2.BackgroundColor = Color.FromArgb(229, 229, 229);
            button2.BorderColor = Color.FromArgb(156, 84, 213);
            button2.BorderRadius = 15;
            button2.BorderSize = 0;
            button2.ClickedColor = Color.FromArgb(156, 84, 213);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Cascadia Mono", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(110, 110, 110);
            button2.Location = new Point(144, 14);
            button2.Name = "button2";
            button2.Size = new Size(117, 40);
            button2.TabIndex = 4;
            button2.Text = "button2";
            button2.TextColor = Color.FromArgb(110, 110, 110);
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(229, 229, 229);
            button1.BackgroundColor = Color.FromArgb(229, 229, 229);
            button1.BorderColor = Color.FromArgb(156, 84, 213);
            button1.BorderRadius = 15;
            button1.BorderSize = 0;
            button1.ClickedColor = Color.FromArgb(156, 84, 213);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Cascadia Mono", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(110, 110, 110);
            button1.Location = new Point(22, 14);
            button1.Name = "button1";
            button1.Size = new Size(117, 40);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.TextColor = Color.FromArgb(110, 110, 110);
            button1.UseVisualStyleBackColor = false;
            // 
            // FormMessageBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 229, 229);
            ClientSize = new Size(408, 173);
            Controls.Add(panelBody);
            Controls.Add(panelButtons);
            Controls.Add(panelTitleBar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximumSize = new Size(2560, 1440);
            MinimumSize = new Size(406, 167);
            Name = "FormMessageBox";
            Padding = new Padding(2);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            TransparencyKey = Color.Fuchsia;
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            panelBody.ResumeLayout(false);
            panelBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).EndInit();
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTitleBar;
        private Label labelCaption;
        private Button btnClose;
        private Panel panelBody;
        private Label labelMessage;
        private PictureBox pictureBoxIcon;
        private Panel panelButtons;
        private DesktopAppMediaBazaar.CustomElements.RoundButton button3;
        private DesktopAppMediaBazaar.CustomElements.RoundButton button2;
        private DesktopAppMediaBazaar.CustomElements.RoundButton button1;
    }
}

