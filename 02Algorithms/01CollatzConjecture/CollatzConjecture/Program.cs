using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollatzConjecture
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0; // Assignment to make compiler happy

            if (args.Length != 1)
            {
                Console.WriteLine("Incorrect Number of arguments. Give precisely 1");
                Environment.Exit(1);
            }
            try
            {
                n = Convert.ToInt32(args[0]);
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Given argument must be convertable to a 32bit integer.");
                Environment.Exit(1);
            }

            Console.WriteLine(Conjecture_helper(n, 0));
        }

        static int Conjecture_helper(int n, int steps)
        {
            if (n > 1)
            {
                if (n % 2 == 0) // Even
                {
                    return Conjecture_helper(n / 2, steps + 1);
                }
                else
                {
                    return Conjecture_helper(n * 3 + 1, steps + 1);
                }
            }
            else
            {
                return steps;
            }
        }
    }
}
