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

        public static string sqlDate (DateTime date)
        {
            string sqlFormat = date.ToString("yyyy-MM-dd HH:mm");

            return sqlFormat;
        }

        public static DateTime dateTime()
        {
            return DateTime.Now.ToUniversalTime();
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

        public static void modCustomer(int customerId, string customerName, string customerAddress, string customerCity, string customerCountry, 
                                        string customerPostalCode, string customerPhoneNumber)
        {
            MySqlConnection conn = new MySqlConnection(connString);

            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            // Do query to get address from cust record
            string query1 = $"SELECT addressId FROM customer WHERE customerId = {customerId}";
            MySqlCommand command1 = new MySqlCommand(query1, conn);
            int selectedAddressId;
            using (MySqlDataReader dataReader = command1.ExecuteReader())
            {
                dataReader.Read();
                selectedAddressId = Convert.ToInt32(dataReader[0]);
            }

            // Do query to get city from address record
            string query2 = $"SELECT cityId FROM address WHERE addressId = {selectedAddressId}";
            command1 = new MySqlCommand(query2, conn);
            int selectedCityId;
            using (MySqlDataReader dataReader = command1.ExecuteReader())
            {
                dataReader.Read();
                selectedCityId = Convert.ToInt32(dataReader[0]);
            }

            // Do query to get country from city record
            string query3 = $"SELECT countryId FROM city WHERE cityId = {selectedCityId}";
            command1 = new MySqlCommand(query3, conn);
            int selectedCountryId;
            using (MySqlDataReader dataReader = command1.ExecuteReader())
            {
                dataReader.Read();
                selectedCountryId = Convert.ToInt32(dataReader[0]);
            }

            // Update queries

            // Customer update query
            command.CommandText = $"UPDATE customer SET customerName = '{customerName}'" +
                $", lastUpdate = '{sqlDate(dateTime())}', lastUpdateBy = '{UserManager.PullCurrentUserName()}' WHERE customerId = {customerId} ";
            command.ExecuteNonQuery();

            // Address update query
            command.CommandText = $"UPDATE address SET address = '{customerAddress}', postalCode = '{customerPostalCode}', " +
                $"phone = '{customerPhoneNumber}', lastUpdate = '{sqlDate(dateTime())}', lastUpdateBy = '{UserManager.PullCurrentUserName()}' " +
                $"WHERE addressId = {selectedAddressId}";
            command.ExecuteNonQuery();

            // City update query
            command.CommandText =  $"UPDATE city SET city = '{customerCity}', lastUpdate = '{sqlDate(dateTime())}', " +
                $"lastUpdateBy = '{UserManager.PullCurrentUserName()}' WHERE cityId = {selectedCityId}";
            command.ExecuteNonQuery();

            // Country update query
            command.CommandText = $"UPDATE country SET country = '{customerCountry}', lastUpdate = '{sqlDate(dateTime())}', " +
                $"lastUpdateBy = '{UserManager.PullCurrentUserName()}' WHERE countryId = {selectedCountryId}";
            command.ExecuteNonQuery();

            conn.Close();

        }

        public static int updateID(string schema, string _id)
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

        public static int addCountry (string country)
        {
            int countryID = updateID("country", "countryId") + 1;

            string userName = UserManager.PullCurrentUserName();
            DateTime UTC = dateTime();

            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            MySqlTransaction insertTransaction = conn.BeginTransaction();

            string query = "INSERT into country (countryId, country, createDate, createdBy, lastUpdateBy) " +
                            $"VALUES ('{countryID}', '{country}', '{sqlDate(UTC)}', '{userName}', '{userName}')";
            MySqlCommand command = new MySqlCommand(query, conn);
            command.Transaction = insertTransaction;
            command.ExecuteNonQuery();
            insertTransaction.Commit();
            conn.Close();

            return countryID;

        }

        public static int addCity(int countryID, string city)
        {
            int cityID = updateID("city", "cityId") + 1;

            string userName = UserManager.PullCurrentUserName();
            DateTime UTC = dateTime();

            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            MySqlTransaction insertTransaction = conn.BeginTransaction();

            string query = "INSERT into city (cityId, city, countryId, createDate, createdBy, lastUpdate, lastUpdateBy) " +
                            $"VALUES ('{cityID}', '{city}', '{countryID}', '{sqlDate(UTC)}', '{userName}', '{sqlDate(UTC)}', '{userName}')";
            MySqlCommand command = new MySqlCommand(query, conn);
            command.Transaction = insertTransaction;
            command.ExecuteNonQuery();
            insertTransaction.Commit();
            conn.Close();

            return cityID;

        }

        public static int addAddress (int cityID, string address, string postalCode, string phoneNumber)
        {
            int addressID = updateID("address", "addressId") + 1;

            string userName = UserManager.PullCurrentUserName();
            DateTime UTC = dateTime();

            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            MySqlTransaction insertTransaction = conn.BeginTransaction();

            string query = "INSERT into address (addressId, address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdateBy) " +
                            $"VALUES ('{addressID}', '{address}', '{address}', '{cityID}', '{postalCode}', '{phoneNumber}', '{sqlDate(UTC)}', '{userName}', '{userName}')";
            MySqlCommand command = new MySqlCommand(query, conn);
            command.Transaction = insertTransaction;
            command.ExecuteNonQuery();
            insertTransaction.Commit();
            conn.Close();

            return addressID;
        }

        public bool deleteCust (int customerId)
        {
            MySqlConnection conn = new MySqlConnection(connString);

            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            // Do query to get address from cust record
            string query1 = $"SELECT addressId FROM customer WHERE customerId = {customerId}";
            MySqlCommand command1 = new MySqlCommand(query1, conn);
            int selectedAddress; 
            using (MySqlDataReader dataReader = command1.ExecuteReader())
            {
                dataReader.Read();                                
                selectedAddress =  Convert.ToInt32(dataReader[0]); 
            }

            // Do query to get city from address record
            string query2 = $"SELECT cityId FROM address WHERE addressId = {selectedAddress}";
            command1 = new MySqlCommand(query2, conn);
            int selectedCity;
            using (MySqlDataReader dataReader = command1.ExecuteReader())
            {
                dataReader.Read();
                selectedCity = Convert.ToInt32(dataReader[0]);
            }

            // Do query to get country from city record
            string query3 = $"SELECT countryId FROM city WHERE cityId = {selectedCity}";
            command1 = new MySqlCommand(query3, conn);
            int selectedCountry;
            using (MySqlDataReader dataReader = command1.ExecuteReader())
            {
                dataReader.Read();
                selectedCountry = Convert.ToInt32(dataReader[0]);
            }

            // command.CommandText to delete country record
            // command.CommandText to delete city record
            // command.CommandText to delete address record
            command.CommandText = $"DELETE FROM customer WHERE customerId = {customerId}";
            // command.Parameters.AddWithValue($"{customerId}", customerId);
            command.ExecuteNonQuery();
            command.CommandText = $"DELETE FROM address WHERE addressId = {selectedAddress}";
            command.ExecuteNonQuery();
            command.CommandText = $"DELETE FROM city WHERE cityId = {selectedCity}";
            command.ExecuteNonQuery();
            command.CommandText = $"DELETE FROM country WHERE countryId = {selectedCountry}";
            command.ExecuteNonQuery();

            conn.Close();

            //TO DO
            // Delete appointments associated with customers
            
  

            return true;
        }


    }
}
