using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace List
{
    class Quicksort<T> : List<T> where T : IComparable
    {

        public void QuickSort(int[] array, int begin, int end)
        {
            int pivot = array[(begin + (end - begin) / 2)];
            int left = begin;
            int right = end;
            while (left <= right)
            {
                while (array[left] < pivot)
                {
                    left++;
                }
                while (array[right] > pivot)
                {
                    right--;
                }
                if (left <= right)
                {
                    swap(array, left, right);
                    left++;
                    right--;
                }
            }
            if (begin < right)
            {
                QuickSort(array, begin, left - 1);
            }
            if (end > left)
            {
                QuickSort(array, right + 1, end);
            }
        }
        private void swap(int[] items, int x, int y)
        {
            int temp = items[x];
            items[x] = items[y];
            items[y] = temp;
        }
    }
}
