using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string pattern = @"(.*?["+key+@"])([a-zA-z]+)["+key+@"]+(.*?["+key+@"]+)([a-zA-Z]+)(.*?\s)(.*)\b";

            Dictionary<string, int> standing = new Dictionary<string, int>();
            Dictionary<string, int> goals = new Dictionary<string, int>();

            string command = Console.ReadLine();

            while (!command.Equals("final"))
            {
                MatchCollection matches = Regex.Matches(command, pattern);
                foreach (Match match in matches)
                {
                    string country1Reversed = match.Groups[2].ToString().ToUpper();
                    string country2Rebersed = match.Groups[4].ToString().ToUpper();
                    int[] result = match.Groups[6].ToString().Split(':').Select(int.Parse).ToArray();

                    string country1 = ReverseCountry(country1Reversed);
                    string country2 = ReverseCountry(country2Rebersed);
                    AddingResults(standing, goals, result, country1, country2);
                }

                command = Console.ReadLine();
            }
            int place = 1;
            foreach (var country in standing.OrderByDescending(x=>x.Value))
            {
                
                Console.WriteLine($"{place}. {country.Key} {country.Value}");
                place++;
            }

        }

        private static void AddingResults(Dictionary<string, int> standing, Dictionary<string, int> goals, int[] result, string country1, string country2)
        {
            if (!standing.ContainsKey(country1))
            {
                standing.Add(country1, 0);
                goals.Add(country1, 0);
            }

            if (!standing.ContainsKey(country2))
            {
                standing.Add(country2, 0);
                goals.Add(country2, 0);
            }
            goals[country1] += result[0];
            goals[country2] += result[1];

            if (result[0] == result[1])
            {
                standing[country1]++;
                standing[country2]++;
            }
            else if (result[0] > result[1])
            {
                standing[country1] += 3;
            }
            else
            {
                standing[country2] += 3;
            }
        }

        private static string ReverseCountry(string country)
        {
            StringBuilder sb = new StringBuilder(country.Length);

            foreach (char ch in country)
            {
                sb.Insert(0, ch);
            }
            //Console.WriteLine(sb);
            return sb.ToString();
        }
    }
}
