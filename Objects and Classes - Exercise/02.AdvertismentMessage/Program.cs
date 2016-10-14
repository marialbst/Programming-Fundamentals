using System;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string[] phrases = new string[]
        {
            "Excellent product.",
            "Such a great product.",
            "I always use that product.",
            "Best product of its category.",
            "Exceptional product.",
            "I can’t live without this product."
        };

        string[] events = new string[]
        {
            "Now I feel good.",
            "I have succeeded with this product.",
            "Makes miracles. I am happy of the results!",
            "I cannot believe but now I feel awesome.",
            "Try it yourself, I am very satisfied.",
            "I feel great!"
        };

        string[] autors = new string[]
        {
            "Diana",
            "Petya",
            "Stella",
            "Elena",
            "Katya",
            "Iva",
            "Annie",
            "Eva"
        };

        string[] cities = new string[]
        {
            "Burgas",
            "Sofia",
            "Plovdiv",
            "Varna",
            "Ruse"
        };

        Random rd = new Random();

        for (int i = 0; i < n; i++)
        {
            int phraseIndex = rd.Next(phrases.Length);
            int eventIndex = rd.Next(events.Length);
            int autorIndex = rd.Next(autors.Length);
            int cityIndex = rd.Next(cities.Length);

            Console.WriteLine("{0} {1} {2} - {3}", phrases[phraseIndex], events[eventIndex], autors[autorIndex], cities[cityIndex]);
        }
    }
}
