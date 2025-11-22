using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.Data.SqlClient;
using System.Data;

namespace BankAppClassLibrary
{
    public class clsDatabaseManager
    {         
        private IRepository _irepo;

        public clsDatabaseManager( IRepository irepo)
        {
            this._irepo = irepo;
        }
        
        public DataTable SetAllTransaction(string strQuery)
        {
           return  this._irepo.GetAllTRansactions(strQuery);               
        }

        public void setAllChange(DataSet dsDataset, string strTable, string strQuery)
        {
            this._irepo.GetAllChanges(dsDataset, strTable,strQuery);
        }

        public void AddTransaction(Dictionary<string, object> parameters, string strProcedure)
        {
            this._irepo.AddTransaction(parameters, strProcedure);                
                                  
        }

        
        public void DeleteTransaction(string strQuery)
        {
            this._irepo.DeleteTransaction(strQuery);              
        }
    }
}
