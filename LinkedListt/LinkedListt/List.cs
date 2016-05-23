using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class List<T>
    {
        protected Node<T>  header;
        public List()
        {
            header = new Node<T>();
        }

        public void Insert(T valn, T after)
        {
            Node<T> curent = new Node<T>();
            Node<T> nn = new Node<T>(valn);
            curent = Search(after);
            nn.address = curent.address;
            curent.address = nn;
        }

        private Node<T> Search(T item)
        {
            Node<T> curent = new Node<T>();
            curent = header;
            while (!curent.value.Equals(item))
                curent = curent.address;
            return curent;
        }
        private Node<T> SearchP(T n)
        {
            Node<T> curent = header;
            while (curent.address != null && !curent.address.value.Equals(n))
                curent = curent.address;
            return curent;
        }

        public void Clean(T n)
        {
            Node<T> p = SearchP(n);
            if (!(p.address == null))
                p.address = p.address.address;
        }
        public int Count()
        {
            Node<T> curent = new Node<T>();
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



