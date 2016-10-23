using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<int, string> eventsById = new Dictionary<int, string>();
            Dictionary<string, List<string>> partsByEvent = new Dictionary<string, List<string>>();

            while (!input.Equals("Time for Code"))
            {
                if (input.Contains("#"))
                {
                    string[] info = input.Split(new char[]{' ', '#'}, StringSplitOptions.RemoveEmptyEntries);
                    int id = int.Parse(info[0]);
                    string eventName = info[1];

                    List<string> participiants = new List<string>();
                    if (info.Length > 2)
                    {
                        for (int i = 2; i < info.Length; i++)
                        {
                            participiants.Add(info[i]);
                        }
                    }

                    if (!eventsById.ContainsKey(id))
                    {
                        eventsById.Add(id, eventName);
                        partsByEvent.Add(eventName, participiants);
                    }
                    else if(eventsById[id] == eventName)
                    {
                        partsByEvent[eventName].AddRange(participiants);
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var part in partsByEvent.OrderByDescending(x=>x.Value.Distinct().Count()).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{part.Key} - {part.Value.Distinct().Count()}");

                foreach (var val in part.Value.OrderBy(x=>x).Distinct())
                {
                    Console.WriteLine(val);
                }
            }
        }
    }
}
