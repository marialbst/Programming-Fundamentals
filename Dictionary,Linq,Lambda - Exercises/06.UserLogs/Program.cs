using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, int>> userActions = new SortedDictionary<string, Dictionary<string, int>>();
            string command = Console.ReadLine();
            
            while (!command.Equals("end"))
            {
                string[] sequence = command.Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries);
                Dictionary<string, int> ipAddresses = new Dictionary<string, int>();
                var ipAddress = sequence[1];
                var userName = sequence[5];

                if (!userActions.ContainsKey(userName))
                {
                    userActions.Add(userName, new Dictionary<string, int>());
                }

                if (!userActions[userName].ContainsKey(ipAddress))
                {
                    userActions[userName].Add(ipAddress, 0);
                }

                userActions[userName][ipAddress]++;
                

                command = Console.ReadLine();
            }

            foreach (var item in userActions.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: ");
                Console.WriteLine($"{string.Join(", ", item.Value.Select(x => $"{x.Key} => {x.Value}"))}.");
            }
        }

    }
}
