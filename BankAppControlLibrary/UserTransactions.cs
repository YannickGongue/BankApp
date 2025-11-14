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
        public UserTransactions()
        {
            InitializeComponent();
            this.dbName = new clsDbTablenames();
            this.dtTable = new DataTable();
            this.dsDataset = new DataSet();
        }

        
        private void btnNewTransactions_Click(object sender, EventArgs e)
        {

        }

        private void btnOldTransactions_Click(object sender, EventArgs e)
        {

        }

        private void btnAllTransactions_Click(object sender, EventArgs e)
        {
            string strQuerySearch = string.Format("SELECT c.{1}, c.{2}, a.{3}, t.{4}, t.{5}, t.{6}, t.{7}, a.{12},a.{13}" +
                                                  "FROM {0} t " +
                                                  "JOIN {8} a ON t.{9} = a.{9} " +
                                                  "JOIN {10} c ON a.{11} = c.{11}"
                                                  "WHERE a.{9} = '{14}'"
                                                  "ORDER BY t.{5} DESC",
                                                  this.dbName.STR_TBL_TRANSACTIONS,
                                                  this.dbName.STR_FN_FIRSTNAME,
                                                  this.dbName.STR_FN_LASTNAME,
                                                  this.dbName.STR_FN_IBAN,
                                                  this.dbName.
                                                  this.dbName.STR_FN_TRANSACTION_TYPE,
                                                  this.dbName.STR_FN_BALANCE,
                                                  this.dbName.STR_FN_CREATEDAT,
                                                  this.dbName.STR_TBL_CUSTOMER,
                                                  this.dbName.STR_FN_ID_CUSTOMER,
                                                  this.tbCustomerID.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
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
    }
}
