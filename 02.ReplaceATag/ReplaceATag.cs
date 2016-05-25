namespace _02.ReplaceATag
{
    using System;
    using System.Text.RegularExpressions;

    public static class ReplaceATag
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            while (input != "end")
            {
                Console.WriteLine(Regex.Replace(
                    input, 
                    @"<a href=(\""[^\""]*\"")>([^\<]*)<\/a>",
                    "[URL href=$1]$2[/URL]"));
                input = Console.ReadLine();
            }
        }
    }
}
