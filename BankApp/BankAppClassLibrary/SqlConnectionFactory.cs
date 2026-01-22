using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppClassLibrary
{
    public interface IConnectionFactory
    {
        //SqlConnection CreateConnection();
    }

    public class SqlConnectionFactory : IConnectionFactory
    {
        private readonly string _connectionString;

        public SqlConnectionFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        //public SqlConnection CreateConnection()
        //{
        //    return new SqlConnection(_connectionString);
        //}
    }
}
