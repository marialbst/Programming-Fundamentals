using System;

namespace ReverseArrayOfInts
{
    class ReverseArrayOfInts
    {
        static void Main(string[] args)
        {
            int arrayLength = int.Parse(Console.ReadLine());
            int[] array = new int[arrayLength];

            for(int index = 0; index < arrayLength; index++)
            {
                array[index] = int.Parse(Console.ReadLine());
            }

            int[] arrayReversed = new int[arrayLength];
            for(int index1 = 0; index1 < arrayLength; index1++)
            {
                arrayReversed[index1] = array[arrayLength - 1 - index1];
                Console.Write($"{arrayReversed[index1]} ");
            }

        }
    }
}
