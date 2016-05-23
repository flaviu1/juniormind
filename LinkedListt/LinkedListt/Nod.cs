using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node
    {
        public int value;
        public Node address; 
        public Node()
        {
            value = 0;
            address = null;
        }
        public Node(int x)
        {
            value = x;
            address = null;
        }
    }

}