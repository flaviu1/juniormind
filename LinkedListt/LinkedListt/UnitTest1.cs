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
            ListaInlantuita list = new ListaInlantuita();
            list.Insert(1, 0);
            list.Insert(2, 1);
            list.Insert(3, 2);
            list.Insert(4, 3);
            Assert.AreEqual(4, list.Count());
        }
        [TestMethod]
        public void CleanList()
        {
            ListaInlantuita list = new ListaInlantuita();
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
            ListaInlantuita list = new ListaInlantuita();
            list.Insert(1, 0);
            list.Insert(2, 1);
            list.Insert(3, 2);
            list.Insert(4, 3);
            list.Clean(7);
            Assert.AreEqual(4, list.Count());
        }
    }
}
