using System;

namespace _02.CountOccurences
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string pattern = Console.ReadLine().ToLower();

            int counter = 0;
            int index = text.IndexOf(pattern, StringComparison.Ordinal);

            while (index != -1)
            {
                counter++;
                index = text.IndexOf(pattern, index + 1, StringComparison.Ordinal);
            }

            Console.WriteLine(counter);
        }
    }
}
