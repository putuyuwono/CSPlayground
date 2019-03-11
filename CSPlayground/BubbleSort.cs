using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPlayground
{
    public class BubbleSort
    {
        public static void Sort(ref int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j < n-i; j++)
                {
                    int prev = arr[j - 1];
                    int next = arr[j];
                    if (prev > next)
                    {
                        int temp = prev;
                        arr[j - 1] = next;
                        arr[j] = prev;
                    }
                }
            }
        }
    }
}
