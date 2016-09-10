using System;

namespace IntToHexAndBin
{
    class IntToHexAndBin
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string hexVal = Convert.ToString(number, 16).ToUpper();
            string binVal = Convert.ToString(number, 2);

            Console.WriteLine($"{hexVal}\n{binVal}");

        }
    }
}
