using WalletApp.Domain.Entities;

namespace WalletApp.Application.DTOs
{
    public record TransactionDTO(string Title, double Amount, TransactionType TransactionType, DateTime Date)
    {
        public TransactionDTO(Transaction transaction)
            : this(transaction.Title, transaction.Amount, transaction.TransactionType, transaction.Date)
        {
            Description = transaction.Description;
            IsPending = transaction.IsPending;
            AuthorizedUser = transaction.AuthorizedUser;
        }

        public string? Description { get; init; }
        public bool IsPending { get; init; }
        public string? AuthorizedUser { get; init; }
    }
}
