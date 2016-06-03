using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node<T>
    {
        public T value;
        public Node<T> next; 
        public Node()
        {
            value = default(T);
            next = null;
        }
        public Node(T x)
        {
            value = x;
            next = null;
        }
    }

}