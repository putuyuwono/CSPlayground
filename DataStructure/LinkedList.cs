using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public class LinkedList<T> : ICollection<T>
    {
        public int Count { get; private set; }

        public bool IsReadOnly => false;

        public Node<T> Head { get; private set; }
        public Node<T> Tail { get; private set; }

        public void Add(T item)
        {
            AddLast(item);
        }

        public void AddFirst(T value)
        {
            Node<T> newNode = new Node<T> { Value = value, Next = Head };
            Head = newNode;
            Count += 1;
        }

        public void AddLast(T value)
        {
            Node<T> newNode = new Node<T> { Value = value, Next = null };
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Tail.Next = newNode;
            }
            Tail = newNode;
            Count += 1;
        }

        public void AddAfter(T value, Node<T> node)
        {
            if (node != null)
            {
                var newNode = new Node<T>() { Value = value, Next = node.Next };
                node.Next = newNode;
            }
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public bool Contains(T item)
        {
            var curr = Head;
            while (curr != null)
            {
                if (curr.Value.Equals(item)) {
                    return true;
                }
                curr = curr.Next;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            var curr = Head;
            while (curr != null)
            {
                array[arrayIndex++] = curr.Value;
                curr = curr.Next;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            var curr = Head;
            while (curr != null)
            {
                yield return curr.Value;
                curr = curr.Next;
            }
        }

        public bool Remove(T item)
        {
            Node<T> curr = Head;
            Node<T> prev = null;
            while (curr != null)
            {
                if (curr.Value.Equals(item))
                {
                    if (prev != null)
                    {
                        prev.Next = curr.Next;
                        if (curr == Tail)
                        {
                            Tail = prev;
                        }
                        Count--;
                    }
                    else
                    {
                        RemoveFirst();
                    }                   
                    return true;
                }
                prev = curr;
                curr = curr.Next;
            }
            return false;
        }

        public void RemoveFirst()
        {
            if (Head != null)
            {
                if (Head == Tail)
                {
                    Head = null;
                    Tail = null;
                }
                else
                {
                    Head = Head.Next;
                }
                Count -= 1;
            }
        }

        public void RemoveLast()
        {
            if (Tail != null)
            {
                if (Tail == Head)
                {
                    Head = null;
                    Tail = null;
                }
                else
                {
                    var curr = Head;
                    while (curr.Next != Tail)
                    {
                        curr = curr.Next;
                    }
                    curr.Next = null;
                    Tail = curr;
                }
                Count -= 1;
            }
        }

        public override string ToString()
        {
            if (Head == null) return String.Empty;

            var curr = Head;
            StringBuilder sb = new StringBuilder();
            while (curr != null)
            {
                sb.Append(curr.Value);
                if (curr.Next != null) { sb.Append(" -> "); }
                curr = curr.Next;
            }

            return sb.ToString();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)this).GetEnumerator();
        }
    }

}
