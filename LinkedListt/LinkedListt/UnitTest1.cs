using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkedList
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InsertElementToList()
        {
            List<int> list = new List<int>();
            list.Insert(1, 0);
            list.Insert(2, 1);
            list.Insert(3, 2);
            list.Insert(4, 3);
            Assert.AreEqual(4, list.Count());
        }
        [TestMethod]
        public void CleanList()
        {
            List<int> list = new List<int>();
            list.Insert(1, 0);
            list.Insert(2, 1);
            list.Insert(3, 2);
            list.Insert(4, 3);
            list.Clean(4);
            list.Clean(3);
            Assert.AreEqual(2, list.Count());
        }
        [TestMethod]
        public void DeleteElementThatWasNotInTheList()
        {
            List<int> list = new List<int>();
            list.Insert(1, 0);
            list.Insert(2, 1);
            list.Insert(3, 2);
            list.Insert(4, 3); 
            list.Clean(7);
            Assert.AreEqual(4, list.Count());
        }
        [TestMethod]
        public void InsertElementCharToList()
        {
            List<char> list = new List<char>();
            list.Insert('a','\0');
            list.Insert('b', 'a');
            list.Insert('c', 'b');
            list.Insert('d', 'c');
            Assert.AreEqual(4, list.Count());
        }
        [TestMethod]
        public void CleanCharFromList()
        {
            List<char> list = new List<char>();
            list.Insert('a', '\0');
            list.Insert('b', 'a');
            list.Insert('c', 'b');
            list.Insert('d', 'c');
            list.Clean('a');
            list.Clean('b');
            Assert.AreEqual(2, list.Count());
        }
        [TestMethod]
        public void DeleteElementCharThatWasNotInTheList()
        {
            List<char> list = new List<char>();
            list.Insert('a', '\0');
            list.Insert('b', 'a');
            list.Insert('c', 'b');
            list.Insert('d', 'c');
            list.Clean('7');
            Assert.AreEqual(4, list.Count());
        } 
    }
}
