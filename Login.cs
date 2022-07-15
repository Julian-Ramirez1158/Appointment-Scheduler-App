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
        public static MySqlConnection conn = null;
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
            conn = DBConnection.startConnection();
            MySqlCommand command1 = new MySqlCommand(
                $"SELECT userId FROM user WHERE userName = '{userName}' AND password = '{password}'", 
                conn
               );
            MySqlDataReader dataReader = command1.ExecuteReader();

            if (dataReader.HasRows)
            {
                dataReader.Read();
                UserManager.AssignCurrentUserID(Convert.ToInt32(dataReader[0]));
                UserManager.AssignCurrentUserName(userName);
                dataReader.Close();
                return UserManager.PullCurrentUserID();
            }
            return 0;
        }

        private void LoginButton_Click(object sender, EventArgs e)
		{

            if (VerifyUser(usernameTextBox.Text, passwordTextBox.Text) != 0)
            {
                this.Hide();
                new Main(conn).ShowDialog();
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
