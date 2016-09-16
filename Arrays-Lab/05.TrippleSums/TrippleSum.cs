using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int[] numbers = input.Select(int.Parse).ToArray();
        bool contains = false;

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                int sum = numbers[i] + numbers[j];

                if (numbers.Contains(sum))
                {
                    //Console.WriteLine($"{numbers[i]} + {numbers[j]} == {sum}");
                    Console.WriteLine("{0} + {1} == {2}", numbers[i], numbers[j], sum);
                    contains = true;
                }

            }

        }

        if (!contains)
        {
            Console.WriteLine("No");
        }
    }
}