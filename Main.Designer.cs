﻿
namespace BOP3___Task1
{
	partial class Main
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.ModifyAppointmentButton = new System.Windows.Forms.Button();
            this.AddAppointmentButton = new System.Windows.Forms.Button();
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LogoffButton = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.CalendarView = new System.Windows.Forms.Button();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.AddCustButton = new System.Windows.Forms.Button();
            this.ModifyCustButton = new System.Windows.Forms.Button();
            this.custDeleteButton = new System.Windows.Forms.Button();
            this.CustomerGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.CustomerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.ModifyAppointmentButton);
            this.groupBox1.Controls.Add(this.AddAppointmentButton);
            this.groupBox1.Controls.Add(this.dgvAppointments);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(39, 376);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(808, 326);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Appointments";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(696, 279);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 29);
            this.button4.TabIndex = 3;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // ModifyAppointmentButton
            // 
            this.ModifyAppointmentButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyAppointmentButton.Location = new System.Drawing.Point(610, 279);
            this.ModifyAppointmentButton.Name = "ModifyAppointmentButton";
            this.ModifyAppointmentButton.Size = new System.Drawing.Size(80, 29);
            this.ModifyAppointmentButton.TabIndex = 2;
            this.ModifyAppointmentButton.Text = "Modify";
            this.ModifyAppointmentButton.UseVisualStyleBackColor = true;
            this.ModifyAppointmentButton.Click += new System.EventHandler(this.ModifyAppointmentButton_Click);
            // 
            // AddAppointmentButton
            // 
            this.AddAppointmentButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAppointmentButton.Location = new System.Drawing.Point(524, 279);
            this.AddAppointmentButton.Name = "AddAppointmentButton";
            this.AddAppointmentButton.Size = new System.Drawing.Size(80, 29);
            this.AddAppointmentButton.TabIndex = 1;
            this.AddAppointmentButton.Text = "Add";
            this.AddAppointmentButton.UseVisualStyleBackColor = true;
            this.AddAppointmentButton.Click += new System.EventHandler(this.AddAppointmentButton_Click);
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointments.Location = new System.Drawing.Point(33, 42);
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.Size = new System.Drawing.Size(743, 220);
            this.dgvAppointments.TabIndex = 0;
            this.dgvAppointments.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.clearSelection2);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.LogoffButton);
            this.groupBox2.Controls.Add(this.button10);
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.CalendarView);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(915, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 495);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controls";
            // 
            // LogoffButton
            // 
            this.LogoffButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoffButton.Location = new System.Drawing.Point(63, 398);
            this.LogoffButton.Name = "LogoffButton";
            this.LogoffButton.Size = new System.Drawing.Size(182, 51);
            this.LogoffButton.TabIndex = 4;
            this.LogoffButton.Text = "Log Off";
            this.LogoffButton.UseVisualStyleBackColor = true;
            this.LogoffButton.Click += new System.EventHandler(this.LogoffButton_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(63, 314);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(182, 51);
            this.button10.TabIndex = 3;
            this.button10.Text = "Report 3";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(63, 227);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(182, 51);
            this.button9.TabIndex = 2;
            this.button9.Text = "Consultant Schedule Report";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(63, 145);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(182, 51);
            this.button8.TabIndex = 1;
            this.button8.Text = "Appointment Type Report";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // CalendarView
            // 
            this.CalendarView.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalendarView.Location = new System.Drawing.Point(63, 64);
            this.CalendarView.Name = "CalendarView";
            this.CalendarView.Size = new System.Drawing.Size(182, 51);
            this.CalendarView.TabIndex = 0;
            this.CalendarView.Text = "Calendar View";
            this.CalendarView.UseVisualStyleBackColor = true;
            this.CalendarView.Click += new System.EventHandler(this.CalendarView_Click);
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvCustomers.Location = new System.Drawing.Point(33, 39);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.Size = new System.Drawing.Size(743, 220);
            this.dgvCustomers.TabIndex = 0;
            this.dgvCustomers.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.clearSelection);
            // 
            // AddCustButton
            // 
            this.AddCustButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCustButton.Location = new System.Drawing.Point(524, 275);
            this.AddCustButton.Name = "AddCustButton";
            this.AddCustButton.Size = new System.Drawing.Size(80, 29);
            this.AddCustButton.TabIndex = 1;
            this.AddCustButton.Text = "Add";
            this.AddCustButton.UseVisualStyleBackColor = true;
            this.AddCustButton.Click += new System.EventHandler(this.AddCustButton_Click);
            // 
            // ModifyCustButton
            // 
            this.ModifyCustButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyCustButton.Location = new System.Drawing.Point(610, 275);
            this.ModifyCustButton.Name = "ModifyCustButton";
            this.ModifyCustButton.Size = new System.Drawing.Size(80, 29);
            this.ModifyCustButton.TabIndex = 2;
            this.ModifyCustButton.Text = "Modify";
            this.ModifyCustButton.UseVisualStyleBackColor = true;
            this.ModifyCustButton.Click += new System.EventHandler(this.ModifyCustButton_Click);
            // 
            // custDeleteButton
            // 
            this.custDeleteButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custDeleteButton.Location = new System.Drawing.Point(696, 275);
            this.custDeleteButton.Name = "custDeleteButton";
            this.custDeleteButton.Size = new System.Drawing.Size(80, 29);
            this.custDeleteButton.TabIndex = 3;
            this.custDeleteButton.Text = "Delete";
            this.custDeleteButton.UseVisualStyleBackColor = true;
            this.custDeleteButton.Click += new System.EventHandler(this.custDeleteButton_Click);
            // 
            // CustomerGroupBox
            // 
            this.CustomerGroupBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CustomerGroupBox.Controls.Add(this.custDeleteButton);
            this.CustomerGroupBox.Controls.Add(this.ModifyCustButton);
            this.CustomerGroupBox.Controls.Add(this.AddCustButton);
            this.CustomerGroupBox.Controls.Add(this.dgvCustomers);
            this.CustomerGroupBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerGroupBox.Location = new System.Drawing.Point(39, 30);
            this.CustomerGroupBox.Name = "CustomerGroupBox";
            this.CustomerGroupBox.Size = new System.Drawing.Size(808, 326);
            this.CustomerGroupBox.TabIndex = 2;
            this.CustomerGroupBox.TabStop = false;
            this.CustomerGroupBox.Text = "Customers";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1259, 752);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CustomerGroupBox);
            this.Name = "Main";
            this.Text = "Main";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.CustomerGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button ModifyAppointmentButton;
		private System.Windows.Forms.Button AddAppointmentButton;
		private System.Windows.Forms.DataGridView dgvAppointments;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button CalendarView;
		private System.Windows.Forms.Button LogoffButton;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button AddCustButton;
        private System.Windows.Forms.Button ModifyCustButton;
        private System.Windows.Forms.Button custDeleteButton;
        private System.Windows.Forms.GroupBox CustomerGroupBox;
    }
}