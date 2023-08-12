using System.Globalization;
using WalletApp.Domain.Tools;

namespace WalletApp.Domain.Entities
{
    public class AccountInfo : Entity
    {
        public const int MaxLimit = 1500;

        private static readonly Random _random = new Random();

        public AccountInfo(decimal cardBalance)
        {
            CardBalance = cardBalance;
        }

        public decimal CardBalance { get; set; }
        public decimal AvailableBalance => MaxLimit - CardBalance;
        public float DailyPoints => CalculateDailyPoints();
        public string PaymentDueStatus => GetPaymentDueStatus();

        public static AccountInfo GetRandomAccountInfo()
        {
            return new AccountInfo(_random.NextDecimal() * MaxLimit);
        }

        public string GetDailyPointsKString()
        {
            return NumberConverter.ConvertToKString(DailyPoints);
        }

        private static float CalculateDailyPoints()
        {
            var daysOfSeason = GetDayOfSeason(DateTime.Today);
            List<float> dailyPointsList = new(daysOfSeason) { 2f, 3f };
            for (int i = 2; i < daysOfSeason; i++)
            {
                dailyPointsList.Add(dailyPointsList[i - 2] + 0.6f * dailyPointsList[i - 1]);
            }

            return dailyPointsList.Last();
        }

        private static int GetDayOfSeason(DateTime dateTime)
        {
            var daysOfTheSeason = dateTime.Day;
            int year = dateTime.Year;
            // Adding days of the preceding months of the season.
            // Due to the fact seasons starts with months which is divisible by 3,
            // we break the loop when month has a remainder of 2.
            for (int month = dateTime.Month - 1; month % 3 != 2; month--)
            {
                if (month < 1)
                {
                    month += 12;
                    year--;
                }

                daysOfTheSeason += DateTime.DaysInMonth(year, month);
            }

            return daysOfTheSeason;
        }

        private static string GetPaymentDueStatus()
        {
            var monthName = DateTime.Today.ToString("MMMM", CultureInfo.InvariantCulture);
            return $"You've paid your {monthName} balance.";
        }
    }
}
