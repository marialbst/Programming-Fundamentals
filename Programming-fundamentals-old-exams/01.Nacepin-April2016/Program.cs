using System;

namespace _01.Nacepin_April2016
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal USD = 0.58m;
            const decimal GBP = 0.41m;
            const decimal CNY = 1m/0.27m;

            decimal usPrice = decimal.Parse(Console.ReadLine());
            decimal usWeight = decimal.Parse(Console.ReadLine());
            decimal ukPrice = decimal.Parse(Console.ReadLine());
            decimal ukWeight = decimal.Parse(Console.ReadLine());
            decimal cnPrice = decimal.Parse(Console.ReadLine());
            decimal cnWeight = decimal.Parse(Console.ReadLine());

            decimal pricePerKgUSinLeva = Math.Round((usPrice / usWeight) / USD, 2);
            decimal pricePerKgUKinLeva = Math.Round((ukPrice / ukWeight) / GBP, 2);
            decimal pricePerKgCNinLeva = Math.Round((cnPrice / cnWeight) / CNY, 2);

            string store = "";
            decimal difference = 0;
            decimal price = 0;

            if (pricePerKgCNinLeva <= Math.Min(pricePerKgUSinLeva, pricePerKgUKinLeva))
            {
                store = "Chinese";
                price = pricePerKgCNinLeva;
                difference = Math.Max(pricePerKgUSinLeva, pricePerKgUKinLeva) - price;
            }
            else if (pricePerKgUKinLeva <= Math.Min(pricePerKgUSinLeva, pricePerKgCNinLeva))
            {
                store = "UK";
                price = pricePerKgUKinLeva;
                difference = Math.Max(pricePerKgUSinLeva, pricePerKgCNinLeva) - price;
            }
            else
            {
                store = "US";
                price = pricePerKgUSinLeva;
                difference = Math.Max(pricePerKgUKinLeva, pricePerKgCNinLeva) - price;
            }
            Console.WriteLine($"{store} store. {price:f2} lv/kg");
            Console.WriteLine($"Difference {difference:f2} lv/kg");


        }
    }
}
