using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShopyngCart
{
    [TestClass]
    public class UnitTest1
    {
        private ShoppingCart shophoppingCart;
        private Product product;

        /*private Product[] products;
        Product a = new Product("appel", 4);
        Product b = new Product("orange", 1);
        Product c = new Product("sugar", 3);
        Product p = new Product("a", 4); 
        */
        [TestMethod]
        public void testAddProduct()
        {
            shophoppingCart = new ShoppingCart();
            product = new Product("Orange", 4);
            shophoppingCart.Add(product);
            Assert.IsTrue(shophoppingCart.ceckForProduct(product));
        }

        [TestMethod]
        public void testSummOfProduct()
        {
            shophoppingCart = new ShoppingCart();
            product = new Product("appel", 4);
            shophoppingCart.Add(product);
            Assert.AreEqual(4,shophoppingCart.CalculateTheSumOfProducts());
        }
    } 
}