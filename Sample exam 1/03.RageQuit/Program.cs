using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();

            string pattern = @"([\D]+)([\d]+)";
            MatchCollection matches = Regex.Matches(text, pattern);
           
            List<string> symbols = new List<string>();
            List<int> times = new List<int>();

            foreach (Match match in matches)
            {
                symbols.Add(match.Groups[1].ToString().ToUpper());
                times.Add(int.Parse(match.Groups[2].ToString()));
            }

            StringBuilder sequence = new StringBuilder();

            for (int i = 0; i < symbols.Count; i++)
            {
                for (int j = 0; j < times[i]; j++)
                {
                    sequence.Append(symbols[i]);   
                }
            }

            char[] seqArray = sequence.ToString().ToCharArray().Distinct().ToArray();

            Console.WriteLine($"Unique symbols used: {seqArray.Length}");
            Console.WriteLine(sequence);
        }
    }
}
