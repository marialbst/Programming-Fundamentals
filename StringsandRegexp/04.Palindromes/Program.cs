using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(new char[] { ',', ' ', '?', '!', '.' }, StringSplitOptions.RemoveEmptyEntries);

            List<string> palindromes = new List<string>();

            foreach (string word in text)
            {
                char[] wordArray = word.ToCharArray();
                Array.Reverse(wordArray);
                string reversedWord = string.Join("", wordArray);

                if (word == reversedWord)
                {
                    palindromes.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ", palindromes.Distinct().OrderBy(x => x)));
        }
    }
}
