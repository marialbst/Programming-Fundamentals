using System;

namespace _06.StringsAndObjects
{
    class StringAndObjects
    {
        public static void Main()
        {
            string word1 = "Hello";
            string word2 = "World";
            object concatTwoWords = word1 + " " + word2;
            string objToString = Convert.ToString(concatTwoWords);

            Console.WriteLine(objToString);
        }
    }
}
