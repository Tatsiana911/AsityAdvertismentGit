using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsityAdvertismentServer.Prefs
{
    public class Database
    {
        public string connectionString;

        public Database()
        {
            connectionString = @"Data Source=localhost\NODE1;Initial Catalog=AdvertismentTest;Persist Security Info=False;User ID=sa;Password=Pa$$w0rd";
        }
    }
}

