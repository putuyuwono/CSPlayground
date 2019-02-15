using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }
    }

    public class LinkedList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public void AddFirst(T value) {
            Node<T> newNode = new Node<T> { Value = value, Next = head };
            head = newNode;
        }

        public void AddLast(T value) {
            Node<T> newNode = new Node<T> { Value = value, Next = null };
            if (head == null)
            {
                head = newNode;
                tail = head;
            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
            }
        }

        public override string ToString()
        {
            if (head == null) return String.Empty;

            var curr = head;
            StringBuilder sb = new StringBuilder();
            while (curr != null)
            {
                sb.Append(curr.Value);
                if (curr.Next != null) { sb.Append(" -> "); }
                curr = curr.Next;
            }

            return sb.ToString();
        }
    }

}
