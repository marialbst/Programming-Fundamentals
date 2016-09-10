using System;

namespace CenturiesToNanoseconds
{
    class CenturiesToNanoseconds
    {
        public static void Main()
        {
            sbyte centuries = sbyte.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            long minutes = hours * 60L;
            ulong seconds = (ulong)minutes * 60U;
            ulong miliseconds = seconds * 1000U;
            decimal microseconds = (ulong)miliseconds * 1000M;
            decimal nanoseconds = microseconds * 1000M;

            Console.Write("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = ", centuries, years, days, hours, minutes);
            Console.WriteLine("{0} seconds = {1} milliseconds = {2} microseconds = {3} nanoseconds", seconds, miliseconds, microseconds, nanoseconds);
        }
    }
}
