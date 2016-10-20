using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SoftuniWaterSupplies
{
    class Program
    {
        static void Main(string[] args)
        {
            long waterAvailable = long.Parse(Console.ReadLine());
            List<decimal> bottles = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            long bottlesCapacity = long.Parse(Console.ReadLine());

            decimal waterInBottles = bottles.Sum();
            decimal initial = waterAvailable;
            decimal neededWater = bottlesCapacity * bottles.Count - waterInBottles;
            //проверявам дали водата, която имам е достатъчна, за да остане
            if (waterAvailable >= neededWater)
            {
                Console.WriteLine("Enough water!");
                Console.WriteLine("Water left: {0}l.", waterAvailable - neededWater);
            }
            else //ако не е - започвам да пълня
            {
                long counter = 0;
                List<int> indexesLeft = new List<int>();


                //за нечетно к-во
                if (waterAvailable % 2 != 0)
                {
                    for (int i = bottles.Count - 1; i >= 0; i--)
                    {
                        FillBottles(bottles, bottlesCapacity, ref initial, ref counter, indexesLeft, i);

                    }
                }
                else //за четно количество
                {
                    for (int i = 0; i < bottles.Count; i++)
                    {
                        FillBottles(bottles, bottlesCapacity, ref initial, ref counter, indexesLeft, i);

                    }

                }
                Console.WriteLine("We need more water!");
                Console.WriteLine("Bottles left: {0}", bottles.Count - counter);
                Console.Write($"With indexes: {string.Join(", ", indexesLeft)}");
                Console.WriteLine();
                Console.WriteLine("We need {0} more liters!", neededWater - waterAvailable);
            }
        }

        private static void FillBottles(List<decimal> bottles, long bottlesCapacity, ref decimal initial, ref long counter, List<int> indexesLeft, int i)
        {
            decimal needed = bottlesCapacity - bottles[i];
            if (initial < needed)
            {
                indexesLeft.Add(i);
            }
            else
            {
                bottles[i] += needed;
                initial -= needed;
                counter++;
            }
        }
    }
}