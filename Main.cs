using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BOP3___Task1.Database;
using MySql.Data.MySqlClient;

namespace BOP3___Task1
{
	public partial class Main : Form
	{
		public static MySqlConnection _conn;
		public Main(MySqlConnection conn)
		{
			InitializeComponent();

			_conn = conn;
			CustomerManager CustomerMgr = new CustomerManager(_conn);
			MySqlDataReader CustomerData = CustomerMgr.getCustomerData();
			CustomerData.Read();
			dgvCustomers.DataSource = CustomerData;

			// MessageBox.Show("test");
		}

		private void LogoffButton_Click(object sender, EventArgs e)
		{
			this.Hide();
			DBConnection.closeConnection();
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

		private void ModifyAppointmentButton_Click(object sender, EventArgs e)
		{
			this.Hide();
			new ModifyAppointment().ShowDialog();
			this.Show();
		}

		private void CalendarView_Click(object sender, EventArgs e)
		{
			this.Hide();
			new CalendarView().ShowDialog();
			this.Show();
		}

    }
}
