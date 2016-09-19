using System;

namespace IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            char[] letters = word.ToCharArray(0, word.Length);

            for (int index = 0; index < letters.Length; index++)
            {
                Console.WriteLine("{0} -> {1}", letters[index], (int)letters[index] - 97);
            }
        }
    }
}
