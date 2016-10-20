using System;
using System.Text.RegularExpressions;

namespace _11.ExtractSentencesByWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string query = Console.ReadLine();
            string text = Console.ReadLine();

            //(([\w]+\W)+to(\W[\w-]+)+)
            //(\w[^.!?]*)?\bto\b[^.!?]*[^.!?]
            string pattern = @"(\w[^.!?]*)?\b" + query + @"\b[^.!?]*";

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
