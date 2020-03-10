using Microsoft.Extensions.Configuration;
using System;
using System.Data.Common;
using System.Data.SqlClient;

namespace CalendarioBlazor.Data._Infra
{
    public class MSSQL : IDB, IDisposable
    {
        private SqlConnection _connection;
        private IConfiguration _configuration;
        public MSSQL(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void Dispose()
        {
            _connection.Close();
            _connection.Dispose();
        }

        public DbConnection GetConnection()
        {
            return _connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
        }
    }
}
