using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleChainedLists
{
    class List
    {
        protected Nod header;

        public List()
        {
            header = new Nod(0);
        }

        public void Insert(int x, int dupa)
        {
            Nod curent = new Nod();
            Nod nn = new Nod(x);
            curent = Caut(dupa);
            nn.next = curent.next;
            nn.previous = curent;
            curent.next = nn;
        }

        private Nod Caut(int item)
        {
            Nod curent = new Nod();
            curent = header;
            while (curent.value != item)
                curent = curent.next;
            return curent;
        }

        public void Clear(int n)
        {
            Nod s = Caut(n);
            if (!(s.next == null))
            {
                s.previous.next = s.next;
                s.next.previous = s.previous;
                s.next = null;
                s.previous = null;
            }
        }

        private Nod CautU()
        {
            Nod curent = new Nod();
            curent = header;
            while (!(curent.next == null))
                curent = curent.next;
            return curent;
        }

        public int Count()
        {
            Nod curent = new Nod();
            curent = CautU();
            int counter = 0;
            while (!(curent.previous == null))
            {
                counter++;
                curent = curent.previous;
            }
            return counter;
        }

        public int ReturnElementposition(int position, int count)
        {
            Nod curent = new Nod();
            curent = header;
            int counter = 0;
            while (count > 0)
            {
                counter++;
                curent = curent.next;
                count--;
                if (counter == position)
                    break;
            }
            return curent.value;
        }
    }
}