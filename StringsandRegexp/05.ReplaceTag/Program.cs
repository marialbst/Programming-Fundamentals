using System;
using System.Text.RegularExpressions;

namespace _05.ReplaceTag
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            while (!text.Equals("end"))
            {
                string pattern = @"<a.*href=(\s*.*?)>(.*?)<\/a>";
                string replacement = @"[URL href=$1]$2[/URL]";
                string replacedString = Regex.Replace(text, pattern, replacement);

                Console.WriteLine(replacedString);
                text = Console.ReadLine();
            }
        }
    }
}
