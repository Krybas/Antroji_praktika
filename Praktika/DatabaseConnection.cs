using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Praktika
{
    public class DatabaseConnection
    {
        private MySqlConnection connection;
        private string connectionString;
        public DatabaseConnection()
        {
            connectionString = "Server=localhost; Database=new_schema; Uid=root; Password=1234; Port=3306;";
            connection = new MySqlConnection(connectionString);
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
