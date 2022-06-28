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

			CustomerManager customers = new CustomerManager();

			dgvCustomers.DataSource = customers.getCustomerData();
			
			//using (conn)
   //         {
			//	using (MySqlCommand command = new MySqlCommand("SELECT CU.customerId, CU.customerName, CONCAT(AD.address , ', ' , CI.city , ', ' , CO.country), " +
			//"AD.postalCode, AD.phone " +
			//"FROM customer AS CU, address AS AD, city AS CI, country AS CO " +
			//"WHERE CU.addressId = AD.addressId AND AD.cityId = CI.cityId AND CI.countryId = CO.countryId;", conn))
   //             {
			//		command.CommandType = CommandType.Text;
			//		using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
			//		{
			//			using (DataTable dataTable = new DataTable())
   //                     {
			//				adapter.Fill(dataTable);
			//				dgvCustomers.DataSource = dataTable;
			//			}
   //                 }
   //             }
   //         }
			//CustomerManager CustomerMgr = new CustomerManager(_conn);
			//MySqlDataReader CustomerData = CustomerMgr.getCustomerData();
			//CustomerData.Read();
			//dgvCustomers.DataSource = CustomerData;

			// MessageBox.Show("test");

			//MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT CU.customerId, CU.customerName, CONCAT(AD.address , ', ' , CI.city , ', ' , CO.country), " +
			//"AD.postalCode, AD.phone " +
			//"FROM customer AS CU, address AS AD, city AS CI, country AS CO " +
			//"WHERE CU.addressId = AD.addressId AND AD.cityId = CI.cityId AND CI.countryId = CO.countryId;", conn);

			//DataTable dataTable = new DataTable();
			//adapter.Fill(dataTable);
			//dgvCustomers.DataSource = dataTable;
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
