using System;
using System.Globalization;

namespace _01.Softuni_Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());
            decimal totalPrice = 0;
            for (int i = 0; i < orders; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                long capsules = long.Parse(Console.ReadLine());
                int days = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);


                decimal price = days * capsules * pricePerCapsule;

                Console.WriteLine($"The price for the coffee is: ${price:f2}");
                totalPrice += price;
            }

            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
