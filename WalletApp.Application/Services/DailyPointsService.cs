using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalletApp.Application.Services
{
    public class DailyPointsService : IDailyPointsService
    {
        public float CalculateDailyPoints(DateTime date)
        {
            var daysOfSeason = GetDayOfSeason(date);
            List<float> dailyPointsList = new(daysOfSeason) { 2f, 3f };
            for (int i = 2; i < daysOfSeason; i++)
            {
                dailyPointsList.Add(dailyPointsList[i - 2] + 0.6f * dailyPointsList[i - 1]);
            }

            return dailyPointsList.Last();
        }

        public string GetStringRepresentation(float dailyPoints)
        {
            var postfix = string.Empty;
            
            while (dailyPoints >= 1000)
            {
                dailyPoints /= 1000;
                postfix += "K";
            }
            var value = Math.Round(dailyPoints, MidpointRounding.AwayFromZero);
            return $"{value}{postfix}";
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
    }
}
