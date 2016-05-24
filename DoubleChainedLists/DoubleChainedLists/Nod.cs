using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleChainedLists
{
    public class Node<T>
    {
        public T value;
        public Node<T> next;
        public Node<T> previous;
 

        public Node()
        {
            value = default(T);
            next = null;
            previous = null;
        }
        public Node(T x)
        {
            value = x;
            next = null;
            previous = null;
        }
    }

}
