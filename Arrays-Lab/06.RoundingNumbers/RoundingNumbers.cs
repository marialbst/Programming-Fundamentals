using System;

class RoundingNumbers
{
    static void Main(string[] args)
    {
        string[] array = Console.ReadLine().Split(' ');
        double[] numbers = Array.ConvertAll(array, double.Parse);
        long[] roundedNums = new long[numbers.Length];

        for (int index = 0; index < numbers.Length; index++)
        {
            roundedNums[index] = (long)Math.Round(numbers[index], MidpointRounding.AwayFromZero);
            Console.WriteLine($"{numbers[index]} => {roundedNums[index]}");
        }
    }
}
