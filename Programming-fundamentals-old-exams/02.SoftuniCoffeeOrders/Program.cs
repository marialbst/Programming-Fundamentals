using System;
using System.Globalization;

namespace _02.SoftuniCoffeeOrders
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal totalPrice = 0;

            for (int i = 0; i < n; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                long capsules = long.Parse(Console.ReadLine());

                int daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);
                decimal price = daysInMonth * pricePerCapsule * capsules;

                Console.WriteLine("The price for the coffee is: ${0:f2}", price);
                totalPrice += price;
            }

            Console.WriteLine("Total: ${0:f2}", totalPrice);
        }
    }
}
