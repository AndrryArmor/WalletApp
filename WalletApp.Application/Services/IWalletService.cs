using WalletApp.Domain.Entities;

namespace WalletApp.Application.Services
{
    public interface IWalletService
    {
        IEnumerable<Transaction> GetUserLastTransactions(int userAccountId, int count);
        Transaction GetTransaction(int transactionId);
        AccountInfo GetAccountInfo(int accountId);
    }
}
