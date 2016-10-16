using System;
using System.Linq;

namespace _04.ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] array = Console.ReadLine().Split().Select(long.Parse).ToArray();

            string command = Console.ReadLine();

            while (!command.Equals("end"))
            {
                string[] actions = command.Split(' ');

                string action = actions[0];

                if (action == "swap")
                {
                    array = Swap(array, actions);
                }
                else if (action== "multiply")
                {
                    array = Multiply(array, actions);
                }
                else if (action == "decrease")
                {
                    array = Decrease(array);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", array));
        }

        private static long[] Decrease(long[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i]--;
            }
            return array;
        }

        private static long[] Multiply(long[] array, string[] actions)
        {
            int index1 = int.Parse(actions[1]);
            int index2 = int.Parse(actions[2]);

            array[index1] *= array[index2];
            return array;
        }

        private static long[] Swap(long[] array, string[] actions)
        {
            int index1 = int.Parse(actions[1]);
            int index2 = int.Parse(actions[2]);

            long temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;

            return array;
        }
    }
}
