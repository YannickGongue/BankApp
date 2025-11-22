using System;
using System.Data;
using System.Windows.Forms;
using BankAppClassLibrary;

namespace BankAppControlLibrary
{
    public partial class ucCustomer : UserControl
    {
        private clsDbTablenames dbName;
        private clsDatabaseManager dbManager;
        private DataTable dtTable;
        private DataSet dsDataset;
       
        public ucCustomer()
        {
            InitializeComponent();
            this.dbName = new clsDbTablenames();
            this.dtTable = new DataTable();
            this.dsDataset = new DataSet();
            this.dbManager = new clsDatabaseManager(new Repositories());

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string strQuerySave = string.Format("UPDATE {0} SET {1} = '{10}',{2} = '{11}',{3} = '{12}'," +
                                "{4} = '{13}',{5} = '{14}',{6} = '{15}',{7} = '{16}',{8} = '{17}' " +
                                " WHERE {9} = '{18}'", 
                                this.dbName.STR_TBL_CUSTOMER, 
                                this.dbName.STR_FN_FIRSTNAME, this.dbName.STR_FN_LASTNAME,
                                this.dbName.STR_FN_STREET, this.dbName.STR_FN_HOUSNUMBER,
                                this.dbName.STR_FN_ZIPCODE, this.dbName.STR_FN_CITY,
                                this.dbName.STR_FN_CREATEDAT, this.dbName.STR_FN_EMAIL,
                                this.dbName.STR_FN_ID_CUSTOMER,
                                this.tbFirstName.Text,this.tbLastName.Text,
                                this.tbStreet.Text, this.tbNr.Text, 
                                this.tbPlz.Text,this.tbCity.Text, 
                                this.dtpCreatedAt.Value, this.tbEmail.Text, this.tbCustomerId.Text);
            this.dbManager.setAllChange(dsDataset, this.dbName.STR_TBL_CUSTOMER, strQuerySave);
        }

        private void btnSearch_click(object sender, EventArgs e)
        {
            DataRow drRow;
           string strCustomerSearch = String.Format("SELECT {1},{2},{3},{4},{5},{6},{7},{8} " +
                                                 "FROM {0} " +
                                                 "WHERE {9}='{10}'",
                                                 this.dbName.STR_TBL_CUSTOMER, 
                                                 this.dbName.STR_FN_FIRSTNAME, this.dbName.STR_FN_LASTNAME,
                                                 this.dbName.STR_FN_STREET, this.dbName.STR_FN_HOUSNUMBER,
                                                 this.dbName.STR_FN_ZIPCODE, this.dbName.STR_FN_CITY,
                                                 this.dbName.STR_FN_CREATEDAT,this.dbName.STR_FN_EMAIL, 
                                                 this.dbName.STR_FN_ID_CUSTOMER, this.tbCustomerId.Text);
            this.dtTable = this.dbManager.SetAllTransaction(strCustomerSearch);
            if(this.dtTable.Rows.Count > 0)
            {
                drRow = this.dtTable.Rows[0];
                this.tbFirstName.Text = drRow[1].ToString();
                this.tbLastName.Text = drRow[2].ToString();
                this.tbEmail.Text = drRow[3].ToString();
                this.tbTelephon.Text = drRow[4].ToString();
                this.tbStreet.Text = drRow[5].ToString();
                this.tbNr.Text = drRow[6].ToString();
                this.tbPlz.Text = drRow[7].ToString();
                this.tbCity.Text = drRow[8].ToString();
                this.dtpCreatedAt.Text = drRow[9].ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {     
            string strCustomerInsert = string.Format("INSERT INTO {0} ({1},{2},{3},{4},{5},{6},{7},{8},)" +
                                                    "VALUES( '{9}', '{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}')",
                                                     this.dbName.STR_TBL_CUSTOMER, 
                                                     this.dbName.STR_FN_FIRSTNAME, this.dbName.STR_FN_LASTNAME,
                                                     this.dbName.STR_FN_STREET, this.dbName.STR_FN_HOUSNUMBER,
                                                     this.dbName.STR_FN_ZIPCODE, this.dbName.STR_FN_CITY,
                                                     this.dbName.STR_FN_CREATEDAT, this.dbName.STR_FN_EMAIL,
                                                     this.tbCustomerId.Text, this.tbFirstName.Text,
                                                     this.tbLastName.Text, this.tbStreet.Text, 
                                                     this.tbNr.Text,this.tbPlz.Text,this.tbCity.Text,
                                                     this.dtpCreatedAt.Value,this.tbEmail.Text);

            this.dbManager.setAllChange(dsDataset, this.dbName.STR_TBL_CUSTOMER, strCustomerInsert);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            string strCustomerDelete = string.Format( "DELETE FROM {0} WHERE {1} = '{2}'",
                                                      this.dbName.STR_TBL_CUSTOMER, 
                                                      this.dbName.STR_FN_ID_CUSTOMER,
                                                      this.tbCustomerId.Text);
            this.dbManager.setAllChange(dsDataset, this.dbName.STR_TBL_CUSTOMER, strCustomerDelete);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
