using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    /// <summary>
    /// Queue implementation using Linked List Data Structure
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Queue<T>
    {
        private LinkedList<T> Data { get; set; }

        public Queue()
        {
            Data = new LinkedList<T>();
        }

        public void Enqueue(T value)
        {
            Data.AddLast(value);
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
