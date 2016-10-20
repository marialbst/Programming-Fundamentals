using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.MagicExchangableWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            string word1 = words[0];
            string word2 = words[1];

            if (word1.Length == word2.Length)
            {
                Dictionary<char, char> letters = new Dictionary<char, char>();

                for (int i = 0; i < word1.Length; i++)
                {
                    if (!letters.ContainsKey(word1[i]))
                    {
                        letters.Add(word1[i], word2[i]);
                    }
                    else
                    {
                        if (letters[word1[i]] != word2[i])
                        {
                            Console.WriteLine("false");
                            return;
                        }
                        else if (i == word1.Length - 1)
                        {
                            Console.WriteLine("true");
                        }
                    }

                }

            }
            else
            {
                char[] word1Array = word1.ToCharArray();
                char[] word2Array = word2.ToCharArray();

                int length1 = word1Array.Distinct().ToArray().Length;
                int length2 = word2Array.Distinct().ToArray().Length;

                if (length1 == length2)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
    }
}
