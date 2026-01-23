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
        //void GetAllTRansactions(clsTransactions Transactions);
        Task<MCustomers> AddCustomers(MCustomers customers);
        Task<List<MCustomers>> GetCustomers(string strId);

        Task<MAccounts> AddAccounts(MAccounts Accounts);
        Task<List<MAccounts>> GetAccount(string strId);
        //clsTransactions AddTransaction(Dictionary<string, object> parameters, string strProcedure);
        //void DeleteTransaction(string strid);
     }
}
