using System;
using System.Text.RegularExpressions;

namespace _01.MatchFullname
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"\b([A-Z][a-z]+ [A-Z][a-z]+)\b";

            Regex regex = new Regex(pattern);
            
            while (!text.Equals("end"))
            {
                Match match = regex.Match(text);
                if (match.Success)
                {
                    Console.WriteLine(match);
                }
                text = Console.ReadLine();
            }

            
        }
    }
}
