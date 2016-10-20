using System;
using System.Text.RegularExpressions;

namespace _10.ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            //string pattern =@"\b(?<!\S)(([a-z0-9\-\.]+@[a-z0-9\-]+\.[a-z]+([\.a-z]+)?))\b";
            string pattern = @" \b([a-z](?:_?[a-z0-9\-\.]+@[a-z\-]+\.[a-z]+([\.a-z]+)?))\b";

            //(?<!\S) - проверява за различен от интервал символ преди началото на думата
            //(([a-z0-9\-\.]+@[a-z0-9\-]+\.[a-z]+([\.a-z]+)?)) - групата за мача на целия мейл
            //([\.a-z]+)? - опционалната група, в случай че има повече от един домейн

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
