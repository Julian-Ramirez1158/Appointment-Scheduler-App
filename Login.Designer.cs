
namespace BOP3___Task1
{
	partial class Login
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
			this.Username = new System.Windows.Forms.Label();
			this.LoginButton = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.Schedulex = new System.Windows.Forms.Label();
			this.ExitButton = new System.Windows.Forms.Button();
			this.Password = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Username
			// 
			this.Username.AutoSize = true;
			this.Username.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Username.Location = new System.Drawing.Point(129, 97);
			this.Username.Name = "Username";
			this.Username.Size = new System.Drawing.Size(97, 18);
			this.Username.TabIndex = 0;
			this.Username.Text = "Username:";
			// 
			// LoginButton
			// 
			this.LoginButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LoginButton.Location = new System.Drawing.Point(132, 220);
			this.LoginButton.Name = "LoginButton";
			this.LoginButton.Size = new System.Drawing.Size(78, 30);
			this.LoginButton.TabIndex = 2;
			this.LoginButton.Text = "Login";
			this.LoginButton.UseVisualStyleBackColor = true;
			this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(232, 97);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(141, 20);
			this.textBox1.TabIndex = 3;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(230, 170);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(141, 20);
			this.textBox2.TabIndex = 3;
			// 
			// Schedulex
			// 
			this.Schedulex.AutoSize = true;
			this.Schedulex.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Schedulex.Location = new System.Drawing.Point(13, 13);
			this.Schedulex.Name = "Schedulex";
			this.Schedulex.Size = new System.Drawing.Size(120, 25);
			this.Schedulex.TabIndex = 4;
			this.Schedulex.Text = "Schedulex";
			// 
			// ExitButton
			// 
			this.ExitButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ExitButton.Location = new System.Drawing.Point(295, 220);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(78, 30);
			this.ExitButton.TabIndex = 2;
			this.ExitButton.Text = "Exit";
			this.ExitButton.UseVisualStyleBackColor = true;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// Password
			// 
			this.Password.AutoSize = true;
			this.Password.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Password.Location = new System.Drawing.Point(129, 170);
			this.Password.Name = "Password";
			this.Password.Size = new System.Drawing.Size(92, 18);
			this.Password.TabIndex = 1;
			this.Password.Text = "Password:";
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(526, 330);
			this.Controls.Add(this.Schedulex);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.LoginButton);
			this.Controls.Add(this.Password);
			this.Controls.Add(this.Username);
			this.Name = "Login";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label Username;
		private System.Windows.Forms.Button LoginButton;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label Schedulex;
		private System.Windows.Forms.Button ExitButton;
		private System.Windows.Forms.Label Password;
	}
}

