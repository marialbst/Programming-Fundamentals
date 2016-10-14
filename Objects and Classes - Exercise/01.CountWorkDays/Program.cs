using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountWorkDays
{
    class Program
    {
        public static void Main()
        {
            DateTime startDate = ReadDate();
            DateTime endDate = ReadDate();

            int counter = 0;

            List<DateTime> daysOff = new List<DateTime>()
        {
            new DateTime(4, 01, 01),
            new DateTime(4, 03, 03),
            new DateTime(4, 05, 01),
            new DateTime(4, 05, 06),
            new DateTime(4, 05, 24),
            new DateTime(4, 09, 06),
            new DateTime(4, 09, 22),
            new DateTime(4, 11, 01),
            new DateTime(4, 12, 24),
            new DateTime(4, 12, 25),
            new DateTime(4, 12, 26),

        };

            for (var date = startDate; date <= endDate; date = date.AddDays(1))
            {
                var currDate = new DateTime(4, date.Month, date.Day);

                if (date.DayOfWeek != DayOfWeek.Sunday && !date.DayOfWeek.Equals(DayOfWeek.Saturday)
                    && !daysOff.Contains(currDate))
                {
                    counter++;

                }
            }
            Console.WriteLine(counter);
        }

        static DateTime ReadDate()
        {
            string input = Console.ReadLine();
            int[] inputToArray = input.Split('-').Select(int.Parse).ToArray();
            DateTime inputToDate = new DateTime(inputToArray[2], inputToArray[1], inputToArray[0]);
            return inputToDate;
        }
    }
}
