namespace _07.QueryMess
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public static class QueryMess
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            while (!input.Equals("END"))
            {
                MatchCollection keyValues = Regex.Matches(input, @"((?<key>[^\?\s=&]+)=(?<val>[^\?\s=&]+))");
                Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();

                foreach (Match match in keyValues)
                {
                    string key = match.Groups["key"].ToString();
                    string value = match.Groups["val"].ToString();
                    key = Regex.Replace(key, @"(%20)|(\+)", " ");
                    key = Regex.Replace(key, @"\s+", " ").Trim();
                    value = Regex.Replace(value, @"(%20)|(\+)", " ");
                    value = Regex.Replace(value, @"\s+", " ").Trim();

                    AddResults(result, key, value);
                }

                PrintResults(result);
                input = Console.ReadLine();
            }
        }

        private static void PrintResults(Dictionary<string, List<string>> result)
        {
            foreach (var item in result)
            {
                Console.Write("{0}=[{1}]", item.Key, string.Join(", ", item.Value));
            }
            Console.WriteLine();
        }

        private static void AddResults(Dictionary<string, List<string>> result, string key, string value)
        {
            if (!result.ContainsKey(key))
            {
                result.Add(key, new List<string>());
            }
            result[key].Add(value);
        }
    }
}