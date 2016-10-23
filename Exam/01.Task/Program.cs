using System;

namespace _01.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int marathonDays = int.Parse(Console.ReadLine());
            int numberRunners = int.Parse(Console.ReadLine());
            int averageLaps = int.Parse(Console.ReadLine());
            int trackLengthMeters = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            double moneyPerKm = double.Parse(Console.ReadLine());

            int trackCapacity = capacity*marathonDays;
            int runners = 0;
            if (trackCapacity >= numberRunners)
            {
                runners = numberRunners;
            }
            else
            {
                runners = trackCapacity;
            }

            long totalMetersRan = (long) trackLengthMeters*averageLaps*runners;
            double totalKm = (double)totalMetersRan/1000;

            double totalMoney = totalKm*moneyPerKm;

            Console.WriteLine($"Money raised: {totalMoney:f2}");
        }
    }
}
