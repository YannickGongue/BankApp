using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BankAppClassLibrary
{
    public class dbBankAppContext : DbContext
    {   

        public dbBankAppContext(DbContextOptions<dbBankAppContext> BankDB) : base(BankDB){}

        public DbSet<MCustomers> Customer { get; set; }
        public DbSet<MAccounts> Account { get; set; }
        public DbSet<MTransactions> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<MCustomers>()
              .HasKey(c => c.CustomerId);

            modelBuilder.Entity<MAccounts>()
                .HasKey(a => a.AccountId);

            modelBuilder.Entity<MCustomers>()
                .HasOne(c => c.Account)
                .WithMany(a => a.Customer)
                .HasForeignKey(c => c.AccountId);
        }

    }
}
