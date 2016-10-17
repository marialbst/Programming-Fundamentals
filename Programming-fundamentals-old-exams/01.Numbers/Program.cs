using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            numbers.Sort();
            numbers.Reverse();
            double average = numbers.Average();
            numbers = numbers.Where(x => x > average).Take(5).ToList();

            if (numbers.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                foreach (var number in numbers)
                {
                    Console.Write("{0} ", number);
                }
            }
        }
    }
}
