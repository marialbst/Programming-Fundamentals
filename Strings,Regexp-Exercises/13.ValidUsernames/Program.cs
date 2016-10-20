using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _13.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"\b[A-Za-z][\w]{2,24}\b";

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);

            List<string> validUsers = new List<string>();
            foreach (Match match in matches)
            {
                validUsers.Add(match.ToString());
            }

            int maxLength = -1; ;
            string[] biggest = new string[2];
            for (int i = 0; i < validUsers.Count - 1; i++)
            {
                int length = validUsers[i].Length + validUsers[i + 1].Length;

                if (length > maxLength)
                {
                    maxLength = length;
                    biggest[0] = validUsers[i];
                    biggest[1] = validUsers[i + 1];
                }
            }
            Console.WriteLine(biggest[0]);
            Console.WriteLine(biggest[1]);
        }
    }
}
