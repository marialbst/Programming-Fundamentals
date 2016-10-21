using System;

namespace _09.MelrahShake
{
    class Program
    {
        string text = Console.ReadLine();
        string pattern = Console.ReadLine();
	
        while (true)
        {
		int firstIndex = text.IndexOf(pattern, StringComparison.Ordinal);
        	int lastIndex = text.LastIndexOf(pattern, StringComparison.Ordinal);
		if (firstIndex >= 0 && lastIndex > firstIndex + pattern.Length-1 && lastIndex > 0)
            	{
			text = text.Remove(lastIndex, pattern.Length );
			text = text.Remove(firstIndex, pattern.Length);
			Console.WriteLine("Shaked it.");
		}
		else 
		{
			Console.WriteLine("No shake.");
			break;
		}

		pattern = pattern.Remove(pattern.Length / 2, 1);
				
		if(pattern.Length == 0)
		{
			Console.WriteLine("No shake.");
			break;
		}
		else
		{
			firstIndex = text.IndexOf(pattern, StringComparison.Ordinal);
			lastIndex = text.LastIndexOf(pattern, StringComparison.Ordinal);
		}
	}
	Console.WriteLine(text);
}

