using System;

namespace _09.MelrahShake
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = Console.ReadLine();

            while (pattern.Length > 0)
            {
                int firstIndex = text.IndexOf(pattern, StringComparison.Ordinal);
                int lastIndex = text.LastIndexOf(pattern, StringComparison.Ordinal);

                if (firstIndex >= 0 && lastIndex > firstIndex + pattern.Length)
                {
                    text = text.Remove(lastIndex, pattern.Length );
                    text = text.Remove(firstIndex, pattern.Length);
                    Console.WriteLine("Shaked it.");
                    //Console.WriteLine(text);
                    //Console.WriteLine(pattern);
                }
                else
                {
                    Console.WriteLine("No shake.");
                    break;
                }

                pattern = pattern.Remove(pattern.Length / 2, 1);
            }
            Console.WriteLine(text);
        }
    }
}
