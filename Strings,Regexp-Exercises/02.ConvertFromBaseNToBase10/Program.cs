using System;
using System.Numerics;

namespace _02.ConvertFromBaseNToBase10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(' ');
            long numBase = long.Parse(numbers[0]);

            string num = numbers[1];


            BigInteger decimalNum = 0;

            for (int i = 0; i < num.Length; i++)
            {
                int chToNum = int.Parse(num[i].ToString());

                decimalNum += chToNum * BigInteger.Pow(numBase, num.Length - 1 - i);
            }

            Console.WriteLine(decimalNum);
        }
    }
}
