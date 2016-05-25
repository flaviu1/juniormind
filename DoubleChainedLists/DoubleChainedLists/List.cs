using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleChainedLists
{
    class List<T>
    {
        protected Node<T> header;

        public List()
        {
            header = new Node<T>();
        }

        public void Insert(T x, T after)
        {
            Node<T> curent = new Node<T>();
            Node<T> nn = new Node<T>(x);
            curent = SearchItem(after);
            nn.next = curent.next;
            nn.previous = curent;
            curent.next = nn;
        }

        private Node<T> SearchItem(T item)
        {
            Node<T> curent = new Node<T>();
            curent = header;
            while (!curent.value.Equals(item))
                curent = curent.next;
            return curent;
        }

        public void Clear(T n)
        {
            Node<T> s = SearchItem(n);
            if (s.next != null)
            {
                s.previous.next = s.next;
                s.next.previous = s.previous;
                s.next = null;
                s.previous = null;
            }
        }

        private Node<T> Search()
        {
            Node<T> curent = new Node<T>();
            curent = header;
            while (curent.next !=null)
                curent = curent.next;
            return curent;
        }

        public int Count()
        {
            Node<T> curent = new Node<T>();
            curent = Search();
            int counter = 0;
            while (curent.previous != null)
            {
                counter++;
                curent = curent.previous;
            }
            return counter;
        }

        public T ReturnElementposition(int position, int  count)
        {
            Node<T> curent = new Node<T>();
            curent = header;
            int counter = 0;
            while (!count.Equals(0))
            {
                counter++;
                curent = curent.next;
                count--;
                if (counter.Equals(position))
                    break;
            }
            return curent.value;
        }
    }
}