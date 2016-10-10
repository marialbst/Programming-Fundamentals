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
            var countries = new Dictionary<string, Dictionary<string, long>>();

            while (!command.Equals("report"))
            {
                string[] countriesData = command.Split('|');
                string city = countriesData[0];
                string country = countriesData[1];
                int population = int.Parse(countriesData[2]);

                AddCountry(countries, country);
                AddCityAndPopulation(countries, country, city, population);
                command = Console.ReadLine();
            }

            PrintCountryData(countries);

        }

        private static void PrintCountryData(Dictionary<string, Dictionary<string, long>> countries)
        {
            foreach (var place in countries.OrderByDescending(x => x.Value.Sum(y => y.Value)))
            {
                Console.WriteLine($"{place.Key} (total population: {place.Value.Select(x => x.Value).Sum()})");
                Console.Write($"=>{string.Join("=>", place.Value.OrderByDescending(x => x.Value).Select(x => $"{x.Key}: {x.Value}\n"))}");
            }
        }

        private static void AddCityAndPopulation(Dictionary<string, Dictionary<string, long>> countries, string country, string city, int population)
        {
            if (!countries[country].ContainsKey(city))
            {
                countries[country].Add(city, 0);
            }

            countries[country][city] += population;
        }

        private static void AddCountry(Dictionary<string, Dictionary<string, long>> countries, string country)
        {
            if (!countries.ContainsKey(country))
            {
                countries.Add(country, new Dictionary<string, long>());
            }
        }
    }
}
