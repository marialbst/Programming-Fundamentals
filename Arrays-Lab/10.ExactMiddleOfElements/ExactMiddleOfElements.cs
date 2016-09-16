using System;

class ExactMiddleOfElements
{
    static void Main(string[] args)
    {
        int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int length = numbers.Length;

        if(length == 1)
        {
            Console.WriteLine($"{{ {numbers[length - 1]} }}");
        }
        else if(length % 2 == 0)
        {
            Console.WriteLine($"{{ {numbers[length / 2 - 1]}, {numbers[length / 2] } }}");
        }
        else
        {
            Console.WriteLine($"{{ {numbers[length / 2 - 1]}, {numbers[length / 2 ]}, {numbers[length / 2 + 1]} }}");
        } 

    }
}
