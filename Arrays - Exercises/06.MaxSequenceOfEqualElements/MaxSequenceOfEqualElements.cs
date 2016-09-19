using System;

namespace MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int longest = 0;
            int counter = 1;
            int number = 0;

            for (int index = 0; index < numbers.Length - 1; index++)
            {
                if (numbers[index] == numbers[index + 1])
                {
                    counter++;
                }
                else
                {

                    counter = 1;
                }
                if (counter > longest)
                {
                    longest = counter;
                    number = numbers[index];

                }
            }

            for (int i = 0; i < longest; i++)
            {
                Console.Write("{0} ", number);
            }
        }
    }
}
