using System;

namespace WalletApp.Domain.Entities
{
    public class AccountInfoResponse
    {
        public const int MaxLimit = 1500;

        public decimal CardBalance { get; set; }
        public decimal AvailableBalance => MaxLimit - CardBalance;
        public string? NoPaymentDueMessage { get; set; }
        public string DailyPoints { get; set; } = string.Empty;

        public IEnumerable<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}