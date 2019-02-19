using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public class DoublyLinkedList<T> : ICollection<T>
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
            var newNode = new Node<T> { Value = value, Prev = null, Next = Head };
            if (Head != null)
            {
                Head.Prev = newNode;
            }
            Head = newNode;
            Count++;
        }

        public void AddLast(T value)
        {
            var newNode = new Node<T> { Value = value, Prev = Tail, Next = null };
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Tail.Next = newNode;
            }
            Tail = newNode;
            Count++;
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
            while (curr != null) {
                if (curr.Value.Equals(item))
                {
                    return true;
                }
                curr = curr.Next;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            var curr = Head;
            while (curr != null) {
                array[arrayIndex++] = curr.Value;
                curr = curr.Next;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            var curr = Head;
            while (curr != null) {
                yield return curr.Value;
                curr = curr.Next;
            }
        }

        public bool Remove(T item)
        {
            var curr = Head;
            while (curr != null) {
                if (curr.Value.Equals(item)) {
                    if (curr.Prev != null)
                    {
                        curr.Prev.Next = curr.Prev;
                        if (curr.Next == null)
                        {
                            Tail = curr.Prev;
                        }
                        Count--;
                    }
                    else
                    {
                        RemoveFirst();
                    }
                    return true;
                }
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
                    Head.Prev = null;
                }
                Count--;
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
                    Tail = Tail.Prev;
                    Tail.Next = null;
                }
                Count--;
            }
        }

        public override string ToString()
        {
            if (Head == null) return string.Empty;

            StringBuilder sb = new StringBuilder();
            var curr = Head;
            while (curr != null)
            {
                sb.Append(curr.Value);
                if (curr.Next != null) sb.Append(" <> ");
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
