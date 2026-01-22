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
        //SqlConnection GetConnection();
        //void GetAllTRansactions(clsTransactions Transactions);
        MCustomers AddCustomers(MCustomers customers);
        List<MCustomers> GetCustomers(string strId);

        //clsAccounts AddAccounts(clsAccounts Accounts);
        //clsAccounts GetAccounts(string strId);
        //clsTransactions AddTransaction(Dictionary<string, object> parameters, string strProcedure);
        //void DeleteTransaction(string strid);
     }
}
