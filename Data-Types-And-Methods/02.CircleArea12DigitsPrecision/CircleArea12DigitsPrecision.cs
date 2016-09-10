using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CircleArea12DigitsPrecision
{
    class CircleArea12DigitsPrecision
    {
        public static void Main()
        {
            double radius = double.Parse(Console.ReadLine());
            double area = Math.PI * radius * radius;

            Console.WriteLine("{0:f12}", area);

        }
    }
}
