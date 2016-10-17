using System;

namespace _01.TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long totalShots = long.Parse(Console.ReadLine());
            long secForFilterSingleShot = long.Parse(Console.ReadLine());
            double filterPercent = double.Parse(Console.ReadLine());
            long secForUploadSingleShot = long.Parse(Console.ReadLine());

            long totalFilterTimeSec = totalShots*secForFilterSingleShot; //time in seconds
            //Console.WriteLine(totalFilterTimeSec);
            long filteredShotsLeft = (long) Math.Ceiling(totalShots*filterPercent/100);
            //Console.WriteLine(filteredShotsLeft);
            long totalUploadTimeSec = filteredShotsLeft*secForUploadSingleShot;
            //Console.WriteLine(totalUploadTimeSec);
            long totalTimeSec = totalUploadTimeSec + totalFilterTimeSec;

            long d = totalTimeSec/86400;
            totalTimeSec %= 86400;
            long hh = totalTimeSec / 3600;
            totalTimeSec %= 3600;
            long mm = totalTimeSec / 60;
            totalTimeSec %= 60;
            
            Console.WriteLine($"{d:0}:{hh:00}:{mm:00}:{totalTimeSec:00}");

        }
    }
}
