using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;



namespace BankAppClassLibrary
{
    [Table("Transactions", Schema = "dbo")]

    public class MTransactions
    {
        [Key]
        public string TransactionID { get; set; }
        public MAccounts AccountId { get; set; }
        public string TransactionType { get; set; }
        public string Amount { get; set; }
        public string TransactionsDate { get; set; }
        public string Createdat { get; set; }

    }
}
