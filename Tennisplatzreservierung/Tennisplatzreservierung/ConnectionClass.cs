using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennisplatzreservierung
{
    class ConnectionClass
    {
        private OdbcConnection connection = null;

        private OdbcConnection Connection
        {
            get
            {
                if (connection == null)
                {
                    string connectionString = "Driver={MySQL ODBC 5.2 UNICODE Driver}; Server=htlvb-projekt; Database=4ahwii_truong; User=4ahwii_luger;Password=Paul; Option=3;";
                    connection = new OdbcConnection(connectionString);
                }
                return connection;
            }
        }

        public ConnectionClass()
        {
        }

        public OdbcConnection GetConnection()
        {
            return Connection;
        }
    }
}
