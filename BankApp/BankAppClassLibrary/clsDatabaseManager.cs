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
           
            using (SqlConnection sqlconManager = new SqlConnection(this.strConnectionString))
            {
                SqlCommand sqlcmd = new SqlCommand(this.strQuery, sqlconManager);
                SqlDataAdapter sdaAdapter = new SqlDataAdapter(sqlcmd);
                //this.sdaAdapter.SelectCommand = new SqlCommand();
                sqlconManager.Open();
             
                sdaAdapter.Fill(dt);               
            }

            return  dt;          
        }

        public void SaveChanges(DataSet dsDataset, string strTable)
        {
            SqlConnection sqlconManager = new SqlConnection(this.strConnectionString);
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(this.strQuery, sqlconManager);
            SqlCommandBuilder builder = new SqlCommandBuilder(sdaAdapter);
            sdaAdapter.InsertCommand = builder.GetInsertCommand();
            sdaAdapter.DeleteCommand = builder.GetDeleteCommand();
            sdaAdapter.UpdateCommand = builder.GetUpdateCommand();
            sdaAdapter.Update(dsDataset, strTable);
        }

        public void AddTransaction(Dictionary<string, object> parameters, string strProcedure)
        {
            using (SqlConnection sqlconManager = new SqlConnection(this.strConnectionString))
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
            using (SqlConnection sqlconManager = new SqlConnection(this.strConnectionString))
            {
                SqlCommand sqlcmd = new SqlCommand(strQuery, sqlconManager);
                SqlDataAdapter sdaAdapter = new SqlDataAdapter(sqlcmd);

                sdaAdapter.Fill(dtTable);
            }
 
            return dtTable;
        }

        public void DeleteTransaction()
        {
            using (SqlConnection sqlconManager = new SqlConnection(this.strConnectionString))
            {
                SqlCommand sqlcmd = new SqlCommand( this.strQuery, sqlconManager);
               
                sqlconManager.Open();
                sqlcmd.ExecuteNonQuery();
            }                  
        }
    }
}
