namespace _10.MatchFullName
{
    using System;
    using System.Text.RegularExpressions;

    public static class MatchFullName
    {
        public static void Main()
        {
            // input
            // Ivan Ivanov, ivan ivanov, Ivan ivanov, ivan Ivanov, IVan Ivanov, Ivan IvAnov, Ivan	Ivanov

            var names = Regex.Split(Console.ReadLine(), @",\s+");
            foreach (var number in names)
            {
                var match = Regex.Match(number, @"\b[A-Z][a-z]+ [A-Z][a-z]+\b");
                if (match.Success)
                {
                    Console.WriteLine(match.Value);
                }
            }
        }
    }
}
