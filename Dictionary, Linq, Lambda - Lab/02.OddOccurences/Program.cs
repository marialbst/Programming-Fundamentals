using System;
using System.Collections.Generic;

namespace _02.OddOccurences
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower().Split(' ');
            var occurences = new Dictionary<string, int>();
            
            foreach (var word in input)
            {
                if (occurences.ContainsKey(word))
                {
                    occurences[word]++;
                }
                else
                {
                    occurences[word] = 1;
                }
            }

            var result = new List<string>();

            foreach (var key in occurences.Keys)
            {
                if (occurences[key]%2 == 1)
                {
                    result.Add(key);
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
