using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _04.PopulationAggregation
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> countries = new Dictionary<string, Dictionary<string, int>>();
            while (!command.Equals("stop"))
            {
                string[] data = command.Split('\\');
                string city = "";
                string country = "";
                int population = int.Parse(data[2]);
                for (int i=0;i<2;i++)
                {
                    data[i] =
                        data[i].Split(new char[] {'@', '$', '&', '#', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'},
                            StringSplitOptions.RemoveEmptyEntries).ToString();
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

                if (!countries.ContainsKey(country))
                {
                    countries.Add(country, new Dictionary<string, int>());
                }

                if (!countries[country].ContainsKey(city))
                {
                    countries[country].Add(city, 0);
                }

                countries[country][city] = population;
                command = Console.ReadLine();
            }

            foreach (var country in countries)
            {
                Console.WriteLine($"{country.Key} -> {country.Value.Keys.Count}");
            }
        }
    }

    
}
