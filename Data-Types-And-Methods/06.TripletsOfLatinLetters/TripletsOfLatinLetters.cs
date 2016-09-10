using System;

namespace _06.TripletsOfLatinLetters
{
    class TripletsOfLatinLetters
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (char letter = 'a'; letter < ('a' + n); letter++)
            {
                for (char letter1 = 'a'; letter1 < ('a' + n); letter1++)
                {
                    for (char letter2 = 'a'; letter2 < ('a' + n); letter2++)
                    {
                        Console.WriteLine("{0}{1}{2}", letter, letter1, letter2);
                    }
                }
            }
        }
    }
}
