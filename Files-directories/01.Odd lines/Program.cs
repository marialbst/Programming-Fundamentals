using System.IO;
using System.Linq;

namespace _01.Odd_lines
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = File.ReadAllLines("Input.txt");

            File.WriteAllLines("Otput.txt", text.Where((line, index) => index % 2 == 1));
        }
    }
}
