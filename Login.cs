using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace BOP3___Task1
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		private void LoginButton_Click(object sender, EventArgs e)
		{
			//// get connection string
			//string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;

			//// Make connection
			//MySqlConnection conn = null;

			//try
			//{
			//	conn = new MySqlConnection(constr);

			//	//open connection
			//	conn.Open();

			//}
			//catch (MySqlException ex)
			//{
			//	MessageBox.Show(ex.Message);
			//}
			//finally 
			//{
			//	//close connection
			//	if (conn != null) 
			//	{
			//		conn.Close();	
			//	}
			//}


			this.Hide();
			new Main().ShowDialog();
		}

		private void ExitButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Password_Click(object sender, EventArgs e)
		{

		}
	}
}
