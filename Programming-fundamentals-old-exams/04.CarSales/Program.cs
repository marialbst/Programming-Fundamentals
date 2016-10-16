using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.CarSales
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> vehiclesAvailable = Console.ReadLine().Split(' ').ToList();
            
            string command = Console.ReadLine();
            int counter = 0;

            while (!command.Equals("End of customers!"))
            {
                string[] requests = command.Split(' ');
                string vehicle = requests[0].ToLower();
                
                char firstLetter = vehicle[0];
                int places = int.Parse(requests[2]);

                string car = $"{firstLetter}{places}";

                if (vehiclesAvailable.Contains(car))
                {
                    Console.WriteLine($"Yes, sold for {(int)firstLetter * places}$");
                    counter++;
                    vehiclesAvailable.Remove($"{firstLetter}{places}");
                }
                else
                {
                    Console.WriteLine("No");
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Vehicles left: {string.Join(", ", vehiclesAvailable)}");
            Console.WriteLine($"Vehicles sold: {counter}");
        }
    }
}
