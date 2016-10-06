using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MinMaxSumAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                numbers.Add(num);
            }

            int sum = numbers.Sum();
            int min = numbers.Min();
            int max = numbers.Max();
            double average = numbers.Average();

            Console.WriteLine($"Sum = {sum}\nMin = {min}\nMax = {max}\nAverage = {average}");

        }
    }
}
