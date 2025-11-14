using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankAppClassLibrary;

namespace BankAppControlLibrary
{
    public partial class ucCustomer : UserControl
    {
        private clsDbTablenames dbName;
        private clsDatabaseManager dbManager;
        private DataSet dsDataset;
       
        public ucCustomer()
        {
            InitializeComponent();
            this.dbName = new clsDbTablenames();
            this.dbManager = new clsDatabaseManager();
            this.dsDataset = new DataSet();         
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

            this.dbManager.AddInfoToDB(strQuerySave, "2");
        }

        private void btnSearch_click(object sender, EventArgs e)
        {
            DataRow drRow;
           string strQuerySearch = String.Format("SELECT {1},{2},{3},{4},{5},{6},{7},{8},{9} FROM {0} WHERE {1}='{10}'",
                                                  this.dbName.STR_TBL_CUSTOMER, this.dbName.STR_FN_ID_CUSTOMER,
                                                  this.dbName.STR_FN_FIRSTNAME, this.dbName.STR_FN_LASTNAME,
                                                  this.dbName.STR_FN_STREET, this.dbName.STR_FN_HOUSNUMBER,
                                                  this.dbName.STR_FN_ZIPCODE, this.dbName.STR_FN_CITY,
                                                  this.dbName.STR_FN_CREATEDAT,this.dbName.STR_FN_EMAIL, 
                                                  this.tbCustomerId.Text);

            this.dsDataset = this.dbManager.LoadInfo(strQuerySearch, this.dbName.STR_TBL_CUSTOMER);
            if(this.dsDataset.Tables[this.dbName.STR_TBL_CUSTOMER].Rows.Count > 0)
            {
                drRow = this.dsDataset.Tables[this.dbName.STR_TBL_CUSTOMER].Rows[0];
                this.tbFirstName.Text = this.dsDataset.Tables[0].Rows[0][1].ToString();
                this.tbLastName.Text = this.dsDataset.Tables[0].Rows[0][2].ToString();
                this.tbEmail.Text = this.dsDataset.Tables[0].Rows[0][3].ToString();
                this.tbTelephon.Text = this.dsDataset.Tables[0].Rows[0][4].ToString();
                this.tbStreet.Text = this.dsDataset.Tables[0].Rows[0][5].ToString();
                this.tbNr.Text = this.dsDataset.Tables[0].Rows[0][6].ToString();
                this.tbPlz.Text = this.dsDataset.Tables[0].Rows[0][7].ToString();
                this.tbCity.Text = this.dsDataset.Tables[0].Rows[0][8].ToString();
                this.dtpCreatedAt.Text = this.dsDataset.Tables[0].Rows[0][9].ToString();
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {     
            string strQueryRegister = string.Format("INSERT INTO {0} ({1},{2},{3},{4},{5},{6},{7},{8},{9})" +
                                                    "VALUES('{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}')",
                                                     this.dbName.STR_TBL_CUSTOMER, this.dbName.STR_FN_ID_CUSTOMER,
                                                     this.dbName.STR_FN_FIRSTNAME, this.dbName.STR_FN_LASTNAME,
                                                     this.dbName.STR_FN_STREET, this.dbName.STR_FN_HOUSNUMBER,
                                                     this.dbName.STR_FN_ZIPCODE, this.dbName.STR_FN_CITY,
                                                     this.dbName.STR_FN_CREATEDAT, this.dbName.STR_FN_EMAIL,
                                                     this.tbCustomerId.Text, this.tbFirstName.Text,
                                                     this.tbLastName.Text, this.tbStreet.Text, 
                                                     this.tbNr.Text,this.tbPlz.Text,
                                                     this.tbCity.Text, this.dtpCreatedAt.Value,this.tbEmail.Text);

            this.dbManager.AddInfoToDB(strQueryRegister, "1");           
          
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            string strCustomerDelete = string.Format("DELETE FROM {0} WHERE {1} = '{2}'",
                                                      this.dbName.STR_TBL_CUSTOMER, this.dbName.STR_FN_ID_CUSTOMER,
                                                       this.tbCustomerId.Text);
            this.dbManager.AddInfoToDB(strCustomerDelete, "0");
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
