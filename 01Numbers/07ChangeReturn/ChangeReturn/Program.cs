using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Uses greedy approach to calculate the return change from the given value.
 */

namespace ChangeReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money = -1; // Dummy value to make compiler happy.
            int numberOfThatCoin;
            string suffix;
            LinkedList<Tuple<string, decimal>> coins = new LinkedList<Tuple<string, decimal>>();

            if (args.Length == 0)
            {
                Console.WriteLine("Incorrect Number of arguments. Give precisely 1");
                Environment.Exit(1);
            }
            try
            {
                money = Convert.ToDecimal(args[0]);
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Given argument must be convertable to a decimal.");
                Environment.Exit(1);
            }

            money = decimal.Round(money, 2, MidpointRounding.AwayFromZero);
            coins = createCoinList();
            foreach (Tuple<string, decimal> coin in coins) {
                numberOfThatCoin = (int) (money / coin.Item2);
                money -= numberOfThatCoin * coin.Item2;
                suffix = "";
                if (numberOfThatCoin != 1)
                {
                    suffix = "s";
                }
                Console.WriteLine("You get {0} {1}.", numberOfThatCoin, coin.Item1 + suffix);

            }
        }

        static LinkedList<Tuple<string, decimal>> createCoinList()
        {
            LinkedList<Tuple<string, decimal>> coins = new LinkedList<Tuple<string, decimal>>();
            coins.AddLast(new Tuple<string, decimal>("quater", 0.25M));
            coins.AddLast(new Tuple<string, decimal>("dime", 0.10M));
            coins.AddLast(new Tuple<string, decimal>("nickels", 0.05M));
            coins.AddLast(new Tuple<string, decimal>("pennies", 0.01M));
            return coins;
        }
    }
}