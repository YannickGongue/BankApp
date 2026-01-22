using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace BankAppClassLibrary
{

    public class MAccounts
    {
        [Key]
        public string AccountId { get; set; }
        public string CustomerId { get; set; }
        public string Iban { get; set; }
        public string AccountType { get; set; }
        public string Balance { get; set; }
        public string CreatedAt { get; set; }
        
        public ICollection<MCustomers> Customer { get; set; }
    }
}
