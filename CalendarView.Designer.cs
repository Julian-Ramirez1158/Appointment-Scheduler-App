
namespace BOP3___Task1
{
	partial class CalendarView
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.AllTab = new System.Windows.Forms.TabPage();
			this.WeeklyTab = new System.Windows.Forms.TabPage();
			this.MonthlyTab = new System.Windows.Forms.TabPage();
			this.ExitButton = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.dataGridView3 = new System.Windows.Forms.DataGridView();
			this.tabControl1.SuspendLayout();
			this.AllTab.SuspendLayout();
			this.WeeklyTab.SuspendLayout();
			this.MonthlyTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.AllTab);
			this.tabControl1.Controls.Add(this.WeeklyTab);
			this.tabControl1.Controls.Add(this.MonthlyTab);
			this.tabControl1.Location = new System.Drawing.Point(28, 22);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(745, 403);
			this.tabControl1.TabIndex = 0;
			// 
			// AllTab
			// 
			this.AllTab.Controls.Add(this.dataGridView1);
			this.AllTab.Location = new System.Drawing.Point(4, 22);
			this.AllTab.Name = "AllTab";
			this.AllTab.Padding = new System.Windows.Forms.Padding(3);
			this.AllTab.Size = new System.Drawing.Size(737, 377);
			this.AllTab.TabIndex = 0;
			this.AllTab.Text = "All";
			this.AllTab.UseVisualStyleBackColor = true;
			// 
			// WeeklyTab
			// 
			this.WeeklyTab.Controls.Add(this.dataGridView2);
			this.WeeklyTab.Location = new System.Drawing.Point(4, 22);
			this.WeeklyTab.Name = "WeeklyTab";
			this.WeeklyTab.Padding = new System.Windows.Forms.Padding(3);
			this.WeeklyTab.Size = new System.Drawing.Size(737, 377);
			this.WeeklyTab.TabIndex = 1;
			this.WeeklyTab.Text = "Weekly";
			this.WeeklyTab.UseVisualStyleBackColor = true;
			// 
			// MonthlyTab
			// 
			this.MonthlyTab.Controls.Add(this.dataGridView3);
			this.MonthlyTab.Location = new System.Drawing.Point(4, 22);
			this.MonthlyTab.Name = "MonthlyTab";
			this.MonthlyTab.Size = new System.Drawing.Size(737, 377);
			this.MonthlyTab.TabIndex = 2;
			this.MonthlyTab.Text = "Monthly";
			this.MonthlyTab.UseVisualStyleBackColor = true;
			// 
			// ExitButton
			// 
			this.ExitButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ExitButton.Location = new System.Drawing.Point(689, 450);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(80, 29);
			this.ExitButton.TabIndex = 4;
			this.ExitButton.Text = "Exit";
			this.ExitButton.UseVisualStyleBackColor = true;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(31, 38);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(675, 300);
			this.dataGridView1.TabIndex = 1;
			// 
			// dataGridView2
			// 
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(31, 38);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(675, 300);
			this.dataGridView2.TabIndex = 2;
			// 
			// dataGridView3
			// 
			this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView3.Location = new System.Drawing.Point(31, 38);
			this.dataGridView3.Name = "dataGridView3";
			this.dataGridView3.Size = new System.Drawing.Size(675, 300);
			this.dataGridView3.TabIndex = 2;
			// 
			// CalendarView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(800, 504);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.tabControl1);
			this.Name = "CalendarView";
			this.Text = "CalendarView";
			this.tabControl1.ResumeLayout(false);
			this.AllTab.ResumeLayout(false);
			this.WeeklyTab.ResumeLayout(false);
			this.MonthlyTab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage AllTab;
		private System.Windows.Forms.TabPage WeeklyTab;
		private System.Windows.Forms.TabPage MonthlyTab;
		private System.Windows.Forms.Button ExitButton;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.DataGridView dataGridView3;
	}
}