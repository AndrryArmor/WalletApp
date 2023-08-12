using WalletApp.Domain.Entities;

namespace WalletApp.Application.DTOs
{
    public record TransactionPreviewDTO(string Title, string Amount, string FirstLineDescription, string SecondLineDescription)
    {
        public TransactionPreviewDTO(Transaction transaction)
            : this(transaction.Title,
                   transaction.GetAmountString(),
                   transaction.GetFirstLineDescription(),
                   transaction.GetSecondLineDescription())
        {
        }

        public byte[]? IconBytes { get; init; }
    }
}
