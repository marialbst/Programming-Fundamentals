using System;

namespace _05.SpecialNumbers
{
    class SpecialNumbers
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int sumDigits;
            bool isSpecial = false;

            for (int i = 1; i <= num; i++)
            {
                sumDigits = SumDigits(i);
                isSpecial = IsSpecialNumber(sumDigits, isSpecial);
                Console.WriteLine("{0} -> {1}", i, isSpecial);
            }
        }

        static int SumDigits(int number)
        {
            int sum = 0;

            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }

            return sum;
        }

        static bool IsSpecialNumber(int sum, bool check)
        {

            if (sum == 5 || sum == 7 || sum == 11)
            {
                check = true;
            }
            else
            {
                check = false;
            }
            return check;
        }
    }
}
