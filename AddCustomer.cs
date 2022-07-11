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

namespace BOP3___Task1
{
	public partial class AddCustomer : Form
	{
		public AddCustomer()
		{
			InitializeComponent();
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			int countryID = CustomerManager.addCountry(countryBox.Text);
			int cityID = CustomerManager.addCity(countryID, cityBox.Text);
			int addressID = CustomerManager.addAddress(cityID, addressBox.Text, postalCodeBox.Text, phoneNumberBox.Text);
			
			

			CustomerManager.addCustomer(CustomerManager.updateID("customer", "customerId") + 1, nameBox.Text, addressID, int active, );













			this.Hide();
		}

		private void AddCustCancelButton_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		
	}
}
