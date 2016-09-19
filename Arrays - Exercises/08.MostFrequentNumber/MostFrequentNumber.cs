using System;

namespace MostFrequentNumber
{
    class MostFrequentNumber
    {
        static void Main(string[] args)
        {
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int counter = 1;
            int longest = 0;
            int number = 0; // вариант 1 70/100
                            //int numberPos = 0; // вариант 2 80/100

            for (int index = 0; index < numbers.Length; index++)
            {
                for (int index1 = index + 1; index1 < numbers.Length; index1++)
                {
                    if (numbers[index] == numbers[index1])
                    {
                        //numberPos = index - counter; // вариант 2 80/100
                        counter++;
                    }

                }

                if (counter > longest)
                {
                    longest = counter;
                    number = numbers[index]; // вариант 1 - 70/100 
                }

                counter = 0;

            }

            //Console.WriteLine(longest);
            //Console.WriteLine(numberPos);

            Console.WriteLine("{0}", number); // вариант 1 - 70/100
          //Console.WriteLine("{0}", numbers[numberPos]); // вариант 2 - 80/100
        }
    }
}
