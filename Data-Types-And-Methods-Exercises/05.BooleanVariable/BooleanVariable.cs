using System;

namespace BooleanVariable
{
    class BooleanVariable
    {
        public static void Main()
        {
            bool varToCheck = Convert.ToBoolean(Console.ReadLine());

            if (varToCheck)
            {
                Console.WriteLine("Yes");

            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
