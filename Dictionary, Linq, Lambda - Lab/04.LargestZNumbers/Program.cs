using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.LargestZNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                            .Split(' ')
                                            .Select(int.Parse)
                                            .OrderBy(n => -n)
                                            .Take(3)
                                            .ToList();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
