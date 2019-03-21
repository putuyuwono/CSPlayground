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
            TestLinkedListAdd();
        }

        static void TestLinkedListAdd() {
            LinkedList<int> l1 = new LinkedList<int>();
            foreach (var item in "789")
            {
                int x = int.Parse(item.ToString());
                l1.AddLast(x);
            }
            l1 = ReverseLL(l1);

            LinkedList<int> l2 = new LinkedList<int>();
            foreach (var item in "1")
            {
                int x = int.Parse(item.ToString());
                l2.AddLast(x);
            }
            l2 = ReverseLL(l2);

            LinkedList<int> result = AddLLNode(l1.First, l2.First);
            Console.WriteLine("Result: " + string.Join("", result.ToArray()));
        }

        /// <summary>
        /// Limitations:
        /// - Inputs are reversed linked list
        /// - For example: 152 (2->5->1)
        /// - Reversing Linked List takes O(n) complexity
        /// </summary>
        /// <param name="n1">Head of LinkedList 1</param>
        /// <param name="n2">Head of LinkedList 2</param>
        /// <returns></returns>
        static LinkedList<int> AddLLNode(LinkedListNode<int> n1, LinkedListNode<int> n2) {
            LinkedList<int> result = new LinkedList<int>();

            int carry = 0, sum = 0, first = 0;
            while (n1 != null || n2 != null)
            {
                first++;
                sum = carry;

                if (n1 != null)
                {
                    sum += n1.Value;
                    n1 = n1.Next;
                }

                if (n2 != null)
                {
                    sum += n2.Value;
                    n2 = n2.Next;
                }

                carry = sum / 10;
                sum = sum % 10;
                
                result.AddFirst(sum);
            }

            if (carry > 0)
                result.AddFirst(carry);

            return result;
        }

        static LinkedList<int> ReverseLL(LinkedList<int> list)
        {
            LinkedList<int> r = new LinkedList<int>();

            LinkedListNode<int> curr = list.First;
            while (curr != null)
            {
                r.AddFirst(curr.Value);
                curr = curr.Next;
            }

            return r;
        }
    }
}
