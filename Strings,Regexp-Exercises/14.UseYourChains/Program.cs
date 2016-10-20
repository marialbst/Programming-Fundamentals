using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _14.UseYourChains
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            //string text = @"<html><head><title></title></head><body><h1>Intro</h1><ul><li>Item01</li><li>Item02</li><li>Item03</li></ul><p>jura qevivat va jrg fyvccrel fabjl</p><div><button>Click me, baby!</button></div><p> pbaqvgvbaf fabj  qpunvaf ner nofbyhgryl rffragvny sbe fnsr unaqyvat nygubhtu fabj punvaf znl ybbx </p><span>This manual is false, do not trust it! The illuminati wrote it down to trick you!</span><p>vagvzvqngvat gur onfvp vqrn vf ernyyl fvzcyr svg gurz bire lbhe gverf qevir sbejneq fybjyl naq gvtugra gurz hc va pbyq jrg</p><p> pbaqvgvbaf guvf vf rnfvre fnvq guna qbar ohg vs lbh chg ba lbhe gverf</p></body>";

            //extracting text between <p> - tag
            //string pattern = @"(<\s*p.*?>(.*?)<\s*\/\s*p\s*>)";//88/100
            string pattern = @"(<p>(.*?)<\/p>)"; //100/100
            Regex regexp = new Regex(pattern);
            MatchCollection matches = regexp.Matches(text);

            string extract = "";

            foreach (Match match in matches)
            {
                extract += match.Groups[2].ToString();

            }

            //replace symbols with space
            string replPattern = @"([^a-z0-9])";

            Regex regex = new Regex(replPattern);
            extract = Regex.Replace(extract, replPattern, " ");

            //replace multiply spaces with single
            extract = Regex.Replace(extract, @"\s+|\n+", " ");


            //convert letters
            StringBuilder sb = new StringBuilder(extract.Length);

            foreach (char ch in extract)
            {

                if (ch >= 'a' && ch <= 'm')
                {
                    sb.Append((char)(ch + 13));
                }
                else if (ch >= 'n' && ch <= 'z')
                {
                    sb.Append((char)(ch - 13));
                }
                else
                {
                    sb.Append(ch);
                }

            }

            //print result
            string result = sb.ToString();
            Console.WriteLine(result);
        }
    }
}
