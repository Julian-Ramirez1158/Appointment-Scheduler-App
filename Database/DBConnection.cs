using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOP3___Task1.Database
{
	public class DBConnection
	{

		public static MySqlConnection conn { get; set; }

		public static void startConnection() 
		{

			// get connection string
			string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;

			try
			{
				conn = new MySqlConnection(constr);

				//open connection
				conn.Open();

				// MessageBox.Show("Connection is open");
			}
			catch (MySqlException ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		public static void closeConnection()
		{
			//close connection
			try
			{
				if (conn != null)
				{
					conn.Close();
				}
			}
			catch (MySqlException ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

	}



}
