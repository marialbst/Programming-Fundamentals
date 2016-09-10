using System;

namespace HexVariable
{
    class HexVariable
    {
        public static void Main()
        {
            int number = Convert.ToInt32(Console.ReadLine(), 16);

            Console.WriteLine(number);
        }
    }
}
