using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().TrimEnd('.')
                .Split(new char[] {' '}
                    , StringSplitOptions.RemoveEmptyEntries).ToArray();
            string pattern
                =
                @"^([a-zA-Z0-9]+[.]*)([a-zA-Z0-9]*[-]*[a-zA-Z0-9]*)[@][a-zA-Z0-9]+[-]*[a-zA-Z0-9]*[.][a-zA-Z0-9]+([.]*[a-zA-Z0-9])*$";
            Regex regex = new Regex(pattern);
            foreach (var item in text)
            {
                if (regex.IsMatch(item))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
