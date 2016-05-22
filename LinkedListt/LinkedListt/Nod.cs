using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Nod
    {
        public int value;
        public Nod adres;
        public Nod()
        {
            value = 0;
            adres = null;
        }
        public Nod(int x)
        {
            value = x;
            adres = null;
        }
    }

}