using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Game_Of_Names_24._04._2016
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, long> players = new Dictionary<string, long>();
            long maxPoints = long.MinValue;
            string winner = "";
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                int initialPoints = int.Parse(Console.ReadLine());
                long totalPoints = initialPoints;
                char[] nameArray = name.ToCharArray();

                for(int j=0; j<nameArray.Length; j++)
                {
                    if ((int)nameArray[j] % 2 == 0)
                    {
                        totalPoints += (int)nameArray[j];
                    }
                    else
                    {
                        totalPoints -= (int)nameArray[j];
                    }

                }

                if (totalPoints > maxPoints)
                {
                    maxPoints = totalPoints;
                    winner = name;
                }
                //players.Add(name, totalPoints);
            }

            Console.WriteLine($"The winner is {winner} - {maxPoints} points");

            /*foreach (var player in players.OrderByDescending(x => x.Value).Take(1))
            {
                Console.WriteLine($"The winner is {player.Key} - {player.Value} points");
            }*/
        }
    }
}
