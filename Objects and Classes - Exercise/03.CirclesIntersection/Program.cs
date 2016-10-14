using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CirclesIntersection
{
    public class Program
    {
        public static void Main()
        {
            Circle firstCircle = ReadCircle();
            Circle secondCircle = ReadCircle();

            bool doesIntersect = DoesIntersect(firstCircle, secondCircle);

            PrintResult(doesIntersect);
        }

        static void PrintResult(bool doesIntersect)
        {
            if (doesIntersect)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        static bool DoesIntersect(Circle first, Circle second)
        {
            double distance = CalcDistance(first.Center, second.Center);

            if (distance <= first.Radius + second.Radius)
            {
                return true;
            }

            return false;
        }

        static Circle ReadCircle()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Circle circ = new Circle();
            circ.Center = new Point();
            circ.Center.X = input[0];
            circ.Center.Y = input[1];
            circ.Radius = input[2];

            return circ;
        }

        static double CalcDistance(Point p1, Point p2)
        {
            int sideA = p1.X - p2.X;
            int sideB = p1.Y - p2.Y;
            double distance = Math.Sqrt(sideA * sideA + sideB * sideB);
            return distance;
        }
    }

    /*public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }*/

    /*public class Circle
    {
        public Point Center { get; set; }
        public int Radius { get; set; }

        public double Area
        {
            get
            {
                return Math.PI * Radius * Radius;
            }
        }
    }*/
}
