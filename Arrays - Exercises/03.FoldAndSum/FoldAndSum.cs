using System;

class FoldAndSum
{

    static void Main(string[] args)
    {
        int[] original = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        int[] subArray1 = new int[original.Length / 2];
        int[] subArray2 = new int[original.Length / 2];

        for (int i = 0; i < original.Length / 4; i++)
        {
            subArray1[i] = original[original.Length - 1 - i];
        }
        
        for(int i = original.Length / 2; i < original.Length; i++)
        {
            subArray1[i] = original[original.Length - 1 - i];
        }
        
        for(int i = )

    }
}
