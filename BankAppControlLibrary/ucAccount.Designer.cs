
namespace BankAppControlLibrary
{
    partial class ucAccount
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
            this.lblDate = new System.Windows.Forms.Label();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbAccount = new System.Windows.Forms.GroupBox();
            this.lblAccountId = new System.Windows.Forms.Label();
            this.tbAccountId = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblIban = new System.Windows.Forms.Label();
            this.tbBalance = new System.Windows.Forms.TextBox();
            this.tbIban = new System.Windows.Forms.TextBox();
            this.cbAccountType = new System.Windows.Forms.ComboBox();
            this.lblAccounType = new System.Windows.Forms.Label();
            this.tbCustomerID = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(21, 373);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(127, 56);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDate.Location = new System.Drawing.Point(21, 189);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(64, 22);
            this.lblDate.TabIndex = 17;
            this.lblDate.Text = "Date :";
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(162, 181);
            this.tbDate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(307, 31);
            this.tbDate.TabIndex = 16;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(372, 373);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(144, 56);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbAccount
            // 
            this.gbAccount.Controls.Add(this.lblAccountId);
            this.gbAccount.Controls.Add(this.tbAccountId);
            this.gbAccount.Controls.Add(this.lblBalance);
            this.gbAccount.Controls.Add(this.lblIban);
            this.gbAccount.Controls.Add(this.tbBalance);
            this.gbAccount.Controls.Add(this.tbIban);
            this.gbAccount.Controls.Add(this.lblDate);
            this.gbAccount.Controls.Add(this.tbDate);
            this.gbAccount.Controls.Add(this.cbAccountType);
            this.gbAccount.Controls.Add(this.lblAccounType);
            this.gbAccount.Location = new System.Drawing.Point(4, 54);
            this.gbAccount.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.gbAccount.Name = "gbAccount";
            this.gbAccount.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.gbAccount.Size = new System.Drawing.Size(499, 299);
            this.gbAccount.TabIndex = 25;
            this.gbAccount.TabStop = false;
            this.gbAccount.Text = "Account";
            // 
            // lblAccountId
            // 
            this.lblAccountId.AutoSize = true;
            this.lblAccountId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAccountId.Location = new System.Drawing.Point(24, 50);
            this.lblAccountId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccountId.Name = "lblAccountId";
            this.lblAccountId.Size = new System.Drawing.Size(110, 22);
            this.lblAccountId.TabIndex = 29;
            this.lblAccountId.Text = "AccountId :";
            // 
            // tbAccountId
            // 
            this.tbAccountId.Location = new System.Drawing.Point(162, 40);
            this.tbAccountId.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbAccountId.Name = "tbAccountId";
            this.tbAccountId.Size = new System.Drawing.Size(307, 31);
            this.tbAccountId.TabIndex = 28;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBalance.Location = new System.Drawing.Point(7, 141);
            this.lblBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(171, 22);
            this.lblBalance.TabIndex = 23;
            this.lblBalance.Text = "opening Balance :";
            // 
            // lblIban
            // 
            this.lblIban.AutoSize = true;
            this.lblIban.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIban.Location = new System.Drawing.Point(29, 100);
            this.lblIban.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIban.Name = "lblIban";
            this.lblIban.Size = new System.Drawing.Size(67, 22);
            this.lblIban.TabIndex = 22;
            this.lblIban.Text = "IBAN :";
            // 
            // tbBalance
            // 
            this.tbBalance.Location = new System.Drawing.Point(186, 136);
            this.tbBalance.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbBalance.Name = "tbBalance";
            this.tbBalance.Size = new System.Drawing.Size(283, 31);
            this.tbBalance.TabIndex = 25;
            // 
            // tbIban
            // 
            this.tbIban.Location = new System.Drawing.Point(162, 90);
            this.tbIban.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbIban.Name = "tbIban";
            this.tbIban.Size = new System.Drawing.Size(304, 31);
            this.tbIban.TabIndex = 27;
            // 
            // cbAccountType
            // 
            this.cbAccountType.FormattingEnabled = true;
            this.cbAccountType.Items.AddRange(new object[] {
            "Withdrawal",
            "Deposit",
            "Transfer",
            "Incoming"});
            this.cbAccountType.Location = new System.Drawing.Point(163, 230);
            this.cbAccountType.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cbAccountType.Name = "cbAccountType";
            this.cbAccountType.Size = new System.Drawing.Size(307, 33);
            this.cbAccountType.TabIndex = 15;
            // 
            // lblAccounType
            // 
            this.lblAccounType.AutoSize = true;
            this.lblAccounType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAccounType.Location = new System.Drawing.Point(17, 235);
            this.lblAccounType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccounType.Name = "lblAccounType";
            this.lblAccounType.Size = new System.Drawing.Size(127, 22);
            this.lblAccounType.TabIndex = 14;
            this.lblAccounType.Text = "AccountType";
            // 
            // tbCustomerID
            // 
            this.tbCustomerID.Location = new System.Drawing.Point(42, 19);
            this.tbCustomerID.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbCustomerID.Name = "tbCustomerID";
            this.tbCustomerID.Size = new System.Drawing.Size(307, 31);
            this.tbCustomerID.TabIndex = 6;
            this.tbCustomerID.Text = "customerId enter";
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(356, 16);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(129, 34);
            this.btSearch.TabIndex = 30;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.Location = new System.Drawing.Point(190, 373);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(141, 56);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // ucAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbAccount);
            this.Controls.Add(this.tbCustomerID);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "ucAccount";
            this.Size = new System.Drawing.Size(544, 479);
            this.gbAccount.ResumeLayout(false);
            this.gbAccount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.Label lblDate;
        internal System.Windows.Forms.TextBox tbDate;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.GroupBox gbAccount;
        internal System.Windows.Forms.TextBox tbCustomerID;
        internal System.Windows.Forms.TextBox tbIban;
        internal System.Windows.Forms.TextBox tbUserId;    
        internal System.Windows.Forms.Label lblBalance;
        internal System.Windows.Forms.Label lblIban;
        internal System.Windows.Forms.TextBox tbBalance;
        internal System.Windows.Forms.Label lblAccountId;
        internal System.Windows.Forms.TextBox tbAccountId;
        internal System.Windows.Forms.ComboBox cbAccountType;
        internal System.Windows.Forms.Label lblAccounType;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Button btnDelete;
    }
}
