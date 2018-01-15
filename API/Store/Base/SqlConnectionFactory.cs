using CMMI.Store.Contracts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CMMI.Store.Base
{
    public class SqlConnectionFactory : IDbConnectionFactory
    {
        public IDbConnection CreateConnection()
        {
            SqlConnection sqlConnection = new SqlConnection("DefaultConnectionString");
            sqlConnection.Open();
            return (IDbConnection)sqlConnection;
        }
    }
}
