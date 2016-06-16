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
        private int count = 0;
        public LinkedList()
        {
            head = new Node<T>();
            head.next = null;
            head.prev=null;
        }
      
        public int Count
        {
            get { return count; }
        }

        public T FierstElement()
        {
            return head.next.value;
        }

        public void AddFirst(T node)
        {
            Node<T> current = head;
            Node<T> newNode = new Node<T>(node);
            newNode.next = current.next;
            current.next = newNode;
            newNode.prev = current;
            newNode.next.prev = newNode;
            count++;
        }

        public void AddLast(T data)
        {
            Node<T> toAdd = new Node<T>();
            toAdd.value = data;
            Node<T> current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = toAdd;
        }

        public void AddAfter(T valn, T after)
        {
            Node<T> curent = head;
            Node<T> newNode = new Node<T>(valn);
            if (Find(after))
            {
                newNode.next = curent.next;
                curent.next = newNode;
            }
        }

        public void Clean()
        {
            head = null;
            count = 0;
        }

        public void Remove(T item)
        {
            Node<T> current = head;
            while (current.next != null)
            {
                if (current.next.value.Equals(item))
                {
                    current.next = current.next.next;
                }
                else
                    current = current.next;
            }
        }
        public void RemoveFirst()
        {
            if (head.next != null)
            {
                Node<T> current = head.next.next;
                head.next = current;
                count--;
            }
        }

        public void RemoveLast()
        {
            Node<T> result = FindLast();
            Remove(result.value);

        }
        public bool Find(T item)
        {
            Node<T> curent = head.next;
            while (curent != null)
            {
                if (curent.value.Equals(item))
                    return true;
                curent = curent.next;
            }
            return false;
        }
        public Node<T> FindLast()
        {
            Node<T> current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            return current;
        }


        public IEnumerator<T> GetEnumerator()
        {
            var curr = head.next;
            while (curr != null)
            {
                yield return curr.value;
                curr = curr.next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
