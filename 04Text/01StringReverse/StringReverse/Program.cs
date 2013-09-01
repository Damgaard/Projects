using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("StringReverse takes excatly 1 string argument.");
                Environment.Exit(1);
            }
            char[] input_word = args[0].ToCharArray();
            Array.Reverse(input_word);
            Console.WriteLine(new string(input_word));
        }
    }
}
