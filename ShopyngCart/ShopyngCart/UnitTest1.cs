﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShopyngCart
{
    [TestClass]
    public class UnitTest1
    {
        private ShoppingCart shophoppingCart;
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
            shophoppingCart.Add(b);
            Assert.IsTrue(shophoppingCart.CeckForProduct(a));
        }
        [TestMethod]
        public void testPriceOneProdut()
        {
            shophoppingCart = new ShoppingCart();
            shophoppingCart.Add(a);
            Assert.AreEqual(4, shophoppingCart.CalculateTheSumOfProducts());
        }
        [TestMethod]
        public void testSumProducts()
        {
            shophoppingCart = new ShoppingCart(); ;
            shophoppingCart.Add(a);
            shophoppingCart.Add(b);
            shophoppingCart.Add(c);
            shophoppingCart.Add(p);
            Assert.AreEqual(12, shophoppingCart.CalculateTheSumOfProducts());
        }
        [TestMethod]
        public void testCalculateTheAveragePrice()
        {
            shophoppingCart = new ShoppingCart(); ;
            shophoppingCart.Add(a);
            shophoppingCart.Add(b);
            shophoppingCart.Add(c);
            shophoppingCart.Add(p);
            Assert.AreEqual(3, shophoppingCart.CalculateTheAveragePrice());
        }
        [TestMethod]
        public void testTheCheapestProduct()
        {
            shophoppingCart = new ShoppingCart(); 
            shophoppingCart.Add(a);
            shophoppingCart.Add(b);
            shophoppingCart.Add(c);
            shophoppingCart.Add(p);
            Assert.AreEqual("orange", shophoppingCart.TheCheapestProduct());
        }
        [TestMethod]
        public void testLookingForTheMostMxpensiveProduct()
        {
            shophoppingCart = new ShoppingCart();
            shophoppingCart.Add(new Product("appel", 4));
            shophoppingCart.Add(new Product("orange", 1));
            shophoppingCart.Add(new Product("sugar", 3));
            shophoppingCart.Add(new Product("a", 5));
            Assert.AreEqual(3, shophoppingCart.LookingForTheMostMxpensiveProduct());
        }
        [TestMethod]
        public void testRemoveElementAtPositionX() 
        {
            shophoppingCart = new ShoppingCart();
            shophoppingCart.Add(new Product("appel", 4));
            shophoppingCart.Add(new Product("orange", 1));
            shophoppingCart.Add(new Product("sugar", 3));
            shophoppingCart.Add(new Product("a", 5));
            ShoppingCart newCart;
            newCart=new ShoppingCart();
            newCart.Add(new Product("appel", 4));
            newCart.Add(new Product("sugar", 3));
            newCart.Add(new Product("a", 5));
            Assert.AreEqual(newCart,shophoppingCart.RemoveElementAtPositionX(1));
        }
    } 
}