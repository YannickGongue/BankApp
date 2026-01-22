using BankAppClassLibrary;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAppControlLibrary
{
    public partial class UserTransactions : UserControl
    {
        //private clsDbContext dbName;
        private clsDatabaseManager dbManager;
        private DataTable dtTable;
        private Dictionary<string, object> dTransactions;
        private readonly IConnectionFactory _factory;
        private readonly ILogger<Repositories> _logger;

        public UserTransactions()
        {
            InitializeComponent();
            //this._factory = factory;
            //this._logger = logger;
            //this.dbName = new clsDbContext();
            this.dtTable = new DataTable();
            //this.dbManager = new clsDatabaseManager(new Repositories(this._factory, this._logger));

        }


        private void btnNewTransactions_Click(object sender, EventArgs e)
        {
        //    string strOldTransactionSearch = string.Format("SELECT a.{1}, a.{2}, t.{3}, t.{4}, t.{5},  t.{6}" +
        //                                                    "FROM {0} t " +
        //                                                    "JOIN {7} a ON t.{3} = a.{3} " +
        //                                                    "JOIN {8} c ON a.{9} = c.{9}" +
        //                                                    "WHERE a.{3} = '{10}'" +
        //                                                    " AND t.{5} <=  DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1) " +
        //                                                    "ORDER BY t.{5} DESC",
        //                                                    this.dbName.STR_TBL_TRANSACTIONS,
        //                                                    this.dbName.STR_FN_IBAN,
        //                                                    this.dbName.STR_FN_ID_ACCOUNT,
        //                                                    this.dbName.STR_FN_TRANSACTION_TYPE,
        //                                                    this.dbName.STR_FN_AMOUNT,
        //                                                    this.dbName.STR_FN_CREATEDAT,
        //                                                    this.dbName.STR_FN_ID_TRANSACTION,
        //                                                    this.dbName.STR_TBL_ACCOUNT,
        //                                                    this.dbName.STR_TBL_CUSTOMER,
        //                                                    this.dbName.STR_FN_ID_CUSTOMER,
        //                                                    this.tbCustomerID.Text);

        //    this.dtTable = this.dbManager.SetAllTransaction(strOldTransactionSearch);
        //    this.dgvTansactions.DataSource = this.dtTable;
        }

        private void btnOldTransactions_Click(object sender, EventArgs e)
        {
        //    string strOldTransactionSearch = string.Format("SELECT a.{1}, a.{2}, t.{3}, t.{4}, t.{5},  t.{6}" +
        //                                                    "FROM {0} t " +
        //                                                    "JOIN {7} a ON t.{3} = a.{3} " +
        //                                                    "JOIN {8} c ON a.{9} = c.{9}" +
        //                                                    "WHERE a.{3} = '{10}'" +
        //                                                    " AND t.{5} >= DATEADD(MONTH, -6, GETDATE()) " +
        //                                                    " AND t.{5} <= GETDATE()" +
        //                                                    "ORDER BY t.{5} DESC",
        //                                                    this.dbName.STR_TBL_TRANSACTIONS,
        //                                                    this.dbName.STR_FN_IBAN,
        //                                                    this.dbName.STR_FN_ID_ACCOUNT,
        //                                                    this.dbName.STR_FN_TRANSACTION_TYPE,
        //                                                    this.dbName.STR_FN_AMOUNT,
        //                                                    this.dbName.STR_FN_CREATEDAT,
        //                                                    this.dbName.STR_FN_ID_TRANSACTION,
        //                                                    this.dbName.STR_TBL_ACCOUNT,
        //                                                    this.dbName.STR_TBL_CUSTOMER,
        //                                                    this.dbName.STR_FN_ID_CUSTOMER,
        //                                                    this.tbCustomerID.Text);

        //    this.dtTable = this.dbManager.SetAllTransaction(strOldTransactionSearch);
        //    this.dgvTansactions.DataSource = this.dtTable;
       }

        private void btnAllTransactions_Click(object sender, EventArgs e)
        { 
        //    string strAllTransactionSearch = string.Format( "SELECT a.{1}, a.{2}, t.{3}, t.{4}, t.{5},  t.{6}" +
        //                                                    "FROM {0} t " +
        //                                                    "JOIN {7} a ON t.{3} = a.{3} " +
        //                                                    "JOIN {8} c ON a.{9} = c.{9}" +
        //                                                    "WHERE a.{3} = '{10}'"+
        //                                                    "ORDER BY t.{5} DESC",
        //                                                    this.dbName.STR_TBL_TRANSACTIONS,                                                      
        //                                                    this.dbName.STR_FN_IBAN,
        //                                                    this.dbName.STR_FN_ID_ACCOUNT,
        //                                                    this.dbName.STR_FN_TRANSACTION_TYPE,
        //                                                    this.dbName.STR_FN_AMOUNT,
        //                                                    this.dbName.STR_FN_CREATEDAT,
        //                                                    this.dbName.STR_FN_ID_TRANSACTION,
        //                                                    this.dbName.STR_TBL_ACCOUNT,
        //                                                    this.dbName.STR_TBL_CUSTOMER,                                                                                               
        //                                                    this.dbName.STR_FN_ID_CUSTOMER,
        //                                                    this.tbCustomerID.Text);
        //    this.dtTable = this.dbManager.SetAllTransaction(strAllTransactionSearch);
        //    this.dgvTansactions.DataSource = this.dtTable; 
        }

     
        private void btnDelete_click(object sender, EventArgs e)
        {
            
        //    string strDeleteTransaction = string.Format("UPDATE {0} SET {1} = 1 WHERE {2} = '{3}",
        //                                                this.dbName.STR_TBL_TRANSACTIONS,
        //                                                this.dbName.STR_FN_IS_DELETED,
        //                                                this.dbName.STR_FN_ID_TRANSACTION,
        //                                                this.tbTransactionID.Text);
        //    try
        //    {
        //        this.dbManager.DeleteTransaction(strDeleteTransaction);
        //        MessageBox.Show("Transaction deleted successfully!", "OK",
        //        MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error",
        //        MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        }


        private void btnDisplayBalance__Click(object sender, EventArgs e)
        {          
        //    string strBalance = string.Format(" SELECT {1} FROM {0} WHERE {2} ='{3}",
        //                                      this.dbName.STR_TBL_ACCOUNT_BALANCES,
        //                                      this.dbName.STR_FN_BALANCE,
        //                                      this.dbName.STR_FN_ID_ACCOUNT,
        //                                      this.tbAccountID.Text);
        //    this.lblDisplaySaldo.Text = this.dbManager.SetAllTransaction(strBalance).Rows[0].ToString();
        }

        private void dgvTransactions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgrRow = this.dgvTansactions.Rows[e.RowIndex];
            this.tbAccountID.Text = dgrRow.Cells["AccountID"].Value.ToString();
            this.tbAmount.Text = dgrRow.Cells["AccountID"].Value.ToString();
            this.cbTansactionType.Text = dgrRow.Cells["TransactionType"].Value.ToString();
            this.tbTransactionID.Text = dgrRow.Cells["TransactionID"].Value.ToString();
            this.tbPurpose.Text = dgrRow.Cells["Purpose"].Value.ToString();
            this.dptTransactionDate.Text = dgrRow.Cells["AccountID"].Value.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnTransfert_Click(object sender, EventArgs e)
        {
            //string strDefault = "";
            //string strProcedure = "sp_AddTransaction";
            //this.dTransactions = new Dictionary<string, object>
            //{
            //    {"@AccountID", this.tbAccountID.Text},
            //    {"@Amount", this.tbAmount.Text},
            //    {"@TransactionID", this.tbTransactionID.Text},
            //    {"@Purpose",this.tbPurpose.Text },
            //    {"@TransactionType",this.cbTansactionType.SelectedItem.ToString() },
            //    {"@Date",this.dptTransactionDate.Text },
            //};

            //try
            //{              
            //    this.dbManager.AddTransaction(this.dTransactions, strProcedure);
            //    MessageBox.Show("Transaction added successfully!", "OK",
            //    MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error",
            //    MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            
        }
    }
}
