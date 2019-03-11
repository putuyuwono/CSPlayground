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
            int[] arr = { 4, 3, 2, 1, 5, 9, 8, 0};
            Console.WriteLine(string.Join(" ", arr));
            BubbleSort.Sort(ref arr);
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
