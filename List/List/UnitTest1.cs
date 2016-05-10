using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace List
{
    [TestClass]
    public class UnitTest1
    {
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
            Assert.AreEqual(4, list.Count);
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
    }

}
