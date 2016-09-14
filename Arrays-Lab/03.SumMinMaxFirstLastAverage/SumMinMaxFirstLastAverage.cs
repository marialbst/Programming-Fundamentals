using System;
using System.Linq;

namespace SumMinMaxFirstLastAverage
{
    class SumMinMaxFirstLastAverage
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] intArray = new int[n];

            for(int i = 0; i < n; i++)
            {
                intArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Sum = {0}", intArray.Sum());
            Console.WriteLine("Min = {0}", intArray.Min());
            Console.WriteLine("Max = {0}", intArray.Max());
            Console.WriteLine("First = {0}", intArray.First());
            Console.WriteLine("Last = {0}", intArray.Last());
            Console.WriteLine("Average = {0}", intArray.Average());
        }
    }
}
