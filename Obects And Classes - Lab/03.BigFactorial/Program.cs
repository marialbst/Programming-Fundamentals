using System;
using System.Numerics;

public class Program
{
    public static void Main()
    {
        BigInteger factorial = 1;
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        Console.WriteLine(factorial);
    }
}
