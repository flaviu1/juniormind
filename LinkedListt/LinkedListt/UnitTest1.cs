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
            LinkedList<int> List = new LinkedList<int>();
            Assert.AreEqual(0, List.Count);
        }
        [TestMethod]
        public void AddFirstWhenListIsEempty()
        {
            LinkedList<int> myList = new LinkedList<int>();
            myList.AddFirst(2);
            myList.AddFirst(3);
            myList.AddFirst(4);
            Assert.IsTrue(myList.FierstElement().Equals(4));
        }
        //[TestMethod]
        //public void AddFirstIntElement()
        //{
        //    LinkedList<int> myList1 = new LinkedList<int>();
        //    myList1.AddFirst(2);
        //    myList1.AddFirst(3);
        //    myList1.AddFirst(4);
        //    Assert.IsTrue(myList1.FierstElement().Equals(4));
        //}
        //[TestMethod]
        //public void AddFirst()
        //{
        //    LinkedList<string> myList1 = new LinkedList<string>();
        //    myList1.AddFirst("a");
        //    myList1.AddFirst("b");
        //    myList1.AddFirst("c");
        //    string a = myList1.FierstElement();
        //    Assert.IsTrue(a.Equals("c"));
        //}

        //[TestMethod]
        //public void AddLastInListWhitThreeElements()
        //{
        //    LinkedList<string> myList1 = new LinkedList<string>();
        //    myList1.AddFirst("a");
        //    myList1.AddFirst("b");
        //    myList1.AddFirst("c");
        //    myList1.AddLast("d");
        //    myList1.AddLast("x");
            
        //    Node<string> result = myList1.FindLast();
        //    Assert.AreEqual("x",result.valueNext);
        //}

        //[TestMethod]
        //public void AddLastInEmptyList()
        //{
        //    LinkedList<string> myList1 = new LinkedList<string>();
        //    myList1.AddLast("x");
        //    Node<string> result = myList1.FindLast();
        //    Assert.AreEqual("x", result.valueNext);
        //}
        //[TestMethod]
        //public void AddLastAEmptiListOfEmptListofTypeIsInt()
        //{
        //    LinkedList<int> myList1 = new LinkedList<int>();
        //    myList1.AddLast(1);
        //    Node<int> result = myList1.FindLast();
        //    Assert.AreEqual(1, result.valueNext);
        //}

        //[TestMethod]
        //public void CleanLikedList()
        //{
        //    LinkedList<string> myList1 = new LinkedList<string>();
        //    myList1.AddFirst("a");
        //    myList1.AddFirst("b");
        //    myList1.AddFirst("c");
        //    myList1.AddLast("d");
        //    myList1.AddLast("x");
        //    myList1.Clean();
        //    Assert.AreEqual(0, myList1.Count);
        //}
        //[TestMethod]
        //public void CleanEmptyList()
        //{
        //    LinkedList<string> myList1 = new LinkedList<string>();
        //    myList1.Clean();
        //    Assert.AreEqual(0, myList1.Count);
        //}

        //[TestMethod]
        //public void AddAfterWhenExistOneElement()   
        //{
        //    LinkedList<string> myList1 = new LinkedList<string>();
        //    myList1.AddFirst("a");
        //    myList1.AddAfter("b", "a");
        //    myList1.AddAfter("c", "b");
        //    myList1.AddAfter("x", "c");
        //    Assert.IsTrue(myList1.Find("x"));
        //}
        //[TestMethod]
        //public void AddAfterWhenlistIsEmpty()
        //{
        //    LinkedList<string> myList1 = new LinkedList<string>();
        //    myList1.AddAfter("b", "e");
        //    Assert.IsFalse(myList1.Find("b"));
        //    myList1.AddFirst("a");
        //    myList1.AddAfter("x", "a");
        //    Assert.IsTrue(myList1.Find("x"));
        //}
 
        //[TestMethod]
        //public void IEnumerator()
        //{
        //    LinkedList<string> myList1 = new LinkedList<string>();
        //    myList1.AddFirst("a");
        //    myList1.AddFirst("b");
        //    myList1.AddFirst("c");
        //    myList1.AddFirst("a");
        //    myList1.AddFirst("b");
        //    myList1.AddFirst("c");
        //    int counter = 0;
        //    foreach (var item in myList1)
        //    {
        //        counter++;
        //    }
        //    Assert.AreEqual(6, counter);
        //}
        //[TestMethod]
        //public void RemoveNumbersTheListIfTheListContainsSeveralIdenticalNumbers()
        //{
        //    LinkedList<string> myList1 = new LinkedList<string>();
        //    myList1.AddFirst("a");
        //    myList1.AddFirst("b");
        //    myList1.AddFirst("c");
        //    myList1.AddFirst("a");
        //    myList1.AddFirst("b");
        //    myList1.AddFirst("c");
        //    int counter = 0;
        //    foreach (var item in myList1)
        //    {
        //        counter++;
        //    }
        //    Assert.AreEqual(6, counter);
        //}
 
        //[TestMethod]
        //public void Remove()
        //{
        //    LinkedList<string> myList1 = new LinkedList<string>();
        //    myList1.AddLast("a");
        //    myList1.AddLast("b");
        //    myList1.AddLast("c");
        //    myList1.AddLast("d");
        //    myList1.AddLast("e");
        //    myList1.AddLast("f");
        //    myList1.Remove("b");
        //    myList1.Remove("c");
        //    myList1.Remove("d");
        //    myList1.Remove("d");
        //    int counter = 0;
        //    foreach (var item in myList1)
        //        counter++;
        //    Assert.AreEqual(3, counter);
        //}
        //[TestMethod]
        //public void RemoveFirst()
        //{
        //    LinkedList<string> myList1 = new LinkedList<string>();
        //    myList1.AddFirst("f");
        //    myList1.AddLast("a");
        //    myList1.AddLast("b");
        //    myList1.AddLast("c");
        //    myList1.AddLast("d");
        //    myList1.AddLast("e");
        //    myList1.RemoveFirst();
        //    myList1.RemoveFirst();
        //    Assert.IsFalse(myList1.FierstElement().Equals("f"));
        //    Assert.IsFalse(myList1.FierstElement().Equals("a"));
        //    Assert.IsTrue(myList1.FierstElement().Equals("b"));
        //    int counter = 0;
        //    foreach (var item in myList1)
        //    {
        //        counter++;
        //    }
        //    Assert.AreEqual(4, counter);
        //}
        //[TestMethod]
        //public void RemoveLast()
        //{
        //    LinkedList<string> myList1 = new LinkedList<string>();
        //    myList1.AddLast("a");
        //    myList1.AddLast("b");
        //    myList1.AddLast("c");
        //    myList1.AddLast("d");
        //    myList1.AddLast("e");
        //    myList1.AddLast("f");
        //    myList1.RemoveLast();
        //    Node<string> result = myList1.FindLast();
        //    Assert.AreEqual("e", result.valueNext);
        //}

        //[TestMethod]
        //public void MyTestMethod()
        //{
        //    LinkedList<string> myList1 = new LinkedList<string>();
        //    myList1.Remove("s");
        //}
        //[TestMethod]
        //public void Find()
        //{
        //    LinkedList<string> myList1 = new LinkedList<string>();
        //    myList1.AddLast("a");
        //    myList1.AddLast("b");
        //    myList1.AddLast("c");
        //    myList1.AddLast("d");
        //    myList1.AddLast("e");
        //    myList1.AddLast("f");
        //    Assert.IsFalse(myList1.Find("x"));
        //    Assert.IsTrue(myList1.Find("a"));
        //    Assert.IsTrue(myList1.Find("f"));
        //}
        //[TestMethod]
        //public void FindLast()
        //{
        //    LinkedList<string> myList1 = new LinkedList<string>();
        //    myList1.AddLast("a");
        //    myList1.AddLast("b");
        //    myList1.AddLast("c");
        //    myList1.AddLast("d");
        //    myList1.AddLast("e");
        //    myList1.AddLast("f");
        //    Node<string> result = myList1.FindLast();
        //    Assert.AreEqual("f", result.valueNext);
        //}
        //[TestMethod]
        //public void FindLastListIsEmpty()
        //{
        //    LinkedList<string> myList1 = new LinkedList<string>();
        //    Node<string> result = myList1.FindLast();
        //    Assert.AreEqual(null, result.valueNext);
        //}
        //[TestMethod]
        //public void RemoveLastListIsEmpty()
        //{
        //    LinkedList<string> myList1 = new LinkedList<string>();
        //    myList1.RemoveLast();
        //    Assert.AreEqual(0, myList1.Count);
        //}
        //[TestMethod]
        //public void RemoveFirstListIsEmpty()
        //{
        //    LinkedList<string> myList1 = new LinkedList<string>();
        //    myList1.RemoveFirst();
        //    Assert.AreEqual(0, myList1.Count);
        //}
        //[TestMethod]
        //public void RemoveFirstListContainsWoneElement()
        //{
        //    LinkedList<string> myList1 = new LinkedList<string>();
        //    myList1.AddFirst("1");
        //    myList1.RemoveFirst();
        //    Assert.AreEqual(0, myList1.Count);
        //}
    }
}