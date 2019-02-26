using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTreeDemo();
        }

        static void BinaryTreeDemo()
        {
            Node<int> root = null;
            BinaryTree<int> bst = new BinaryTree<int>();
            int SIZE = 1000000;
            int[] a = new int[SIZE];

            Console.WriteLine("Generating random array with {0} values...", SIZE);

            Random random = new Random();

            Stopwatch watch = Stopwatch.StartNew();

            for (int i = 0; i < SIZE; i++)
            {
                a[i] = random.Next(10000);
            }

            watch.Stop();

            Console.WriteLine("Done. Took {0} seconds", (double)watch.ElapsedMilliseconds / 1000.0);
            Console.WriteLine();
            Console.WriteLine("Filling the tree with {0} nodes...", SIZE);

            watch = Stopwatch.StartNew();

            for (int i = 0; i < SIZE; i++)
            {
                root = bst.Insert(root, a[i]);
            }

            watch.Stop();

            Console.WriteLine("Done. Took {0} seconds", (double)watch.ElapsedMilliseconds / 1000.0);
            Console.WriteLine();

            int searchValue = a[random.Next(SIZE)];
            Console.WriteLine("Searching {0} in tree...", searchValue);

            watch = Stopwatch.StartNew();

            var result = bst.Search(root, searchValue);
            if (result != null)
                Console.WriteLine("Result found: {0}", result.Value);
            else
                Console.WriteLine("Cannot found: {0}", searchValue);

            watch.Stop();

            Console.WriteLine("Done. Took {0} ms", (double)watch.ElapsedMilliseconds / 1000000.0);
            Console.WriteLine();

            Console.WriteLine("Searching {0} in Array...", searchValue);
            watch = Stopwatch.StartNew();
            foreach (var item in a)
            {
                if (item == searchValue)
                {
                    Console.WriteLine("Result found: {0}", item);
                    break;
                }                    
            }
            watch.Stop();
            Console.WriteLine("Done. Took {0} ms", (double)watch.ElapsedMilliseconds / 1000000.0);
            Console.WriteLine();
            Console.ReadKey();
        }

        static void StackQueueDemo()
        {
            int[] nums = new int[] { 1, 5, 2, 3, 4 };
            LinkedList<int> l1 = new LinkedList<int>();
            LinkedList<int> l2 = new LinkedList<int>();
            DoublyLinkedList<int> d1 = new DoublyLinkedList<int>();
            PriorityQueue<int> pq = new PriorityQueue<int>();
            Queue<int> q1 = new Queue<int>();
            Stack<int> s1 = new Stack<int>();
            foreach (var n in nums)
            {
                l1.AddLast(n);
                l2.AddFirst(n);
                d1.AddLast(n);
                pq.Enqueue(n);
                q1.Enqueue(n);
                s1.Push(n);
            }

            Console.WriteLine("### STACK DEMO ###");
            Console.WriteLine(s1.ToString());
            s1.Pop();
            Console.WriteLine(s1.ToString() + "\n");

            Console.WriteLine("### BASIC QUEUE DEMO ###");
            Console.WriteLine(q1.ToString());
            q1.Dequeue();
            Console.WriteLine(q1.ToString() + "\n");

            Console.WriteLine("### PRIORITY QUEUE DEMO ###");
            Console.WriteLine(pq.ToString());
            pq.Dequeue();
            Console.WriteLine(pq.ToString() + "\n");
        }
    }
}
