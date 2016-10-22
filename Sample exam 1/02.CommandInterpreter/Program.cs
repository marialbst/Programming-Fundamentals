using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.CommandInterpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            text = Regex.Replace(text, @"\s+", " ");

            List<string> sequence = text.Split(' ').ToList();

            string command = Console.ReadLine();

            while (!command.Equals("end"))
            {
                command = Regex.Replace(command, @"\s+", " ");
                string[] instructions = command.Split(' ');

                if (instructions[0] == "reverse")
                {
                    sequence = ReverseArray(instructions, sequence);
                }
                else if(instructions[0] == "sort")
                {
                    sequence = SortArray(instructions, sequence);
                }
                else if (instructions[0] == "rollLeft")
                {
                    sequence = RollLeft(instructions, sequence);
                }
                else if (instructions[0] == "rollRight")
                {
                    sequence = RollRight(instructions, sequence);
                }
                else
                {
                    Console.WriteLine("Invalid input parameters.");
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", sequence)}]");
        }

        private static List<string> RollRight(string[] instr, List<string> seq)
        {
            int count = int.Parse(instr[1]);

            if (count < 0)
            {
                Console.WriteLine("Invalid input parameters.");
            }
            else
            {
                for (int j = 0; j < count%seq.Count; j++)
                {
                    string temp = seq[seq.Count - 1];
                    for (int i = seq.Count - 1; i > 0; i--)
                    {
                        seq[i] = seq[i - 1];
                    }

                    seq[0] = temp;
                }
            }
            return seq;
        }

        private static List<string> RollLeft(string[] instr, List<string> seq)
        {
            int count = int.Parse(instr[1]);

            if (count < 0)
            {
                Console.WriteLine("Invalid input parameters.");
            }
            else
            {
                for (int j = 0; j < count%seq.Count; j++)
                {
                    string temp = seq[0];
                    for (int i = 0; i < seq.Count - 1; i++)
                    {
                        seq[i] = seq[i + 1];
                    }

                    seq[seq.Count - 1] = temp;
                }

            }
            return seq;   
        }

        private static List<string> ReverseArray(string[] instr, List<string> seq)
        {
            int startPos = int.Parse(instr[2]);
            int numOfElements = int.Parse(instr[4]);

            if (startPos < 0 || startPos >= seq.Count || numOfElements > seq.Count || numOfElements < 0 || startPos + numOfElements > seq.Count)
            {
                Console.WriteLine("Invalid input parameters.");
            }
            else
            {
                seq.Reverse(startPos, numOfElements);
            }

            return seq;
        }

        private static List<string> SortArray(string[] instr, List<string> seq)
        {
            int startPos = int.Parse(instr[2]);
            int numOfElements = int.Parse(instr[4]);

            if (startPos < 0 || startPos >= seq.Count || numOfElements > seq.Count || numOfElements < 0 || startPos + numOfElements > seq.Count)
            {
                Console.WriteLine("Invalid input parameters.");
            }
            else
            {
                seq.Sort(startPos, numOfElements, StringComparer.InvariantCulture);
            }

            return seq;
        }
    }
}
