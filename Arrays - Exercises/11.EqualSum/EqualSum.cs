using System;

namespace EqualSum
{
    class EqualSum
    {
        static void Main(string[] args)
        {
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int leftSum = 0;
            int rightSum = 0;
            bool equalSum = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    leftSum += numbers[j];
                }

                for (int k = i + 1; k < numbers.Length; k++)
                {
                    rightSum += numbers[k];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);// (i + " " + leftSum + " " + rightSum);
                    equalSum = true;
                }

                leftSum = 0;
                rightSum = 0;
            }

            if (!equalSum)
            {
                Console.WriteLine("no");
            }
        }
    }
}
