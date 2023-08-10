using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletApp.Domain.Entities;

namespace WalletApp.Application.Services
{
    public interface IWalletService
    {
        IEnumerable<Transaction> GetUserLastTransactions(int userAccountId, int count);
        Transaction GetTransaction(int transactionId);
    }
}
