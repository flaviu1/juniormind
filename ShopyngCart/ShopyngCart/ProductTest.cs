using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ShopyngCart
{
    [TestClass]
    public class UnitTest3
    {

        private ShoppingCart shoppingCart;
        [TestMethod]
        public void testCompareProduct()
        {
            Product a = new Product("appel", 4);
            Product b = new Product("orange", 1);
            Assert.AreEqual(-1, a.CompareProduct(b));
            Assert.AreEqual(1, b.CompareProduct(a));
            Assert.AreEqual(0, b.CompareProduct(b));
        }
    }
}

