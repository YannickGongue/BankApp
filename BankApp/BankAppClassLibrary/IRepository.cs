using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppClassLibrary
{
     public interface IRepository
     {
        SqlConnection GetConnection();
        DataTable GetAllTRansactions(string strQuery);
        void GetAllChanges(DataSet dsDataset, string strTable, string strQuery);
        void AddTransaction(Dictionary<string, object> parameters, string strProcedure);
        void DeleteTransaction(string strQuery);
     }
}
