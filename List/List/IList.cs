using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class List<T> : IList<T>
    {
        private T[] array = new T[] { };
        private int count;
        public int IndexOf(T item)
        {
            int itemIndex = -1;
            for (int i = 0; i < Count; i++)
            {
                if (array[i].Equals(item))
                {
                    itemIndex = i;
                    break;
                }
            }
            return itemIndex;
        }

        public void Insert(int index, T item)
        {
            {
                if ((count <= array.Length) && (index < Count) && (index >= 0))
                {
                    count++;

                    for (int i = Count - 2; i > index; i--)
                    {
                        array[i] = array[i - 1];
                    }
                    array[index] = item;
                }
            }
        }

        public void RemoveAt(int index)
        {
            if ((index >= 0) && (index < Count))
            {
                for (int i = index; i < Count - 1; i++)
                {
                    array[i] = array[i + 1];
                }
                count--;
            }
        }

        public T this[int index]
        {
            get
            {
                return array[count];
            }
            set
            {
                array[count] = value;
            }
        }

        public void Add(T item)
        {
            if (Count == 0)
                Array.Resize(ref array, array.Length + 1);
            if (array.Length <= Count && count == Count)
                Array.Resize(ref array, array.Length * 2);
            array[count] = item;
            count++;
        }

        public void Clear()
        {
            count = 0;
        }

        public bool Contains(T item)
        {
            bool inList = false;
            for (int i = 0; i < Count; i++)
            {
                if (array[i].Equals(item))
                {
                    inList = true;
                    break;
                }
            }
            return inList;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(T item)
        {
            return true;
        }
        public IEnumerator<T> GetEnumerator()
        {
            return this.GetEnumerator();

        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
