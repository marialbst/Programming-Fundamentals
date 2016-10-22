using System;

namespace _01.SweetDessert
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal ivanchoCash = decimal.Parse(Console.ReadLine());
            long guests = long.Parse(Console.ReadLine());
            decimal singleBananaPrice = decimal.Parse(Console.ReadLine());
            decimal singleEggPrice = decimal.Parse(Console.ReadLine());
            decimal singleBerryPrice = decimal.Parse(Console.ReadLine());

            long setsToCook = guests / 6;

            if (guests%6 != 0)
            {
                setsToCook ++;
            }

            decimal priceForSet = singleBananaPrice*2m + singleEggPrice*4m + singleBerryPrice*0.2m;
            decimal totalPrice = priceForSet*setsToCook;

            if (totalPrice > ivanchoCash)
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {totalPrice - ivanchoCash:f2}lv more.");
            }
            else
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalPrice:f2}lv.");
            }
        }
    }
}
