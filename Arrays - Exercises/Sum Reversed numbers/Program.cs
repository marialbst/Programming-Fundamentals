using System;
using System.Collections.Generic;
using System.Linq;

namespace Sum_Reversed_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int sum = 0;

            foreach(int number in numbers)
            {
                sum += ReverseNumber(number);
            }

            Console.WriteLine(sum);
        }

        static int ReverseNumber(int num)
        {
            int reversed = 0;
            int numToReverse = num;
            while(numToReverse > 0)
            {
                int rest = numToReverse % 10;
                reversed = reversed*10 + rest;
                numToReverse /= 10;
            }

            return reversed;
        }
    }
}
