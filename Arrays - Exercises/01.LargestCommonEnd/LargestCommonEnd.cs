using System;

class LargestCommonEnd
{
    static int FindSequence(string[] a1, string[] a2)
    {
        int result = 0;

        for (int index = 0; index < Math.Min(a1.Length, a2.Length); index++)
        {
            if (a1[index] == a2[index])
            {
                result++;
            }
            else
            {
                break;
            }
        }

        return result;
    }

    static void Main(string[] args)
    {
        string[] seq1 = Console.ReadLine().Split(' ');
        string[] seq2 = Console.ReadLine().Split(' ');

        int left = FindSequence(seq1, seq2);
        Array.Reverse(seq1);
        Array.Reverse(seq2);
        int right = FindSequence(seq1, seq2);

        Console.WriteLine(Math.Max(left, right));
    }
}
