using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletApp.Domain.Entities;

namespace WalletApp.Persistence.Contexts
{
    public class WalletAppContext : DbContext
    {
        private readonly List<Account> _accounts;
        private readonly List<Transaction> _transactions;

        public WalletAppContext(DbContextOptions<WalletAppContext> options) : base(options)
        {
            var random = new Random();
            _accounts = new List<Account>();
            _transactions = new List<Transaction>();

            for (int i = 1; i <= 2; i++)
            {
                _accounts.Add(new Account { Id = i });
            }

            for (int i = 0; i < 50; i++)
            {
                var randomTransaction = Transaction.GetRandom();
                randomTransaction.AccountId = _accounts[random.Next(_accounts.Count)].Id;
                _transactions.Add(randomTransaction);
            }

            _transactions = _transactions.OrderBy(t => t.Date).ToList();
            for (int i = 0; i < _transactions.Count; i++)
            {
                _transactions[i].Id = i;
            }
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .HasData(_accounts);
            modelBuilder.Entity<Transaction>()
                .HasData(_transactions);
        }

    }
}
