namespace WalletApp.Domain.Entities
{
    public class Account : Entity
    {
        public decimal CardBalance { get; set; }
        public decimal AvailableBalance { get; set; }
        public string? NoPaymentDueMessage { get; set; }
        public int DailyPoints { get; set; }

        public ICollection<Transaction> Transactions { get; } = new List<Transaction>();
    }
}