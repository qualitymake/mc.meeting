using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace mc.meeting.DAL
{
    public class SQLConnect
    {
        public static SqlConnection GetConnection()
        {
            try
            {
                string connectionString = "";
                SqlConnection _connection = new SqlConnection();
                _connection.ConnectionString = connectionString;
                if(_connection.State != ConnectionState.Open)
                {
                    _connection.Open();
                }
                return _connection;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}
