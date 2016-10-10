using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SrabskoUnleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> concerts = new Dictionary<string, Dictionary<string, int>>();
            while (!command.Equals("End"))
            {
                string[] tourData = command.Split('@').ToArray();
                string singer = tourData[0];
                string[] tourCity = tourData[1].Split(' ');
                string city = "";
                int ticketPrice = 0;
                int soldTickets = 0;

                if (singer[singer.Length - 1] == ' ' && tourCity.Length >= 3
                              && int.TryParse(tourCity[tourCity.Length - 1], out soldTickets)
                              && int.TryParse(tourCity[tourCity.Length - 2], out ticketPrice))
                {
                    soldTickets = int.Parse(tourCity[tourCity.Length - 1]);
                    ticketPrice = int.Parse(tourCity[tourCity.Length - 2]);

                    for (int i = 0; i < tourCity.Length - 2; i++)
                    {
                        city += tourCity[i] + " ";
                    }
                }
                else
                {
                    command = Console.ReadLine();
                    continue;
                }

                AddConcertsData(concerts, singer, city, ticketPrice, soldTickets);

                command = Console.ReadLine();
            }

            PrintResults(concerts);
        }

        private static void AddConcertsData(Dictionary<string, Dictionary<string, int>> concerts, string singer, string city, int ticketPrice, int soldTickets)
        {
            if (!concerts.ContainsKey(city))
            {
                concerts.Add(city, new Dictionary<string, int>());
            }

            if (!concerts[city].ContainsKey(singer))
            {
                concerts[city].Add(singer, 0);
            }

            concerts[city][singer] += ticketPrice * soldTickets;
        }

        private static void PrintResults(Dictionary<string, Dictionary<string, int>> concerts)
        {
            foreach (var concert in concerts)
            {
                Console.Write($"{concert.Key}\n");
                Console.Write($"#  {string.Join("#  ", concert.Value.OrderByDescending(x => x.Value).Select(x => $"{x.Key}-> {x.Value}\n"))}");
            }
        }
    }
}
