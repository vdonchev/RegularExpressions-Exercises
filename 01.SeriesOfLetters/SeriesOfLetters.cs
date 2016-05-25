namespace _01.SeriesOfLetters
{
    using System;
    using System.Text.RegularExpressions;

    public static class SeriesOfLetters
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var result = Regex.Replace(input, @"(.{1})\1+", "$1");
            Console.WriteLine(result);
        }
    }
}
