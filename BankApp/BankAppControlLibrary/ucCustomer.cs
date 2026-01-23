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
        private MCustomers _mCustomers;
        private IRepository _irepo;

        public ucCustomer(IRepository irepo, MCustomers mCustomers)
        {
            InitializeComponent();
            this._irepo = irepo;
            this._mCustomers = mCustomers;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
                     
        }

        private async void btnSearch_click(object sender, EventArgs e)
        {
            List<MCustomers> ltCustomers = new List<MCustomers>();
            ltCustomers = await this._irepo.GetCustomers(this.tbCustomerId.Text.ToString());
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

        private async void btnAdd_Click(object sender, EventArgs e)
        {

            this._mCustomers.FirstName = this.tbFirstName.Text;
            this._mCustomers.LastName = this.tbLastName.Text;
            this._mCustomers.street = this.tbStreet.Text;
            this._mCustomers.Housenumber = this.tbNr.Text;
            this._mCustomers.ZipCode = this.tbPlz.Text;
            this._mCustomers.City = this.tbCity.Text;
            this._mCustomers.Createdat = this.dtpCreatedAt.Value.ToString();
            this._mCustomers.Email = this.tbEmail.Text;
            this._mCustomers.Phone = this.tbTelephon.Text;
            this._mCustomers.CustomerId = this.tbCustomerId.Text;

           await this._irepo.AddCustomers(_mCustomers);
            MessageBox.Show("Customer has saved");

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
