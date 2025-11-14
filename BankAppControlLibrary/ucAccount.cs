using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Data;
using BankAppClassLibrary;
using System.Configuration;

namespace BankAppControlLibrary
{
    public partial class ucAccount : UserControl
    {
       
        private clsDbTablenames dbName;
        private string strConnectionString;
        private clsDatabaseManager dbManager;
        private DataSet dsDataset;

        public ucAccount()
        {
            InitializeComponent();
            this.dbManager = new clsDatabaseManager();
            this.dbName = new clsDbTablenames();
            this.dsDataset = new DataSet();

        }

           
        private void btnCancel_Click(object sender, EventArgs e)
        {
                this.Visible = false;       
        }

        private void btnAdd_click(object sender, EventArgs e)
        {
            string strAccountRegister = string.Format( "INSERT INTO {0} ({1},{2},{3},{4},{5})" +
                                                       "VALUES('{6}','{7}','{8}','{9}','{10}')",
                                                       this.dbName.STR_TBL_ACCOUNT, this.dbName.STR_FN_ID_ACCOUNT,
                                                       this.dbName.STR_FN_BALANCE, this.dbName.STR_FN_IBAN,
                                                       this.dbName.STR_FN_ACCOUNT_TYPE, this.dbName.STR_FN_CREATEDAT,
                                                       this.tbAccountId.Text, this.tbBalance.Text,
                                                       this.tbIban.Text, this.cbAccountType.Text, this.tbDate.Text);

            this.dbManager.AddInfoToDB(strAccountRegister,"1");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string strAccountDelete = string.Format( "DELETE FROM {0} WHERE {1} = '{2}'",
                                                     this.dbName.STR_TBL_ACCOUNT,
                                                     this.dbName.STR_FN_ID_ACCOUNT,
                                                     this.tbAccountId.Text);
            this.dbManager.AddInfoToDB(strAccountDelete, "0");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataRow drRow;
            string strQuerySearch = string.Format( "SELECT a.{1}, a.{2}, a.{3}, a.{4}, a.{5} " +
                                                   "FROM {0} a " +
                                                   "JOIN {6} c ON a.{7} = c.{7} " +
                                                   "WHERE c.{7} = '{8}'",
                                                   this.dbName.STR_TBL_ACCOUNT,       
                                                   this.dbName.STR_FN_ID_ACCOUNT,      
                                                   this.dbName.STR_FN_IBAN,           
                                                   this.dbName.STR_FN_TRANSACTION_TYPE,
                                                   this.dbName.STR_FN_BALANCE,        
                                                   this.dbName.STR_FN_CREATEDAT,      
                                                   this.dbName.STR_TBL_CUSTOMER,       
                                                   this.dbName.STR_FN_ID_CUSTOMER,                    
                                                   this.tbCustomerID.Text );


            this.dsDataset = this.dbManager.LoadInfo(strQuerySearch, this.dbName.STR_TBL_ACCOUNT);
            if (this.dsDataset.Tables[this.dbName.STR_TBL_CUSTOMER].Rows.Count > 0)
            {
                drRow = this.dsDataset.Tables[this.dbName.STR_TBL_CUSTOMER].Rows[0];
                this.tbAccountId.Text = this.dsDataset.Tables[0].Rows[0][1].ToString();
                this.tbIban.Text = this.dsDataset.Tables[0].Rows[0][2].ToString();
                this.cbAccountType.Text = this.dsDataset.Tables[0].Rows[0][3].ToString();
                this.tbBalance.Text = this.dsDataset.Tables[0].Rows[0][4].ToString();
                this.tbDate.Text = this.dsDataset.Tables[0].Rows[0][5].ToString();               
            }
        }
    }
}
