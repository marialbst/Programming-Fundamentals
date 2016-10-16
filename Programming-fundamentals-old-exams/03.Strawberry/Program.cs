using System;

namespace _03.Strawberry
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int outerDash = 0;
            int innerDash = n;

            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine("{0}\\{1}|{1}/{0}", new String('-', outerDash), new String('-', innerDash));
                outerDash += 2;
                innerDash -= 2;
            }

            outerDash = n;
            int dots = 1;

            for (int i = 0; i < n/2 + 1; i++)
            {
                Console.WriteLine("{0}#{1}#{0}", new String('-', outerDash), new String('.', dots));
                outerDash -= 2;
                dots += 4;
            }

            outerDash = 0;
            dots = 2*n + 1;

            for (int i = 0; i < n+1; i++)
            {
                Console.WriteLine("{0}#{1}#{0}", new String('-', outerDash), new String('.', dots));
                outerDash++;
                dots -= 2;
            }
        }
    }
}
