namespace Napilnik
{
    public class UserUtils
    {
        private static readonly Random _random;

        static UserUtils() =>
            _random = new Random();

        public static int GetRandomNumber() =>
            _random.Next();

        public static int GetRandomNumber(in int maxValue) =>
            _random.Next(maxValue + 1);

        public static int GetRandomNumber(in int minValue, in int maxValue) =>
            _random.Next(minValue, maxValue + 1);
    }
}
