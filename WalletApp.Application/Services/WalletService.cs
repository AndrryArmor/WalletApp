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
        private readonly WalletAppContext _walletAppContext;

        public WalletService(WalletAppContext walletAppContext)
        {
            _walletAppContext = walletAppContext;
        }

        public Transaction GetTransaction(int transactionId)
        {
            return _walletAppContext.Transactions.Single(t => t.Id == transactionId);
        }

        public Account GetUserAccountInfo(int userAccountId)
        {
            return _walletAppContext.Accounts.Single(a => a.Id == userAccountId);
        }

        public IEnumerable<Transaction> GetUserLastTransactions(int userAccountId, int count)
        {
            return _walletAppContext.Accounts.Single(a => a.Id == userAccountId).Transactions.TakeLast(count);
        }
    }
}
