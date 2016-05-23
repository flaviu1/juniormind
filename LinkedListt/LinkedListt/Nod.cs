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
        public Node<T> address; 
        public Node()
        {
            value = default(T);
            address = null;
        }
        public Node(T x)
        {
            value = x;
            address = null;
        }
    }

}