using System;

namespace DifferentIntegerSize
{
    class DifferentIntegerSize
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            sbyte number;
            short number1;
            int number2;
            long number3;
            byte number4;
            ushort number5;
            uint number6;


            try
            {
                number = sbyte.Parse(input);
                Console.WriteLine("{0} can fit in:", number);
                if (number < 0)
                {
                    Console.WriteLine("* sbyte\n* short\n* int\n* long");
                }
                else
                {
                    Console.WriteLine("* sbyte\n* byte\n* short\n* ushort\n* int\n* uint\n* long");
                }
            }
            catch (OverflowException)
            {

                try
                {
                    number4 = byte.Parse(input);
                    Console.WriteLine("{0} can fit in:", number4);
                    Console.WriteLine("* byte\n* short\n* ushort\n* int\n* uint\n* long");

                }
                catch (OverflowException)
                {

                    try
                    {
                        number1 = short.Parse(input);
                        Console.WriteLine("{0} can fit in:", number1);
                        if (number1 < 0)
                        {
                            Console.WriteLine("* short\n* int\n* long");
                        }
                        else
                        {
                            Console.WriteLine("* short\n* ushort\n* int\n* uint\n* long");
                        }
                    }
                    catch (OverflowException)
                    {
                        try
                        {
                            number5 = ushort.Parse(input);
                            Console.WriteLine("{0} can fit in:", number5);
                            Console.WriteLine("* ushort\n* int\n* uint\n* long");
                        }
                        catch (OverflowException)
                        {

                            try
                            {
                                number2 = int.Parse(input);
                                Console.WriteLine("{0} can fit in:", number2);

                                if (number2 < 0)
                                {
                                    Console.WriteLine("* int\n* long");
                                }
                                else
                                {
                                    Console.WriteLine("* int\n* uint\n* long");
                                }
                            }
                            catch (OverflowException)
                            {
                                try
                                {
                                    number6 = uint.Parse(input);
                                    Console.WriteLine("{0} can fit in:", number6);
                                    Console.WriteLine("* uint\n* long");
                                }
                                catch (OverflowException)
                                {
                                    try
                                    {
                                        number3 = long.Parse(input);
                                        Console.WriteLine("{0} can fit in:", number3);

                                        if (number3 < 0)
                                        {
                                            Console.WriteLine("* long");
                                        }
                                        else
                                        {
                                            Console.WriteLine("* long");
                                        }
                                    }
                                    catch (OverflowException)
                                    {
                                        Console.WriteLine("{0} can't fit in any type", input);

                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
