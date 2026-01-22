using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace BankAppClassLibrary
{

    public class MCustomers
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string street { get; set; }
        public string Housenumber { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Createdat { get; set; }
       [Key]
        public string CustomerId { get; set; }
        public string AccountId { get; set; }

        public MAccounts Account { get; set; }

    }
}
