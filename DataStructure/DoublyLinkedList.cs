using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class DNode<T> {
        public T Value { get; set; }
        public DNode<T> Prev { get; set; }
        public DNode<T> Next { get; set; }
    }

    public class DoublyLinkedList<T>
    {
        private DNode<T> head;
        private DNode<T> tail;

        public void AddFirst(T value) {
            var newNode = new DNode<T> { Value = value, Prev = null, Next = head };
            if (head != null)
            {
                head.Prev = newNode;
            }
            head = newNode;
        }

        public void AddLast(T value) {
            var newNode = new DNode<T> { Value = value, Prev = tail, Next = null };
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
            }
        }

        public string ReverseToString() {
            if (tail == null) return string.Empty;

            StringBuilder sb = new StringBuilder();
            var curr = tail;
            while (curr != null) {
                sb.Append(curr.Value);
                if (curr.Prev != null) sb.Append(" <> ");
                curr = curr.Prev;
            }
            return sb.ToString();
        }

        public override string ToString()
        {
            if (head == null) return string.Empty;

            StringBuilder sb = new StringBuilder();
            var curr = head;
            while (curr != null) {
                sb.Append(curr.Value);
                if (curr.Next != null) sb.Append(" <> ");
                curr = curr.Next;
            }

            return sb.ToString();
        }
    }
}
