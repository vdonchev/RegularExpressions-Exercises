namespace _04.SentenceExtractor
{
    using System;
    using System.Text.RegularExpressions;

    public static class SentenceExtractor
    {
        public static void Main()
        {
            var needle = Console.ReadLine();
            var haystack = Console.ReadLine();
            var matches = Regex.Matches(
                haystack, 
                @".*?[!?\.]");

            foreach (Match match in matches)
            {
                if (Regex.IsMatch(match.Value, @"\s" + needle + @"\s"))
                {
                    Console.WriteLine(match.Value.Trim());
                }
            }
        }
    }
}
