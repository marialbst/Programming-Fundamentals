using System;

namespace ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        public static void Main()
        {
            int a = 5;
            int b = 10;
            int buffer;

            Console.WriteLine("Before:\na = {0}\nb = {1}", a, b);

            buffer = a;
            a = b;
            b = buffer;

            Console.WriteLine("After:\na = {0}\nb = {1}", a, b);
        }
    }
}
