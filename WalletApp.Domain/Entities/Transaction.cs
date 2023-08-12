using System.ComponentModel.DataAnnotations.Schema;

namespace WalletApp.Domain.Entities
{
    public class Transaction : Entity
    {
        private static readonly Random _random = new Random();

        public Transaction(string title, decimal amount, TransactionType transactionType, DateTime date)
        {
            Title = title;
            Amount = amount;
            TransactionType = transactionType;
            Date = date;
        }

        public string Title { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Amount { get; set; }
        public TransactionType TransactionType { get; set; }
        public DateTime Date { get; set; }
        public string? Description { get; set; }
        public bool IsPending { get; set; }
        public string? AuthorizedUser { get; set; }

        public int AccountId { get; set; }

        public static Transaction GetRandomTransaction()
        {
            var transactionType = (TransactionType)_random.Next(2);
            var transactionTitle = transactionType.ToString();
            var transactionAmount = _random.NextDecimal() * 1000;
            var currentDateTime = DateTime.Now;
            var transactionDate = _random.NextDateTime(currentDateTime.AddDays(-30), currentDateTime);
            return new Transaction(transactionTitle, transactionAmount, transactionType, transactionDate)
            {
                Description = _random.GetValueOrNull("Some description"),
                IsPending = _random.NextBool(),
                AuthorizedUser = _random.GetValueOrNull("Author")
            };
        }

        public string GetAmountString()
        {
            var prefix = TransactionType == TransactionType.Payment
                ? "+"
                : string.Empty;
            return $"{prefix}${Amount:F}";
        }

        public string GetFirstLineDescription()
        {
            if (IsPending)
            {
                return Description is not null
                    ? $"Pending - {Description}"
                    : "Pending";
            }
            else
            {
                return Description ?? "";
            }
        }

        public string GetSecondLineDescription()
        {
            var dateString = GetDataString(Date);
            return AuthorizedUser is not null
                ? $"{AuthorizedUser} - {dateString}"
                : dateString;
        }

        private static string GetDataString(DateTime date)
        {
            var daysDifference = (DateTime.Today - date).Days;
            return daysDifference switch
            {
                0 => "Today",
                > 0 and < 7 => date.DayOfWeek.ToString(),
                _ => date.ToShortDateString()
            };
        }
    }
}