using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AndreyAndBilliard
{
    public class Program
    {
        public static void Main()
        {
            Dictionary<string, decimal> menuItems = AddMenuItems();

            
            List<Client> clients = ReadClients(menuItems);
            

            PrintResults(clients, menuItems);

        }

        private static List<Client> ReadClients(Dictionary<string, decimal> menuItems)
        {
            string command = Console.ReadLine();
            List < Client > clients = new List<Client>();
            while (!command.Equals("end of clients"))
            {
                string[] ordersData = command.Split(new char[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries);
                string item = ordersData[1];
                string clientName = ordersData[0];
                int quantity = int.Parse(ordersData[2]);
                Dictionary<string, int> clientOrders = new Dictionary<string, int>();

                if (!menuItems.ContainsKey(item))
                {
                    command = Console.ReadLine();
                    continue;
                }
                Client client = new Client();
                if (clients.Any(cl => cl.Name == clientName))
                {
                    client = clients.First(cl => cl.Name == clientName);
                    if (!client.Order.ContainsKey(item))
                    {
                        client.Order.Add(item, 0);
                    }

                    client.Order[item] += quantity;
                   
                }
                else
                {
                    client.Name = clientName;
                    client.Order = new Dictionary<string, int>();
                    client.Order.Add(item, quantity);
                    clients.Add(client);
                }

                command = Console.ReadLine();
            }

            return clients;
        }

        static void PrintResults(List<Client> clients, Dictionary<string, decimal> menuItems)
        {
            List<decimal> bills = new List<decimal>();

            foreach (var client in clients.OrderBy(x => x.Name))
            {
                Console.WriteLine("{0}", client.Name);

                foreach (var order in client.Order)
                {
                    client.Bill = order.Value * menuItems[order.Key];
                    Console.WriteLine("-- {0} - {1}", order.Key, order.Value);
                }

                bills.Add(client.Bill);

                Console.WriteLine("Bill: {0:f2}", client.Bill);
            }

            Console.WriteLine("Total bill: {0:f2}", bills.Sum());
        }

        static Dictionary<string, decimal> AddMenuItems()
        {
            Dictionary<string, decimal> items = new Dictionary<string, decimal>();
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string[] itemProp = Console.ReadLine().Split('-').ToArray();
                string item = itemProp[0];
                decimal singlePrice = decimal.Parse(itemProp[1]);

                if (!items.ContainsKey(item))
                {
                    items.Add(item, 0);
                }

                items[item] = singlePrice;
            }

            return items;
        }
    }

    class Client
    {
        public string Name { get; set; }
        public Dictionary<string, int> Order { get; set; }
        public decimal Bill { get; set; }
    }
}
