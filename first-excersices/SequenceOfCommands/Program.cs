using System;
using System.Linq;

public class SequenceOfCommands_broken
{
    private const char ArgumentsDelimiter = ' ';

    public static void Main()
    {
        int sizeOfArray = int.Parse(Console.ReadLine());

        long[] array = Console.ReadLine()
            .Split(ArgumentsDelimiter)
            .Select(long.Parse)
            .ToArray();

        string command = Console.ReadLine();

        while (!command.Equals("stop"))
        {
            string line = command.Trim();
            int[] args = new int[2];
            string[] stringParams = line.Split(ArgumentsDelimiter);
            command = stringParams[0];

            if (command.Equals("add") ||
                command.Equals("subtract") ||
                command.Equals("multiply"))
            {
                args[0] = int.Parse(stringParams[1]);
                args[1] = int.Parse(stringParams[2]);
                PerformAction(array, command, args);
            }
            else
            {
                PerformAction(array, command, args);
            }
            PrintArray(array);
            Console.WriteLine();

            command = Console.ReadLine();
        }
    }

    static void PerformAction(long[] array, string action, int[] args)
    {
        int pos = args[0];
        int value = args[1];


        switch (action)
        {
            case "multiply":
                array[pos - 1] *= value;
                break;
            case "add":
                array[pos - 1] += value;
                break;
            case "subtract":
                array[pos - 1] -= value;
                break;
            case "lshift":
                ArrayShiftLeft(array);
                break;
            case "rshift":
                ArrayShiftRight(array);
                break;
        }
    }

    private static void ArrayShiftRight(long[] array)
    {
        long indexLast = array[array.Length - 1];

        for (int i = array.Length - 1; i >= 1; i--)
        {
            array[i] = array[i - 1];

        }

        array[0] = indexLast;
    }

    private static void ArrayShiftLeft(long[] array)
    {
        long indexFirst = array[0];

        for (int i = 0; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];
        }
        array[array.Length - 1] = indexFirst;


    }

    private static void PrintArray(long[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}