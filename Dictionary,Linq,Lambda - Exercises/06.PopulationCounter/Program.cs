using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            var countries = new SortedDictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> cityPopulation = new Dictionary<string, int>();

            while (!command.Equals("report"))
            {
                string[] countriesData = command.Split('|');
                string city = countriesData[0];
                string country = countriesData[1];
                int population = int.Parse(countriesData[2]);
               

                if (!countries.ContainsKey(country))
                {
                    countries.Add(country, new Dictionary<string, int>());
                }

                if (!cityPopulation.ContainsKey(city))
                {
                    cityPopulation.Add(city, population);
                }

                command = Console.ReadLine();
            }

            
            foreach (var place in countries.OrderBy(x=> x.Value))
            {
                Console.WriteLine($"{place.Key} (total population: {cityPopulation.Sum(x => x.Value)})");
                Console.WriteLine($"{string.Join("=>",place.Value.Select(x => $"{x.Key}: {x.Value}"))}\n");
            }
            
        }
    }
}
