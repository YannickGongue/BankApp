using System;
using System.Data;
using System.Windows.Forms;
using BankAppClassLibrary;
using Microsoft.Extensions.Logging;

namespace BankAppControlLibrary
{
    public partial class ucAccount : UserControl
    {
               
        private DataTable dtTable;
        private IRepository _irepo;
        private MAccounts _mAccount;


        public ucAccount(IRepository irepo, MAccounts mAccount)
        {
            InitializeComponent();
            this._irepo = irepo;
            this._mAccount = mAccount;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           this.Visible = false;       
        }

        private void btnAdd_click(object sender, EventArgs e)
        {
            this._mAccount.AccountId = this.tbAccountId.Text;
            this._mAccount.AccountType = this.cbAccountType.Text;
            this._mAccount.Balance = this.tbBalance.Text;
            this._mAccount.CreatedAt = this.tbDate.Text;
            this._mAccount.Iban = this.tbIban.Text;

            this._irepo.AddAccounts(this._mAccount);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //string strAccountDelete = string.Format( "DELETE FROM {0} WHERE {1} = '{2}'",
            //                                         this.dbName.STR_TBL_ACCOUNT,
            //                                         this.dbName.STR_FN_ID_ACCOUNT,
            //                                         this.tbAccountId.Text);

            //this.dbManager.setAllChange(this.dsDataset, this.dbName.STR_TBL_ACCOUNT, strAccountDelete);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //DataRow drRow;
            //string strQuerySearch = string.Format( "SELECT a.{1}, a.{2}, a.{3}, a.{4}, a.{5} " +
            //                                       "FROM {0} a " +
            //                                       "JOIN {6} c ON a.{7} = c.{7} " +
            //                                       "WHERE c.{7} = '{8}' ",
            //                                       this.dbName.STR_TBL_ACCOUNT,       
            //                                       this.dbName.STR_FN_ID_ACCOUNT,      
            //                                       this.dbName.STR_FN_IBAN,           
            //                                       this.dbName.STR_FN_ACCOUNT_TYPE,
            //                                       this.dbName.STR_FN_BALANCE,        
            //                                       this.dbName.STR_FN_CREATEDAT,      
            //                                       this.dbName.STR_TBL_CUSTOMER,       
            //                                       this.dbName.STR_FN_ID_CUSTOMER,                                                 
            //                                       this.tbCustomerID.Text );

            //this.dtTable = this.dbManager.SetAllTransaction(strQuerySearch);
            //if (this.dtTable.Rows.Count > 0)
            //{
            //    drRow = this.dtTable.Rows[0];
            //    this.tbAccountId.Text = drRow[1].ToString();
            //    this.tbIban.Text = drRow[2].ToString();
            //    this.cbAccountType.Text = drRow[3].ToString();
            //    this.tbBalance.Text = drRow[4].ToString();
            //    this.tbDate.Text = drRow[5].ToString();               
            //}
        }
    }
}
