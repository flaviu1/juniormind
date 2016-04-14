using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShopyngCart
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
           var result=new Product("apple",15);
           var input = new Product("apple", 15);
           Assert.AreEqual(result,AddNedwProductWhenListIsEmpty("apple",15));
        }
    }   
}