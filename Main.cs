using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOP3___Task1
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
		}

		private void LogoffButton_Click(object sender, EventArgs e)
		{
			this.Hide();
			new Login().ShowDialog();
		}

		private void AddCustButton_Click(object sender, EventArgs e)
		{
			this.Hide();
			new AddCustomer().ShowDialog();
			this.Show();
		}

		private void ModifyCustButton_Click(object sender, EventArgs e)
		{
			this.Hide();
			new ModifyCustomer().ShowDialog();
			this.Show();
		}

		private void AddAppointmentButton_Click(object sender, EventArgs e)
		{
			this.Hide();
			new AddAppointment().ShowDialog();
			this.Show();
		}
	}
}
