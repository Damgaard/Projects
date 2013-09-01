using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaesarCipher
{
    class Code
    {
        private int LOWER_BOUND = (int)'A';
        private int UPPER_BOUND = (int)'Z';
        public int modifier;

        public Code(int modifier)
        {
            this.modifier = modifier;
        }

        public string decode(string unencoded)
        {
            return code_helper(unencoded, modifier);
        }

        public string encode(string unencoded)
        {
            return code_helper(unencoded, -modifier);
        }

        private string code_helper(string unencoded, int modifier)
        {
            int ch_int, new_ch_int, i=0;
            char[] result = new char[unencoded.Length];

            foreach (char ch in unencoded)
            {
                ch_int = (int)ch;
                if (ch_int < LOWER_BOUND || ch_int > UPPER_BOUND)
                {
                    result[i++] = (char)ch_int;
                    continue;
                }
                new_ch_int = ch_int + modifier;
                if (new_ch_int > UPPER_BOUND)
                {
                    new_ch_int = LOWER_BOUND + (new_ch_int - UPPER_BOUND - 1);
                }
                else if (new_ch_int < LOWER_BOUND)
                {
                    new_ch_int = UPPER_BOUND - (LOWER_BOUND - new_ch_int - 1);
                }
                result[i++] = (char)new_ch_int;
            }

            return new string(result);
        }
    }
}
