using System;

namespace DifferentIntegerSize
{
    public class DifferentIntegerSize
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            sbyte number;
            byte number1;
            short number2;
            ushort number3;
            int number4;
            uint number5;
            long number6;

            if (long.TryParse(input, out number6))
            {
                Console.WriteLine("{0} can fit in:", number6);
                if (sbyte.TryParse(input, out number))
                {
                    Console.WriteLine("* sbyte");
                }
                if (byte.TryParse(input, out number1))
                {
                    Console.WriteLine("* byte");
                }
                if (short.TryParse(input, out number2))
                {
                    Console.WriteLine("* short");
                }
                if (ushort.TryParse(input, out number3))
                {
                    Console.WriteLine("* ushort");
                }
                if (int.TryParse(input, out number4))
                {
                    Console.WriteLine("* int");
                }
                if (uint.TryParse(input, out number5))
                {
                    Console.WriteLine("* uint");
                }
                Console.WriteLine("* long");

            }
            else
            {
                Console.WriteLine("{0} can't fit in any type", input);
            }

        }
    }
}

