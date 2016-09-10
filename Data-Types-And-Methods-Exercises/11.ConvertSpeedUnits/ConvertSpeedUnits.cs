using System;

namespace ConvertSpeedUnits
{
    class ConvertSpeedUnits
    {
        static void Main(string[] args)
        {
            int distanceMeter = int.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine()); //5 20 30 = 5*360 + 20*60 + 30
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());//seconds + 

            float totalTimeInSeconds = hours * 3600 + minutes * 60 + seconds;
            float totalTimeInHours = totalTimeInSeconds / 3600;

            float kmPerHour = (distanceMeter/1000f)/ totalTimeInHours;
            float mPerSecond = (distanceMeter/ totalTimeInSeconds);
            float milesPerHour = (distanceMeter / 1609f)/ totalTimeInHours;

            Console.WriteLine("{0}", mPerSecond);
            Console.WriteLine("{0}", kmPerHour);
            Console.WriteLine("{0}", milesPerHour);
        }
    }
}
