using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.PopulationAggregation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Dictionary<string, int> citiesByCountry = new Dictionary<string, int>();
            Dictionary<string, long> populationByCity = new Dictionary<string, long>();

            while (!command.Equals("stop"))
            {
                string[] data = command.Split('\\');
                string city = "";
                string country = "";
                long population = long.Parse(data[2]);
                for (int i = 0; i < 2; i++)
                {
                    data[i] = string.Join("", data[i].Split(new char[] { '@', '$', '&', '#', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' },
                            StringSplitOptions.RemoveEmptyEntries));

                }

                if (data[0].StartsWith(data[0].ToLower()))
                {
                    city = data[0];
                    country = data[1];
                }
                else
                {
                    city = data[1];
                    country = data[0];
                }


                if (!citiesByCountry.ContainsKey(country))
                {
                    citiesByCountry.Add(country, 0);
                }

                citiesByCountry[country]++;

                if (!populationByCity.ContainsKey(city))
                {
                    populationByCity.Add(city, 0);
                }

                populationByCity[city] = population;

                command = Console.ReadLine();
            }

            foreach (var country in citiesByCountry.OrderBy(x => x.Key))
            {
                Console.WriteLine("{0} -> {1}", country.Key, country.Value);

            }

            foreach (var city in populationByCity.OrderByDescending(x => x.Value).Take(3))
            {

                Console.WriteLine("{0} -> {1}", city.Key, city.Value);
            }
        }
    }


}