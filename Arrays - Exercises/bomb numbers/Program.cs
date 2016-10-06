using System;
using System.Collections.Generic;
using System.Linq;

namespace bomb_numbers
{
    class Program
    {
        static List<int> ExplodeBombs(List<int> nums, int[] instruction)
        {
            int bomb = instruction[0];
            int power = instruction[1];

            while (nums.Contains(bomb))
            {
                int index = nums.IndexOf(bomb);

                int left = Math.Max(0, index - power);
                int right = Math.Min(index + power, nums.Count - 1);
                int length = right - left + 1;
                nums.RemoveRange(left, length);
                index = nums.IndexOf(bomb);
            }

            return nums;
        }

        
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] instruction = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            List<int> result = ExplodeBombs(numbers, instruction);
            int sum = numbers.Sum();
            //Console.WriteLine(string.Join(" ", numbers));
            Console.WriteLine(sum);
        }

        
    }
}
