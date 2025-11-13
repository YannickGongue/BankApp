
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
            this.tbDate = new System.Windows.Forms.TextBox();
            this.tbIban = new System.Windows.Forms.TextBox();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.tbPurpose = new System.Windows.Forms.TextBox();
            this.tbTransactionNr = new System.Windows.Forms.TextBox();
            this.tbDisplayBalance = new System.Windows.Forms.TextBox();
            this.tbCustomerIB = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvColDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purpose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColTransactionNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTransactionsNr = new System.Windows.Forms.Label();
            this.lblIban = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPurpose = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(66, 20);
            this.tbDate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(282, 31);
            this.tbDate.TabIndex = 16;
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
            this.tbPurpose.Location = new System.Drawing.Point(131, 271);
            this.tbPurpose.Name = "tbPurpose";
            this.tbPurpose.Size = new System.Drawing.Size(211, 31);
            this.tbPurpose.TabIndex = 17;
            // 
            // tbTransactionNr
            // 
            this.tbTransactionNr.Location = new System.Drawing.Point(134, 170);
            this.tbTransactionNr.Name = "tbTransactionNr";
            this.tbTransactionNr.Size = new System.Drawing.Size(208, 31);
            this.tbTransactionNr.TabIndex = 18;
            // 
            // tbDisplayBalance
            // 
            this.tbDisplayBalance.Location = new System.Drawing.Point(132, 179);
            this.tbDisplayBalance.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbDisplayBalance.Name = "tbDisplayBalance";
            this.tbDisplayBalance.Size = new System.Drawing.Size(307, 31);
            this.tbDisplayBalance.TabIndex = 19;
            // 
            // tbCustomerIB
            // 
            this.tbCustomerIB.Location = new System.Drawing.Point(25, 19);
            this.tbCustomerIB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCustomerIB.Name = "tbCustomerIB";
            this.tbCustomerIB.Size = new System.Drawing.Size(321, 31);
            this.tbCustomerIB.TabIndex = 5;
            this.tbCustomerIB.Text = "Customer id enter";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.Location = new System.Drawing.Point(13, 357);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 38);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
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
            this.btnSave.Click += new System.EventHandler(this.buttonSave_Click);
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
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonRefresh.Location = new System.Drawing.Point(684, 13);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(149, 38);
            this.buttonRefresh.TabIndex = 9;
            this.buttonRefresh.Text = "All Transactions";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColDate,
            this.dgvAmount,
            this.Purpose,
            this.dgvColTransactionNr,
            this.dgvColType});
            this.dataGridView1.Location = new System.Drawing.Point(25, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(816, 387);
            this.dataGridView1.TabIndex = 10;
            // 
            // dgvColDate
            // 
            this.dgvColDate.HeaderText = "Date";
            this.dgvColDate.MinimumWidth = 8;
            this.dgvColDate.Name = "dgvColDate";
            this.dgvColDate.Width = 150;
            // 
            // dgvAmount
            // 
            this.dgvAmount.HeaderText = "Amount";
            this.dgvAmount.MinimumWidth = 8;
            this.dgvAmount.Name = "dgvAmount";
            this.dgvAmount.Width = 150;
            // 
            // Purpose
            // 
            this.Purpose.HeaderText = "IBAN";
            this.Purpose.MinimumWidth = 8;
            this.Purpose.Name = "Purpose";
            this.Purpose.Width = 150;
            // 
            // dgvColTransactionNr
            // 
            this.dgvColTransactionNr.HeaderText = "TransactionNr";
            this.dgvColTransactionNr.MinimumWidth = 8;
            this.dgvColTransactionNr.Name = "dgvColTransactionNr";
            this.dgvColTransactionNr.Width = 150;
            // 
            // dgvColType
            // 
            this.dgvColType.HeaderText = "Type";
            this.dgvColType.MinimumWidth = 8;
            this.dgvColType.Name = "dgvColType";
            this.dgvColType.Width = 150;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTransactionsNr);
            this.panel1.Controls.Add(this.lblIban);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblPurpose);
            this.panel1.Controls.Add(this.lblAmount);
            this.panel1.Controls.Add(this.lblType);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.comboBoxType);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.tbDate);
            this.panel1.Controls.Add(this.tbIban);
            this.panel1.Controls.Add(this.tbAmount);
            this.panel1.Controls.Add(this.tbPurpose);
            this.panel1.Controls.Add(this.tbTransactionNr);
            this.panel1.Location = new System.Drawing.Point(847, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 429);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblTransactionsNr
            // 
            this.lblTransactionsNr.AutoSize = true;
            this.lblTransactionsNr.Location = new System.Drawing.Point(8, 171);
            this.lblTransactionsNr.Name = "lblTransactionsNr";
            this.lblTransactionsNr.Size = new System.Drawing.Size(128, 25);
            this.lblTransactionsNr.TabIndex = 11;
            this.lblTransactionsNr.Text = "TransactionNr :";
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
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(4, 23);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(49, 25);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "Date";
            // 
            // lblPurpose
            // 
            this.lblPurpose.AutoSize = true;
            this.lblPurpose.Location = new System.Drawing.Point(13, 278);
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
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Withdrawal",
            "Deposit",
            "Transfer",
            "Incoming"});
            this.comboBoxType.Location = new System.Drawing.Point(131, 220);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(206, 33);
            this.comboBoxType.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(351, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 39);
            this.button1.TabIndex = 12;
            this.button1.Text = "old Transactions";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(507, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 38);
            this.button2.TabIndex = 13;
            this.button2.Text = "New Transactions";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(28, 463);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 34);
            this.button3.TabIndex = 14;
            this.button3.Text = "Display Balance";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // UserTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbCustomerIB);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.tbDisplayBalance);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserTransactions";
            this.Size = new System.Drawing.Size(1347, 583);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.TextBox tbIban;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.TextBox tbPurpose;
        private System.Windows.Forms.TextBox tbTransactionNr;
        private System.Windows.Forms.TextBox tbDisplayBalance;
        private System.Windows.Forms.TextBox tbCustomerIB;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purpose;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColTransactionNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblPurpose;
        private System.Windows.Forms.Label lblTransactionsNr;
        private System.Windows.Forms.Label lblIban;
        private System.Windows.Forms.Button button3;
    }
}
