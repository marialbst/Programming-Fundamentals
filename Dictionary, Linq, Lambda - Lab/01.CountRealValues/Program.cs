using System;
using System.Collections.Generic;

namespace _01.CountRealValues
{
    class Program
    {
        private static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ');
            var counters = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                double parsedNumber = double.Parse(number);

                if (counters.ContainsKey(parsedNumber))
                {
                    counters[parsedNumber]++;
                }
                else
                {
                    counters[parsedNumber] = 1;
                }

            }

            foreach (var number in counters.Keys)
            {
                Console.WriteLine($"{number} -> {counters[number]} times");
            }
        }
    }
}
