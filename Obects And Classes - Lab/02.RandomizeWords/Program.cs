using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        string[] textToWords = Console.ReadLine().Split(' ').ToArray();
        Random randomWord = new Random();

        for (int i = 0; i < textToWords.Length; i++)
        {
            int nextWord = randomWord.Next(textToWords.Length);

            string prevWord = textToWords[i];
            textToWords[i] = textToWords[nextWord];
            textToWords[nextWord] = prevWord;
        }

        Console.WriteLine(string.Join("\n", textToWords));
    }
}