using System;

namespace _03.TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] banned = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            foreach (string word in banned)
            {
                if (text.Contains(word))
                {
                    text = text.Replace(word, new String('*', word.Length));
                }

            }

            Console.WriteLine(text);
        }
    }
}
