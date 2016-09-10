using System;

namespace _01.CenturiesToMinutes
{
    class CenturiesToMinutes
    {
        public static void Main()
        {
            sbyte centuries = sbyte.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            long minutes = hours * 60L;

            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes", centuries, years, days, hours, minutes);
        }
    }
}
