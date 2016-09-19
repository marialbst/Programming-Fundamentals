using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendLists
{
    class AppendLists
    {
        static void Main(string[] args)
        {
            string[] sequence = Console.ReadLine().Split('|');
            List<string> appendedList = new List<string>();

            for(int seq = sequence.Length - 1; seq >= 0; seq--)
            {
                List<string> listToAppend = sequence[seq].Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                foreach(string item in listToAppend)
                {
                    appendedList.Add(item);
                }
            }

            Console.WriteLine(string.Join(" ", appendedList));
        }
    }
}
