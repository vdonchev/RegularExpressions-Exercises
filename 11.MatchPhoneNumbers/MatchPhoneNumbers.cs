namespace _11.MatchPhoneNumbers
{
    using System;
    using System.Text.RegularExpressions;

    public static class MatchPhoneNumbers
    {
        public static void Main()
        {
            // Input
            // +359 2 222 2222, +359-2-222-2222, 359-2-222-2222, +359/2/222/2222, +359-2 222 2222, +359 2 - 222 - 2222, +359 - 2 - 222 - 222, +359 - 2 - 222 - 22222

            var numbers = Regex.Split(Console.ReadLine(), @",\s+");
            foreach (var number in numbers)
            {
                var match = Regex.Match(number, @"\+359([\s\-])2\1\d{3}\1\d{4}");
                if (match.Success)
                {
                    Console.WriteLine(match.Value);
                }
            }
        }
    }
}
