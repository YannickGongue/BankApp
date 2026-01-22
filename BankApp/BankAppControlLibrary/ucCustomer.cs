using System;
using System.Data;
using System.Windows.Forms;
using BankAppClassLibrary;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;


namespace BankAppControlLibrary
{
    public partial class ucCustomer : UserControl
    {
        private DataTable dtTable;
        private MCustomers customers;
        private IRepository _irepo;

        public ucCustomer(IRepository irepo)
        {
            InitializeComponent();
            this._irepo = irepo;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //string strQuerySave = string.Format("UPDATE {0} SET {1} = '{10}',{2} = '{11}',{3} = '{12}'," +
            //                    "{4} = '{13}',{5} = '{14}',{6} = '{15}',{7} = '{16}',{8} = '{17}' " +
            //                    " WHERE {9} = '{18}'", 
            //                    this.dbName.STR_TBL_CUSTOMER, 
            //                    this.dbName.STR_FN_FIRSTNAME, this.dbName.STR_FN_LASTNAME,
            //                    this.dbName.STR_FN_STREET, this.dbName.STR_FN_HOUSNUMBER,
            //                    this.dbName.STR_FN_ZIPCODE, this.dbName.STR_FN_CITY,
            //                    this.dbName.STR_FN_CREATEDAT, this.dbName.STR_FN_EMAIL,
            //                    this.dbName.STR_FN_ID_CUSTOMER,
            //                    this.tbFirstName.Text,this.tbLastName.Text,
            //                    this.tbStreet.Text, this.tbNr.Text, 
            //                    this.tbPlz.Text,this.tbCity.Text, 
            //                    this.dtpCreatedAt.Value, this.tbEmail.Text, this.tbCustomerId.Text);
           
        }

        private void btnSearch_click(object sender, EventArgs e)
        {

            List<MCustomers> ltCustomers = new List<MCustomers>();
            ltCustomers = this._irepo.GetCustomers(this.tbCustomerId.Text.ToString());
            if (ltCustomers.Count > 0)
            {

                this.tbFirstName.Text = ltCustomers[0].FirstName.ToString();
                this.tbLastName.Text = ltCustomers[0].LastName.ToString();
                this.tbEmail.Text = ltCustomers[0].Email.ToString();
                this.tbTelephon.Text = ltCustomers[0].Phone.ToString();
                this.tbStreet.Text = ltCustomers[0].street.ToString();
                this.tbNr.Text = ltCustomers[0].Housenumber.ToString();
                this.tbPlz.Text = ltCustomers[0].ZipCode.ToString();
                this.tbCity.Text = ltCustomers[0].City.ToString();
                this.dtpCreatedAt.Text = ltCustomers[0].Createdat.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            customers = new MCustomers()
            {
                FirstName = this.tbFirstName.Text,
                LastName = this.tbLastName.Text,
                street = this.tbStreet.Text,
                Housenumber = this.tbNr.Text,
                ZipCode = this.tbPlz.Text,
                City = this.tbCity.Text,
                Createdat = this.dtpCreatedAt.Value.ToString(),
                Email = this.tbEmail.Text,
                Phone = this.tbTelephon.Text,
               CustomerId = this.tbCustomerId.Text

            };

            this._irepo.AddCustomers(customers);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

           
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
