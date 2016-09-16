using System;

class SumArrays
{
    static int[] SumArray(int[] a1, int[] a2)
    {
        int largerLength = Math.Max(a1.Length, a2.Length);
        int[] arrayOfSums = new int[largerLength];
        
        for(int i = 0; i < largerLength; i++)
        {
            arrayOfSums[i] = a1[ i % a1.Length ] + a2[ i % a2.Length ];
        }

        return arrayOfSums;
    }
    
    static void PrintArray(int[] sum)
    {
        Console.WriteLine(string.Join(" ", sum));
    }

    static void Main(string[] args)
    {
       int[] arrayFirst = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
       int[] arraySecond = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

       int[] arraySums =  SumArray(arrayFirst, arraySecond);
       PrintArray(arraySums);
    }
}
