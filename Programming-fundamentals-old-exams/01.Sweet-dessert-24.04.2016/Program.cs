using System;

namespace _01.Sweet_dessert_24._04._2016
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal ivanchoMoney = decimal.Parse(Console.ReadLine());
            long guests = long.Parse(Console.ReadLine());
            double bananaSinglePrice = double.Parse(Console.ReadLine());
            double eggsSinglePrice = double.Parse(Console.ReadLine());
            double berrySinglePrice = double.Parse(Console.ReadLine());

            decimal priceForSinglePortion = (decimal)(2 *bananaSinglePrice + 4*eggsSinglePrice + 0.2*berrySinglePrice);

            long portionsToMake = 0;

            if (guests%6 == 0)
            {
                portionsToMake = guests/6;
            }
            else
            {
                portionsToMake = 1 + guests/6;
            }

            decimal totalMoneyNeeded = portionsToMake * priceForSinglePortion;

            if (ivanchoMoney >= totalMoneyNeeded)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalMoneyNeeded:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {totalMoneyNeeded-ivanchoMoney:f2}lv more.");
            }
        }
    }
}
