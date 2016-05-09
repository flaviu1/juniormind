using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ImplementIList
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void AddList()
        {
            List list = new List();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(3);
            Assert.AreEqual(4, list.Count);
        }
        [TestMethod]
        public void IndexOf()
        {
            List list = new List();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            Assert.AreEqual(1, list.IndexOf(2));
        }
        [TestMethod]
        public void Clear()
        {
            List list = new List();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Clear();
            Assert.AreEqual(0, list.Count);
        }
        [TestMethod]
        public void RemoveAt()
        {
            List list = new List();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.RemoveAt(1);
            Assert.AreEqual(2, list.Count);
        }
        [TestMethod]
        public void Insert()
        {
            List list = new List();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Insert(2, 10);
            Assert.AreEqual(4, list.Count);
        }
        [TestMethod]
        public void Contains()
        {
            List list = new List();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            Assert.IsFalse(list.Contains(4));
            Assert.IsTrue(list.Contains(2));
        }
        [TestMethod]
        public void CopyTo()
        {
            List list = new List();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            int[] a = new int[] { };
            list.CopyTo(a, 0);
            Assert.AreEqual(6, a.Length);

        }


    }
}
