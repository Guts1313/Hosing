namespace DesktopAppMediaBazaar
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LogInContainer = new CustomElements.Controls.CustomContainer();
            rightPanel = new CustomElements.Controls.CustomPanelV2();
            leftPanel = new CustomElements.Controls.CustomPanelV2();
            customControlBox1 = new CustomElements.Controls.CustomControlBox();
            LogInContainer.SuspendLayout();
            SuspendLayout();
            // 
            // LogInContainer
            // 
            LogInContainer.Controls.Add(rightPanel);
            LogInContainer.Controls.Add(leftPanel);
            LogInContainer.Controls.Add(customControlBox1);
            LogInContainer.Dock = DockStyle.Fill;
            LogInContainer.DrawIcon = false;
            LogInContainer.Font = new Font("Cascadia Code", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            LogInContainer.Location = new Point(0, 0);
            LogInContainer.MinimumSize = new Size(100, 42);
            LogInContainer.Name = "LogInContainer";
            LogInContainer.Padding = new Padding(0, 31, 0, 0);
            LogInContainer.Size = new Size(700, 515);
            LogInContainer.TabIndex = 0;
            LogInContainer.TextAlignment = CustomElements.Controls.CustomContainer.Alignment.Left;
            LogInContainer.TitleBarTextColor = Color.Gainsboro;
            // 
            // rightPanel
            // 
            rightPanel.Dock = DockStyle.Left;
            rightPanel.ForeColor = Color.FromArgb(250, 250, 250);
            rightPanel.Location = new Point(350, 31);
            rightPanel.Name = "rightPanel";
            rightPanel.Side = CustomElements.Controls.CustomPanelV2.PanelSide.Right;
            rightPanel.Size = new Size(350, 484);
            rightPanel.TabIndex = 2;
            // 
            // leftPanel
            // 
            leftPanel.Dock = DockStyle.Left;
            leftPanel.ForeColor = Color.FromArgb(250, 250, 250);
            leftPanel.Location = new Point(0, 31);
            leftPanel.Name = "leftPanel";
            leftPanel.Side = CustomElements.Controls.CustomPanelV2.PanelSide.Left;
            leftPanel.Size = new Size(350, 484);
            leftPanel.TabIndex = 1;
            // 
            // customControlBox1
            // 
            customControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            customControlBox1.BackColor = Color.Transparent;
            customControlBox1.EnableMaximizeButton = false;
            customControlBox1.EnableMinimizeButton = true;
            customControlBox1.Location = new Point(561, 0);
            customControlBox1.Name = "customControlBox1";
            customControlBox1.Size = new Size(139, 31);
            customControlBox1.TabIndex = 0;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 515);
            Controls.Add(LogInContainer);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(2560, 1440);
            MinimumSize = new Size(100, 42);
            Name = "Dashboard";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            TransparencyKey = Color.Fuchsia;
            LogInContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CustomElements.Controls.CustomContainer LogInContainer;
        private CustomElements.Controls.CustomPanelV2 rightPanel;
        private CustomElements.Controls.CustomPanelV2 leftPanel;
        private CustomElements.Controls.CustomControlBox customControlBox1;
    }
}