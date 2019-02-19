﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[]{ 1, 5, 2, 3, 4 };
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

            //Console.WriteLine(l1.ToString());
            //Console.WriteLine(l2.ToString());
            //Console.WriteLine(d1.ToString());
            //Console.WriteLine(d1.ReverseToString());

            //d1.RemoveFirst();
            //Console.WriteLine(d1.ToString());
            //l1.Remove(1);
            //Console.WriteLine(l1.ToString());
            
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
