using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input_string = "Hello WorldazAZ";
            Code code = new Code(1);

            Console.WriteLine("Input String: " + input_string);

            input_string = input_string.ToUpper();

            Console.WriteLine("Encoded: " + code.encode(input_string));
            Console.WriteLine("Decoded again: " + code.decode(code.encode(input_string)));
        }
    }
}
