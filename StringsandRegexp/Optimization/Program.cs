using System;
using System.Diagnostics;
using System.Text;

public class Program
{
    public static void Main()
    {
        StringBuilder result = new StringBuilder();
        Stopwatch st = new Stopwatch();
        st.Start();


        for (int i = 0; i < 50000; i++)
        {
            result.Append(Convert.ToString(i, 2) + "\n");
        }

        st.Stop();
        Console.WriteLine(st.Elapsed);

    }
}