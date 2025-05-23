using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Fire_Sales___Sales_Management_System.Helpers.Extensions;
using System.Data;

namespace Fire_Sales___Sales_Management_System.Helpers.Database_Helpers
{
    public class MySQLManager: DatabaseManager
    {
        private readonly string _connectionString;

        public MySQLManager(string connectionString): base(connectionString)
        {
            _connectionString = connectionString;
        }

        
        public override int ExecuteNonQuery(string query, Dictionary<string, object> parameters = null)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    AddParameters(command, parameters);
                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
        }

        public override object ExecuteScalar(string query, Dictionary<string, object> parameters = null)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    AddParameters(command, parameters);
                    connection.Open();
                    return command.ExecuteScalar();
                }
            }
        }

        public override List<T> ExecuteToList<T>(string query, Dictionary<string, object> parameters = null)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    AddParameters(command, parameters);
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        return reader.MapToList<T>();
                    }
                }
            }
        }

        public override DataTable ExecuteDataTable(string query, Dictionary<string, object> parameters = null)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    AddParameters(command, parameters);
                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        var table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }
            }
        }

        private void AddParameters(MySqlCommand command, Dictionary<string, object> parameters)
        {
            if (parameters == null) return;

            foreach (var param in parameters)
            {
                command.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
            }
        }


    }
}
