using System;

namespace PairsByDifference
{
    class PairsBydifference
    {
        static void Main(string[] args)
        {
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int difference = int.Parse(Console.ReadLine());
            int pairs = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (Math.Abs(numbers[i] - numbers[j]) == difference)
                    {
                        //Console.WriteLine(numbers[i]+ " "+ numbers[j]);
                        pairs++;
                    }
                }
            }
            Console.WriteLine(pairs);
        }
    }
}
