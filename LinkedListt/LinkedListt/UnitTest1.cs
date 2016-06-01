using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkedList
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddFirstIntElement()
        {
            LinkedList<int> myList1 = new LinkedList<int>();
            myList1.AddFirst(2);
            myList1.AddFirst(2);
            myList1.AddFirst(2);
            Assert.IsTrue(myList1.FierstElement().Equals(2));
        }
        [TestMethod]
        public void AddFirst()
        {
            LinkedList<string> myList1 = new LinkedList<string>();
            myList1.AddFirst("a");
            myList1.AddFirst("b");
            myList1.AddFirst("c");
            string a = myList1.FierstElement();
            Assert.IsTrue(a.Equals("c"));
        }

        [TestMethod]
        public void AddLastInListWhitThreeElements()
        {
            LinkedList<string> myList1 = new LinkedList<string>();
            myList1.AddFirst("a");
            myList1.AddFirst("b");
            myList1.AddFirst("c");
            myList1.AddLast("d");
            myList1.AddLast("x");
            string result = myList1.FindLast();
            Assert.IsTrue(result.Equals("x"));
        }

        [TestMethod]
        public void AddLastInEmptyList()
        {
            LinkedList<string> myList1 = new LinkedList<string>();
            myList1.AddLast("x");
            Assert.IsTrue(myList1.FindLast().Equals("x"));
        }

        [TestMethod]
        public void CleanLikedList()
        {
            LinkedList<string> myList1 = new LinkedList<string>();
            myList1.AddFirst("a");
            myList1.AddFirst("b");
            myList1.AddFirst("c");
            myList1.AddLast("d");
            myList1.AddLast("x");
            myList1.Clean();
            Assert.AreEqual(0, myList1.EachListContainsElements());
        }

        [TestMethod]
        public void EachListContainsElements()
        {
            LinkedList<string> myList1 = new LinkedList<string>();
            myList1.AddFirst("x");
            myList1.AddLast("e");
            int counter = 0;
            foreach (var item in myList1)
            {
                counter++;
            }
            Assert.AreEqual(2, counter);
        }

        [TestMethod]
        public void AddAfter()
        {
            LinkedList<string> myList1 = new LinkedList<string>();
            myList1.AddFirst("a");
            myList1.AddAfter("b", "a");
            myList1.AddAfter("c", "b");
            myList1.AddAfter("x", "c");
            Assert.IsTrue(myList1.Find("x"));
        }
        [TestMethod]
        public void AddAfterWhenlistIsEmpty()
        {
            LinkedList<string> myList1 = new LinkedList<string>();
            myList1.AddAfter("b", "e");
            Assert.IsFalse(myList1.Find("b"));
            myList1.AddFirst("a");
            myList1.AddAfter("x", "a");
            Assert.IsTrue(myList1.Find("x"));
        }

        [TestMethod]
        public void IEnumerator()
        {
            LinkedList<string> myList1 = new LinkedList<string>();
            myList1.AddFirst("a");
            myList1.AddFirst("b");
            myList1.AddFirst("c");
            myList1.AddFirst("a");
            myList1.AddFirst("b");
            myList1.AddFirst("c");
            int counter = 0;
            foreach (var item in myList1)
            {
                counter++;
            }
            Assert.AreEqual(6, counter);
        }
        [TestMethod]
        public void AddLastWhenLIstIseMPTY()
        {
            LinkedList<string> myList1 = new LinkedList<string>();
            myList1.AddLast("a");
            string result = myList1.FierstElement();
            Assert.IsTrue(result.Equals("a"));

        }
        [TestMethod]
        public void Remove()
        {
            LinkedList<string> myList1 = new LinkedList<string>();
            myList1.AddLast("a");
            myList1.AddLast("b");
            myList1.AddLast("c");
            myList1.AddLast("d");
            myList1.AddLast("e");
            myList1.AddLast("f");
            myList1.Remove("b");
            myList1.Remove("c");
            myList1.Remove("d");
            myList1.Remove("d");
            int counter = 0;
            foreach (var item in myList1)
                counter++;
            Assert.AreEqual(3, counter);
        }
        [TestMethod]
        public void RemoveFirst()
        {
            LinkedList<string> myList1 = new LinkedList<string>();
            myList1.AddFirst("f");
            myList1.AddLast("a");
            myList1.AddLast("b");
            myList1.AddLast("c");
            myList1.AddLast("d");
            myList1.AddLast("e");
            myList1.RemoveFirst();
            myList1.RemoveFirst();
            Assert.IsFalse(myList1.FierstElement().Equals("f"));
            Assert.IsFalse(myList1.FierstElement().Equals("a"));
            Assert.IsTrue(myList1.FierstElement().Equals("b"));
            int counter = 0;
            foreach (var item in myList1)
            {
                counter++;
            }
            Assert.AreEqual(4, counter);
        }
        [TestMethod]
        public void RemoveLast()
        {
            LinkedList<string> myList1 = new LinkedList<string>();
            myList1.AddLast("a");
            myList1.AddLast("b");
            myList1.AddLast("c");
            myList1.AddLast("d");
            myList1.AddLast("e");
            myList1.AddLast("f");
            myList1.RemoveLast();
            Assert.IsFalse(myList1.FindLast().Equals("f"));
            Assert.IsTrue(myList1.FindLast().Equals("e"));
        }
        [TestMethod]
        public void Find()
        {
            LinkedList<string> myList1 = new LinkedList<string>();
            myList1.AddLast("a");
            myList1.AddLast("b");
            myList1.AddLast("c");
            myList1.AddLast("d");
            myList1.AddLast("e");
            myList1.AddLast("f");
            Assert.IsFalse(myList1.Find("x"));
            Assert.IsTrue(myList1.Find("a"));
            Assert.IsTrue(myList1.Find("f"));
        }
        [TestMethod]
        public void FindLast()
        {
            LinkedList<string> myList1 = new LinkedList<string>();
            myList1.AddLast("a");
            myList1.AddLast("b");
            myList1.AddLast("c");
            myList1.AddLast("d");
            myList1.AddLast("e");
            myList1.AddLast("f");
            Assert.IsFalse(myList1.FindLast().Equals("x"));
            Assert.IsTrue(myList1.FindLast().Equals("f"));
        }
    }
}
