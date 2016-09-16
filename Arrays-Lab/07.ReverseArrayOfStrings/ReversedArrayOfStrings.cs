using System;

class ReversedArrayOfStrings
{
    static void Main(string[] args)
    {
        string[] arr = Console.ReadLine().Split(' ');
        Array.Reverse(arr);

        Console.WriteLine(string.Join(" ", arr));
    }
}
