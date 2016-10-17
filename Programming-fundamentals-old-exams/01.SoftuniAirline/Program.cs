using System;

namespace _01.SoftuniAirline
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal overallProfit = 0;
            decimal averageProfit = 0;

            for (int i = 0; i < n; i++)
            {
                long adultsCount = long.Parse(Console.ReadLine());
                decimal adultPrice = decimal.Parse(Console.ReadLine());
                long kidsCount = long.Parse(Console.ReadLine());
                decimal kidsPrice = decimal.Parse(Console.ReadLine());
                decimal fuelPrice = decimal.Parse(Console.ReadLine());
                decimal fuelConsumption = decimal.Parse(Console.ReadLine());
                int flightDuration = int.Parse(Console.ReadLine());

                decimal income = adultsCount * adultPrice + kidsCount * kidsPrice;
                decimal outtake = fuelPrice * fuelConsumption * flightDuration;
                decimal flightProfit = income - outtake;

                if (flightProfit < 0)
                {
                    Console.WriteLine("We've got to sell more tickets! We've lost {0:f3}$.", flightProfit);
                }
                else
                {
                    Console.WriteLine("You are ahead with {0:f3}$.", flightProfit);
                }

                overallProfit += flightProfit;
            }

            averageProfit = overallProfit / n;

            Console.WriteLine("Overall profit -> {0:f3}$.", overallProfit);
            Console.WriteLine("Average profit -> {0:f3}$.", averageProfit);
        }
    }
}
