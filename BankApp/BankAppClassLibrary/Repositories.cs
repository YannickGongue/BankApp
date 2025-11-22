using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppClassLibrary
{
    public class Repositories : IRepository
    {
         string strConnectionString;
        public SqlConnection GetConnection()
        {
            this.strConnectionString = ConfigurationManager.ConnectionStrings["BankConnectionString"].ConnectionString;
            SqlConnection sqlconManager = new SqlConnection(this.strConnectionString);
            return sqlconManager;
        }

        public DataTable GetAllTRansactions(string strQuery)
        {
            DataTable dt = new DataTable();           
            SqlCommand sqlcmd = new SqlCommand(strQuery, this.GetConnection());
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(sqlcmd);
            this.GetConnection().Open();
            sdaAdapter.Fill(dt);
            
            return dt;
        }

        public void GetAllChanges(DataSet dsDataset, string strTable, string strQuery)
        {
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(strQuery, this.GetConnection());
            SqlCommandBuilder builder = new SqlCommandBuilder(sdaAdapter);
            sdaAdapter.InsertCommand = builder.GetInsertCommand();
            sdaAdapter.DeleteCommand = builder.GetDeleteCommand();
            sdaAdapter.UpdateCommand = builder.GetUpdateCommand();
            sdaAdapter.Update(dsDataset, strTable);
        }

        public void AddTransaction(Dictionary<string, object> parameters, string strProcedure)
        {
            
                SqlCommand sqlcmd = new SqlCommand(strProcedure, this.GetConnection());
                sqlcmd.CommandType = CommandType.StoredProcedure;

                foreach (var p in parameters)
                {
                    sqlcmd.Parameters.AddWithValue(p.Key, p.Value ?? DBNull.Value);
                }

                this.GetConnection().Open();
                sqlcmd.ExecuteNonQuery();            
        }

        
        public void DeleteTransaction(string strQuery)
        {       
            SqlCommand sqlcmd = new SqlCommand(strQuery, this.GetConnection());
            this.GetConnection().Open();
             sqlcmd.ExecuteNonQuery();      
        }
    }
}
