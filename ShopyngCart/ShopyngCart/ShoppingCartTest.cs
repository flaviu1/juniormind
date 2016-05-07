using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ShopyngCart
{
    [TestClass]
    public class UnitTest2
    {
        private ShoppingCart shoppingCart;
        Product[] products = new Product[0];

        [TestMethod]
        public void IEnumerableOnShoppingCart()
        {
            shoppingCart = new ShoppingCart();
            shoppingCart.Add(new Product("appel", 4));
            shoppingCart.Add(new Product("orange", 1));
            shoppingCart.Add(new Product("sugar", 7));
            shoppingCart.Add(new Product("a", 5));
            int counter = 0;
            foreach (var product in shoppingCart)
            {
                counter++;
            }
            Assert.AreEqual(4, counter);
        }
        [TestMethod]
        public void testAddProduct()
        {
            Product a = new Product("appel", 4);
            Product b = new Product("orange", 1);
            shoppingCart = new ShoppingCart();
            shoppingCart.Add(a);
            Assert.IsTrue(shoppingCart.CheckForProduct(a));
            Assert.IsFalse(shoppingCart.CheckForProduct(b));
        }
        [TestMethod]
        public void testPriceOneProdut()
        {
            shoppingCart = new ShoppingCart();
            Product a = new Product("appel", 4);
            shoppingCart.Add(new Product("appel", 4));
            Assert.AreEqual(4, shoppingCart.CalculateTheSumOfProducts());
        }
        [TestMethod]
        public void testSumProducts()
        {
            shoppingCart = new ShoppingCart(); ;
            Product a = new Product("appel", 4);
            Product b = new Product("orange", 1);
            Product c = new Product("sugar", 3);
            shoppingCart.Add(new Product("appel", 4));
            shoppingCart.Add(new Product("orange", 1));
            shoppingCart.Add(new Product("sugar", 3));
            Assert.AreEqual(8, shoppingCart.CalculateTheSumOfProducts());
        }
        [TestMethod]
        public void testCalculateTheAveragePrice()
        {
            shoppingCart = new ShoppingCart(); ;
            shoppingCart.Add(new Product("appel", 4));
            shoppingCart.Add(new Product("orange", 4));
            shoppingCart.Add(new Product("sugar", 4));
            Assert.AreEqual(4, shoppingCart.CalculateTheAveragePrice());
        }
        [TestMethod]
        public void testTheCheapestProduct()
        {
            shoppingCart = new ShoppingCart();
            shoppingCart = new ShoppingCart(); ;
            shoppingCart.Add(new Product("appel", 4));
            shoppingCart.Add(new Product("orange", 6));
            shoppingCart.Add(new Product("sugar", 7));
            ShoppingCart x = new ShoppingCart();
            x.Add(shoppingCart.TheCheapestProduct());
            Assert.AreEqual(4, x.CalculateTheSumOfProducts());
        }
        [TestMethod]
        public void testLookingForTheMostExpensiveProduct()
        {
            shoppingCart = new ShoppingCart();
            shoppingCart.Add(new Product("appel", 4));
            shoppingCart.Add(new Product("orange", 1));
            shoppingCart.Add(new Product("sugar", 7));
            shoppingCart.Add(new Product("a", 5));
            Assert.AreEqual(2, shoppingCart.FindMostExpensive());
        }
        [TestMethod]
        public void testRemoveElementAtPositionX()
        {
            shoppingCart = new ShoppingCart();
            shoppingCart.Add(new Product("appel", 4));
            shoppingCart.Add(new Product("orange", 1));
            shoppingCart.Add(new Product("sugar", 1));
            shoppingCart.Add(new Product("a", 5));
            shoppingCart.RemoveElementAtPositionX(1);
            Assert.AreEqual(10, shoppingCart.CalculateTheSumOfProducts());
        }
    }
}

