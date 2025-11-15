
namespace BankAppControlLibrary
{
    partial class ucCustomer
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.LblCallNumber = new System.Windows.Forms.Label();
            this.tbTelephon = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbPlz = new System.Windows.Forms.TextBox();
            this.lblNr = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.tbNr = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblstrace = new System.Windows.Forms.Label();
            this.lblVorname = new System.Windows.Forms.Label();
            this.pnlUserRegistration = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbCustomerId = new System.Windows.Forms.TextBox();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblCreatedAt = new System.Windows.Forms.Label();
            this.dtpCreatedAt = new System.Windows.Forms.DateTimePicker();
            this.pnlUserRegistration.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(6, 455);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 41);
            this.btnAdd.TabIndex = 58;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(211, 453);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 41);
            this.btnSave.TabIndex = 57;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // LblCallNumber
            // 
            this.LblCallNumber.AutoSize = true;
            this.LblCallNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblCallNumber.Location = new System.Drawing.Point(13, 358);
            this.LblCallNumber.Name = "LblCallNumber";
            this.LblCallNumber.Size = new System.Drawing.Size(80, 20);
            this.LblCallNumber.TabIndex = 55;
            this.LblCallNumber.Text = "Phone *:";
            // 
            // tbTelephon
            // 
            this.tbTelephon.Location = new System.Drawing.Point(126, 347);
            this.tbTelephon.Name = "tbTelephon";
            this.tbTelephon.Size = new System.Drawing.Size(250, 31);
            this.tbTelephon.TabIndex = 54;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(128, 139);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(255, 31);
            this.tbEmail.TabIndex = 53;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(23, 150);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(69, 20);
            this.lblEmail.TabIndex = 44;
            this.lblEmail.Text = "Email*:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCity.Location = new System.Drawing.Point(20, 315);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(61, 20);
            this.lblCity.TabIndex = 52;
            this.lblCity.Text = "City* :";
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(126, 307);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(250, 31);
            this.tbCity.TabIndex = 51;
            // 
            // tbPlz
            // 
            this.tbPlz.Location = new System.Drawing.Point(128, 266);
            this.tbPlz.Name = "tbPlz";
            this.tbPlz.Size = new System.Drawing.Size(250, 31);
            this.tbPlz.TabIndex = 50;
            // 
            // lblNr
            // 
            this.lblNr.AutoSize = true;
            this.lblNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNr.Location = new System.Drawing.Point(24, 236);
            this.lblNr.Name = "lblNr";
            this.lblNr.Size = new System.Drawing.Size(48, 20);
            this.lblNr.TabIndex = 49;
            this.lblNr.Text = "Nr* :";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(128, 55);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(255, 31);
            this.tbFirstName.TabIndex = 45;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(128, 96);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(254, 31);
            this.tbLastName.TabIndex = 46;
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblZipCode.Location = new System.Drawing.Point(3, 272);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(102, 20);
            this.lblZipCode.TabIndex = 41;
            this.lblZipCode.Text = "Zip Code* :";
            // 
            // tbNr
            // 
            this.tbNr.Location = new System.Drawing.Point(128, 229);
            this.tbNr.Name = "tbNr";
            this.tbNr.Size = new System.Drawing.Size(106, 31);
            this.tbNr.TabIndex = 48;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(3, 66);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(119, 20);
            this.lblName.TabIndex = 39;
            this.lblName.Text = "Last Name *:";
            // 
            // lblstrace
            // 
            this.lblstrace.AutoSize = true;
            this.lblstrace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblstrace.Location = new System.Drawing.Point(15, 191);
            this.lblstrace.Name = "lblstrace";
            this.lblstrace.Size = new System.Drawing.Size(85, 20);
            this.lblstrace.TabIndex = 42;
            this.lblstrace.Text = "Street * :";
            // 
            // lblVorname
            // 
            this.lblVorname.AutoSize = true;
            this.lblVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVorname.Location = new System.Drawing.Point(3, 100);
            this.lblVorname.Name = "lblVorname";
            this.lblVorname.Size = new System.Drawing.Size(127, 20);
            this.lblVorname.TabIndex = 40;
            this.lblVorname.Text = "First Name * :";
            // 
            // pnlUserRegistration
            // 
            this.pnlUserRegistration.Controls.Add(this.dtpCreatedAt);
            this.pnlUserRegistration.Controls.Add(this.lblCreatedAt);
            this.pnlUserRegistration.Controls.Add(this.lblCustomerID);
            this.pnlUserRegistration.Controls.Add(this.button1);
            this.pnlUserRegistration.Controls.Add(this.btnDelete);
            this.pnlUserRegistration.Controls.Add(this.btnSearch);
            this.pnlUserRegistration.Controls.Add(this.btnAdd);
            this.pnlUserRegistration.Controls.Add(this.lblName);
            this.pnlUserRegistration.Controls.Add(this.tbFirstName);
            this.pnlUserRegistration.Controls.Add(this.tbLastName);
            this.pnlUserRegistration.Controls.Add(this.lblVorname);
            this.pnlUserRegistration.Controls.Add(this.tbCustomerId);
            this.pnlUserRegistration.Controls.Add(this.lblNr);
            this.pnlUserRegistration.Controls.Add(this.lblCity);
            this.pnlUserRegistration.Controls.Add(this.lblEmail);
            this.pnlUserRegistration.Controls.Add(this.lblstrace);
            this.pnlUserRegistration.Controls.Add(this.tbCity);
            this.pnlUserRegistration.Controls.Add(this.tbEmail);
            this.pnlUserRegistration.Controls.Add(this.tbNr);
            this.pnlUserRegistration.Controls.Add(this.lblZipCode);
            this.pnlUserRegistration.Controls.Add(this.tbPlz);
            this.pnlUserRegistration.Controls.Add(this.LblCallNumber);
            this.pnlUserRegistration.Controls.Add(this.tbTelephon);
            this.pnlUserRegistration.Controls.Add(this.btnSave);
            this.pnlUserRegistration.Controls.Add(this.tbStreet);
            this.pnlUserRegistration.Location = new System.Drawing.Point(5, 2);
            this.pnlUserRegistration.Name = "pnlUserRegistration";
            this.pnlUserRegistration.Size = new System.Drawing.Size(452, 515);
            this.pnlUserRegistration.TabIndex = 71;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(336, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 38);
            this.button1.TabIndex = 62;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(101, 455);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 39);
            this.btnDelete.TabIndex = 60;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.Location = new System.Drawing.Point(336, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(102, 34);
            this.btnSearch.TabIndex = 59;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_click);
            // 
            // tbCustomerId
            // 
            this.tbCustomerId.Location = new System.Drawing.Point(128, 16);
            this.tbCustomerId.Name = "tbCustomerId";
            this.tbCustomerId.Size = new System.Drawing.Size(195, 31);
            this.tbCustomerId.TabIndex = 47;
            // 
            // tbStreet
            // 
            this.tbStreet.Location = new System.Drawing.Point(128, 180);
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.Size = new System.Drawing.Size(253, 31);
            this.tbStreet.TabIndex = 61;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(13, 16);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(107, 25);
            this.lblCustomerID.TabIndex = 63;
            this.lblCustomerID.Text = "CustomerID";
            // 
            // lblCreatedAt
            // 
            this.lblCreatedAt.AutoSize = true;
            this.lblCreatedAt.Location = new System.Drawing.Point(12, 396);
            this.lblCreatedAt.Name = "lblCreatedAt";
            this.lblCreatedAt.Size = new System.Drawing.Size(91, 25);
            this.lblCreatedAt.TabIndex = 64;
            this.lblCreatedAt.Text = "CreatedAt";
            // 
            // dtpCreatedAt
            // 
            this.dtpCreatedAt.Location = new System.Drawing.Point(128, 393);
            this.dtpCreatedAt.Name = "dtpCreatedAt";
            this.dtpCreatedAt.Size = new System.Drawing.Size(310, 31);
            this.dtpCreatedAt.TabIndex = 65;
            // 
            // ucregister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlUserRegistration);
            this.Name = "ucregister";
            this.Size = new System.Drawing.Size(460, 528);
            this.pnlUserRegistration.ResumeLayout(false);
            this.pnlUserRegistration.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
		internal System.Windows.Forms.Button btnAdd;
		internal System.Windows.Forms.Button btnSave;
		internal System.Windows.Forms.Label LblCallNumber;
		internal System.Windows.Forms.TextBox tbTelephon;
		internal System.Windows.Forms.TextBox tbEmail;
		internal System.Windows.Forms.Label lblEmail;
		internal System.Windows.Forms.Label lblCity;
		internal System.Windows.Forms.TextBox tbCity;
		internal System.Windows.Forms.TextBox tbPlz;
		internal System.Windows.Forms.Label lblNr;
		internal System.Windows.Forms.TextBox tbFirstName;
		internal System.Windows.Forms.TextBox tbLastName;
        internal System.Windows.Forms.TextBox tbStreet;
        internal System.Windows.Forms.Label lblZipCode;
		internal System.Windows.Forms.TextBox tbNr;
		internal System.Windows.Forms.Label lblName;
		internal System.Windows.Forms.Label lblstrace;
		internal System.Windows.Forms.Label lblVorname;
		internal System.Windows.Forms.Panel pnlUserRegistration;
        private System.Windows.Forms.Button btnSearch;
        internal System.Windows.Forms.TextBox tbCustomerId;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.DateTimePicker dtpCreatedAt;
        private System.Windows.Forms.Label lblCreatedAt;
    }
}
