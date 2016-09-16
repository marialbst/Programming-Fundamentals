using System;

class CondenseArrayToNumber
{
    static void Main(string[] args)
    {
        int[] originalArray = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        while (originalArray.Length > 1)
        {
            int[] sumsArray = new int[originalArray.Length - 1];

            for (int index = 0; index < sumsArray.Length; index++)
            {
                sumsArray[index] = originalArray[index] + originalArray[index + 1];
            }

            originalArray = sumsArray;

            //Console.WriteLine(string.Join(" ", originalArray));
        }

        Console.WriteLine(string.Join("", originalArray));
    }
}
