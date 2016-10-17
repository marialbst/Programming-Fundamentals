using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.TrophonTheGrumpyCat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            int startPos = int.Parse(Console.ReadLine());

            List<long> leftSide = numbers.Take(startPos).ToList();
            List<long> rightSide = numbers.Skip(startPos + 1).ToList();

            FirstLoop(numbers, startPos, ref leftSide, ref rightSide);
            SecondLoop(ref leftSide, ref rightSide);

            FindSums(leftSide, rightSide);
        }

        private static void FindSums(List<long> leftSide, List<long> rightSide)
        {
            long leftSideDamage = leftSide.Sum();
            long rightSideDamage = rightSide.Sum();

            if (leftSideDamage >= rightSideDamage)
            {
                Console.WriteLine($"Left - {leftSideDamage}");
            }
            else
            {
                Console.WriteLine($"Right - {rightSideDamage}");
            }
        }

        private static void SecondLoop(ref List<long> leftSide, ref List<long> rightSide)
        {
            string valuesRating = Console.ReadLine();

            if (valuesRating.Equals("positive"))
            {
                leftSide = leftSide.Where(x => x > 0).ToList();
                rightSide = rightSide.Where(x => x > 0).ToList();
            }
            else if (valuesRating.Equals("negative"))
            {
                leftSide = leftSide.Where(x => x < 0).ToList();
                rightSide = rightSide.Where(x => x < 0).ToList();
            }
        }

        private static void FirstLoop(List<long> numbers, int startPos, ref List<long> leftSide, ref List<long> rightSide)
        {
            string itemPrice = Console.ReadLine();

            if (itemPrice.Equals("cheap"))
            {

                leftSide = leftSide.Where(x => x < numbers[startPos]).ToList();
                rightSide = rightSide.Where(x => x < numbers[startPos]).ToList();
            }
            else
            {
                leftSide = leftSide.Where(x => x >= numbers[startPos]).ToList();
                rightSide = rightSide.Where(x => x >= numbers[startPos]).ToList();
            }
        }
    }
}