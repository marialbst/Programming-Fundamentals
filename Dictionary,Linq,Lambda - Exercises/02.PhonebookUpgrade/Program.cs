using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PhonebookUpgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            SortedDictionary<string, string> phoneBook = new SortedDictionary<string, string>();

            while (command != "END")
            {
                string[] actions = command.Split(' ')
                    .ToArray();

                if (actions[0] == "A")
                {
                    phoneBook[actions[1]] = actions[2];
                }
                else if (actions[0] == "S")
                {
                    if (phoneBook.ContainsKey(actions[1]))
                    {

                        Console.WriteLine("{0} -> {1}", actions[1], phoneBook[actions[1]]);
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", actions[1]);
                    }

                }
                else if (command == "ListAll")
                {

                    foreach (var pair in phoneBook)
                    {
                        Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
                    }
                }
                command = Console.ReadLine();
            }
        }
    }
}
