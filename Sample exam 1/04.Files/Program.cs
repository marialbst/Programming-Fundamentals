using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.Files
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, long>> files = new Dictionary<string, Dictionary<string, long>>();
            for (int i = 0; i < n; i++)
            {
                string filePath = Console.ReadLine();
                string pattern = @"\b(.*?)(?:(\\.*)*\\)(.*);([\d]+\b)";
                //string pattern = @"\b(.*?)(?:(\\.*)*\\[\d\s\.]*)(.*);([\d]+\b)"; - not include space and numbers before filename

                MatchCollection matches = Regex.Matches(filePath, pattern);

                foreach (Match match in matches)
                {
                    string rootDir = match.Groups[1].ToString();
                    string fileName = match.Groups[3].ToString();
                    long fileSize = long.Parse(match.Groups[4].ToString());

                    if (!files.ContainsKey(rootDir))
                    {
                        files.Add(rootDir, new Dictionary<string, long>());
                    }

                    if (!files[rootDir].ContainsKey(fileName))
                    {
                        files[rootDir].Add(fileName, 0);
                    }

                    files[rootDir][fileName] = fileSize;
                }
            }

            string[] query = Console.ReadLine().Split(' ');
            bool isThereFiles = false;
            if (files.ContainsKey(query[2]))
            {
                foreach (var file in files[query[2]].OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    if (file.Key.Contains($".{query[0]}"))
                    {
                        Console.WriteLine($"{file.Key} - {file.Value} KB");
                        isThereFiles = true;
                    }

                }
            }

            if (!isThereFiles)
            {
                Console.WriteLine("No");
            }
        }
    }
}
