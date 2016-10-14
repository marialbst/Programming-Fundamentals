using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.RectanglePosition
{
    public class Program
    {
        public static void Main()
        {
            Rectangle rect1 = ReadRectangle();
            Rectangle rect2 = ReadRectangle();

            bool answer = IsFirstInsideSecond(rect1, rect2);

            PrintResult(answer);
        }

        static void PrintResult(bool val)
        {
            if (val)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }

        }

        static bool IsFirstInsideSecond(Rectangle r1, Rectangle r2)
        {
           
            if (r1.Top <= r2.Top && r1.Bottom <= r2.Bottom && r1.Left >= r2.Left && r1.Right <= r2.Right)
            {
                return true;
            }

            return false;
        }

        static Rectangle ReadRectangle()
        {
            Rectangle rect = new Rectangle();
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            rect.Left = input[0];
            rect.Top = input[1];
            rect.Width = input[2];
            rect.Height = input[3];

            return rect;
        }
    }

    /*class Rectangle
    {
        public int Top { get; set; }
        public int Left { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Right
        {
            get
            {
                return Left + Width;
            }

        }

        public int Bottom
        {
            get
            {
                return Top + Height;
            }
        }


    }*/
}
