using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int upto = 11;
            LinkedList<int> res = Sieve(upto);

            Console.WriteLine("The primes lower or equal to {0} are:", upto);
            foreach (int i in res)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("");
        }

        static LinkedList<int> Sieve(int upto)
        {
            LinkedList<int> result = new LinkedList<int>();
            bool[] numberIsPrime = new bool[upto + 1];

            /*
             * For code clarity numberIsPrime is number x will be 
             * accessed by numberIsPrime[x]. This mean the first two
             * cells in the aray will not be used.
             */
            for (int i = 2; i <= upto; i++)
            {
                numberIsPrime[i] = true;
            }

            for (int i = 2; i <= upto; i++)
            {
                if (!numberIsPrime[i])
                {
                    continue;
                }
                markMultiplesAsNonPrimes(numberIsPrime, i, upto);
                result.AddLast(i);
            }
            return result;
        }

        static void markMultiplesAsNonPrimes(bool[] numberIsPrime, int number, int maximum)
        {
            for (int i = 2; i * number <= maximum; i++)
            {
                numberIsPrime[i * number] = false;
            }
        }
    }
}
