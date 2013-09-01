using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] test_strings = {"palindrome", "racecar", "", "helloolleh"};
            string result;  // TODO: Better name

            foreach (string test_string in test_strings)
            {
                result = IsPalindrome(test_string) ? "" : "not ";
                Console.WriteLine("The string '{0}' is {1}a palindrome.", test_string, result);
            }
        }

        static bool IsPalindrome(string palindrome_string)
        {
            char[] input_word = palindrome_string.ToCharArray();

            if (input_word.Length == 0)
            {
                return true;
            }

            for (int i = 0; i <= input_word.Length / 2; i++)
            {
                if (input_word[i] != input_word[input_word.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
