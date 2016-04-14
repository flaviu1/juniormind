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
           var result=new Product();
           result.name = "apple";
           result.price = 15;
           var input = new Product();
           input.name = "apple";
           input.price = 15;
           Assert.AreEqual(result, Product.AddNedwProductWhenListIsEmpty(input.name,input.price));
        }
    }   
}