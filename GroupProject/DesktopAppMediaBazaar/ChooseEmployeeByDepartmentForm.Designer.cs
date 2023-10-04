namespace DesktopAppMediaBazaar
{
	partial class ChooseEmployeeByDepartmentForm
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
			this.txbSearch = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lbxEmployees = new System.Windows.Forms.ListBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txbSearch
			// 
			this.txbSearch.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txbSearch.Location = new System.Drawing.Point(12, 81);
			this.txbSearch.Name = "txbSearch";
			this.txbSearch.Size = new System.Drawing.Size(294, 30);
			this.txbSearch.TabIndex = 0;
			this.txbSearch.TextChanged += new System.EventHandler(this.txbSearch_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(80, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(212, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Choose employee";
			// 
			// lbxEmployees
			// 
			this.lbxEmployees.FormattingEnabled = true;
			this.lbxEmployees.ItemHeight = 21;
			this.lbxEmployees.Location = new System.Drawing.Point(12, 117);
			this.lbxEmployees.Name = "lbxEmployees";
			this.lbxEmployees.Size = new System.Drawing.Size(340, 382);
			this.lbxEmployees.TabIndex = 2;
			// 
			// btnSearch
			// 
			this.btnSearch.BackColor = System.Drawing.Color.Black;
			this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearch.ForeColor = System.Drawing.Color.White;
			this.btnSearch.Location = new System.Drawing.Point(312, 81);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(39, 30);
			this.btnSearch.TabIndex = 3;
			this.btnSearch.Text = "🔍";
			this.btnSearch.UseVisualStyleBackColor = false;
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.SeaGreen;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.ForeColor = System.Drawing.Color.White;
			this.btnAdd.Location = new System.Drawing.Point(108, 523);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(150, 76);
			this.btnAdd.TabIndex = 4;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// ChooseEmployeeByDepartmentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(364, 611);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.lbxEmployees);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txbSearch);
			this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "ChooseEmployeeByDepartmentForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ChooseEmployeeByDepartmentForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TextBox txbSearch;
		private Label label1;
		private ListBox lbxEmployees;
		private Button btnSearch;
		private Button btnAdd;
	}
}