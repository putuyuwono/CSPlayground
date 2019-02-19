using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    /// <summary>
    /// Priority Queue Implementation using Linked List Data Structure
    /// </summary>
    public class PriorityQueue<T> where T : IComparable
    {
        private LinkedList<T> Data { get; set; }

        public PriorityQueue()
        {
            Data = new LinkedList<T>();
        }

        public void Enqueue(T value)
        {            
            Node<T> curr = Data.Head;
            Node<T> prev = null;
            while (curr != null) {
                if (value.CompareTo(curr.Value) > 0)
                {
                    break;
                }

                prev = curr;
                curr = curr.Next;
            }

            if (prev != null)
            {
                Data.AddAfter(value, prev);
            }
            else
            {
                Data.AddFirst(value);
            }
                
        }

        public T Dequeue()
        {
            var value = Data.Head.Value;
            Data.RemoveFirst();
            return value;
        }

        public T GetFirst()
        {
            return Data.Head.Value;
        }

        public bool IsEmpty()
        {
            return Data.Count == 0;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
