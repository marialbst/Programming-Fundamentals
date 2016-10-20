using System;

namespace _04.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');

            string word1 = words[0];
            string word2 = words[1];

            int length = Math.Min(word1.Length, word2.Length);
            long sum = 0;

            for (int i = 0; i < length; i++)
            {
                sum += word1[i] * word2[i];
            }

            if (word1.Length != word2.Length)
            {
                int max = Math.Max(word1.Length, word2.Length);
                string word = "";

                if (max == word1.Length)
                {
                    word = word1;
                }
                else
                {
                    word = word2;
                }

                for (int i = length; i < max; i++)
                {
                    sum += word[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
