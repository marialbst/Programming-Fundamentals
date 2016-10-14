using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SalesReport
{
    public class Program
    {
        public static void Main()
        {
            Sale[] sales = ReadSales();
            var towns = sales.Select(x => x.Town).Distinct().OrderBy(x => x);

            foreach (var town in towns)
            {
                decimal salesByTown = sales.Where(s => s.Town == town).Select(s => s.Profit).Sum();
                Console.WriteLine("{0} -> {1:f2}", town, salesByTown);
            }
        }

        static Sale ReadSingleSale()
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            Sale sale = new Sale();
            sale.Town = input[0];
            sale.Product = input[1];
            sale.Quantity = decimal.Parse(input[2]);
            sale.SinglePrice = decimal.Parse(input[3]);

            return sale;

        }

        static Sale[] ReadSales()
        {
            int n = int.Parse(Console.ReadLine());
            Sale[] sales = new Sale[n];

            for (int i = 0; i < n; i++)
            {
                sales[i] = ReadSingleSale();
            }

            return sales;
        }
    }

    /*class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Quantity { get; set; }
        public decimal SinglePrice { get; set; }
        public decimal Profit
        {
            get
            {
                return Quantity * SinglePrice;
            }
        }
    }*/
}
