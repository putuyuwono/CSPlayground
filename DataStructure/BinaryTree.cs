using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class BinaryTree<T> where T : IComparable
    {
        public Node<T> Insert(Node<T> root, T v) {
            if (root == null)
            {
                root = new Node<T> { Value = v };
            }
            else if (v.CompareTo(root.Value) < 0)
            {
                root.Prev = Insert(root.Prev, v);
            }
            else
            {
                root.Next = Insert(root.Next, v);
            }
            return root;
        }

        public void Traverse(Node<T> root)
        {
            if (root == null) return;

            Traverse(root.Prev);
            Traverse(root.Next);
        }

        public Node<T> Search(Node<T> node, T value) {
            Node<T> result = node;
            if (node == null || node.Value.CompareTo(value) == 0)
            {
                result = node;
            }
            else if (node.Value.CompareTo(value) > 0)
            {
                result = Search(node.Prev, value);
            }
            else
            {
                result = Search(node.Next, value);
            }
            return result;
        }
    }
}
