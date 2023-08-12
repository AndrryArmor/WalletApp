using WalletApp.Domain.Entities;

namespace WalletApp.Application.DTOs
{
    public record AccountInfoDTO(double CardBalance, string PaymentDueStatus, string DailyPointsMessage, 
        IEnumerable<TransactionPreviewDTO> Transactions)
    {
        public AccountInfoDTO(AccountInfo accountInfo, IEnumerable<TransactionPreviewDTO> transactions)
            : this(accountInfo.CardBalance, accountInfo.PaymentDueStatus, accountInfo.GetDailyPointsKString(), transactions)
        {
        }
    }
}