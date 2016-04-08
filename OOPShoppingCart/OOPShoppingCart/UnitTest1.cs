using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OOPShoppingCart
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddNewProduct()
        {
            Product[] x = new Product[] {new Product("apple", 15)};
            Product[] products = new Product[] { new Product("apple", 15) };
            string name = "apple";
            decimal price = 15;
            CollectionAssert.AreEqual(x, Product.AddNewProduct(products,name, price));
        }
    }
}
 