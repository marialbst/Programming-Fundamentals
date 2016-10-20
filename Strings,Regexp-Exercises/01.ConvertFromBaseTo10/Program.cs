using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace _01.ConvertFromBaseTo10
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] bases = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();

            BigInteger targetBase = bases[0];
            BigInteger decNumber = bases[1];

            StringBuilder convertedNum = new StringBuilder();

            while (decNumber > 0)
            {
                BigInteger remainder = decNumber % targetBase;

                convertedNum.Insert(0, remainder);
                decNumber /= targetBase;

            }

            Console.WriteLine(convertedNum.ToString());
        }
    }
}
