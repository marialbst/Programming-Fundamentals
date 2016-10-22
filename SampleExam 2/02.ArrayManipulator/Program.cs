using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(new char[] {' ','\n'}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> numSubseq = new List<int>();
            string command = Console.ReadLine();

            while (!command.Equals("end"))
            {
                string[] instructions = command.Split(' ');

                if (instructions[0].Equals("exchange"))
                {
                    numbers = ExchangeValues(numbers, instructions);
                }
                else if (instructions[0].Equals("max") || instructions[0].Equals("min"))
                {
                    int index = FindIndexes(numbers, instructions);

                    if (index >= 0)
                    {
                        Console.WriteLine(index);
                    }
                    else
                    {
                        Console.WriteLine("No matches");
                    }
                }
                else if (instructions[0].Equals("first")||instructions[0].Equals("last"))
                {
                    int count = int.Parse(instructions[1]);
                    bool isValid = IsValid(numbers, count);
                    if (isValid)
                    {
                        numSubseq = FindNumbers(numbers, instructions);
                        Console.WriteLine($"[{string.Join(", ", numSubseq)}]");
                    }
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }

        private static List<int> FindNumbers(List<int> nums, string[] instr)
        {
            List<int> result = new List<int>();
            int count = int.Parse(instr[1]);
            if (instr[0].Equals("first"))
            {
                if (instr[2].Equals("even"))
                {
                    result = nums.Where(x => x%2 == 0).Take(count).ToList();
                }
                else if (instr[2].Equals("odd"))
                {
                    result = nums.Where(x => x % 2 != 0).Take(count).ToList();
                }
            }
            else if (instr[0].Equals("last"))
            {
                nums.Reverse();
                if (instr[2].Equals("even"))
                {
                    result = nums.Where(x => x % 2 == 0).Take(count).ToList(); 
                }
                else if (instr[2].Equals("odd"))
                {
                    result = nums.Where(x => x % 2 != 0).Take(count).ToList(); 
                }
                result.Reverse();
                nums.Reverse();
            }
            return result;
        }

        private static bool IsValid(List<int> nums, int count)
        {
            if (count > nums.Count)
            {
                Console.WriteLine("Invalid count");
                return false;
            }
            return true;
        }

        private static int FindIndexes(List<int> nums, string[] instr)
        {
            int result = 0;
            bool isAny = false;
            if (instr[0] == "max")
            {
                int maxValue = 0;
                if (instr[1] == "odd")
                {
                    if (nums.Exists(x => x % 2 != 0))
                    {
                        maxValue = nums.Where(x => x % 2 != 0).Max();
                        isAny = true;
                        result = nums.LastIndexOf(maxValue);
                    }
                }
                else if (instr[1] == "even")
                {
                    if (nums.Exists(x => x % 2 == 0))
                    {
                        maxValue = nums.Where(x => x % 2 == 0).Max();
                        isAny = true;
                        result = nums.LastIndexOf(maxValue);
                    }                  
                }
            }
            else
            {
                int minValue = 0;
                if (instr[1] == "odd")
                {
                    if (nums.Exists(x => x%2 != 0))
                    {
                        minValue = nums.Where(x => x%2 != 0).Min();
                        isAny = true;
                        result = nums.LastIndexOf(minValue);
                    }
                }
                else if (instr[1] == "even")
                {
                    if (nums.Exists(x => x%2 == 0))
                    {
                        minValue = nums.Where(x => x%2 == 0).Min();
                        isAny = true;
                        result = nums.LastIndexOf(minValue);
                    }
                }
                
            }
            if (isAny)
            {
                return result;
            }
            return -1;
            
        }

        private static List<int> ExchangeValues(List<int> nums, string[] instr)
        {
            int index = int.Parse(instr[1]);
            if (index >= nums.Count || index < 0)
            {
                Console.WriteLine("Invalid index");
                return nums;
            }
            else
            {
                List<int> subseq1 = nums.Take(index + 1).ToList();
                List<int> subseq2 = nums.Skip(index + 1).ToList();

                return subseq2.Concat(subseq1).ToList();
            }
            
        }
    }
}
