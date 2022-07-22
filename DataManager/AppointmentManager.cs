using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOP3___Task1.DataManager
{
    public class AppointmentManager
    {
        private const string connString = "Host=localhost;Port=3306;Database=client_schedule;Username=sqlUser;Password=Passw0rd!";


        public DataTable getAppointmentData(int customerID)
        {
            MySqlConnection conn = new MySqlConnection(connString);

            DataTable allAppointments = new DataTable();

            if (!allAppointments.Columns.Contains("Appointment ID")) { allAppointments.Columns.Add("Appointment ID", typeof(int)); }
            if (!allAppointments.Columns.Contains("Customer ID")) { allAppointments.Columns.Add("Customer ID", typeof(int)); }
            if (!allAppointments.Columns.Contains("User ID")) { allAppointments.Columns.Add("User ID", typeof(int)); }
            if (!allAppointments.Columns.Contains("Description")) { allAppointments.Columns.Add("Description", typeof(string)); }
            if (!allAppointments.Columns.Contains("Location")) { allAppointments.Columns.Add("Location", typeof(string)); }
            if (!allAppointments.Columns.Contains("Type")) { allAppointments.Columns.Add("Type", typeof(string)); }
            if (!allAppointments.Columns.Contains("Start")) { allAppointments.Columns.Add("Start", typeof(string)); }
            if (!allAppointments.Columns.Contains("End")) { allAppointments.Columns.Add("End", typeof(string)); }


            conn.Open();

            string query = $"SELECT appointmentId, customerId, userId, description, location , type, start, end FROM appointment WHERE customerId = {customerID};";

            // Add where clause to select customer from customer datagrid

            MySqlCommand command1 = new MySqlCommand(query, conn);
            using (MySqlDataReader dataReader = command1.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    allAppointments.Rows.Add(
                        dataReader["appointmentId"], dataReader["customerId"], dataReader["userId"],
                        dataReader["description"], dataReader["location"], dataReader["type"],
                        dataReader["start"], dataReader["end"]);
                }
            }

            return allAppointments;
        }



    }
}
