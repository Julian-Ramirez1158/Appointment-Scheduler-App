using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BOP3___Task1.DataManager;
using MySql.Data.MySqlClient;

namespace BOP3___Task1
{
	public partial class AddCustomer : Form
	{
		public static MySqlConnection _conn;
		public AddCustomer()
		{
			InitializeComponent();
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{

			if ((string.IsNullOrEmpty(nameBox.Text) || string.IsNullOrWhiteSpace(nameBox.Text)) ||
				(string.IsNullOrEmpty(addressBox.Text) || string.IsNullOrWhiteSpace(addressBox.Text)) ||
				(string.IsNullOrEmpty(cityBox.Text) || string.IsNullOrWhiteSpace(cityBox.Text)) ||
				(string.IsNullOrEmpty(countryBox.Text) || string.IsNullOrWhiteSpace(countryBox.Text)) ||
				(string.IsNullOrEmpty(postalCodeBox.Text) || string.IsNullOrWhiteSpace(postalCodeBox.Text)) ||
				(string.IsNullOrEmpty(phoneNumberBox.Text) || string.IsNullOrWhiteSpace(phoneNumberBox.Text))
				)
            {
				MessageBox.Show("Please ensure all fields are completed");
            }
			else
            {
				int active = 1;
				int countryID = CustomerManager.addCountry(countryBox.Text);
				int cityID = CustomerManager.addCity(countryID, cityBox.Text);
				int addressID = CustomerManager.addAddress(cityID, addressBox.Text, postalCodeBox.Text, phoneNumberBox.Text);



				CustomerManager.addCustomer(CustomerManager.updateID("customer", "customerId") + 1,
											nameBox.Text, addressID, active, CustomerManager.dateTime(), UserManager.PullCurrentUserName());


				this.Hide();
				new Main(_conn).ShowDialog();
				this.Show();
			}

		}

		private void AddCustCancelButton_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		
	}
}
