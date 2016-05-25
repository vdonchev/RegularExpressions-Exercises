namespace _03.ExtractEmails
{
    using System;
    using System.Text.RegularExpressions;

    public static class ExtractEmails
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var matches = Regex.Matches(
                input,
                @"\s(?<mail>[a-zA-Z0-9][a-zA-Z0-9\-\._]*[a-zA-Z0-9]@([a-zA-Z][a-zA-Z\-]*[a-zA-Z])\.([a-zA-Z][a-zA-Z\-]*[a-zA-Z])(\.[a-zA-Z][a-zA-Z\-]*[a-zA-Z])?(\.[a-zA-Z][a-zA-Z\-]*[a-zA-Z])?(\.[a-zA-Z][a-zA-Z\-]*[a-zA-Z])?)\b[\.?!\s]*");

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups["mail"].Value);
            }
        }
    }
}
