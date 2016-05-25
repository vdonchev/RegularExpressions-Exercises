namespace _05.ValidUsernames
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public static class ValidUsernames
    {
        public static void Main()
        {
            var inputText = Console.ReadLine();

            var matches = Regex.Matches(inputText, @"(?<=\b|\s|\\|\/|\(|\))[a-zA-Z][\w]{2,24}(?=\b|\s|\\|\/|\(|\))");

            var longestNames = 0;
            var index = 0;

            for (var i = 0; i < matches.Count - 1; i++)
            {
                var nameLength = matches[i].Length + matches[i + 1].Length;
                if (nameLength > longestNames)
                {
                    longestNames = nameLength;
                    index = i;
                }
            }

            matches.Cast<Match>().Where((v, i) => i == index || i == index + 1).ToList().ForEach(Console.WriteLine);
        }
    }
}