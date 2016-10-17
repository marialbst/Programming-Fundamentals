using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SoftuniCoffeeSupplies
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] delimeters = Console.ReadLine().Split(' ');

            Dictionary<string, string> cofeeByUser = new Dictionary<string, string>();
            Dictionary<string, long> cofeeQuantity = new Dictionary<string, long>();

            string command = Console.ReadLine();

            while (command != "end of info")
            {
                string[] personCoffee = command.Split(new string[] { delimeters[0] }, StringSplitOptions.RemoveEmptyEntries);
                string[] coffeeQuantity = command.Split(new string[] { delimeters[1] }, StringSplitOptions.RemoveEmptyEntries);

                if (personCoffee.Length > 1)
                {
                    string name = personCoffee[0];
                    string coffeeType = personCoffee[1];

                    if (!cofeeByUser.ContainsKey(name))
                    {
                        cofeeByUser.Add(name, "");
                    }

                    if (!cofeeQuantity.ContainsKey(coffeeType))
                    {
                        cofeeQuantity.Add(coffeeType, 0);
                    }

                    cofeeByUser[name] = coffeeType;
                }
                else if (coffeeQuantity.Length > 1)
                {
                    string coffeeType = coffeeQuantity[0];
                    long quantity = long.Parse(coffeeQuantity[1]);

                    if (!cofeeQuantity.ContainsKey(coffeeType))
                    {
                        cofeeQuantity.Add(coffeeType, 0);
                    }

                    cofeeQuantity[coffeeType] += quantity;
                }


                command = Console.ReadLine();
            }

            /*foreach(var coffee in cofeeByUser)
            {
                Console.WriteLine("{0}->{1}", coffee.Key, coffee.Value);
            }

            foreach(var coffee in cofeeQuantity)
            {
                Console.WriteLine("{0}->{1}", coffee.Key, coffee.Value);
            }
            */
            foreach (var coffee in cofeeQuantity.Where(x => x.Value <= 0))
            {
                Console.WriteLine("Out of {0}", coffee.Key);
            }

            command = Console.ReadLine();
            while (!command.Equals("end of week"))
            {

                string[] drinkAmount = command.Split(' ');
                //Console.WriteLine(drinkAmount.Length);

                string name = drinkAmount[0];
                long quantity = long.Parse(drinkAmount[1]);

                string coffeeType = cofeeByUser[name];

                cofeeQuantity[coffeeType] -= quantity;

                if (cofeeQuantity[coffeeType] <= 0)
                {
                    Console.WriteLine("Out of {0}", coffeeType);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("Coffee Left:");

            foreach (var coffee in cofeeQuantity.OrderByDescending(x => x.Value).Where(x => x.Value > 0))
            {
                Console.WriteLine("{0} {1}", coffee.Key, coffee.Value);
            }

            Console.WriteLine("For:");

            foreach (var person in cofeeByUser.OrderBy(x => x.Value).ThenByDescending(x => x.Key).Where(x => cofeeQuantity[x.Value] > 0))
            {
                Console.WriteLine("{0} {1}", person.Key, person.Value);
            }
        }
    }
}
