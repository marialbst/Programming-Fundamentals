using System;

class RotateAndSum
{
    static void Main(string[] args)
    {
        int[] arrOriginal = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int rotations = int.Parse(Console.ReadLine());
        int[] arrSums = new int[arrOriginal.Length];

        for(int rotation = 1; rotation <= rotations; rotation++)
        {
            int[] rotatedArr = new int[arrOriginal.Length];
            
            for(int index = 0; index < arrOriginal.Length; index++)
            {
                if (index == 0)
                {
                    rotatedArr[index] = arrOriginal[arrOriginal.Length - 1];
                }
                else
                {
                    rotatedArr[index] = arrOriginal[index - 1];
                }

                arrSums[index] += rotatedArr[index];
            }

            arrOriginal = rotatedArr;
        }
        Console.WriteLine(string.Join(" ", arrSums));
    }
}
