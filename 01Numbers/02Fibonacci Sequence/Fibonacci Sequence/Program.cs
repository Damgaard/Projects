using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Uses Memoization to ensure that each number is only calculated once.
 * This greatly speeds up the execution of the application. 
 */
namespace Fibonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Incorrect number of arguments. Give precisely 1.");
                Environment.Exit(1);
            }

            Console.WriteLine("Fibonacci of {0} is {1}", args[0], Fibonacci(int.Parse(args[0])));
        }

        static int Fibonacci(int x)
        {
            int[] alreadyComputed = new int[x + 1];
            alreadyComputed[0] = 0;
            alreadyComputed[1] = 1;
            alreadyComputed[2] = 1;
            for (int i = 3; i <= x; i++)
            {
                alreadyComputed[i] = -1;
            }
            return Fibonacci_helper(ref alreadyComputed, x);
        }

        static int Fibonacci_helper(ref int[] alreadyComputed, int x)
        {
            if (alreadyComputed[x] != -1)
            {
                return alreadyComputed[x];
            }
            return Fibonacci_helper(ref alreadyComputed, x - 1) + Fibonacci_helper(ref alreadyComputed, x - 2);
        }
    }
}
