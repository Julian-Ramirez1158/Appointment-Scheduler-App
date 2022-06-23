﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOP3___Task1
{
    class DataManager
    {
        private static string _currentUserName;
        private static int _currentUserID;
        public static string connectionString = "Host=localhost;Port=3306;Database=client_schedule;Username=sqlUser;Password=Passw0rd!";

        public static int PullCurrentUserID()
        {
            return _currentUserID;
        }

        public static void AssignCurrentUserID(int currentUserID)
        {
            _currentUserID = currentUserID;
        }

        public static string PullCurrentUserName()
        {
            return _currentUserName;
        }

        public static void AssignCurrentUserName(string currentUserName)
        {
            _currentUserName = currentUserName;
        }

    }
}
