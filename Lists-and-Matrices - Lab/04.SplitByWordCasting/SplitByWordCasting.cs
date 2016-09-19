using System;
using System.Collections.Generic;
using System.Linq;

namespace SplitByWordCasting
{
    class SplitByWordCasting
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Trim().Split(new Char[] { ' ', ';', ':', ',', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> uppercased = new List<string>();
            List<string> lowercased = new List<string>();
            List<string> mixed = new List<string>();
            long num;
            
            foreach (string word in words)
            {
                if (word == word.ToLower() && word.ToCharArray().All(c => char.IsLetter(c)))
                {
                    lowercased.Add(word);
                }
                else if (word == word.ToUpper() && word.ToCharArray().All(c => char.IsLetter(c)))
                {
                    uppercased.Add(word);
                }
                else
                {
                    mixed.Add(word);
                }
            } 
           
            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowercased));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixed));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", uppercased));
        }
    }
}
