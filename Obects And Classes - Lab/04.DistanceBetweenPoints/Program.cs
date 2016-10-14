using System;
using System.Linq;

namespace _04.DistanceBetweenPoints
{
    public class Program
    {
        public static void Main()
        {

            Point p1 = ReadPoints();
            Point p2 = ReadPoints();

            double distance = CalcDistance(p1, p2);

            Console.WriteLine("{0:f3}", distance);
        }

        static Point ReadPoints()
        {
            int[] point = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Point p = new Point() {X = point[0], Y = point[1]};
            return p;

        }

        static double CalcDistance(Point p1, Point p2)
        {
            int sideA = p1.X - p2.X;
            int sideB = p1.Y - p2.Y;
            double distance = Math.Sqrt(sideA*sideA + sideB*sideB);
            return distance;
        }
    }

    /*class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }*/
}