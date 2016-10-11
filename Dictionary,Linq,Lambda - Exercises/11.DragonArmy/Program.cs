using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.DragonArmy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dragons = new Dictionary<string, Dictionary<string, int[]>>();
            int[] numbers = new int[3];
            
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string color = input[0];
                string name = input[1];
                
                ExtractDefaultValues(input);

                for (int j = 2; j < 5; j++)
                {
                    numbers[j - 2] = int.Parse(input[j]);
                   
                }

                AddValuesToDictionary(dragons, numbers, color, name);
            }

            PrintResults(dragons);

        }

        private static void PrintResults(Dictionary<string, Dictionary<string, int[]>> dragons)
        {
            foreach (var dragon in dragons)
            {
                var avDamage = dragon.Value.Select(x => x.Value[0]).Average();
		var avHealth = dragon.Value.Select(x => x.Value[1]).Average();
		var avArmor = dragon.Value.Select(x => x.Value[2]).Average();
		Console.WriteLine($"{dragon.Key}::({avDamage:f}/{avHealth:f}/{avArmor:f})");
                Console.Write($"-{string.Join("-", dragon.Value.OrderBy(x => x.Key).Select(x => $"{x.Key} -> damage: {x.Value[0]}, health: {x.Value[1]}, armor: {x.Value[2]}\n"))}"); 
	    }
        }

        private static void AddValuesToDictionary(Dictionary<string, Dictionary<string, int[]>> dragons, int[] numbers, string color, string name)
        {
            if (!dragons.ContainsKey(color))
            {
                dragons.Add(color, new Dictionary<string, int[]>());
            }

            if (!dragons[color].ContainsKey(name))
            {
                dragons[color].Add(name, new int[3]);
            }

            for (int k = 0; k < 3; k++)
            {
                dragons[color][name][k] += numbers[k];
            }
        }

        private static void ExtractDefaultValues(string[] input)
        {
            if (input[2] == "null")
            {
                input[2] = "45";
            }
            if (input[3] == "null")
            {
                input[3] = "250";
            }
            if (input[4] == "null")
            {
                input[4] = "10";
            }
        }
    }
}
