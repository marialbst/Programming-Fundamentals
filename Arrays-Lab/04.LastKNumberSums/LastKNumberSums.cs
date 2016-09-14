using System;

namespace LastKNumberSums
{
    class LastKNumberSums
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] values = new long[n];
            values[0] = 1;

            for(int index = 1; index < n; index++)
            {
                int start = Math.Max(0, index - k);
                int end = index - 1;
                long sum = 0;

                for(int i = start; i < end; i++)
                {
                    sum += values[i];
                }

                values[index] = sum;

            }

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("{0} ", values[i]);
            }
        }
    }
}
