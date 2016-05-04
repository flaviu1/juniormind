using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;


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
        ProductRepository stock;
        List<Product> list = new List<Product>();

        [TestMethod]
        public void HowManyProducts()
        {
            stock = new ProductRepository();
            list = stock.ListProduct();
            Assert.AreEqual(11, list.Count);
        }










        [TestMethod]
        public void testAddProduct()
        {
            shophoppingCart = new ShoppingCart();
            shophoppingCart.Add(a);
            shophoppingCart.Add(b);
            Assert.IsTrue(shophoppingCart.CheckForProduct(a));
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
            shophoppingCart.Add(new Product("sugar", 7));
            shophoppingCart.Add(new Product("a", 5));
            Assert.AreEqual(2, shophoppingCart.LookingForTheMostMxpensiveProduct());
        }
        [TestMethod]
        public void testRemoveElementAtPositionX()
        {
            shophoppingCart = new ShoppingCart();
            shophoppingCart.Add(new Product("appel", 4));
            shophoppingCart.Add(new Product("orange", 1));
            shophoppingCart.Add(new Product("sugar", 1));
            shophoppingCart.Add(new Product("a", 5));
            shophoppingCart.RemoveElementAtPositionX(1);
            Assert.AreEqual(10, shophoppingCart.CalculateTheSumOfProducts());
        }
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
        public void testReset()
        {
            shophoppingCart = new ShoppingCart();
            shophoppingCart.Add(new Product("appel", 4));
            shophoppingCart.Add(new Product("orange", 1));
            shophoppingCart.Add(new Product("sugar", 7));
            shophoppingCart.Add(new Product("a", 5));
            //shophoppingCart.Reset();
            // Assert.AreEqual(0, shophoppingCart.CalculateTheSumOfProducts());
        }
        [TestMethod]
        public void testCurrent()
        {
            shophoppingCart = new ShoppingCart();
            shophoppingCart.Add(new Product("appel", 4));
            shophoppingCart.Add(new Product("orange", 1));
            shophoppingCart.Add(new Product("sugar", 7));
            shophoppingCart.Add(new Product("a", 5));
            //Assert.AreEqual("sugar", shophoppingCart.Current());
        }
        [TestMethod]
        public void testTrueMoveNext()
        {
            shophoppingCart = new ShoppingCart();
            shophoppingCart.Add(new Product("appel", 4));
            shophoppingCart.Add(new Product("orange", 1));
            shophoppingCart.Add(new Product("sugar", 7));
            shophoppingCart.Add(new Product("a", 5));
            //  Assert.AreEqual(true, shophoppingCart.MoveNext());
        }
        public void testFalseMoveNext()
        {
            shophoppingCart = new ShoppingCart();
            //Assert.AreEqual(true, shophoppingCart.MoveNext());
        }
        [TestMethod]
        public void testIEnumerable()
        {
            shophoppingCart = new ShoppingCart();
            shophoppingCart.Add(new Product("appel", 4));
            shophoppingCart.Add(new Product("orange", 1));
            shophoppingCart.Add(new Product("sugar", 7));
            shophoppingCart.Add(new Product("a", 5));
            int counter = 0;
            foreach (var product in shophoppingCart)
            {
                counter++;
            }
            Assert.AreEqual(4, counter);
        }
    }
}