namespace _09.SematicHtml
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public static class SemanticHtml
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            StringBuilder code = new StringBuilder();

            while (text != "END")
            {
                string patt1 = @"<(?<div>div).+(?<toRemove>\s*id\s*=\s*""\s*(?<divType>\w+)\s*""|\s*class\s*=\s*""\s*(?<divType>\w+)\s*"").*>";
                string patt2 = @"(?<all><\s*\/div\s*>\s*<!--\s*(?<closing>\w+)\s*-->\s*)";

                if (text.Contains("/div"))
                {
                    Match closing = Regex.Match(text, patt2);
                    text = Regex.Replace(text, closing.Groups["all"].ToString(), string.Format("</{0}>", closing.Groups["closing"]));
                }
                else if (text.Contains("div"))
                {
                    Match opening = Regex.Match(text, patt1);
                    text = Regex.Replace(text, opening.Groups["div"].ToString(), opening.Groups["divType"].ToString());
                    text = Regex.Replace(text, opening.Groups["toRemove"].ToString(), "");
                    text = Regex.Replace(text, @"(?<=[^\s])(\s)\1{1,}", " ");
                    text = Regex.Replace(text, @"(?<=<)(\s)|(\s)(?=[>])", "");
                }

                code.AppendLine(text);
                text = Console.ReadLine();
            }

            Console.Write(code.ToString());
        }
    }
}