using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPlayground
{
    public class ParenthesisChecker
    {
        /// <summary>
        /// This method check whether parenthesis structure is correct or not.
        /// Sample Input: "()()()"
        /// </summary>
        /// <param name="input">input string</param>
        /// <returns>true if valid</returns>
        public static bool IsValid(string input) {
            DataStructure.Stack<char> stack = new DataStructure.Stack<char>();

            foreach (char c in input) {
                switch (c){
                    case '(':
                    case '{':
                    case '[':
                        stack.Push(c); break;
                    case ')':
                        if (stack.Pop() != '(') return false; break;
                    case '}':
                        if (stack.Pop() != '{') return false; break;
                    case ']':
                        if (stack.Pop() != '[') return false; break;
                    default: break;
                }
            }

            return stack.IsEmpty();
        }
    }
}
