using BankAppClassLibrary;
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
        private clsDbTablenames dbName;
        private clsDatabaseManager dbManager;
        private DataTable dtTable;
        private DataSet dsDataset;
        private Dictionary<string, object> dTransactions;
        public UserTransactions()
        {
            InitializeComponent();
            this.dbName = new clsDbTablenames();
            this.dtTable = new DataTable();
            this.dsDataset = new DataSet();
        }

        
        private void btnNewTransactions_Click(object sender, EventArgs e)
        {
            string strOldTransactionSearch = string.Format("SELECT a.{1}, a.{2}, t.{3}, t.{4}, t.{5},  t.{6}" +
                                                            "FROM {0} t " +
                                                            "JOIN {7} a ON t.{3} = a.{3} " +
                                                            "JOIN {8} c ON a.{9} = c.{9}" +
                                                            "WHERE a.{3} = '{10}'" +
                                                            " AND t.{5} <=  DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1) " +
                                                            "ORDER BY t.{5} DESC",
                                                           this.dbName.STR_TBL_TRANSACTIONS,
                                                            this.dbName.STR_FN_IBAN,
                                                            this.dbName.STR_FN_ID_ACCOUNT,
                                                            this.dbName.STR_FN_TRANSACTION_TYPE,
                                                            this.dbName.STR_FN_AMOUNT,
                                                            this.dbName.STR_FN_CREATEDAT,
                                                            this.dbName.STR_FN_TRANSACTION_NR,
                                                            this.dbName.STR_TBL_ACCOUNT,
                                                            this.dbName.STR_TBL_CUSTOMER,
                                                            this.dbName.STR_FN_ID_CUSTOMER,
                                                            this.tbCustomerID.Text);

            this.dbManager = new clsDatabaseManager(strOldTransactionSearch, this.dbName.STR_TBL_TRANSACTIONS);
            this.dtTable = this.dbManager.LoadInfo();
            this.dgvTansactions.DataSource = this.dtTable;
        }

        private void btnOldTransactions_Click(object sender, EventArgs e)
        {
            string strOldTransactionSearch = string.Format("SELECT a.{1}, a.{2}, t.{3}, t.{4}, t.{5},  t.{6}" +
                                                            "FROM {0} t " +
                                                            "JOIN {7} a ON t.{3} = a.{3} " +
                                                            "JOIN {8} c ON a.{9} = c.{9}" +
                                                            "WHERE a.{3} = '{10}'" +
                                                            " AND t.{5} >= DATEADD(MONTH, -6, GETDATE()) " +
                                                            " AND t.{5} <= GETDATE()" +
                                                            "ORDER BY t.{5} DESC",
                                                            this.dbName.STR_TBL_TRANSACTIONS,
                                                            this.dbName.STR_FN_IBAN,
                                                            this.dbName.STR_FN_ID_ACCOUNT,
                                                            this.dbName.STR_FN_TRANSACTION_TYPE,
                                                            this.dbName.STR_FN_AMOUNT,
                                                            this.dbName.STR_FN_CREATEDAT,
                                                            this.dbName.STR_FN_TRANSACTION_NR,
                                                            this.dbName.STR_TBL_ACCOUNT,
                                                            this.dbName.STR_TBL_CUSTOMER,
                                                            this.dbName.STR_FN_ID_CUSTOMER,
                                                            this.tbCustomerID.Text);

            this.dbManager = new clsDatabaseManager(strOldTransactionSearch, this.dbName.STR_TBL_TRANSACTIONS);
            this.dtTable = this.dbManager.LoadInfo();
            this.dgvTansactions.DataSource = this.dtTable;
        }

        private void btnAllTransactions_Click(object sender, EventArgs e)
        { 
            string strAllTransactionSearch = string.Format( "SELECT a.{1}, a.{2}, t.{3}, t.{4}, t.{5},  t.{6}" +
                                                            "FROM {0} t " +
                                                            "JOIN {7} a ON t.{3} = a.{3} " +
                                                            "JOIN {8} c ON a.{9} = c.{9}" +
                                                            "WHERE a.{3} = '{10}'"+
                                                            "ORDER BY t.{5} DESC",
                                                            this.dbName.STR_TBL_TRANSACTIONS,                                                      
                                                            this.dbName.STR_FN_IBAN,
                                                            this.dbName.STR_FN_ID_ACCOUNT,
                                                            this.dbName.STR_FN_TRANSACTION_TYPE,
                                                            this.dbName.STR_FN_AMOUNT,
                                                            this.dbName.STR_FN_CREATEDAT,
                                                            this.dbName.STR_FN_TRANSACTION_NR,
                                                            this.dbName.STR_TBL_ACCOUNT,
                                                            this.dbName.STR_TBL_CUSTOMER,                                                                                               
                                                            this.dbName.STR_FN_ID_CUSTOMER,
                                                            this.tbCustomerID.Text);

            this.dbManager = new clsDatabaseManager(strAllTransactionSearch, this.dbName.STR_TBL_TRANSACTIONS);
            this.dtTable = this.dbManager.LoadInfo();
            this.dgvTansactions.DataSource = this.dtTable; 
        }


        private void btnDelete_click(object sender, EventArgs e)
        {

        }

        private void btnDisplayBalance__Click(object sender, EventArgs e)
        {

        }

        private void dgvTransactions_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnTransfert_Click(object sender, EventArgs e)
        {

        }
    }
}
