using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.CubicMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            Dictionary<string, string> messages = new Dictionary<string, string>();
            while (!message.Equals("Over!"))
            {
                int sequence = int.Parse(Console.ReadLine());
                string pattern = @"^([\d]+)([a-zA-Z]{"+sequence+@"})([^a-zA-Z]*\d*)$";
                
                MatchCollection matches = Regex.Matches(message, pattern);

                foreach (Match match in matches)
                {
                    string key = match.Groups[2].ToString();
                    string value1 = match.Groups[1].ToString();
                    string value2 = match.Groups[3].ToString();

                    messages.Add(key, "");
                    messages[key]+=(value1);
                    messages[key]+=(value2);
                }

                message = Console.ReadLine();
            }

            foreach (var msg in messages)
            {
                StringBuilder result = new StringBuilder();
                List<int> pos = new List<int>();
                string encryptedMessage = msg.Key;
                string positions = msg.Value;
                for(int i=0; i< positions.Length; i++)
                {
                    
                    int posToInt = 0;

                    if(int.TryParse(positions[i].ToString(), out posToInt))
                    {
                        pos.Add(posToInt);
                    }
                }

                for (int i = 0; i < pos.Count; i++)
                {
                    //Console.WriteLine(result);
                    if (pos[i] > encryptedMessage.Length - 1)
                    {
                        result.Append(" ");
                    }
                    else
                    {
                        result.Append(encryptedMessage[pos[i]]);
                    }
                }

                Console.WriteLine($"{encryptedMessage} == {result}");
            }
        }
    }
}
