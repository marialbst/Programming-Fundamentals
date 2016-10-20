using System;
using System.Text;

namespace _07.MultiplyBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string bigNum1 = Console.ReadLine().TrimStart(new Char[] { '0' });
            int multiplicator = int.Parse(Console.ReadLine());

            if (bigNum1 == "0" || multiplicator == 0 || bigNum1 == "")
            {
                Console.WriteLine(0);
                return;
            }

            int length = bigNum1.Length;

            StringBuilder result = new StringBuilder(length + 1);
            int reminder = 0;
            int toRemind = 0;
            for (int i = length - 1; i >= 0; i--)
            {
                byte num1 = byte.Parse(bigNum1[i].ToString());


                int product = toRemind + num1 * multiplicator;

                reminder = product % 10;
                toRemind = product / 10;

                result.Insert(0, reminder);

                if (i == 0 && toRemind > 0)
                {
                    result.Insert(0, toRemind);
                }

            }

            Console.WriteLine(result);
        }
    }
}
