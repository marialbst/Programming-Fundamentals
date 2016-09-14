using System;

namespace FastPrimeChecker
{
    class FastPrimeChecker
    {
        static void Main(string[] args)
        {
            int endNum = int.Parse(Console.ReadLine());
            for (int currentNum = 2; currentNum <= endNum; currentNum++)
            {
                bool isPrime = true;
                for (int check = 2; check <= Math.Sqrt(currentNum); check++)
                {
                    if (currentNum % check == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{currentNum} -> {isPrime}");
            }
        }
    }
}
