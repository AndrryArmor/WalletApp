using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletApp.Domain.Entities;
using WalletApp.Persistence.Contexts;

namespace WalletApp.Application.Services
{
    public class WalletService : IWalletService
    {
        private readonly WalletAppDbContext _walletAppDbContext;

        public WalletService(WalletAppDbContext walletAppDbContext)
        {
            _walletAppDbContext = walletAppDbContext;
        }

        public Transaction GetTransaction(int transactionId)
        {
            return _walletAppDbContext.Transactions.Single(t => t.Id == transactionId);
        }

        public IEnumerable<Transaction> GetUserLastTransactions(int userAccountId, int count)
        {
            return _walletAppDbContext.Transactions
                .Where(t => t.AccountId == userAccountId)
                .OrderByDescending(t => t.Date)
                .Take(count);
        }
    }
}
