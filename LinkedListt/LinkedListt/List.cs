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
        
        public T TheLastItemInTheList()
        {
            Node<T> current = head;
            while (current.address != null)
            {
                current = current.address;
            }
            return current.value;
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
            Node<T> curent = head; ;
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
            Node<T> _current = head;
            while (_current.address != null)
            {
                if (_current.address.value.Equals(item))
                {
                    _current.address = _current.address.address;
                    break;
                }
                else
                    _current = _current.address;
            }
        }


        public IEnumerator<T> GetEnumerator()
        {
            var curr = head;
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
