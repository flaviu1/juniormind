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
        private int _index;
        
        public List() { }

        public List(T[] array)
        {
            this.array = array;
        }
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
            if (index < Count && index >= 0)
            {
                if (_index <= array.Length)
                    Array.Resize(ref array, array.Length * 2);
                _index++;
                for (int i = Count - 1; i > index; i--)
                {
                    array[i] = array[i - 1];
                }
                array[index] = item;
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
                _index--;
            }
        }

        public T this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }



        public void Add(T item)
        {
            if (Count == 0)
                Array.Resize(ref array, array.Length + 1);
            if (array.Length <= Count && _index == Count)
                Array.Resize(ref array, array.Length * 2);

            array[_index] = item;
            _index++;
        }

        public void Clear()
        {
            _index = 0;
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

        public void CopyTo(T[] arrayToAdd, int arrayIndex)
        {
            if (arrayToAdd.Length <= array.Count())
                Array.Resize(ref arrayToAdd, arrayToAdd.Count() + array.Count() + 1);

            int j = arrayIndex;
            for (int i = 0; i < _index; i++)
            {
                arrayToAdd.SetValue(array[i], j++);
            }
        }
        public bool Compare(T[] array1, T[] array2)
        {
            for(int i=0;i<array1.Length;i++)
            {
                if(!array1[i].Equals(array2[i]))
                    return false;
            }
            return true;
        }
        public int Count
        {
            get
            {
                return _index;
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
            int counter = 0;
            while (counter < Count)
            {
                yield return array[counter];
                counter++;
            }
        }


        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            int counter = 0;
            while (counter < Count)
            {
                yield return array[counter];
                counter++;
            }
        }
    }
}
