using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Windows.Forms;
using System.Globalization;
using System.Data;
using System.ComponentModel;

namespace BOP3___Task1
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();

			DisplayLanguage();

		}

		private void DisplayLanguage() 
		{
			switch (RegionInfo.CurrentRegion.EnglishName) 
			{
				case "United States":
					DisplayEnglish();
					break;
				case "Colombia":
					DisplaySpanish();
					break;
				default:
					DisplayEnglish();
					break;
			}
		}

		private void DisplayEnglish() 
		{
			UsernameLabel.Text = "Username:";
			PasswordLabel.Text = "Password:";
			LoginButton.Text = "Login";
			ExitButton.Text = "Exit";
		}

		private void DisplaySpanish() 
		{
			UsernameLabel.Text = "Usuario:";
			PasswordLabel.Text = "Contraseña:";
			LoginButton.Text = "Iniciar";
			ExitButton.Text = "Cancelar";
		}

		static public int VerifyUser(string userName, string password) 
		{
			MySqlCommand cmd = new MySqlCommand($"SELECT userId FROM user WHERE userName = '{userName}' AND password = '{password}'", c);
			MySqlDataReader rdr = cmd.ExecuteReader();

			if (rdr.HasRows) 
			{
				rdr.Read();
				DataHelper.setCurrentUserId(Convert.ToInt32(rdr[]));
			}
			return 0;
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
			Application.Exit();
		}


	}
}
