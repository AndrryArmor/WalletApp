namespace WalletApp.Domain.Entities
{
    public class Account : Entity
    {
        public float CardBalance { get; set; }
        public float AvailableBalance { get; set; }
        public string? NoPaymentDueMessage { get; set; }
        public int DailyPoints { get; set; }
    }
}