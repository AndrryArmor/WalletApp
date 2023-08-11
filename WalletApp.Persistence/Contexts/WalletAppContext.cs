using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletApp.Domain.Entities;

namespace WalletApp.Persistence.Contexts
{
    public class WalletAppDbContext : DbContext
    {
        private readonly List<Transaction> _transactions;

        public WalletAppDbContext(DbContextOptions<WalletAppDbContext> options) : base(options)
        {
            var random = new Random();
            _transactions = new List<Transaction>();

            for (int i = 0; i < 25; i++)
            {
                var randomTransaction = Transaction.GetRandom();
                randomTransaction.AccountId = random.Next(2) + 1;
                _transactions.Add(randomTransaction);
            }

            _transactions = _transactions.OrderBy(t => t.Date).ToList();
            for (int i = 0; i < _transactions.Count; i++)
            {
                _transactions[i].Id = i + 1;
            }
        }

        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Transaction>()
                .HasData(_transactions);
        }
    }
}
