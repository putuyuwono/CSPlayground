using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    /// <summary>
    /// Stack Implementation using Linked List Data Structure
    /// </summary>
    public class Stack<T>
    {
        private LinkedList<T> Data { get; set; }

        public Stack()
        {
            Data = new LinkedList<T>();
        }

        public void Push(T value)
        {
            Data.AddLast(value);
        }

        public T Pop()
        {
            T value = default(T);

            if (Data.Tail != null)
            {
                value = Data.Tail.Value;
                Data.RemoveLast();
            }

            return value;
        }

        public T Peek()
        {
            return Data.Tail.Value;
        }

        public bool IsEmpty()
        {
            return Data.Count == 0;
        }

        public override string ToString()
        {
            return Data.ToString();
        }

        public int Count() {
            return Data.Count;
        }

    }
}
