using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

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

                command = Console.ReadLine();
            }
        }
    }
}
