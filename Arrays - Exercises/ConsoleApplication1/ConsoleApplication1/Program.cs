using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList(); // example : 2 3 4 5 1
        List<int>[] sequences = new List<int>[numbers.Count];

        /*for (int i = 0; i < numbers.Count; i++) // add current to list<list<int>> indexes
        {

            for (int j = 0; j < numbers.Count - 1; j++) //current index numbers[j]=2
        {
         if (numbers[j] < numbers[j+1]) //if current < any of the next  => add current to each position of sequences[i] where is true
                    {
                    sequences[i] = new List<int> { numbers[j] };// 2 < 3  => sequences[0].Add(2)
                    }
                }
            
        }*/

        for(int numberIndex = 0; numberIndex < numbers.Count; numberIndex++)
        {
            for(int nextNumIndex = numberIndex; nextNumIndex < numbers.Count; nextNumIndex++)
            {
                if(numbers[numberIndex] < numbers[nextNumIndex])
                {
                    Console.Write($"{numbers[numberIndex]} ");
                }
            }
        }
        //print list sequence on each list position, just for check!!!!
       /* for (int x = 0; x < sequences.Length; x++)
        {
            for (int z = 0; z < sequences[x].Count; z++)
            {
                Console.WriteLine(string.Join(" ", sequences[x]));
            }
        }*/

    }
}
