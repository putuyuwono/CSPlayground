using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            String test = "3 4 5 * - 10 *";
            Console.WriteLine(PostfixCalculator.Calculate(test));
        }
    }
}
