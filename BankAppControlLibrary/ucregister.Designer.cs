
namespace BankAppControlLibrary
{
    partial class ucregister
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.tbCustomerId = new System.Windows.Forms.TextBox();
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
            this.btnAdd.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(297, 453);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 43);
            this.btnSave.TabIndex = 57;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // LblCallNumber
            // 
            this.LblCallNumber.AutoSize = true;
            this.LblCallNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblCallNumber.Location = new System.Drawing.Point(11, 411);
            this.LblCallNumber.Name = "LblCallNumber";
            this.LblCallNumber.Size = new System.Drawing.Size(80, 20);
            this.LblCallNumber.TabIndex = 55;
            this.LblCallNumber.Text = "Phone *:";
            // 
            // tbTelephon
            // 
            this.tbTelephon.Location = new System.Drawing.Point(118, 399);
            this.tbTelephon.Name = "tbTelephon";
            this.tbTelephon.Size = new System.Drawing.Size(250, 31);
            this.tbTelephon.TabIndex = 54;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(135, 162);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(255, 31);
            this.tbEmail.TabIndex = 53;
            this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(12, 173);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(69, 20);
            this.lblEmail.TabIndex = 44;
            this.lblEmail.Text = "Email*:";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCity.Location = new System.Drawing.Point(20, 358);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(61, 20);
            this.lblCity.TabIndex = 52;
            this.lblCity.Text = "City* :";
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(119, 347);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(250, 31);
            this.tbCity.TabIndex = 51;
            // 
            // tbPlz
            // 
            this.tbPlz.Location = new System.Drawing.Point(119, 298);
            this.tbPlz.Name = "tbPlz";
            this.tbPlz.Size = new System.Drawing.Size(250, 31);
            this.tbPlz.TabIndex = 50;
            // 
            // lblNr
            // 
            this.lblNr.AutoSize = true;
            this.lblNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNr.Location = new System.Drawing.Point(37, 263);
            this.lblNr.Name = "lblNr";
            this.lblNr.Size = new System.Drawing.Size(48, 20);
            this.lblNr.TabIndex = 49;
            this.lblNr.Text = "Nr* :";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(135, 67);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(255, 31);
            this.tbFirstName.TabIndex = 45;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(136, 115);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(254, 31);
            this.tbLastName.TabIndex = 46;
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblZipCode.Location = new System.Drawing.Point(6, 305);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(102, 20);
            this.lblZipCode.TabIndex = 41;
            this.lblZipCode.Text = "Zip Code* :";
            this.lblZipCode.Click += new System.EventHandler(this.lblPlz_Click);
            // 
            // tbNr
            // 
            this.tbNr.Location = new System.Drawing.Point(119, 257);
            this.tbNr.Name = "tbNr";
            this.tbNr.Size = new System.Drawing.Size(106, 31);
            this.tbNr.TabIndex = 48;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(4, 78);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(119, 20);
            this.lblName.TabIndex = 39;
            this.lblName.Text = "Last Name *:";
            // 
            // lblstrace
            // 
            this.lblstrace.AutoSize = true;
            this.lblstrace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblstrace.Location = new System.Drawing.Point(8, 214);
            this.lblstrace.Name = "lblstrace";
            this.lblstrace.Size = new System.Drawing.Size(85, 20);
            this.lblstrace.TabIndex = 42;
            this.lblstrace.Text = "Street * :";
            // 
            // lblVorname
            // 
            this.lblVorname.AutoSize = true;
            this.lblVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVorname.Location = new System.Drawing.Point(3, 122);
            this.lblVorname.Name = "lblVorname";
            this.lblVorname.Size = new System.Drawing.Size(127, 20);
            this.lblVorname.TabIndex = 40;
            this.lblVorname.Text = "First Name * :";
            // 
            // pnlUserRegistration
            // 
            this.pnlUserRegistration.Controls.Add(this.btnDelete);
            this.pnlUserRegistration.Controls.Add(this.btnSearch);
            this.pnlUserRegistration.Controls.Add(this.btnAdd);
            this.pnlUserRegistration.Controls.Add(this.lblName);
            this.pnlUserRegistration.Controls.Add(this.tbFirstName);
            this.pnlUserRegistration.Controls.Add(this.tbLastName);
            this.pnlUserRegistration.Controls.Add(this.lblVorname);
            this.pnlUserRegistration.Controls.Add(this.tbStreet);
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
            this.pnlUserRegistration.Controls.Add(this.tbCustomerId);
            this.pnlUserRegistration.Location = new System.Drawing.Point(5, 2);
            this.pnlUserRegistration.Name = "pnlUserRegistration";
            this.pnlUserRegistration.Size = new System.Drawing.Size(452, 511);
            this.pnlUserRegistration.TabIndex = 71;
            this.pnlUserRegistration.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlUserRegistration_Paint);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(137, 455);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 39);
            this.btnDelete.TabIndex = 60;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.Location = new System.Drawing.Point(296, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 34);
            this.btnSearch.TabIndex = 59;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // tbStreet
            // 
            this.tbStreet.Location = new System.Drawing.Point(37, 16);
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.Size = new System.Drawing.Size(253, 31);
            this.tbStreet.TabIndex = 47;
            // 
            // tbCustomerId
            // 
            this.tbCustomerId.Location = new System.Drawing.Point(118, 207);
            this.tbCustomerId.Name = "tbCustomerId";
            this.tbCustomerId.Size = new System.Drawing.Size(253, 31);
            this.tbCustomerId.TabIndex = 61;
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
        internal System.Windows.Forms.TextBox tbCustomerId;
        internal System.Windows.Forms.Label lblZipCode;
		internal System.Windows.Forms.TextBox tbNr;
		internal System.Windows.Forms.Label lblName;
		internal System.Windows.Forms.Label lblstrace;
		internal System.Windows.Forms.Label lblVorname;
		internal System.Windows.Forms.Panel pnlUserRegistration;
        private System.Windows.Forms.Button btnSearch;
        internal System.Windows.Forms.TextBox tbStreet;
        private System.Windows.Forms.Button btnDelete;
    }
}
