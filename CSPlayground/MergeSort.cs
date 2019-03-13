using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPlayground
{
    public class MergeSort
    {
        public static List<int> Sort(List<int> list)
        {
            if (list.Count <= 1) return list;

            List<int> l1 = new List<int>();
            List<int> l2 = new List<int>();

            int mid = list.Count / 2;
            l1.AddRange(list.GetRange(0, mid));
            l2.AddRange(list.GetRange(mid, list.Count - mid));

            l1 = Sort(l1);
            l2 = Sort(l2);

            return Merge(l1, l2);
        }

        private static List<int> Merge(List<int> l1, List<int> l2)
        {
            List<int> result = new List<int>();

            while (l1.Count > 0 || l2.Count > 0) {
                if (l1.Count > 0 && l2.Count > 0) {
                    int a = l1.First();
                    int b = l2.First();
                    if (a <= b)
                    {
                        result.Add(a);
                        l1.Remove(a);
                    }
                    else
                    {
                        result.Add(b);
                        l2.Remove(b);
                    }
                }
                else if (l1.Count > 0)
                {
                    result.Add(l1.First());
                    l1.Remove(l1.First());
                }
                else if (l2.Count > 0)
                {
                    result.Add(l2.First());
                    l2.Remove(l2.First());
                }
            }

            return result;
        }
    }
}
