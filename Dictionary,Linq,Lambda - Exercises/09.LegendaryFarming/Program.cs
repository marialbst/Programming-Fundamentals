using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            bool haveValanyr = false;
            bool haveShadowmourne = false;
            bool haveDragonwrath = false;
            Dictionary<string, int> materials = new Dictionary<string, int>();

            materials.Add("shards", 0);
            materials.Add("fragments", 0);
            materials.Add("motes", 0);

            while (!haveValanyr && !haveShadowmourne && !haveDragonwrath)
            {
                string[] input = Console.ReadLine()
                    .ToLower()
                    .Split(' ')
                    .ToArray();
                string material = "";
                int quantity = 0;

                for (int i = 1; i < input.Length; i += 2)
                {
                    material = input[i];
                    quantity = int.Parse(input[i - 1]);
                    AddMaterials(materials, material, quantity);

                    if (material.Equals("shards") && materials[material] >= 250)
                    {
                        haveShadowmourne = true;
                        materials[material] -= 250;
                        Console.WriteLine("Shadowmourne obtained!");
                        break;
                    }
                    else if (material.Equals("fragments") && materials[material] >= 250)
                    {
                        haveValanyr = true;
                        materials[material] -= 250;
                        Console.WriteLine("Valanyr obtained!");
                        break;
                    }
                    else if (material.Equals("motes") && materials[material] >= 250)
                    {
                        haveDragonwrath = true;
                        materials[material] -= 250;
                        Console.WriteLine("Dragonwrath obtained!");
                        break;
                    }
                }
            }
            PrintLeftovers(materials);
        }

        private static void AddMaterials(Dictionary<string, int> materials, string material, int quantity)
        {
            if (!materials.ContainsKey(material))
            {
                materials.Add(material, 0);
            }

            materials[material] += quantity;
        }

        private static void PrintLeftovers(Dictionary<string, int> materials)
        {
            var keyMaterials = materials.Take(3).OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToList();
            var junkMaterials = materials.Skip(3).OrderBy(x => x.Key).ToList();

            foreach (var key in keyMaterials)
            {
                Console.WriteLine($"{key.Key}: {key.Value}");
            }

            foreach (var junk in junkMaterials)
            {
                Console.WriteLine($"{junk.Key}: {junk.Value}");
            }
        }
    }
}
