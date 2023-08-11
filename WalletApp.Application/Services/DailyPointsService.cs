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
            return CalculateDailyPointsInner(daysOfSeason);
        }

        public string GetStringRepresentation(float dailyPoints)
        {
            var thousands = Math.Round(dailyPoints / 1000, MidpointRounding.AwayFromZero);
            return $"{thousands}K";
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

        public float CalculateDailyPointsInner(int daysOfSeason)
        {
            return daysOfSeason switch
            {
                1 => 2.0f,
                2 => 3.0f,
                _ => CalculateDailyPointsInner(daysOfSeason - 2) + 0.6f * CalculateDailyPointsInner(daysOfSeason - 1)
            };
        }
    }
}
