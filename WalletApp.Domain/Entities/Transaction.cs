namespace WalletApp.Domain.Entities
{
    public class Transaction : Entity
    {
        public TransactionType TransactionType { get; set; }
        public float Sum { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public DateTime Date { get; set; }
        public bool IsPending { get; set; }
        public string? AuthorizedUser { get; set; }
        public string? Icon { get; set; }
    }
}