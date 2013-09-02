using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountVowels
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> countedVowels;
            int totalVowels;
            string input_string;

            while (true)
            {
                Console.WriteLine("Enter a string and I will tell you how many vowels it contains.");
                input_string = Console.ReadLine();

                if (input_string == "")
                {
                    break;
                }

                countedVowels = countVowels(input_string);
                
                totalVowels = 0;
                foreach (KeyValuePair<int, int> entry in countedVowels)
                {
                    Console.WriteLine("The vowel {0} was present {1} times.", (char)entry.Key, entry.Value);
                    totalVowels += entry.Value;
                }
                Console.WriteLine("There was a total of {0} vowels.", totalVowels);
            }
        }

        static Dictionary<int, int> countVowels(string input_string)
        {
            char[] vowels = { 'A', 'E', 'I', 'O', 'U', 'Y' };
            Dictionary<int, int> countedVowels = new Dictionary<int,int>();
            foreach (char vowel in vowels)
            {
                countedVowels.Add(vowel, 0);
            }
            input_string = input_string.ToUpper();

            foreach (char ch in input_string.ToArray())
            {
                if (countedVowels.ContainsKey(ch))
                {
                    countedVowels[ch] += 1;
                }
            }
            return countedVowels;
        }
    }
}
