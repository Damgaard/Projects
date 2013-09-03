using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CountWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(countWords("Hello World"));
        }

        static int countWords(string input_string)
        {
            string pattern = @"\b\w+\b";
            Regex rgx = new Regex(pattern);
            return rgx.Matches(input_string).Count;
        }
    }
}
