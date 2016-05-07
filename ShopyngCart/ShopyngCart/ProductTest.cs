using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ShopyngCart
{
    [TestClass]
    public class UnitTest3
    {
        Product[] products = new Product[0];
        [TestMethod]
        public void testCompareProduct()
        {
            Product a = new Product("appel", 4);
            Product b = new Product("orange", 1);
            Assert.AreEqual(-1, a.CompareProduct(b));
            Assert.AreEqual(1, b.CompareProduct(a));
            Assert.AreEqual(0, b.CompareProduct(b));
        }
        [TestMethod]
        public void SumProducts()
        {
            Product a = new Product("appel", 4);
            Product b = new Product("orange", 1);
            int x = 10;
            Assert.AreEqual(14, a.Sum(ref x));
        }
        [TestMethod]
        public void QuantityAndPrice()
        {
            Product a = new Product("appel", 4, 2);
            Assert.AreEqual(8, a.QuantityAndPrice());
        }
    }
}

