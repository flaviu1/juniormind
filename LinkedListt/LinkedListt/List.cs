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
        protected Nod header;
        public ListaInlantuita()
        {
            header = new Nod(0);
        }

        public void Insert(int valn, int dupa)
        {
            Nod curent = new Nod();
            Nod nn = new Nod(valn);
            curent = Caut(dupa);
            nn.adres = curent.adres;
            curent.adres = nn;
        }

        private Nod Caut(int item)
        {
            Nod curent = new Nod();
            curent = header;
            while (curent.value != item)
                curent = curent.adres;
            return curent;
        }
        private Nod CautP(int n)
        {
            Nod curent = header;
            while (!(curent.adres == null) && (curent.adres.value != n))
                curent = curent.adres;
            return curent;
        }

        public void Clear(int n)
        {
            Nod p = CautP(n);
            if (!(p.adres == null))
                p.adres = p.adres.adres;
        }
        public int Count()
        {
            Nod curent = new Nod();
            curent = header;
            int counter = 0;
            while (curent.adres != null)
            {
                curent = curent.adres;
                counter++;
            }
            return counter;
        }

    }
}



