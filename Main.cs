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
using BOP3___Task1.DataManager;
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

			CustomerManager customers = new CustomerManager();

			dgvCustomers.DataSource = customers.getCustomerData();

			// selects full row in data grid
			dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

			// make data grid read only and turn multiselect off
			dgvCustomers.ReadOnly = true;
			dgvCustomers.MultiSelect = false;

			// remove blank bottom row
			dgvCustomers.AllowUserToAddRows = false;



			AppointmentManager appointments = new AppointmentManager();

			dgvAppointments.DataSource = appointments.getAppointmentData();

			// selects full row in data grid
			dgvAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

			// make data grid read only and turn multiselect off
			dgvAppointments.ReadOnly = true;
			dgvAppointments.MultiSelect = false;

			// remove blank bottom row
			dgvAppointments.AllowUserToAddRows = false;

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
