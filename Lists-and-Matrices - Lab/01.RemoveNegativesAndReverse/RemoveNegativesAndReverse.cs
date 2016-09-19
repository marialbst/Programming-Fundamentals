using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNegativesAndReverse
{
    class RemoveNegativesAndReverse
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> positiveNums = new List<int>();

            foreach(int number in numbers)
            {
                if(number >= 0)
                {
                    positiveNums.Add(number);
                }
            }

           if(positiveNums.Count == 0)
            {
                Console.WriteLine("empty");
            }
           else
            {
                positiveNums.Reverse();
                Console.WriteLine(string.Join(" ", positiveNums));
            }

        }
    }
}
