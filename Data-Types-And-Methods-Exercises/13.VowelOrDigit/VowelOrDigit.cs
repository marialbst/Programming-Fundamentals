using System;

namespace VowelOrDigit
{
    class VowelOrDigit
    {
        static void Main(string[] args)
        {
            char letter = char.Parse(Console.ReadLine().ToLower());

            if (letter >= '0' && letter <= '9')
            {
                Console.WriteLine("digit");
            }
            else
            {
                switch (letter)
                {
                    case 'a':
                    case 'o':
                    case 'e':
                    case 'u':
                    case 'i':
                        Console.WriteLine("vowel"); break;
                    default:
                        Console.WriteLine("other"); break;
                }
            }

        }
    }
}
