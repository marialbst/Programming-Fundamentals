using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = Console.ReadLine();

            string command = Console.ReadLine();
            Dictionary<string, long> pointsByCountry = new Dictionary<string, long>();
            Dictionary<string, long> goalsByCountry = new Dictionary<string, long>();

            while (!command.Equals("final"))
            {
                string[] commandArray = command.Split(' ');

                commandArray = ExtractCountries(pattern, commandArray);
                DistributePointsToCountries(pointsByCountry, goalsByCountry, commandArray);
                command = Console.ReadLine();
            }

            PrintStandings(pointsByCountry, goalsByCountry);

        }

        private static void PrintStandings(Dictionary<string, long> pointsByCountry, Dictionary<string, long> goalsByCountry)
        {
            Console.WriteLine("League standings:");
            int counter = 1;

            foreach (var country in pointsByCountry.OrderByDescending(x => x.Value).ThenBy(x=> x.Key))
            {
                Console.WriteLine($"{counter}. {country.Key} {country.Value}");
                counter++;
            }

            Console.WriteLine("Top 3 scored goals:");

            foreach (var country in goalsByCountry.OrderByDescending(x => x.Value).ThenBy(x=>x.Key).Take(3))
            {
                Console.WriteLine($"- {country.Key} -> {country.Value}");
            }
        }

        private static void DistributePointsToCountries(Dictionary<string, long> pointsByCountry, Dictionary<string, long> goalsByCountry, string[] commandArray)
        {
            string firstTeam = commandArray[0];
            string secondTeam = commandArray[1];
            long[] resultArray = commandArray[2].Split(':').Select(long.Parse).ToArray();
            long firstTeamResult = resultArray[0];
            long secondTeamResult = resultArray[1];

            for (int i = 0; i < 2; i++)
            {
                if (!pointsByCountry.ContainsKey(commandArray[i]))
                {
                    pointsByCountry.Add(commandArray[i], 0);
                }

                if (!goalsByCountry.ContainsKey(commandArray[i]))
                {
                    goalsByCountry.Add(commandArray[i], 0);
                }
            }

            goalsByCountry[firstTeam] += firstTeamResult;
            goalsByCountry[secondTeam] += secondTeamResult;

            if (firstTeamResult > secondTeamResult)
            {
                pointsByCountry[firstTeam] += 3;
            }
            else if (secondTeamResult > firstTeamResult)
            {
                pointsByCountry[secondTeam] += 3;
            }
            else
            {
                pointsByCountry[firstTeam]++;
                pointsByCountry[secondTeam]++;
            }
        }

        private static string[] ExtractCountries(string pattern, string[] commandArray)
        {
            for (int i = 0; i < 2; i++)
            {
                int startIndex = commandArray[i].IndexOf(pattern, StringComparison.Ordinal);
                int endIndex = commandArray[i].LastIndexOf(pattern, StringComparison.Ordinal);
                int length = endIndex - startIndex;
                commandArray[i] = commandArray[i].Substring(startIndex, length).ToUpper();

                string str = string.Join("", commandArray[i].Skip(pattern.Length).Reverse());
                commandArray[i] = str;
            }

            return commandArray;
        }
    }
}
