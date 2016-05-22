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
            List list = new List();
            Assert.AreEqual(0, list.Count());
        }
        [TestMethod]
        public void Insert()
        {
            List list = new List();
            list.Insert(1, 0);
            list.Insert(2, 1);
            list.Insert(3, 2);
            list.Insert(4, 3);
            Assert.AreEqual(4, list.Count());
        }
        [TestMethod]
        public void ReturnElementPositionX()
        {
            List list = new List();
            list.Insert(1, 0);
            list.Insert(2, 1);
            list.Insert(3, 2);
            list.Insert(4, 3);
            Assert.AreEqual(3, list.ReturnElementposition(3,list.Count()));
        }
        [TestMethod]
        public void ClearElementToList()
        {
            List list = new List();
            list.Insert(1, 0);
            list.Insert(2, 1);
            list.Insert(3, 2);
            list.Insert(4, 3);
            list.Clear(3);
            Assert.AreEqual(4,list.ReturnElementposition(3,list.Count()));            
        }
    }
}
