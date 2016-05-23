using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class ListaInlantuita
    {
        protected Node header;
        public ListaInlantuita()
        {
            header = new Node(0);
        }

        public void Insert(int valn, int dupa)
        {
            Node curent = new Node();
            Node nn = new Node(valn);
            curent = Search(dupa);
            nn.address = curent.address;
            curent.address = nn;
        }

        private Node Search(int item)
        {
            Node curent = new Node();
            curent = header;
            while (curent.value != item)
                curent = curent.address;
            return curent;
        }
        private Node SearchP(int n)
        {
            Node curent = header;
            while (curent.address != null && curent.address.value != n)
                curent = curent.address;
            return curent;
        }

        public void Clean(int n)
        {
            Node p = SearchP(n);
            if (!(p.address == null))
                p.address = p.address.address;
        }
        public int Count()
        {
            Node curent = new Node();
            curent = header;
            int counter = 0;
            while (curent.address != null)
            {
                curent = curent.address;
                counter++;
            }
            return counter;
        }

    }
}



