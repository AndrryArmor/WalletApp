

namespace WalletApp.Domain.Entities
{
    public class Transaction : Entity
    {
        private static readonly Random _random = new Random();

        public TransactionType TransactionType { get; set; }
        public decimal Sum { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public DateTime Date { get; set; }
        public bool IsPending { get; set; }
        public string? AuthorizedUser { get; set; }
        public string? Icon { get; set; }

        public int AccountId { get; set; }

        public static Transaction GetRandom()
        {
            var randomTransactionType = (TransactionType)_random.Next(2);
            var currentDateTime = DateTime.Now;
            return new Transaction()
            {
                TransactionType = randomTransactionType,
                Sum = _random.Next(1000),
                Title = randomTransactionType.GetType().Name,
                Description = _random.GetValueOrNull("Some description"),
                Date = _random.NextDateTime(currentDateTime.AddDays(-30), currentDateTime),
                IsPending = _random.NextBool(),
                AuthorizedUser = _random.GetValueOrNull("Author"),
                Icon = null
            };
        }
    }
}