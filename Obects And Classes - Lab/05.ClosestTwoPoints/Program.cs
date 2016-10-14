using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ClosestTwoPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            Point[] points = AddPoints();
            Point[] closestPoints = FindClosestPoints(points);

            PrintDistance(closestPoints);

            PrintPoint(closestPoints[0]);
            PrintPoint(closestPoints[1]);
        }

        static Point ReadPoint()
        {
            int[] point = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Point p = new Point() { X = point[0], Y = point[1] };
            return p;
        }

        static void PrintPoint(Point p)
        {
            Console.WriteLine("({0}, {1})", p.X, p.Y);
        }

        static Point[] FindClosestPoints(Point[] points)
        {
            double minDistance = double.MaxValue;
            Point[] closestPoints = new Point[2];
            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    double distance = CalcDistance(points[i], points[j]);

                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        closestPoints = new Point[] { points[i], points[j] };
                    }
                }
            }

            return closestPoints;
        }

        static Point[] AddPoints()
        {
            int n = int.Parse(Console.ReadLine());

            Point[] points = new Point[n];

            for (int i = 0; i < n; i++)
            {
                points[i] = ReadPoint();
            }

            return points;
        }

        static void PrintDistance(Point[] points)
        {
            Console.WriteLine("{0:f3}", CalcDistance(points[0], points[1]));
        }

        static double CalcDistance(Point p1, Point p2)
        {
            int sideA = p1.X - p2.X;
            int sideB = p1.Y - p2.Y;
            double distance = Math.Sqrt(sideA * sideA + sideB * sideB);
            return distance;
        }
    }

  /*  class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }*/
}
