using System;

namespace FilledRectangle
{
    class FilledRectangle
    {
        static void PrintOuterRows(int number)
        {
            Console.WriteLine(new String('-', 2 * number));
        }

        static void PrintInnerRows(int number)
        {
            for (int i = 0; i < number - 2; i++)
            {
                Console.Write("-");

                for (int j = 0; j < number - 1; j++)
                {
                    Console.Write("\\/");
                }

                Console.WriteLine("-");
            }
        }

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            PrintOuterRows(n);
            PrintInnerRows(n);
            PrintOuterRows(n);
        }
    }
}
