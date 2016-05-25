using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DoubleChainedLists
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ListIsEmpty()
        {
            List<int> list = new List<int>();
            Assert.AreEqual(0, list.Count());
        }
        [TestMethod]
        public void Insert()
        {
            List<int> list = new List<int>();
            list.Insert(1, 0);
            list.Insert(2, 1);
            list.Insert(3, 2);
            list.Insert(4, 3);
            Assert.AreEqual(4, list.Count());
        }
        [TestMethod]
        public void ReturnElementPositionX()
        {
            List<int> list = new List<int>();
            list.Insert(1, 0);
            list.Insert(2, 1);
            list.Insert(3, 2);
            list.Insert(4, 3);
            Assert.AreEqual(3, list.ReturnElementposition(3,list.Count()));
        }
        [TestMethod]
        public void ClearElementToList()
        {
            List<int> list = new List<int>();
            list.Insert(1, 0);
            list.Insert(2, 1);
            list.Insert(3, 2);
            list.Insert(4, 3);
            list.Clear(3);
            Assert.AreEqual(4,list.ReturnElementposition(3,list.Count()));            
        }
        [TestMethod]
        public void ListIsEmptyChar()
        {
            List<char> list = new List<char>();
            Assert.AreEqual(0, list.Count());
        }
        [TestMethod]
        public void InsertCharToList()
        {
            List<char> list = new List<char>();
            list.Insert('1', '\0');
            list.Insert('2', '1');
            list.Insert('3', '2');
            list.Insert('4', '3');
            Assert.AreEqual(4, list.Count());
        }
        [TestMethod]
        public void ReturnCharPositionX()
        {
            List<char> list = new List<char>();
            list.Insert('1','\0');
            list.Insert('2', '1');
            list.Insert('3', '2');
            list.Insert('4', '3');
            Assert.AreEqual('3',list.ReturnElementposition(3,list.Count()));
        }
        [TestMethod]
        public void ClearCharToList()
        {
            List<char> list = new List<char>();
            list.Insert('1', '\0');
            list.Insert('2', '1');
            list.Insert('3', '2');
            list.Insert('4', '3');
            list.Clear('2');
            Assert.AreEqual('4', list.ReturnElementposition(4, list.Count()));
        }
    }
}
