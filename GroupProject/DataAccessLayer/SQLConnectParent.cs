using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class SQLConnectParent
    {
        protected string CONNECTION_STRING;

        public SQLConnectParent()
        {
            CONNECTION_STRING = "Server = mssqlstud.fhict.local;" +
                               "Database = dbi499309_bazaar;" +
                               "User Id = dbi499309_bazaar;" +
                               "Password = 1234password;";
        }
    }
}
