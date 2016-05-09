using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementIList
{
    class List : IList<int>
    {
        private int[] array = new int[] { };
        private int _index;
        public int IndexOf(int item)
        {
            int itemIndex = -1;
            for (int i = 0; i < Count; i++)
            {
                if (array[i] == item)
                {
                    itemIndex = i;
                    break;
                }
            }
            return itemIndex;
        }

        public void Insert(int index, int item)
        {
            if ((_index <= array.Length) && (index < Count) && (index >= 0))
            {
                _index++;

                for (int i = Count - 2; i > index; i--)
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

        public int this[int index]
        {
            get
            {
                return array[_index];
            }
            set
            {
                array[index] = value;
            }
        }

        public void Add(int value)
        {
            if (array.Length <= _index)
                Array.Resize(ref array, array.Length + 1);

            array[array.Length - 1] = value;
            _index++;

        }

        public void Clear()
        {
            _index = 0;
        }

        public bool Contains(int value)
        {
            bool inList = false;
            for (int i = 0; i < Count; i++)
            {
                if (array[i] == value)
                {
                    inList = true;
                    break;
                }
            }
            return inList;
        }

        public void CopyTo(int[] array1, int index)
        {
            int j = index;
            for (int i = 0; i < Count; i++)
            {
                array1.SetValue(array[i], j);
                j++;
            }
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

        public bool Remove(int item)
        {
            return true;
        }

        public IEnumerator<int> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
