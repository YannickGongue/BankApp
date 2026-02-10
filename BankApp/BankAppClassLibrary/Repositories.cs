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

        public async Task<MCustomers> AddCustomers(MCustomers customers)
        {
           
            this._dbContext.Customer.Add(customers);
            await this._dbContext.SaveChangesAsync();

            return customers;
        }

        public async Task<List<MCustomers>> GetCustomers(string strId)
        {
            return await _dbContext.Customer
                     .Where(c => c.CustomerId == strId)
                     .ToListAsync();
        }

        public async Task<MAccounts> AddAccounts(MAccounts mAccount)
        {
            this._dbContext.Account.Add(mAccount);
            await this._dbContext.SaveChangesAsync();

            return mAccount;
        }

        public async Task<List<MAccounts>> GetAccount(string strId)
        {
            return await _dbContext.Account
                     .Where(a => a.AccountId == strId)
                     .ToListAsync();
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
