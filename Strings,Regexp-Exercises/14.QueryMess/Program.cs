using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _14.QueryMess
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            //string partPattern = @"(\b[a-z]*)=(?:\s*|[\W]*)(\b([\w]*([:\/\w\. ])*)\b)";	
            string partPattern = @"([^&=?]*)=\s*([^&=]*)";

            //login=student&password=student
            //field=value1&field=value2&field=value3
            //http://example.com/over/there?name=ferret
            //foo= foo&value=val&foo=5 203
            //foo=poo &value=valley&dog=wow
            //url=https://softuni.bg/trainings/coursesinstances/details/1070
            //https://softuni.bg/trainings.asp?trainer=nakov&course=oop&course=php		


            while (!text.Equals("END"))
            {
                string replacement = @"(%20|\+)+";


                text = Regex.Replace(text, replacement, " ");

                //Console.WriteLine(text);

                Regex regex = new Regex(partPattern);
                MatchCollection matches = regex.Matches(text);

                Dictionary<string, List<string>> values = new Dictionary<string, List<string>>();

                foreach (Match match in matches)
                {
                    string valuesKey = match.Groups[1].ToString().Trim();
                    string valuesValue = match.Groups[2].ToString().Trim();


                    if (!values.ContainsKey(valuesKey))
                    {
                        values.Add(valuesKey, new List<string>());
                    }

                    values[valuesKey].Add(valuesValue);
                }

                foreach (var val in values)
                {
                    Console.Write("{0}=[{1}]", val.Key, string.Join(", ", val.Value));
                }

                Console.WriteLine();
                text = Console.ReadLine();
            }
        }
    }
}
