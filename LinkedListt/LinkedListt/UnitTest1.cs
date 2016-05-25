using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkedList
{
    [TestClass]
    public class UnitTest1
    {
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
            string result = myList1.TheLastItemInTheList();
            Assert.IsTrue(result.Equals("x"));
        }

        [TestMethod]
        public void AddLastInEmptyList()
        {
            LinkedList<string> myList1 = new LinkedList<string>();
            myList1.AddLast("x");
            string result = myList1.TheLastItemInTheList();
            Assert.IsTrue(result.Equals("x"));
        }

        [TestMethod]
        public void RemoveLikedList()
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
            myList1.AddFirst("a");
            myList1.AddLast("x");
            Assert.AreEqual(2, myList1.EachListContainsElements());
            myList1.AddLast("e");
            Assert.AreEqual(3, myList1.EachListContainsElements());
        }

        [TestMethod]
        public void InsertElementCharToList()
        {
            LinkedList<string> myList1 = new LinkedList<string>();
            myList1.AddFirst("a");
            myList1.AddFirst("b");
            myList1.AddFirst("c");
            myList1.AddAfter("x", "a");
            string result = myList1.TheLastItemInTheList();
            Assert.IsTrue(result.Equals("x"));
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
        public void RemoveLast()
        {
            LinkedList<string> myList1 = new LinkedList<string>();
            myList1.AddLast("a");
            myList1.AddLast("b");
            myList1.AddLast("c");
            myList1.AddLast("d");
            myList1.AddLast("e");
            myList1.AddLast("f");
            myList1.Remove("f");
            string result=myList1.TheLastItemInTheList();
            Assert.IsTrue(result.Equals("e"));     
        }

    }
}
