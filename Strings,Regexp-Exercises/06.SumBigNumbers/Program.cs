using System;
using System.Text;

namespace _06.SumBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string bigNum1 = Console.ReadLine().TrimStart(new Char[] { '0' });
            string bigNum2 = Console.ReadLine().TrimStart(new Char[] { '0' });

            //Console.WriteLine(bigNum1);
            //Console.WriteLine(bigNum2);

            int length = Math.Max(bigNum1.Length, bigNum2.Length);

            if (bigNum1.Length > bigNum2.Length)
            {
                bigNum2 = bigNum2.PadLeft(bigNum1.Length, '0');
                //Console.WriteLine(bigNum2);
            }
            else
            {
                bigNum1 = bigNum1.PadLeft(bigNum2.Length, '0');
                //Console.WriteLine(bigNum1);
            }

            StringBuilder result = new StringBuilder(length + 1);
            int reminder = 0;
            int toRemind = 0;
            for (int i = length - 1; i >= 0; i--)
            {
                byte num1 = byte.Parse(bigNum1[i].ToString());
                byte num2 = byte.Parse(bigNum2[i].ToString());

                int sum = toRemind + num1 + num2;

                reminder = sum % 10;
                toRemind = sum / 10;

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
