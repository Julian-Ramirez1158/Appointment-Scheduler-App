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

		public static MySqlConnection startConnection() 
		{

			// get connection string
			string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;

			try
			{
				conn = new MySqlConnection(constr);



				if (conn != null)
                {
					//open connection
					conn.Open();
					return conn;
                }
				else
                {
					return null;
                }

				// MessageBox.Show("Connection is open");
			}
			catch (MySqlException ex)
			{
				MessageBox.Show(ex.Message);
				return null;
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
					// MessageBox.Show("Connection closed!");
				}
			}
			catch (MySqlException ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

	}



}
