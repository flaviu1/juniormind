using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkedList
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ListIsEmpty()
        {
            LinkedList<int> list = new LinkedList<int>();
            Assert.AreEqual(0, list.Count);
        }

        [TestMethod]
        public void AddFirstWhenListIsEempty()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(2);
            Assert.AreEqual(2, list.FierstElement().value);
        }

        [TestMethod]
        public void AddFirstIntElement()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(2);
            list.AddFirst(4);
            Assert.AreEqual(4, list.FierstElement().value);
            Assert.AreEqual(2, list.Count);
        }

        [TestMethod]
        public void AddFirst()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddFirst("a");
            list.AddFirst("b");
            list.AddFirst("c");
            string a = list.FierstElement().value;
            Assert.IsTrue(a.Equals("c"));
        }

        [TestMethod]
        public void AddLastInListWhitThreeElements()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddLast("a");
            list.AddLast("x");
            Assert.AreEqual("x", list.LastElement().value);
        }

        [TestMethod]
        public void AddLastInEmptyList()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddLast("x");
            Assert.AreEqual("x", list.LastElement().value);
        }

        [TestMethod]
        public void AddLastAEmptiListOfEmptListofTypeIsInt()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(1);
            Assert.AreEqual(1, list.LastElement().value);
        }

        [TestMethod]
        public void CleanLikedList()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddFirst("a");
            list.AddFirst("b");
            list.AddFirst("c");
            list.AddLast("d");
            list.AddLast("x");
            list.Clean();
            Assert.AreEqual(0, list.Count);
        }

        [TestMethod]
        public void CleanEmptyList()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.Clean();
            Assert.AreEqual(0, list.Count);
        }

        [TestMethod]
        public void AddAfterWhenExistOneElement()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddFirst("a");
            list.AddFirst("b");
            list.AddFirst("c");
            list.AddAfter("x", "a");
            Assert.AreEqual(4, list.Count);
            Assert.AreEqual("x", list.LastElement().value);
            list.AddFirst("c");
            Assert.AreEqual(5, list.Count);

        }

        [TestMethod]
        public void AddAfterWhenlistIsEmpty()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddAfter("b", "e");
            Assert.IsFalse(list.Find("b"));
            list.AddFirst("a");
            list.AddAfter("x", "a");
            Assert.AreEqual("x", list.LastElement().value);
        }

        [TestMethod]
        public void IEnumerator()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddFirst("a");
            list.AddFirst("b");
            list.AddFirst("c");
            list.AddFirst("d");
            list.AddFirst("e");
            list.AddFirst("f");
            int counter = 0;
            foreach (var item in list)
            {
                counter++;
            }

            Assert.AreEqual(6, counter);
        }

        [TestMethod]
        public void RemoveNumbersTheListIfTheListContainsSeveralIdenticalNumbers()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddFirst("a");
            list.AddFirst("b");
            list.AddFirst("c");
            list.AddFirst("a");
            list.AddFirst("b");
            list.AddFirst("c");
            int counter = 0;
            foreach (var item in list)
            {
                counter++;
            }
            Assert.AreEqual(6, counter);
        }

        [TestMethod]
        public void Remove()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddLast("a");
            list.AddLast("b");
            list.AddLast("c");
            list.AddLast("d");
            list.AddLast("e");
            list.AddLast("f");
            list.Remove("b");
            list.Remove("c");
            list.Remove("d");
            int counter = 0;
            foreach (var item in list)
                counter++;
            Assert.AreEqual(3, counter);
        }

        [TestMethod]
        public void RemoveFirst()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddFirst("f");
            list.AddLast("a");
            list.AddLast("b");
            list.AddLast("c");
            list.AddLast("d");
            list.AddLast("e");
            list.RemoveFirst();
            Assert.AreEqual("a", list.FierstElement().value);
            int counter = 0;
            foreach (var item in list)
            {
                counter++;
            }
            Assert.AreEqual(5, counter);
        }

        [TestMethod]
        public void RemoveLast()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddLast("a");
            list.AddLast("b");
            list.AddLast("c");
            list.AddLast("d");
            list.AddLast("e");
            list.AddLast("f");
            list.RemoveLast();
            Assert.AreEqual("e", list.LastElement().value);
        }

        [TestMethod]
        public void MyTestMethod()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.Remove("s");
        }

        [TestMethod]
        public void Find()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddLast("a");
            list.AddLast("b");
            list.AddLast("c");
            list.AddLast("d");
            list.AddLast("e");
            list.AddLast("f");
            Assert.IsFalse(list.Find("x"));
            Assert.IsTrue(list.Find("a"));
            Assert.IsTrue(list.Find("f"));
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

            Assert.AreEqual("f", myList1.FindLast().value);
        }

        [TestMethod]
        public void FindLastListIsEmpty()
        {
            LinkedList<string> list = new LinkedList<string>();
            Assert.AreEqual(null, list.FindLast().value);
        }

        [TestMethod]
        public void RemoveLastListIsEmpty()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.RemoveLast();
            Assert.AreEqual(0, list.Count);
        }

        [TestMethod]
        public void RemoveFirstListIsEmpty()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.RemoveFirst();
            Assert.AreEqual(0, list.Count);
        }

        [TestMethod]
        public void RemoveFirstListContainsWoneElement()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddFirst("1");
            list.RemoveFirst();
            Assert.AreEqual(0, list.Count);
        }
    }
}