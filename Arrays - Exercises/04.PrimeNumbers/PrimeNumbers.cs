using System;

namespace PrimeNumbers
{
    class PrimeNumbers
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());

            bool[] interval = new bool[end + 1];

            for (int i = 0; i <= end; i++)
            {
                if (i == 0 || i == 1)
                {
                    interval[i] = false;
                }
                else
                {
                    interval[i] = true;
                }
            }

            for (int j = 2; j <= end; j++)
            {
                if (interval[j])
                {
                    Console.Write("{0} ", j);

                    for (int k = 2; k * j <= end; k++)
                    {
                        interval[j * k] = false;
                    }
                }
            }
        }
    }
}
