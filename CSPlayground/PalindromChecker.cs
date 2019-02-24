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
            if (string.IsNullOrEmpty(input)) return false;
            for (int i = 0; i < input.Length / 2; i++)
            {
                char a = input[i];
                char b = input[input.Length - 1 - i];
                if (a != b) return false;
            }
            return true;
        }
    }
}
