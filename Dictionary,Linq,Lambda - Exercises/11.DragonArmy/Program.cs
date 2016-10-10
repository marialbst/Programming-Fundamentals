using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.DragonArmy
{
    class Program
    {
        static void Main(string[] args)
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
                Console.WriteLine(dragon.Key);
                Console.WriteLine($"-{string.Join(": ", dragon.Value.Select(x => $"{x.Key}-> damage: {x.Value[0]}, health: {x.Value[1]}, armor: {x.Value[2]}"))}"); //
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
                dragons[color].Add(name, numbers);
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
