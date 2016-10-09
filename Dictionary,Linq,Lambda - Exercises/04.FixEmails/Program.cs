using System;
using System.Collections.Generic;

namespace _04.FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Dictionary<string, string> mails = new Dictionary<string, string>();

            while (command != "stop")
            {
                var name = command;
                var mail = Console.ReadLine();
                
                string domain = mail.Substring(mail.Length - 2, 2);

                if (domain != "us" && domain != "uk")
                {
                    mails[name] = mail;
                }
                
                command = Console.ReadLine();
            }

            foreach (var person in mails)
            {
                Console.WriteLine("{0} -> {1}", person.Key, person.Value);
            }
        }
    }
}
