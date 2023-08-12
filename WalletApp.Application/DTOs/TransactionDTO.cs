using WalletApp.Domain.Entities;

namespace WalletApp.Application.DTOs
{
    public record TransactionDTO(string Title, double Amount, string TransactionType, string DateTime)
    {
        public TransactionDTO(Transaction transaction)
            : this(transaction.Title, transaction.Amount, transaction.TransactionType.ToString(), transaction.Date.ToString("dd.MM.yyyy, HH:mm"))
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
