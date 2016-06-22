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
            head.next = head;
            head.prev = head;
        }

        public int Count
        {
            get { return count; }
        }

        public Node<T> LastElement()
        {
            return head != head.next ? head.prev : null;
        }

        public Node<T> FierstElement()
        {
            return head != head.next ? head.next : null;
        }

        public void AddFirst(T value)
        {
            Node<T> newNode = new Node<T>(value);
            newNode.next = head.next;
            newNode.prev = head;
            head.next.prev = newNode;
            head.next = newNode;
            count++;
        }

        public void Add(T data)
        {
            AddLast(data);
        }

        public void AddLast(T data)
        {
            Node<T> newNode = new Node<T>(data);
            newNode.next = head;
            newNode.prev = head.prev;
            head.prev.next = newNode;
            head.prev = newNode;
            count++;
        }

        public void AddAfter(T valn, T after)
        {
            Node<T> newNode = new Node<T>(valn);
            AddNode(after, newNode);
        }

        private void AddNode(T after, Node<T> newNode)
        {
            Node<T> nodeAfter = FindValueReturnNode(after);
            if (nodeAfter != null)
            {
                newNode.next = nodeAfter.next;
                newNode.prev = nodeAfter;
                nodeAfter.next.prev = newNode;
                nodeAfter.next = newNode;
                count++;
            }
        }

        public void Clean()
        {
            head = null;
            count = 0;
        }

        public void Remove(T item)
        {
            while (FindValueReturnNode(item) != null)
            {
                var newNode = FindValueReturnNode(item);
                newNode.prev.next = newNode.next;
                newNode.next.prev = newNode.prev;
                count--;
            }
        }

        public void RemoveFirst()
        {
            if (count != 0)
            {
                head.next = head.next.next;
                head.next.next.prev = head;
                count--;
            }
        }

        public void RemoveLast()
        {
            if (count > 0)
            {
                head.prev.prev.prev.next = head;
                head.prev = head.prev.prev;
                count--;
            }
        }

        public Node<T> FindValueReturnNode(T item)
        {
            Node<T> curent = head.next;
            while (curent != null && Find(item) == true)
            {
                if (curent.value.Equals(item))
                    return curent;
                curent = curent.next;
            }
            return null;
        }

        public bool Find(T item)
        {
            Node<T> curent = head.next;
            while (curent != head)
            {
                if (curent.value.Equals(item))
                    return true;
                curent = curent.next;
            }
            return false;
        }

        public Node<T> FindLast(T item)
        {
            Node<T> curent = head.prev;
            Node<T> lastNode = head.next;
            while (curent != head)
            {
                if (curent.value.Equals(item))
                    lastNode = curent;
                curent = curent.prev;
            }
            return lastNode;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var curr = head.next;
            while (curr != head)
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
