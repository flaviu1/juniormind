using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace List
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void QuickSort()
        {
            var x = new List<int>(); 
            int[] numbers= new int[] { 6, 2, 4, 9, 1, 7, 3, 5, 8 };
            var sort = new Quicksort<int>();
            sort.QuickSort(numbers, 0, numbers.Length - 1);
             var array = new int[]{1,2,3,4,5,6,7,8,9};
             Assert.IsTrue(x.Compare(numbers, array));
        }

        //[TestMethod]
        //public void Quick()
        //{
        //    var numbers = new List<int>() { 2, 1 };
        //    var sortedNumbers = new List<int>() { 1, 2 }; 
        //    var sort = new Quicksort<int>();
        //    int[] a = new int[] { 2, 1, 3, 3, 3, 6, 5 };
        //    sort.QuickSort(a, 2, 1);
        //   // numbers.Sort();

        //    for (int index = 0; index < numbers.Count; index++)
        //    {
        //        Assert.AreEqual(numbers[index], sortedNumbers[index]);
        //    }
        //}
        [TestMethod]
        public void AddListInt()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(3);
            Assert.AreEqual(4, list.Count);
        }
        [TestMethod]
        public void AddListString()
        {
            List<string> list = new List<string>();
            list.Add("a");
            list.Add("b");
            list.Add("c");
            list.Add("d");
            Assert.AreEqual(4, list.Count);
        }
        [TestMethod]
        public void IndexOfInt()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            Assert.AreEqual(1, list.IndexOf(2));
        }
        [TestMethod]
        public void IndexOfString()
        {
            List<string> list = new List<string>();
            list.Add("1");
            list.Add("2");
            list.Add("3");
            Assert.AreEqual(1, list.IndexOf("2"));
        }
        [TestMethod]
        public void ClearListInt()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Clear();
            Assert.AreEqual(0, list.Count);
        }
        [TestMethod]
        public void ClearListString()
        {
            List<string> list = new List<string>();
            list.Add("1");
            list.Add("2");
            list.Add("3");
            list.Clear();
            Assert.AreEqual(0, list.Count);
        }
        [TestMethod]
        public void ClearListChar()
        {
            List<char> list = new List<char>();
            list.Add('1');
            list.Add('2');
            list.Add('3');
            list.Clear();
            Assert.AreEqual(0, list.Count);
        }
        [TestMethod]
        public void RemoveAtElementFromListOfInt()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.RemoveAt(1);
            Assert.AreEqual(2, list.Count);
        }
        [TestMethod]
        public void RemoveAtElementFromListOfString()
        {
            List<string> list = new List<string>();
            list.Add("a");
            list.Add("a");
            list.Add("a");
            list.RemoveAt(1);
            Assert.AreEqual(2, list.Count);
        }
        [TestMethod]
        public void RemoveAtElementFromListOfChar()
        {
            List<char> list = new List<char>();
            list.Add('a');
            list.Add('a');
            list.Add('a');
            list.RemoveAt(1);
            Assert.AreEqual(2, list.Count);
        }
        [TestMethod]
        public void RemoveElementIndexNegativeFromListInt()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.RemoveAt(-1);
            Assert.AreEqual(3, list.Count);
        }
        [TestMethod]
        public void RemoveElementIndexNegativeFromListString()
        {
            List<string> list = new List<string>();
            list.Add("1");
            list.Add("2");
            list.Add("3");
            list.RemoveAt(-1);
            Assert.AreEqual(3, list.Count);
        }
        [TestMethod]
        public void RemoveElementIndexNegativeFromListChar()
        {
            List<char> list = new List<char>();
            list.Add('1');
            list.Add('2');
            list.Add('3');
            list.RemoveAt(-1);
            Assert.AreEqual(3, list.Count);
        }
        [TestMethod]
        public void RemoveElementIndexLargerThanTheListveFromListInt()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.RemoveAt(4);
            Assert.AreEqual(3, list.Count);
        }
        [TestMethod]
        public void RemoveElementIndexLargerThanTheListveFromListString()
        {
            List<string> list = new List<string>();
            list.Add("1");
            list.Add("2");
            list.Add("3");
            list.RemoveAt(4);
            Assert.AreEqual(3, list.Count);
        }
        [TestMethod]
        public void RemoveElementIndexLargerThanTheListveFromListChar()
        {
            List<char> list = new List<char>();
            list.Add('1');
            list.Add('2');
            list.Add('3');
            list.RemoveAt(3);
            Assert.AreEqual(3, list.Count);
        }
        [TestMethod]
        public void InsertInListInt()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Insert(2, 10);
            list.Insert(2, 10);
            list.Insert(2, 10);
            list.Insert(2, 10);
            Assert.AreEqual(7, list.Count);
        }
        [TestMethod]
        public void InsertInListString()
        {
            List<string> list = new List<string>();
            list.Add("1");
            list.Add("2");
            list.Add("3");
            list.Insert(2, "10");
            Assert.AreEqual(4, list.Count);
        }
        [TestMethod]
        public void InsertInListChar()
        {
            List<char> list = new List<char>();
            list.Add('1');
            list.Add('2');
            list.Add('3');
            list.Insert(2, '1');
            Assert.AreEqual(4, list.Count);
        }
        [TestMethod]
        public void InsertInListIntIndexLargerThanCountIndexLessThanZero()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Insert(-1, 10);
            list.Insert(4, 10);
            Assert.AreEqual(3, list.Count);
        }
        [TestMethod]
        public void InsertInListStringIndexLargerThanCountIndexLessThanZero()
        {
            List<string> list = new List<string>();
            list.Add("1");
            list.Add("2");
            list.Add("3");
            list.Insert(-1, "10");
            list.Insert(4, "10");
            Assert.AreEqual(3, list.Count);
        }
        [TestMethod]
        public void InsertInListCharIndexLargerThanCountIndexLessThanZero()
        {
            List<char> list = new List<char>();
            list.Add('1');
            list.Add('2');
            list.Add('3');
            list.Insert(-2, '1');
            list.Insert(4, '1');
            Assert.AreEqual(3, list.Count);
        }
        [TestMethod]
        public void ContainsListNumber()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            Assert.IsFalse(list.Contains(4));
            Assert.IsTrue(list.Contains(2));
        }
        [TestMethod]
        public void ContainsListString()
        {
            List<string> list = new List<string>();
            list.Add("1");
            list.Add("2");
            list.Add("3");
            Assert.IsFalse(list.Contains("4"));
            Assert.IsTrue(list.Contains("2"));
        }
        [TestMethod]
        public void ContainsListChar()
        {
            List<char> list = new List<char>();
            list.Add('1');
            list.Add('2');
            list.Add('3');
            Assert.IsFalse(list.Contains('4'));
            Assert.IsTrue(list.Contains('2'));
        }
        [TestMethod]
        public void GetEnumerator()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            int counter = 0;
            foreach (var item in list)
            {
                counter++;
            }
            Assert.AreEqual(3, counter);
        }
        [TestMethod]
        public void CopyTo()
        {
            List<int> list = new List<int>();
            list.Add(3);
            list.Add(2);
            list.Add(1);
            var newList = new int[] {1,2,3,4,5,6};
            list.CopyTo(newList, 3);
            int[] result = new int[] { 1, 2, 3, 3, 2, 1 };
            Assert.IsTrue(list.Compare(newList, result));
        }





 
    }

}
