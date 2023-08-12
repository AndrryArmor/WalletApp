using Microsoft.EntityFrameworkCore;
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
                var randomTransaction = Transaction.GetRandomTransaction();
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
