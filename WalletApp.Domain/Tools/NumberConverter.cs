namespace WalletApp.Domain.Tools
{
    public static class NumberConverter
    {
        public static string ConvertToKString(float number)
        {
            var postfix = string.Empty;

            while (number >= 1000)
            {
                number /= 1000;
                postfix += "K";
            }
            var value = Math.Round(number, MidpointRounding.AwayFromZero);
            return $"{value}{postfix}";
        }
    }
}
