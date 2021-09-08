using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace SamLop.Data
{
    public class SqlDataProvider
    {
        public static string connectionstring;
        public static SqlConnection connection;
        public SqlDataProvider()
        {
            if (connection == null)
            {
                StreamReader Re = File.OpenText("Config.txt");
                connectionstring=  Re.ReadLine();
                Re.Close();
                connection = new SqlConnection(connectionstring);
            }
        }
        public SqlConnection GetConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
                return connection;
            }
            else
            {
                return connection;
            }
        }
    }
}