using System;
using System.Linq;

namespace _02.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            long[] field = new long[size];
            long[] bugsPos = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            //fill field with bugs
            for (long i = 0; i < bugsPos.Length; i++)
            {
                if (bugsPos[i] < field.Length && bugsPos[i] >= 0)
                {
                    field[bugsPos[i]] = 1;
                }
            }

            string command = Console.ReadLine();

            while (!command.Equals("end"))
            {
                string[] instructions = command.Split(' ');

                long ladybugIndex = long.Parse(instructions[0]);
                string direction = instructions[1];
                long flightLength = long.Parse(instructions[2]);
                //Console.WriteLine(string.Join(" ", field));
                if (ladybugIndex < field.Length && ladybugIndex >= 0)
                {
                    if (field[ladybugIndex] != 0)
                    {
                        if (direction == "right" && flightLength > 0 || direction == "left" && flightLength < 0)
                        {
                            flightLength = Math.Abs(flightLength);
                            field[ladybugIndex] = 0;

                            while (true)
                            {
                                if (ladybugIndex + flightLength < field.Length)
                                {
                                    if (field[ladybugIndex + flightLength] != 0)
                                    {
                                        flightLength *= 2;
                                    }
                                    else
                                    {
                                        field[ladybugIndex + flightLength] = 1;
                                        break;
                                    }
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        else if (direction == "right" && flightLength < 0 || direction == "left" && flightLength > 0)
                        {
                            flightLength = Math.Abs(flightLength);

                            field[ladybugIndex] = 0;
                            while (true)
                            {
                                if (ladybugIndex - flightLength >= 0)
                                {
                                    if (field[ladybugIndex - flightLength] != 0)
                                    {
                                        flightLength *= 2;
                                    }
                                    else
                                    {
                                        field[ladybugIndex - flightLength] = 1;
                                        break;
                                    }
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
