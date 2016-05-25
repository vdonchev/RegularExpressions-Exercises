namespace _08.UseYourChainsBuddy
{
    using System;
    using System.IO;
    using System.Text;
    using System.Text.RegularExpressions;

    public static class UseYourChainsBuddy
    {
        public static void Main()
        {
            Console.SetIn(new StreamReader(Console.OpenStandardInput(8192)));

            string htmlCode = Console.ReadLine();
            StringBuilder manual = new StringBuilder();
            MatchCollection matches = Regex.Matches(htmlCode, @"<p>(?<p>.+?)<\/p>");

            foreach (Match match in matches)
            {
                manual.Append(match.Groups["p"]);
            }

            string result = Regex.Replace(manual.ToString(), @"[^a-z0-9]", " ");
            manual.Clear();
            ConvertLetters(result, manual);
            Console.WriteLine(Regex.Replace(manual.ToString(), @"\s+", " "));
        }

        static void ConvertLetters(string result, StringBuilder manual)
        {
            foreach (var ch in result)
            {
                if (ch >= 'a' && ch <= 'm')
                {
                    manual.Append((char)(ch + 13));
                }
                else if (ch >= 'm' && ch <= 'z')
                {
                    manual.Append((char)(ch - 13));
                }
                else
                {
                    manual.Append(ch);
                }
            }
        }
    }
}