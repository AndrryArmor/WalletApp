using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletApp.Domain.Entities;

namespace WalletApp.Application.Services
{
    public class WalletService : IWalletService
    {
        public Transaction GetTransaction(int transactionId)
        {
            throw new NotImplementedException();
        }

        public Account GetUserAccountInfo(int userAccountId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Transaction> GetUserLastTransactions(int userAccountId)
        {
            throw new NotImplementedException();
        }
    }
}
