using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Windows.Forms;
using System.Globalization;
using System.Data;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Text;
using BOP3___Task1.Database;

namespace BOP3___Task1
{
	public partial class Login : Form
	{

        public string loginError = "The username and password did not match";
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
                case "Mexico":
                    DisplaySpanish();
                    break;
                case "Spain":
                    DisplaySpanish();
                    break;
                case "Venezuela":
                    DisplaySpanish();
                    break;
                case "Argentina":
                    DisplaySpanish();
                    break;
                case "Peru":
                    DisplaySpanish();
                    break;
                case "Chile":
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
            topLabel.Text = "Please enter your login credentials below:";
        }

        private void DisplaySpanish()
        {
            loginError = "El usuario y la contraseña no coinciden.";
            UsernameLabel.Text = "Usuario:";
            PasswordLabel.Text = "Contraseña:";
            LoginButton.Text = "Iniciar";
            ExitButton.Text = "Cancelar";
            topLabel.Text = "Estimado cliente, por favor inicie su sesión:";
        }

        static public int VerifyUser(string userName, string password)
        {
            MySqlConnection conn = new MySqlConnection(DataManager.connectionString);
            conn.Open();
            MySqlCommand command1 = new MySqlCommand($"SELECT userId FROM user WHERE userName = '{userName}' AND password = '{password}'", conn);
            MySqlDataReader dataReader = command1.ExecuteReader();

            if (dataReader.HasRows)
            {
                dataReader.Read();
                DataManager.AssignCurrentUserID(Convert.ToInt32(dataReader[0]));
                DataManager.AssignCurrentUserName(userName);
                dataReader.Close();
                return DataManager.PullCurrentUserID();
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

            if (VerifyUser(usernameTextBox.Text, passwordTextBox.Text) != 0)
            {
                this.Hide();
                new Main().ShowDialog();
            }
            else
            {
                MessageBox.Show(loginError);
            }


			
			
		}

		private void ExitButton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}


	}
}
