using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPlayground
{
    public class PostfixCalculator
    {
        /// <summary>
        /// This method caluculate operands and operators using postfix mechanism
        /// Sample input: "3 4 5 * - 10 *"
        /// </summary>
        /// <param name="input">input string</param>
        /// <returns>result</returns>
        public static double Calculate(String input) {
            double result = 0;

            DataStructure.Stack<double> stack = new DataStructure.Stack<double>();
            var splits = input.Split(' ');
            foreach (var item in splits)
            {
                if (double.TryParse(item, out double num)){
                    stack.Push(num);
                }
                else
                {
                    switch (item)
                    {
                        case "*":
                            var a = stack.Pop();
                            var b = stack.Pop();
                            stack.Push(a * b);
                            break;
                        case "/":
                            a = stack.Pop();
                            b = stack.Pop();
                            stack.Push(a / b);
                            break;
                        case "+":
                            a = stack.Pop();
                            b = stack.Pop();
                            stack.Push(a + b);
                            break;
                        case "-":
                            a = stack.Pop();
                            b = stack.Pop();
                            stack.Push(a - b);
                            break;
                        default: break;
                    }
                }
            }

            if (stack.Count() == 1) {
                result = stack.Pop();
            }

            return result;
        }
    }
}
