using System;

namespace _08.LetterChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double totalSum = 0;

            string[] sequence = command.Trim().Split(new char[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string seq in sequence)
            {
                char firstLetter = seq[0];
                char secondLetter = seq[seq.Length - 1];
                double number = double.Parse(seq.Substring(1, seq.Length - 2));
                double result = 0;

                if (firstLetter >= 'A' && firstLetter <= 'Z')
                {
                    result = number / ((int)firstLetter - 64);//1-26

                }
                else if (firstLetter >= 'a' && firstLetter <= 'z')
                {
                    result = number * ((int)firstLetter - 96);//1-26

                }


                if (secondLetter >= 'A' && secondLetter <= 'Z')
                {
                    result -= ((int)secondLetter - 64);

                }
                else if (secondLetter >= 'a' && secondLetter <= 'z')
                {
                    result += ((int)secondLetter - 96);

                }
                //Console.WriteLine(result2);
                totalSum += result;

            }

            Console.WriteLine("{0:f2}", totalSum);
        }
    }
}
