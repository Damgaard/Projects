using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Pig Latin is a language game where words in English are altered according to a simple set of rules.
 * http://en.wikipedia.org/wiki/Pig_latin
 * 
 * This program translate an english word to pig lating. During this translation the word will become lowercase.
 * 
 * RULES:
 * For words that begin with consonant sounds, the initial consonant or consonant cluster is moved to the end of the word, and "ay" is added, 
 * as in the following examples:
 *
 * "happy" → "appyhay"
 * "duck" → "uckday"
 * "glove" → "oveglay"
 * 
 * For words that begin with vowel sounds or silent letter, "way" is added at the end of the word. In this implementation
 * this rules has been simplified, so it is only for vowels. Consonent sounding as vowels or silent letters are ignore. Examples are
 *
 * "egg" → "eggway"
 * "inbox" → "inboxway"
 * "eight" → "eightway"
 * 
 * The letter 'y' can play the role of either consonant or vowel, depending on its location
 * 
 * "yellow" → "ellowyay"
 * "rhythm" → "ythmrhay"
 * 
 * In some variants, though, just add an "ay" at the end. These varients are ignored in this implementation. But examples are
 *
 * "egg" → "eggay"
 * 
 * Yet another acceptable variant is to add the ending "yay" to words that begin with a vowel sound. Also ignored.
 * 
 * "egg" → "eggyay"
 * 
 */

namespace PigLating
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = new string[] { "happy", "eight", "yellow", "rhythm" };

            foreach (string word in words)
            {
                Console.WriteLine("{0} -> {1}", word, englishWordToPigLation(word));
            }
        }

        static string englishWordToPigLation(string word)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'u', 'o', 'y'};
            word = word.ToLower();
            int firstNonVowel;

            if (vowels.Contains(word[0]) && word[0] != 'Y')
            {
                return word + "way";
            }

            for (firstNonVowel = 1; firstNonVowel < word.Length; firstNonVowel++)
            {
                if (vowels.Contains(word[firstNonVowel]))
                {
                    break;
                }
            }

            return word.Substring(firstNonVowel, word.Length - firstNonVowel) + word.Substring(0, firstNonVowel) + "ay";
        }
    }
}
