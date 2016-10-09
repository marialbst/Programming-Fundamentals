using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ShortSortedWords
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                                    .ToLower()
                                    .Split(new char[] { ' ', '.', ',', '!', '?', '(', ')', '[', ']', '\"', '\'', ':', ';' },
                                           StringSplitOptions.RemoveEmptyEntries)
                                    .ToList();

            List<string> result = input.Distinct()
                                        .OrderBy(word => word)
                                        .Where(word => word.Length < 5)
                                        .ToList();
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
