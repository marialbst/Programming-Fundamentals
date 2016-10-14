using System;
using System.Globalization;

namespace _01_DayOfWeek
{
    public class DayOfWeek
    {
        public static void Main(string[] args)
        {
            string dateAsText = Console.ReadLine();
            DateTime date = DateTime.ParseExact(dateAsText, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(date.DayOfWeek);
        }
    }
}