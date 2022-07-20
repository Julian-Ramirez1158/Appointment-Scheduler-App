using MySql.Data.MySqlClient;
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
	public partial class ModifyCustomer : Form
	{
		public static MySqlConnection _conn;
		public ModifyCustomer(int modCustomerIndex, string custName, string custAddress, string custCity, 
								string custCountry, string custPostalCode, string custPhoneNumber)
		{
			InitializeComponent();

			idBox.Text = modCustomerIndex.ToString();
			nameBox.Text = custName;
			addressBox.Text = custAddress;
			cityBox.Text = custCity;
			countryBox.Text = custCountry;
			postalCodeBox.Text = custPostalCode;
			phoneNumberBox.Text = custPhoneNumber;

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
				CustomerManager.modCustomer(Convert.ToInt32(idBox.Text), nameBox.Text, addressBox.Text, cityBox.Text, countryBox.Text, 
											postalCodeBox.Text, phoneNumberBox.Text);
            }





			this.Hide();
			new Main(_conn).ShowDialog();
			this.Show();
		}


		private void CancelButton_Click_1(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
