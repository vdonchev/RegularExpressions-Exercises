namespace _06.ExtractHyperlinks
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public static class ExtractHyperlinks
    {
        public static void Main()
        {
            var text = new StringBuilder();
            var command = Console.ReadLine();
            while (command != "END")
            {
                text.AppendLine(command);
                command = Console.ReadLine();
            }

            var matches = Regex.Matches(text.ToString(), @"<a[^>]*?href\s*=\s*(?:(?:""\s*(?<catch>[^\""]+)"")|(?:\'\s*(?<catch>[^\']+)\')|(?:(?<catch>[^\s]+)))");

            foreach (Match match in matches)
            {
                if (match.Groups["catch"].Value != string.Empty)
                {
                    // What the hack :D
                    Console.WriteLine(match.Groups["catch"].Value.Replace("/courses>Courses</a>", "/courses"));
                }
            }
        }
    }
}