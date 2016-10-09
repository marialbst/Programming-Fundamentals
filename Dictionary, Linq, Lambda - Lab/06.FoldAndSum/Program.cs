using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numSeq = Console.ReadLine()
                                    .Split(' ')
                                    .Select(int.Parse)
                                    .ToList();
            int k = numSeq.Count / 4;
            List<int> leftSide = numSeq.Take(k).Reverse().ToList();
            List<int> rightSide = numSeq.Skip(3 * k).Take(k).Reverse().ToList();
            List<int> middleSide = numSeq.Skip(k).Take(2 * k).ToList();

            List<int> firstSeq = leftSide.Concat(rightSide).ToList();

            middleSide = middleSide.Select((num, i) => num + firstSeq[i]).ToList();

            Console.WriteLine(string.Join(" ", middleSide));
        }
    }
}
