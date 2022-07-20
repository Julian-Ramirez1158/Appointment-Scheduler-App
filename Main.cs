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
			// check for row selection and null values
			if (dgvCustomers.CurrentRow == null || !dgvCustomers.CurrentRow.Selected)
			{
				MessageBox.Show("Nothing was selected! Please select a customer to modify.");
				return;
			}


			int selectedCustomerIndex = Convert.ToInt32(dgvCustomers.Rows[dgvCustomers.CurrentCell.RowIndex].Cells[0].Value);
			string custName = Convert.ToString(dgvCustomers.Rows[dgvCustomers.CurrentCell.RowIndex].Cells[1].Value);
			string custAddress = Convert.ToString(dgvCustomers.Rows[dgvCustomers.CurrentCell.RowIndex].Cells[2].Value);
			string custCity = Convert.ToString(dgvCustomers.Rows[dgvCustomers.CurrentCell.RowIndex].Cells[3].Value);
			string custCountry = Convert.ToString(dgvCustomers.Rows[dgvCustomers.CurrentCell.RowIndex].Cells[4].Value);
			string custPostalCode = Convert.ToString(dgvCustomers.Rows[dgvCustomers.CurrentCell.RowIndex].Cells[5].Value);
			string custPhoneNumber = Convert.ToString(dgvCustomers.Rows[dgvCustomers.CurrentCell.RowIndex].Cells[6].Value);

			if (selectedCustomerIndex != -1)
            {
				this.Hide();
				ModifyCustomer modCustomer = new ModifyCustomer(selectedCustomerIndex, custName, custAddress, custCity, custCountry, custPostalCode, custPhoneNumber);
				modCustomer.ShowDialog();
				this.Show();
			}
		}

		private void custDeleteButton_Click(object sender, EventArgs e)
		{
			// check for row selection and null values
			if (dgvCustomers.CurrentRow == null || !dgvCustomers.CurrentRow.Selected)
            {
				MessageBox.Show("Nothing was selected! Please select a customer to delete.");
				return;
            }

			DialogResult deleteCustomerAnswer = MessageBox.Show("Are you sure want to delete this customer?", "Confirmation" , MessageBoxButtons.YesNo);
			int selectedCustomer = Convert.ToInt32(dgvCustomers.Rows[dgvCustomers.CurrentCell.RowIndex].Cells[0].Value);


			if (deleteCustomerAnswer == DialogResult.Yes)
            {
				CustomerManager customers = new CustomerManager();
				customers.deleteCust(selectedCustomer);
				dgvCustomers.DataSource = customers.getCustomerData();
			}
			else
            {
				return;
            }
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


		// these clear selection of rows in datagirds upon opening the application
        private void clearSelection(object sender, DataGridViewBindingCompleteEventArgs e)
        {
			dgvCustomers.ClearSelection();
        }

        private void clearSelection2(object sender, DataGridViewBindingCompleteEventArgs e)
        {
			dgvAppointments.ClearSelection();
        }

    }
}
