using System;

namespace MaxSequenceOfIncreasingElements
{
    class MaxSequenceOfIncreasingElements
    {
        static void Main(string[] args)
        {
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int longest = 0;
            int counter = 1;
            int endIndex = 0;

            for (int index = 0; index < numbers.Length - 1; index++)
            {

                if (numbers[index] < numbers[index + 1])
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
                    endIndex = index + 2;

                }
            }

            //Console.WriteLine(longest);
            //Console.WriteLine(endIndex);

            for (int i = endIndex - longest; i < endIndex; i++)
            {
                Console.Write("{0} ", numbers[i]);
                //Console.WriteLine(i);
            }
        }
    }
}
