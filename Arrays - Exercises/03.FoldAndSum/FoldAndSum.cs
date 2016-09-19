using System;

class FoldAndSum
{

    static void Main(string[] args)
    {
        int[] original = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        int[] subArray1 = new int[original.Length / 2];
        int[] subArray2 = new int[original.Length / 2];
        int[] sumArray = new int[original.Length / 2];

        for (int i = 0; i < original.Length / 2; i++)
        {
            if (i >= 0 && i < original.Length / 4)
            {
                subArray1[i] = original[original.Length / 4 - 1 - i];
            }
            else
            {
                subArray1[i] = original[original.Length + original.Length / 4 - 1 - i];
            }

            subArray2[i] = original[original.Length / 4 + i];

            sumArray[i] = subArray1[i] + subArray2[i];
        }

        //Console.WriteLine(string.Join(" ", subArray1));
        //Console.WriteLine(string.Join(" ", subArray2));
        Console.WriteLine(string.Join(" ", sumArray));

    }
}
