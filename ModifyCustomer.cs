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
		// private int _rowIndex;
		public ModifyCustomer(int modCustomerIndex)
		{
			InitializeComponent();
			//_rowIndex = modCustomerIndex;
			//idBox.Text = modCustomerIndex;
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
				
            }





			this.Hide();
		}


		private void CancelButton_Click_1(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
