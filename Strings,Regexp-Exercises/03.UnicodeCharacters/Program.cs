using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string letters = Console.ReadLine();

            string letSeq = GetUnicodeString(letters);

            Console.WriteLine(letSeq);
        }

        static string GetUnicodeString(string s)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in s)
            {
                sb.Append("\\u");
                sb.Append($"{(int) c:x4}");
            }
            return sb.ToString();
        }
    }
}
