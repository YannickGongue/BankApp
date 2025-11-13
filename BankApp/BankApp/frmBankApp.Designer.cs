
namespace BankApp
{
    partial class frmBankApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmuiCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmuiRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmuiAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUserTransactions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.extrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmuiCustomer,
            this.toolStripMenuItem5,
            this.extrasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1311, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmuiCustomer
            // 
            this.tsmuiCustomer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmuiRegister,
            this.tsmuiAccount,
            this.tsmiUserTransactions});
            this.tsmuiCustomer.Name = "tsmuiCustomer";
            this.tsmuiCustomer.Size = new System.Drawing.Size(75, 20);
            this.tsmuiCustomer.Text = "Customer";
            // 
            // tsmuiRegister
            // 
            this.tsmuiRegister.Name = "tsmuiRegister";
            this.tsmuiRegister.Size = new System.Drawing.Size(222, 34);
            this.tsmuiRegister.Text = "Customer Registration";
            this.tsmuiRegister.Click += new System.EventHandler(this.tsmuiRegister_Click);
            // 
            // tsmuiAccount
            // 
            this.tsmuiAccount.Name = "tsmuiAccount";
            this.tsmuiAccount.Size = new System.Drawing.Size(222, 34);
            this.tsmuiAccount.Text = "Account managing";
            this.tsmuiAccount.Click += new System.EventHandler(this.tsmuiAccount_Click);
            // 
            // tsmiUserTransactions
            // 
            this.tsmiUserTransactions.Name = "tsmiUserTransactions";
            this.tsmiUserTransactions.Size = new System.Drawing.Size(222, 34);
            this.tsmiUserTransactions.Text = "Transactions";
            this.tsmiUserTransactions.Click += new System.EventHandler(this.tsmuiTransactions_click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(16, 20);
            // 
            // extrasToolStripMenuItem
            // 
            this.extrasToolStripMenuItem.Name = "extrasToolStripMenuItem";
            this.extrasToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.extrasToolStripMenuItem.Text = "Extras";
            // 
            // pnlControl
            // 
            this.pnlControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlControl.Location = new System.Drawing.Point(24, 38);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(1275, 646);
            this.pnlControl.TabIndex = 1;
            // 
            // frmBankApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 696);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmBankApp";
            this.Text = "Bank App";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmuiCustomer;
        private System.Windows.Forms.ToolStripMenuItem tsmuiRegister;
        private System.Windows.Forms.ToolStripMenuItem tsmuiAccount;
        private System.Windows.Forms.ToolStripMenuItem tsmiUserTransactions;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem extrasToolStripMenuItem;
        private System.Windows.Forms.Panel pnlControl;
        //private System.Windows.Forms.Panel pnlControl;
    }
}