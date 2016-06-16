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
        public Node<T> prev;
        public Node()
        {
            value = default(T);
            prev = null;
            next = null;

        }
        public Node(T x)
        {
            value = x;
            next = null;
            prev = null;
        }
    }

}