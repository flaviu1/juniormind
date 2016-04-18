using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShopyngCart
{
    [TestClass]
    public class UnitTest1
    {
        private ShoppingCart shophoppingCart;
        private Product product;

        private Product[] products;
        Product a = new Product("appel", 4);
        Product b = new Product("orange", 1);
        Product c = new Product("sugar", 3);
        Product p = new Product("a", 4); 
        
        [TestMethod]
        public void testAddProduct()
        {
            shophoppingCart = new ShoppingCart();
            a = new Product("Orange", 4);
            shophoppingCart.Add(a);
            Assert.IsTrue(shophoppingCart.CeckForProduct(a));
        }

        [TestMethod]
        public void testPriceOneProdut()
        {
            shophoppingCart = new ShoppingCart();
            shophoppingCart.Add(new Product("appel", 4));
            Assert.AreEqual(4, shophoppingCart.CalculateTheSumOfProducts());
        }

        [TestMethod]
        public void testSumProducts()
        {
            ShoppingCart[] shophoppingCart = new ShoppingCart[]{};
            //shophoppingCart.
            //shophoppingCart.Add(new Product("appel", 4));
           // Assert.AreEqual(4, shophoppingCart.CalculateTheSumOfProducts());
        }
    } 
}