namespace WalletApp.Domain
{
    public static class RandomExtensions
    {
        public static DateTime NextDateTime(this Random random, DateTime minDateTime, DateTime maxDateTime)
        {
            return new DateTime(random.NextInt64(minDateTime.Ticks, maxDateTime.Ticks));
        }

        public static double Nextdouble(this Random random)
        {
            return (double)random.NextDouble();
        }

        public static bool NextBool(this Random random)
        {
            return random.Next(2) > 0;
        }

        public static T? GetValueOrNull<T>(this Random random, T value) where T : class
        {
            return random.Next(2) > 0
                ? value
                : null;
        }
    }
}
