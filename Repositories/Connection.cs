using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class Connection
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;

        public Connection() 
        {
            var connectionString = ConfigurationManager.AppSettings["StringConnection"].ToString();
            connection = new SqlConnection(connectionString);
        }

        public SqlDataReader GetComand(string sql) 
        {
            command = new SqlCommand(sql, connection);
            connection.Open();
            reader = command.ExecuteReader();
            return reader;
        }

        public void Execute(string sql)
        {
            command = new SqlCommand(sql, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Close() {
            connection.Close();
            reader.Close();
        }
    }
}
