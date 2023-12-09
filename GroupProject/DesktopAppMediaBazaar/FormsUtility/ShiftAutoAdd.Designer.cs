namespace DesktopAppMediaBazaar.FormsUtility
{
    partial class ShiftAutoAdd
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
            btnGenerate = new CustomElements.RoundButton();
            label1 = new Label();
            label2 = new Label();
            StartCalendar = new CustomElements.CustomDatePicker();
            EndCalendar = new CustomElements.CustomDatePicker();
            SuspendLayout();
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.FromArgb(229, 229, 229);
            btnGenerate.BackgroundColor = Color.FromArgb(229, 229, 229);
            btnGenerate.BorderColor = Color.White;
            btnGenerate.BorderRadius = 14;
            btnGenerate.BorderSize = 0;
            btnGenerate.ClickedColor = Color.White;
            btnGenerate.FlatAppearance.BorderSize = 0;
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.Font = new Font("Cascadia Code", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnGenerate.ForeColor = Color.FromArgb(127, 131, 140);
            btnGenerate.Location = new Point(26, 202);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(352, 43);
            btnGenerate.TabIndex = 13;
            btnGenerate.Text = "Generate";
            btnGenerate.TextColor = Color.FromArgb(127, 131, 140);
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(156, 84, 213);
            label1.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(229, 229, 229);
            label1.Location = new Point(157, 29);
            label1.Name = "label1";
            label1.Size = new Size(109, 21);
            label1.TabIndex = 45;
            label1.Text = "Start Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(156, 84, 213);
            label2.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(229, 229, 229);
            label2.Location = new Point(166, 113);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 46;
            label2.Text = "End Date:";
            // 
            // StartCalendar
            // 
            StartCalendar.BorderColor = Color.FromArgb(156, 84, 213);
            StartCalendar.BorderSize = 2;
            StartCalendar.CalendarFont = new Font("Cascadia Code", 10F, FontStyle.Bold, GraphicsUnit.Point);
            StartCalendar.CalendarForeColor = Color.FromArgb(156, 84, 213);
            StartCalendar.CalendarMonthBackground = Color.FromArgb(156, 84, 213);
            StartCalendar.CalendarTitleBackColor = Color.FromArgb(229, 229, 229);
            StartCalendar.CalendarTitleForeColor = Color.FromArgb(156, 84, 213);
            StartCalendar.CustomFormat = "MMM dd, yyy";
            StartCalendar.Font = new Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            StartCalendar.Location = new Point(107, 53);
            StartCalendar.MinimumSize = new Size(0, 35);
            StartCalendar.Name = "StartCalendar";
            StartCalendar.Size = new Size(201, 35);
            StartCalendar.SkinColor = Color.FromArgb(156, 84, 213);
            StartCalendar.TabIndex = 47;
            StartCalendar.TextColor = Color.FromArgb(229, 229, 229);
            StartCalendar.Value = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            // 
            // EndCalendar
            // 
            EndCalendar.BorderColor = Color.FromArgb(156, 84, 213);
            EndCalendar.BorderSize = 2;
            EndCalendar.CalendarFont = new Font("Cascadia Code", 10F, FontStyle.Bold, GraphicsUnit.Point);
            EndCalendar.CalendarForeColor = Color.FromArgb(156, 84, 213);
            EndCalendar.CalendarMonthBackground = Color.FromArgb(156, 84, 213);
            EndCalendar.CalendarTitleBackColor = Color.FromArgb(229, 229, 229);
            EndCalendar.CalendarTitleForeColor = Color.FromArgb(156, 84, 213);
            EndCalendar.CustomFormat = "MMM dd, yyy";
            EndCalendar.Font = new Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            EndCalendar.Location = new Point(105, 137);
            EndCalendar.MinimumSize = new Size(0, 35);
            EndCalendar.Name = "EndCalendar";
            EndCalendar.Size = new Size(201, 35);
            EndCalendar.SkinColor = Color.FromArgb(156, 84, 213);
            EndCalendar.TabIndex = 48;
            EndCalendar.TextColor = Color.FromArgb(229, 229, 229);
            EndCalendar.Value = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            // 
            // ShiftAutoAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(156, 84, 213);
            ClientSize = new Size(407, 257);
            Controls.Add(EndCalendar);
            Controls.Add(StartCalendar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGenerate);
            Name = "ShiftAutoAdd";
            Text = "ShiftAutoAdd";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomElements.RoundButton btnGenerate;
        private Label label1;
        private Label label2;
        private CustomElements.CustomDatePicker StartCalendar;
        private CustomElements.CustomDatePicker EndCalendar;
    }
}