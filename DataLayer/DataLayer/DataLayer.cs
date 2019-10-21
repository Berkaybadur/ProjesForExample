using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DataLayer
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        public void ExecuteCommand(string cmdText, SqlParameter[] parameters)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlCommand command = new SqlCommand(cmdText, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(parameters);
            command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
        }


        public DataTable ExecuteAdapter(string cmdText)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(cmdText, connectionString);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable ExecuteAdapter(string cmdText, SqlParameter[] parameters)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(cmdText, connectionString);
            adapter.SelectCommand.Parameters.AddRange(parameters);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
