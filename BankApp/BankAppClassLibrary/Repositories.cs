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
        private List<MCustomers> ltCustomers;

        public Repositories( dbBankAppContext dbContext)
        {
            _dbContext = dbContext;
        }

        //public SqlConnection GetConnection()
        //{
        //    SqlConnection sqlconManager = this._factory.CreateConnection();
        //    return sqlconManager;
        //}

        public DataTable GetAllTRansactions(string strQuery)
        {
            DataTable dt = new DataTable();           
            //SqlCommand sqlcmd = new SqlCommand(strQuery, this.GetConnection());
            //SqlDataAdapter sdaAdapter = new SqlDataAdapter(sqlcmd);
            //this.GetConnection().Open();
            //sdaAdapter.Fill(dt);
            
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

        
        public void DeleteTransaction(string strQuery)
        {       
            //SqlCommand sqlcmd = new SqlCommand(strQuery, this.GetConnection());
            //this.GetConnection().Open();
            // sqlcmd.ExecuteNonQuery();      
        }
    }
}
