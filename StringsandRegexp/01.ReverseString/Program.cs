using System;

namespace _01.ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            char[] wordArr = word.ToCharArray();
            Array.Reverse(wordArr);

            Console.WriteLine(new string(wordArr));
        }
    }
}
