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
        private SqlCommand sqlcmdManager;
        private SqlConnection sqlconManager;
        private SqlDataAdapter sdaAdapter;
        private string strConnectionString;

        public void AddInfoToDB(string strQuery, string strflag)
        {
           
            this.strConnectionString = ConfigurationManager.ConnectionStrings["BankConnectionString"].ConnectionString;
            //Connectionstring-Objekt instanzieren.
            using (sqlconManager = new SqlConnection(this.strConnectionString))

            //Sql-command Objekt instanzieren.
            using (sqlcmdManager = new SqlCommand(strQuery, sqlconManager))
            {
               
                try
                {
                    sqlcmdManager.CommandType = CommandType.Text;
                    //Verbindung öffnen.
                    sqlconManager.Open();

                    //sql-Befehle ausführen.
                    if (sqlcmdManager.ExecuteNonQuery() > 0)
                    {
                        if(strflag == "1")
                        {
                            MessageBox.Show("die Einträgen wurden erfolgreich in die Datenbank hinzugefügt");
                        }
                        else if(strflag == "0")
                        {
                            MessageBox.Show("die Einträgen wurden erfolgreich in die Datenbank entfernt");
                        }
                        else
                        {
                            MessageBox.Show("die Veränderungen wurden erfolgreich in die Datenbank vorgenommen");
                        }
                      
                    }
                    //Die Verbindung schließen.
                    sqlconManager.Close();
                }
                catch (SqlException ex)
                {
                    throw new InvalidOperationException("SQL error executing query: " + ex.Message, ex);
                }
            }
        }

       
        public DataSet LoadInfo(string strQuery,  string strTablename)
        {
            DataSet dsDataset = new DataSet();
            using (SqlConnection connection = new SqlConnection(strConnectionString))
            {
               
                this.sdaAdapter = new SqlDataAdapter(strQuery, connection);             

                SqlCommandBuilder builder = new SqlCommandBuilder(this.sdaAdapter);
                dsDataset = new DataSet();
                this.sdaAdapter.Fill(dsDataset, strTablename);              
            }

            return dsDataset;
        }
    }
}
