using System;

namespace CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            char[] charArr1 = Array.ConvertAll(Console.ReadLine().Split(' '), char.Parse);
            char[] charArr2 = Array.ConvertAll(Console.ReadLine().Split(' '), char.Parse);

            int length = Math.Min(charArr1.Length, charArr2.Length);

            for (int i = 0; i < length; i++)
            {

                if (charArr1[i] > charArr2[i] || (charArr1[i] == charArr2[i] && length == charArr2.Length))
                {
                    Console.WriteLine(string.Join("", charArr2));
                    Console.WriteLine(string.Join("", charArr1));
                    break;
                }
                else if (charArr1[i] < charArr2[i] || (charArr1[i] == charArr2[i] && length == charArr1.Length))
                {
                    Console.WriteLine(string.Join("", charArr1));
                    Console.WriteLine(string.Join("", charArr2));
                    break;
                }

            }
        }
    }
}
