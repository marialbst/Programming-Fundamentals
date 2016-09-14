using System;

namespace TheaThePhotographer
{
    class TheaThePhotographer
    {
        static void Main(string[] args)
        {
            ulong totalPictures = ulong.Parse(Console.ReadLine()); 
            ulong filterTimeSec = ulong.Parse(Console.ReadLine()); //100000
            byte percentUploads = byte.Parse(Console.ReadLine());//100
            ulong uploadTimeSec = ulong.Parse(Console.ReadLine());//100000

            ulong uploadPictures = (ulong)Math.Ceiling((decimal)(totalPictures * percentUploads) / 100);//1000000
            ulong totalFilterTime = totalPictures * filterTimeSec; // /100000000000
            ulong totalUploadTime = (ulong)(uploadPictures * uploadTimeSec);//100000000000
            ulong totalTimeSec = totalFilterTime + totalUploadTime;//200000000000
           /* ulong days = totalTimeSec / 86400;
            totalTimeSec %= 86400;
            TimeSpan totalTime = new TimeSpan((long)totalTimeSec);
            string str = totalTime.ToString(@"d\:hh\:mm\:ss");
            Console.WriteLine($"{days}:{str}");*/

            ulong days = totalTimeSec / 86400;
            totalTimeSec %= 86400;
            ulong hours = totalTimeSec / 3600;
            totalTimeSec %= 3600;
            ulong minutes = totalTimeSec / 60;
            ulong seconds = totalTimeSec % 60;
            //Console.WriteLine(uploadPictures);
            Console.WriteLine("{0}:{1:00}:{2:00}:{3:00}", days, hours, minutes, seconds);
        }
    }
}
