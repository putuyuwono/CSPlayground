using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPlayground
{
    public class PalindromChecker
    {
        /// <summary>
        /// This method check whether a certain string is a palindrom
        /// Sample input: "rakasakar"
        /// </summary>
        /// <param name="input">input string</param>
        /// <returns>true if palindrom</returns>
        public static bool IsPalindrom(string input) {
            if (string.IsNullOrEmpty(input) || input.Length <= 1) return false;

            int i = 0;
            int j = input.Length - 1;
            while(i < j)
            {
                if (input[i] != input[j]) return false;
                i++;
                j--;
            }

            return true;
        }
    }
}
