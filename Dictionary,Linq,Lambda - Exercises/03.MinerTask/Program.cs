using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> goods = new Dictionary<string, int>();
            string command = Console.ReadLine();

            while (command != "stop")
            {
                string typeGood = command;
                int valueGood = int.Parse(Console.ReadLine());

                if (goods.ContainsKey(typeGood))
                {
                    goods[typeGood] += valueGood;
                }
                else
                {
                    goods[typeGood] = valueGood;
                }

                command = Console.ReadLine();
            }

            foreach (var good in goods)
            {
                Console.WriteLine("{0} -> {1}", good.Key, good.Value);
            }
        }
    }
}
