using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOP3___Task1
{
    public class CustomerManager
    {
        private static MySqlConnection _conn;

        private static string query = "SELECT CU.customerId, CU.customerName, CONCAT(AD.address , ', ' , CI.city , ', ' , CO.country), " +
            "AD.postalCode, AD.phone " +
            "FROM customer AS CU, address AS AD, city AS CI, country AS CO " + 
            "WHERE CU.addressId = AD.addressId AND AD.cityId = CI.cityId AND CI.countryId = CO.countryId;";
        public CustomerManager(MySqlConnection conn) 
        {
            _conn = conn;
        }

        public MySqlDataReader getCustomerData()
        {
            MySqlDataReader dataReader = null;

            if (_conn != null)
            {

                MySqlCommand command1 = new MySqlCommand(query, _conn);
                dataReader = command1.ExecuteReader();

                //if (dataReader.HasRows)
                //{

                //    while (dataReader.Read())
                //    {
                //        MessageBox.Show("dataReader", dataReader[0].ToString());
                //    }

                //    dataReader.Close();
                //}

            }
            return dataReader;
        }

    }
}
