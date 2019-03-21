using LinkedList = System.Collections.Generic.LinkedList<int>;
using DataStructure;
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
            TestGCD();
        }

        static void TestGCD()
        {
            int[] inp1 = { 2, 3, 4, 5, 6 };
            int res1 = findGCD(inp1, inp1.Length);
            Console.WriteLine("Resu: " + res1);

            int[] inp2 = { 2, 4, 6, 8, 10 };
            int res2 = findGCD(inp2, inp2.Length);
            Console.WriteLine("Resu: " + res2);
        }

        static int gcd(int a, int b)
        {
            if (a == 0)
                return b;
            return gcd(b % a, a);
        }

        // Function to find gcd of  
        // array of numbers 
        static int findGCD(int[] arr, int n)
        {
            int result = arr[0];
            for (int i = 1; i < n; i++)
                result = gcd(arr[i], result);

            return result;
        }

        static void TestCellCompete()
        {
            int[] input = { 1,1,1,0,1,1,1,1 };
            int[] input1 = { 1, 0, 0, 0, 0, 1, 0, 0 };
            int[] result = cellCompete(input1, 1);

        }

        static int[] cellCompete(int[] states, int days) {
            int[] curStates = new int[states.Length];
            int[] preStates = new int[states.Length];
            for (int i = 0; i < states.Length; i++)
            {
                curStates[i] = states[i];
                preStates[i] = states[i];
            }

            Console.WriteLine(string.Join(" ", preStates));
            while (days > 0)
            {
                int p = 0, n = 0;
                for (int i = 0; i < curStates.Length; i++)
                {
                    if (i == 0)
                        p = 0;
                    else 
                        p = preStates[i - 1];

                    if (i == preStates.Length - 1)
                        n = 0;
                    else
                        n = preStates[i + 1];

                    int a = 0;
                    if (p == n) a = 0;
                    else a = 1;
                    curStates[i] = a;
                }
                
                for (int i = 0; i < states.Length; i++)
                {
                    preStates[i] = curStates[i];
                }
                Console.WriteLine(string.Join(" ", curStates));
                days--;
            }

            return curStates;
        }

        static void TestBST() {
            BinaryTree<int> bTree = new BinaryTree<int>();
            Node<int> root = null;
            string input = "2 1 4 3 5";
            string[] splits = input.Split(' ');
            foreach (var item in splits)
            {
                root = bTree.Insert(root, int.Parse(item.Trim()));
            }
            int height = bTree.GetHeight(root);
            Console.WriteLine("Height: " + height);
        }

        static void TestBTreeAdd() {
            BinaryTree<int> bTree = new BinaryTree<int>();
            Node<int> root = null;
            string input = "2 1 4 3 5";
            string[] splits = input.Split(' ');
            foreach (var item in splits)
            {
                root = bTree.Insert(root, int.Parse(item.Trim()));
            }
        }

        static int BTreeAdd(Node<int> root)
        {
            int sum = 0;
            if (root != null)
            {
                if (root.Prev != null) sum += root.Prev.Value;
                if (root.Next != null) sum += root.Next.Value;
            }
            return sum;
        }

        static void TestLinkedListAdd() {
            LinkedList l1 = new LinkedList();
            foreach (var item in "789")
            {
                int x = int.Parse(item.ToString());
                l1.AddLast(x);
            }
            l1 = ReverseLL(l1);

            LinkedList l2 = new LinkedList();
            foreach (var item in "1")
            {
                int x = int.Parse(item.ToString());
                l2.AddLast(x);
            }
            l2 = ReverseLL(l2);

            LinkedList result = AddLLNode(l1.First, l2.First);
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
        static LinkedList AddLLNode(LinkedListNode<int> n1, LinkedListNode<int> n2) {
            LinkedList result = new LinkedList();

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

        static LinkedList ReverseLL(LinkedList list)
        {
            LinkedList r = new LinkedList();

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
