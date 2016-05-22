using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleChainedLists
{
    public class Nod
    {
        public int value;
        public Nod next;
        public Nod previous;
 

        public Nod()
        {
            value = 0;
            next = null;
            previous = null;
        }
        public Nod(int x)
        {
            value = x;
            next = null;
            previous = null;
        }
    }

}
