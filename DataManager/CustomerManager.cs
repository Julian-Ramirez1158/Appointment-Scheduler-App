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
        //public int ID { get; set; }
        //public string CustomerName { get; set; }
        //public string Address { get; set; }
        //public string City { get; set; }
        //public string Country { get; set; }
        //public string PostalCode { get; set; }
        //public string PhoneNumber { get; set; }

        //public CustomerManager (int _id, string _customerName, string _address, string _city, string _country, string _postalCode, string _phoneNumber)
        //{
        //    ID = _id;
        //    CustomerName = _customerName;
        //    Address = _address;
        //    City = _city;
        //    Country = _country;
        //    PostalCode = _postalCode;
        //    PhoneNumber = _phoneNumber;
        //}



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

        public static string sqlDate (DateTime date)
        {
            string sqlFormat = date.ToString("yyyy-MM-dd HH:mm");

            return sqlFormat;
        }

        public static void addCustomer(int _id, string _customerName, int _addressId, int active, DateTime _dateTime, string user)
        {
            string date = sqlDate(_dateTime);

            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            MySqlTransaction insertTransaction = conn.BeginTransaction();

            string query = "INSERT into customer (customerId, customerName, addressId, active, createDate, createdBy, lastUpdateBy) " +
                            $"VALUES ('{_id}', '{_customerName}', '{_addressId}', '{active}', '{sqlDate(_dateTime)}', '{user}', '{user}')";

            MySqlCommand command = new MySqlCommand(query, conn);
            command.Transaction = insertTransaction;
            command.ExecuteNonQuery();
            insertTransaction.Commit();
            conn.Close();
        }

        public static int updateID (string schema, string _id)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            string query = $"SELECT max({_id}) FROM {schema}";
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader dataReader = command.ExecuteReader();

            if (dataReader.HasRows)
            {
                dataReader.Read();
                if (dataReader[0] == DBNull.Value)
                {
                    return 0;
                }
                return Convert.ToInt32(dataReader[0]);
            }
            return 0;
        }




        

    }
}
