
namespace BankAppControlLibrary
{
    partial class UserTransactions
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
            this.tbAccountID = new System.Windows.Forms.TextBox();
            this.tbIban = new System.Windows.Forms.TextBox();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.tbPurpose = new System.Windows.Forms.TextBox();
            this.tbTransactionID = new System.Windows.Forms.TextBox();
            this.tbCustomerID = new System.Windows.Forms.TextBox();
            this.btnTranfert = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAllTransactions = new System.Windows.Forms.Button();
            this.dgvTansactions = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dptTransactionDate = new System.Windows.Forms.DateTimePicker();
            this.lblTransactionsID = new System.Windows.Forms.Label();
            this.lblIban = new System.Windows.Forms.Label();
            this.lblAccountID = new System.Windows.Forms.Label();
            this.lblPurpose = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.cbTansactionType = new System.Windows.Forms.ComboBox();
            this.btnOldTransaction = new System.Windows.Forms.Button();
            this.btnNewTransaction = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDisplaySaldo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvColTransactionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColAccountID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvIban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColPurpose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTansactions)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbAccountID
            // 
            this.tbAccountID.Location = new System.Drawing.Point(101, 20);
            this.tbAccountID.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbAccountID.Name = "tbAccountID";
            this.tbAccountID.Size = new System.Drawing.Size(247, 31);
            this.tbAccountID.TabIndex = 16;
            // 
            // tbIban
            // 
            this.tbIban.Location = new System.Drawing.Point(101, 107);
            this.tbIban.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbIban.Name = "tbIban";
            this.tbIban.Size = new System.Drawing.Size(244, 31);
            this.tbIban.TabIndex = 14;
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(101, 63);
            this.tbAmount.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(241, 31);
            this.tbAmount.TabIndex = 15;
            // 
            // tbPurpose
            // 
            this.tbPurpose.BackColor = System.Drawing.SystemColors.Window;
            this.tbPurpose.Location = new System.Drawing.Point(109, 263);
            this.tbPurpose.Name = "tbPurpose";
            this.tbPurpose.Size = new System.Drawing.Size(228, 31);
            this.tbPurpose.TabIndex = 17;
            // 
            // tbTransactionID
            // 
            this.tbTransactionID.Location = new System.Drawing.Point(137, 165);
            this.tbTransactionID.Name = "tbTransactionID";
            this.tbTransactionID.Size = new System.Drawing.Size(208, 31);
            this.tbTransactionID.TabIndex = 18;
            // 
            // tbCustomerID
            // 
            this.tbCustomerID.Location = new System.Drawing.Point(25, 19);
            this.tbCustomerID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCustomerID.Name = "tbCustomerID";
            this.tbCustomerID.Size = new System.Drawing.Size(321, 31);
            this.tbCustomerID.TabIndex = 5;
            // 
            // btnTranfert
            // 
            this.btnTranfert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTranfert.Location = new System.Drawing.Point(13, 357);
            this.btnTranfert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTranfert.Name = "btnTranfert";
            this.btnTranfert.Size = new System.Drawing.Size(116, 38);
            this.btnTranfert.TabIndex = 6;
            this.btnTranfert.Text = "transfert";
            this.btnTranfert.UseVisualStyleBackColor = false;
            this.btnTranfert.Click += new System.EventHandler(this.btnTransfert_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.Location = new System.Drawing.Point(133, 354);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 38);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.Location = new System.Drawing.Point(247, 353);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 38);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_click);
            // 
            // btnAllTransactions
            // 
            this.btnAllTransactions.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAllTransactions.Location = new System.Drawing.Point(684, 13);
            this.btnAllTransactions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAllTransactions.Name = "btnAllTransactions";
            this.btnAllTransactions.Size = new System.Drawing.Size(149, 38);
            this.btnAllTransactions.TabIndex = 9;
            this.btnAllTransactions.Text = "All Transactions";
            this.btnAllTransactions.UseVisualStyleBackColor = false;
            this.btnAllTransactions.Click += new System.EventHandler(this.btnAllTransactions_Click);
            // 
            // dgvTansactions
            // 
            this.dgvTansactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTansactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColTransactionID,
            this.dgvColAccountID,
            this.dgvIban,
            this.dgvAmount,
            this.dgvColType,
            this.dgvColPurpose,
            this.dgvColDate});
            this.dgvTansactions.Location = new System.Drawing.Point(25, 61);
            this.dgvTansactions.Name = "dgvTansactions";
            this.dgvTansactions.RowHeadersWidth = 62;
            this.dgvTansactions.RowTemplate.Height = 33;
            this.dgvTansactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTansactions.Size = new System.Drawing.Size(832, 362);
            this.dgvTansactions.TabIndex = 10;
            this.dgvTansactions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransactions_CellClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dptTransactionDate);
            this.panel1.Controls.Add(this.lblTransactionsID);
            this.panel1.Controls.Add(this.lblIban);
            this.panel1.Controls.Add(this.lblAccountID);
            this.panel1.Controls.Add(this.lblPurpose);
            this.panel1.Controls.Add(this.lblAmount);
            this.panel1.Controls.Add(this.lblType);
            this.panel1.Controls.Add(this.btnTranfert);
            this.panel1.Controls.Add(this.cbTansactionType);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.tbAccountID);
            this.panel1.Controls.Add(this.tbIban);
            this.panel1.Controls.Add(this.tbAmount);
            this.panel1.Controls.Add(this.tbPurpose);
            this.panel1.Controls.Add(this.tbTransactionID);
            this.panel1.Location = new System.Drawing.Point(863, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 404);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Date";
            // 
            // dptTransactionDate
            // 
            this.dptTransactionDate.Location = new System.Drawing.Point(109, 309);
            this.dptTransactionDate.Name = "dptTransactionDate";
            this.dptTransactionDate.Size = new System.Drawing.Size(244, 31);
            this.dptTransactionDate.TabIndex = 19;
            // 
            // lblTransactionsID
            // 
            this.lblTransactionsID.AutoSize = true;
            this.lblTransactionsID.Location = new System.Drawing.Point(8, 171);
            this.lblTransactionsID.Name = "lblTransactionsID";
            this.lblTransactionsID.Size = new System.Drawing.Size(122, 25);
            this.lblTransactionsID.TabIndex = 11;
            this.lblTransactionsID.Text = "TransactionID:";
            // 
            // lblIban
            // 
            this.lblIban.AutoSize = true;
            this.lblIban.Location = new System.Drawing.Point(5, 111);
            this.lblIban.Name = "lblIban";
            this.lblIban.Size = new System.Drawing.Size(52, 25);
            this.lblIban.TabIndex = 10;
            this.lblIban.Text = "IBAN";
            // 
            // lblAccountID
            // 
            this.lblAccountID.AutoSize = true;
            this.lblAccountID.Location = new System.Drawing.Point(4, 23);
            this.lblAccountID.Name = "lblAccountID";
            this.lblAccountID.Size = new System.Drawing.Size(95, 25);
            this.lblAccountID.TabIndex = 9;
            this.lblAccountID.Text = "AccountID";
            // 
            // lblPurpose
            // 
            this.lblPurpose.AutoSize = true;
            this.lblPurpose.Location = new System.Drawing.Point(17, 267);
            this.lblPurpose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPurpose.Name = "lblPurpose";
            this.lblPurpose.Size = new System.Drawing.Size(77, 25);
            this.lblPurpose.TabIndex = 4;
            this.lblPurpose.Text = "Purpose";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(4, 72);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(77, 25);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.Text = "Amount";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(20, 225);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(49, 25);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Type";
            // 
            // cbTansactionType
            // 
            this.cbTansactionType.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cbTansactionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTansactionType.FormattingEnabled = true;
            this.cbTansactionType.Items.AddRange(new object[] {
            "Withdrawal",
            "Deposit",
            "Transfer",
            "Incoming"});
            this.cbTansactionType.Location = new System.Drawing.Point(109, 220);
            this.cbTansactionType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTansactionType.Name = "cbTansactionType";
            this.cbTansactionType.Size = new System.Drawing.Size(228, 33);
            this.cbTansactionType.TabIndex = 1;
            // 
            // btnOldTransaction
            // 
            this.btnOldTransaction.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnOldTransaction.Location = new System.Drawing.Point(351, 14);
            this.btnOldTransaction.Name = "btnOldTransaction";
            this.btnOldTransaction.Size = new System.Drawing.Size(153, 39);
            this.btnOldTransaction.TabIndex = 12;
            this.btnOldTransaction.Text = "old Transactions";
            this.btnOldTransaction.UseVisualStyleBackColor = false;
            this.btnOldTransaction.Click += new System.EventHandler(this.btnOldTransactions_Click);
            // 
            // btnNewTransaction
            // 
            this.btnNewTransaction.Location = new System.Drawing.Point(507, 15);
            this.btnNewTransaction.Name = "btnNewTransaction";
            this.btnNewTransaction.Size = new System.Drawing.Size(171, 38);
            this.btnNewTransaction.TabIndex = 13;
            this.btnNewTransaction.Text = "New Transactions";
            this.btnNewTransaction.UseVisualStyleBackColor = true;
            this.btnNewTransaction.Click += new System.EventHandler(this.btnNewTransactions_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(15, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 40);
            this.button3.TabIndex = 14;
            this.button3.Text = "Display Balance";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnDisplayBalance__Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblDisplaySaldo);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Location = new System.Drawing.Point(25, 429);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(808, 44);
            this.panel2.TabIndex = 20;
            // 
            // lblDisplaySaldo
            // 
            this.lblDisplaySaldo.AutoSize = true;
            this.lblDisplaySaldo.Location = new System.Drawing.Point(241, 8);
            this.lblDisplaySaldo.Name = "lblDisplaySaldo";
            this.lblDisplaySaldo.Size = new System.Drawing.Size(0, 25);
            this.lblDisplaySaldo.TabIndex = 60;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(981, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 34);
            this.button1.TabIndex = 21;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dgvColTransactionID
            // 
            this.dgvColTransactionID.HeaderText = "TransactionID";
            this.dgvColTransactionID.MinimumWidth = 8;
            this.dgvColTransactionID.Name = "dgvColTransactionID";
            this.dgvColTransactionID.Width = 150;
            // 
            // dgvColAccountID
            // 
            this.dgvColAccountID.HeaderText = "AccountId";
            this.dgvColAccountID.MinimumWidth = 8;
            this.dgvColAccountID.Name = "dgvColAccountID";
            this.dgvColAccountID.Width = 150;
            // 
            // dgvIban
            // 
            this.dgvIban.HeaderText = "IBAN";
            this.dgvIban.MinimumWidth = 8;
            this.dgvIban.Name = "dgvIban";
            this.dgvIban.Width = 150;
            // 
            // dgvAmount
            // 
            this.dgvAmount.HeaderText = "Amount";
            this.dgvAmount.MinimumWidth = 8;
            this.dgvAmount.Name = "dgvAmount";
            this.dgvAmount.Width = 150;
            // 
            // dgvColType
            // 
            this.dgvColType.HeaderText = "Type";
            this.dgvColType.MinimumWidth = 8;
            this.dgvColType.Name = "dgvColType";
            this.dgvColType.Width = 150;
            // 
            // dgvColPurpose
            // 
            this.dgvColPurpose.HeaderText = "Purpose";
            this.dgvColPurpose.MinimumWidth = 8;
            this.dgvColPurpose.Name = "dgvColPurpose";
            this.dgvColPurpose.Width = 110;
            // 
            // dgvColDate
            // 
            this.dgvColDate.HeaderText = "Date";
            this.dgvColDate.MinimumWidth = 8;
            this.dgvColDate.Name = "dgvColDate";
            this.dgvColDate.Width = 150;
            // 
            // UserTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnNewTransaction);
            this.Controls.Add(this.btnOldTransaction);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvTansactions);
            this.Controls.Add(this.tbCustomerID);
            this.Controls.Add(this.btnAllTransactions);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserTransactions";
            this.Size = new System.Drawing.Size(1257, 480);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTansactions)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbAccountID;
        private System.Windows.Forms.TextBox tbIban;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.TextBox tbPurpose;
        private System.Windows.Forms.TextBox tbTransactionID;
        //private System.Windows.Forms.TextBox tbDisplayBalance;
        private System.Windows.Forms.TextBox tbCustomerID;
        private System.Windows.Forms.Button btnTranfert;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAllTransactions;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cbTansactionType;
        private System.Windows.Forms.Label lblAmount;
        //private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.DataGridView dgvTansactions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAccountID;
        private System.Windows.Forms.Button btnOldTransaction;
        private System.Windows.Forms.Button btnNewTransaction;
        private System.Windows.Forms.Label lblPurpose;
        private System.Windows.Forms.Label lblTransactionsID;
        private System.Windows.Forms.Label lblIban;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDisplaySaldo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dptTransactionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColTransactionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColAccountID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIban;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColPurpose;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColDate;
    }
}
