using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList<T> : IEnumerable<T>
    {
        private Node<T> head;
        public LinkedList()
        {
            head = new Node<T>();
        }

        public int EachListContainsElements()
        {
            int counter = 0;
            Node<T> current = head;
            while (current != null)
            {
                counter++;
                current = current.address;
            }
            return counter;
        }
        public T FierstElement()
        {
            return head.value;
        }

        public void AddFirst(T node)
        {
            Node<T> newNode = new Node<T>();

            newNode.value = node;
            newNode.address = head;

            head = newNode;
        }

        public void AddLast(T data)
        {
            if (head == null)
            {
                head = new Node<T>();

                head.value = data;
                head.address = null;
            }
            else
            {
                Node<T> toAdd = new Node<T>();
                toAdd.value = data;

                Node<T> current = head;
                while (current.address != null)
                {
                    current = current.address;
                }

                current.address = toAdd;
            }
        }

        public void AddAfter(T valn, T after)
        {
            Node<T> curent = head;
            Node<T> nn = new Node<T>(valn);
            while (!curent.value.Equals(after))
                curent = curent.address;
            nn.address = curent.address;
            curent.address = nn;
        }
        public void Clean()
        {
            head = null;
        }

        public void Remove(T item)
        {
            Node<T> current = head;
            while (current.address != null)
            {
                if (current.address.value.Equals(item))
                {
                    current.address = current.address.address;
                    break;
                }
                else
                    current = current.address;
            }
        }
        public void RemoveFirst()
        {
            head = head.address.address;
        }

        public void RemoveLast()
        {
            T result = FindLast();
            Remove(result);
        }
        public bool Find(T item)
        {
            Node<T> curent = head.address;
            while (curent != null)
            {
                if (curent.value.Equals(item))
                    return true;
                curent = curent.address;
            }

            return false;
        }
        public T FindLast()
        {
            Node<T> current = head;
            while (current.address != null)
            {
                current = current.address;
            }
            return current.value;
        }


        public IEnumerator<T> GetEnumerator()
        {
            if (head == null)
                yield return default(T);
            var curr = head.address;
            while (curr != null)
            {
                yield return curr.value;
                curr = curr.address;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
