using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAppClassLibrary
{
    public class Repositories :  IRepository 
    {
              
        private dbBankAppContext _dbContext;

        public Repositories( dbBankAppContext dbContext)
        {
            _dbContext = dbContext;
        }

        public DataTable GetAllTRansactions(string strQuery)
        {
            DataTable dt = new DataTable();           
                 
            return dt;
        }

        public MCustomers AddCustomers(MCustomers customers)
        {
           
            this._dbContext.Customer.Add(customers);
            this._dbContext.SaveChanges();

            return customers;
        }

        public List<MCustomers> GetCustomers(string strId)
        {
            return _dbContext.Customer
                     .Where(c => c.CustomerId == strId)
                     .ToList();
        }

        public MAccounts AddAccounts(MAccounts mAccount)
        {
            this._dbContext.Account.Add(mAccount);
            this._dbContext.SaveChanges();

            return mAccount;
        }

        public List<MAccounts> GetAccount(string strId)
        {
            return _dbContext.Account
                     .Where(a => a.AccountId == strId)
                     .ToList();
        }

        public void AddTransaction(Dictionary<string, object> parameters, string strProcedure)
        {
            
                //SqlCommand sqlcmd = new SqlCommand(strProcedure, this.GetConnection());
                //sqlcmd.CommandType = CommandType.StoredProcedure;

                //foreach (var p in parameters)
                //{
                //    sqlcmd.Parameters.AddWithValue(p.Key, p.Value ?? DBNull.Value);
                //}

                //this.GetConnection().Open();
                //sqlcmd.ExecuteNonQuery();            
        }

        
        public void DeleteTransaction(string strId)
        {
            //this._dbContext.Account.(mAccount);
            //this._dbContext.SaveChanges();
            //SqlCommand sqlcmd = new SqlCommand(strQuery, this.GetConnection());
            //this.GetConnection().Open();
            // sqlcmd.ExecuteNonQuery();      
        }
    }
}
