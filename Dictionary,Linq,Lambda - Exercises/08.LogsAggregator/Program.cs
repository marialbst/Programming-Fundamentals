using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.LogsAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> logs = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ')
                    .ToArray();
                string ip = input[0];
                string user = input[1];
                int duration = int.Parse(input[2]);

                AddUsers(logs, user);
                AddIpsAndDuration(logs, user, ip, duration);
            }

            PrintLogs(logs);
        }

        private static void PrintLogs(Dictionary<string, Dictionary<string, int>> logs)
        {
            foreach (var log in logs.OrderBy(x => x.Key))
            {
                Console.Write($"{log.Key}: ");
                Console.Write($"{log.Value.Sum(x => x.Value)} ");
                Console.WriteLine($"[{string.Join(", ", log.Value.OrderBy(x => x.Key).Select(x => $"{x.Key}"))}]");
            }
        }

        private static void AddIpsAndDuration(Dictionary<string, Dictionary<string, int>> logs, string user, string ip, int duration)
        {
            if (!logs[user].ContainsKey(ip))
            {
                logs[user].Add(ip, 0);
            }

            logs[user][ip] += duration;
        }

        private static void AddUsers(Dictionary<string, Dictionary<string, int>> logs, string user)
        {
            if (!logs.ContainsKey(user))
            {
                logs.Add(user, new Dictionary<string, int>());
            }
        }
    }
}
