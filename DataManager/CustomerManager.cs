using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace BOP3___Task1
{
    public class CustomerManager
    {

        private const string connString = "Host=localhost;Port=3306;Database=client_schedule;Username=sqlUser;Password=Passw0rd!";

        public DataTable getCustomerData()
        {
            MySqlConnection conn = new MySqlConnection(connString);

            DataTable allCustomers = new DataTable();

            if (!allCustomers.Columns.Contains("ID")) { allCustomers.Columns.Add("ID", typeof(int));  }
            if (!allCustomers.Columns.Contains("Customer Name")) { allCustomers.Columns.Add("Customer Name", typeof(string)); }
            if (!allCustomers.Columns.Contains("Address")) { allCustomers.Columns.Add("Address", typeof(string)); }
            if (!allCustomers.Columns.Contains("City")) { allCustomers.Columns.Add("City", typeof(string)); }
            if (!allCustomers.Columns.Contains("Country")) { allCustomers.Columns.Add("Country", typeof(string)); }
            if (!allCustomers.Columns.Contains("Postal Code")) { allCustomers.Columns.Add("Postal Code", typeof(string)); }
            if (!allCustomers.Columns.Contains("Phone")) { allCustomers.Columns.Add("Phone", typeof(string)); }

            conn.Open();

            string query = "SELECT CU.customerId, CU.customerName, AD.address, CI.city, CO.country," +
            "AD.postalCode, AD.phone " +
            "FROM customer AS CU, address AS AD, city AS CI, country AS CO " +
            "WHERE CU.addressId = AD.addressId AND AD.cityId = CI.cityId AND CI.countryId = CO.countryId;";

            MySqlCommand command1 = new MySqlCommand(query, conn);
            using (MySqlDataReader dataReader = command1.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    allCustomers.Rows.Add(
                        dataReader["customerId"], dataReader["customerName"], dataReader["address"], dataReader["city"], dataReader["country"],  dataReader["postalCode"], dataReader["phone"]);
                }
            }

                return allCustomers;
        }
        //private static MySqlConnection _conn;

        //private static string query = "SELECT CU.customerId, CU.customerName, CONCAT(AD.address , ', ' , CI.city , ', ' , CO.country), " +
        //    "AD.postalCode, AD.phone " +
        //    "FROM customer AS CU, address AS AD, city AS CI, country AS CO " +
        //    "WHERE CU.addressId = AD.addressId AND AD.cityId = CI.cityId AND CI.countryId = CO.countryId;";
        //public CustomerManager(MySqlConnection conn)
        //{
        //    _conn = conn;
        //}

        

        //public MySqlDataReader getCustomerData()
        //{
        //    //MySqlDataReader dataReader = null;

        //    //if (_conn != null)
        //    //{

        //    //    MySqlCommand command1 = new MySqlCommand(query, _conn);
        //    //    dataReader = command1.ExecuteReader();

        //    //    //if (dataReader.HasRows)
        //    //    //{

        //    //    //    while (dataReader.Read())
        //    //    //    {
        //    //    //        MessageBox.Show("dataReader", dataReader[0].ToString());
        //    //    //    }

        //    //    //    dataReader.Close();
        //    //    //}

        //    //}
        //    //return dataReader;


        //}

    }
}
