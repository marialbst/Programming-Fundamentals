using System;
					
public class Program
{
	
	public static void Main()
	{
		int numbers = int.Parse(Console.ReadLine());
        int sequence = int.Parse(Console.ReadLine());
		long[] values = new long[numbers];
		
		values[0] = 1;
		
        for(int index = 1; index < numbers; index++)
        {
			int start = Math.Max(0, index - sequence);
			long sumElements = 0;
			
			for(int count = start; count < numbers; count++)
			{
				sumElements += values[count];
			}
			
			values[index] = sumElements;
			
			
		}

		Console.WriteLine(string.Join(" ", values));
		
		/*for(int i = 0; i < numbers; i++)
		{
			Console.Write("{0} ", values[i]);
		}*/
		
	}
}
