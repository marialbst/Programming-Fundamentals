﻿using System;

namespace ComparingFloats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            double eps = 0.000001;

            double difference = Math.Abs(number1 - number2);
            bool isEqual = false;

            if (difference < eps)
            {
                isEqual = true;
            }

            Console.WriteLine(isEqual);
        }
    }
}
