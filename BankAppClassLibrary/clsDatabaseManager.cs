using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Data;

namespace BankAppClassLibrary
{
    public class clsDatabaseManager
    {
       
        private SqlConnection sqlconManager;
        private SqlDataAdapter sdaAdapter;
        private string strConnectionString;      
        private string strQuery;

        public clsDatabaseManager(string strSqlQuery)
        {
            this.strQuery = strSqlQuery;           
            this.strConnectionString = ConfigurationManager.ConnectionStrings["BankConnectionString"].ConnectionString;
        }

           
        public DataTable LoadInfo()
        {
            DataTable dt = new DataTable();
            using (this.sqlconManager = new SqlConnection(this.strConnectionString))
            {
                this.sdaAdapter = new SqlDataAdapter();
                this.sdaAdapter.SelectCommand = new SqlCommand(strQuery, sqlconManager);
                this.sqlconManager.Open();
                this.sdaAdapter.Fill(dt);               
            }

            return  dt;          
        }

        public void SaveChanges(DataSet dsDataset, string strTable)
        {
            this.sdaAdapter = new SqlDataAdapter(this.strQuery, sqlconManager);
            SqlCommandBuilder builder = new SqlCommandBuilder(this.sdaAdapter);
            sdaAdapter.InsertCommand = builder.GetInsertCommand();
            sdaAdapter.DeleteCommand = builder.GetDeleteCommand();
            sdaAdapter.UpdateCommand = builder.GetUpdateCommand();
            sdaAdapter.Update(dsDataset, strTable);
        }

        public void AddTransaction(Dictionary<string, object> parameters, string strProcedure)
        {
            using (this.sqlconManager = new SqlConnection(this.strConnectionString))
            {
                SqlCommand sqlcmd = new SqlCommand(strProcedure, sqlconManager);
                sqlcmd.CommandType = CommandType.StoredProcedure;

                foreach (var p in parameters)
                {
                    sqlcmd.Parameters.AddWithValue(p.Key, p.Value ?? DBNull.Value);
                }

                sqlconManager.Open();
                sqlcmd.ExecuteNonQuery();
            }            
            
        }

        public DataTable LoadBalances()
        {
            DataTable dtTable = new DataTable();
            using (this.sqlconManager = new SqlConnection(this.strConnectionString))
            {
                SqlCommand sqlcmd = new SqlCommand(strQuery, sqlconManager);
                this.sdaAdapter = new SqlDataAdapter(sqlcmd);

                sdaAdapter.Fill(dtTable);
            }
 
            return dtTable;
        }

        public void DeleteTransaction()
        {
            using (this.sqlconManager = new SqlConnection(this.strConnectionString))
            {
                SqlCommand sqlcmd = new SqlCommand( this.strQuery, this.sqlconManager);
               
                this.sqlconManager.Open();
                sqlcmd.ExecuteNonQuery();
            }
           
            
                
            
        }

    }
}
