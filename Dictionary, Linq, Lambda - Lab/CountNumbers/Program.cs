using System;
using System.Collections.Generic;

namespace CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            SortedDictionary<int, int> numbers = new SortedDictionary<int, int>();

            foreach (var val in input)
            {
                int number = int.Parse(val);

                if (numbers.ContainsKey(number))
                {
                    numbers[number]++;
                }
                else
                {
                    numbers[number] = 1;
                }
            }

            foreach (var key in numbers.Keys)
            {
                Console.WriteLine($"{key} ->{numbers[key]}");
            }
        }
    }
}
