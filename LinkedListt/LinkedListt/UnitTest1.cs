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
        public void ClearList()
        {
            ListaInlantuita list = new ListaInlantuita();
            list.Insert(1, 0);
            list.Insert(2, 1);
            list.Insert(3, 2);
            list.Insert(4, 3);
            list.Clear(4);
            list.Clear(3);
            Assert.AreEqual(2, list.Count());

        }
    }
}
