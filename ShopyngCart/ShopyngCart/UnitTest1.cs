using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;


namespace ShopyngCart
{
    [TestClass]
    public class UnitTest1
    {
        private ShoppingCart shoppingCart;
        Product a = new Product("appel", 4);
        Product b = new Product("orange", 1);
        Product c = new Product("sugar", 3);
        Product p = new Product("a", 4);
        Stock stock = new Stock();
        Product[] products = new Product[0];

        [TestMethod]
        public void StockIsEmpty()
        {
            Assert.AreEqual(0, stock.StockLength());
        }
        [TestMethod]
        public void HowManyProductsAddToStock()
        {
            stock.AddProductAtStock(new Product("apple",1,1));
            Assert.AreEqual(1, stock.StockLength());
        }
        [TestMethod]
        public void  HowManyProductsContainsStock()
        {
            products = stock.DisplaysProduct();
            Assert.AreEqual(5, stock.StockLength());
        }
        [TestMethod]
        public void DecreaseQuantity()
        {
            //products = stock.DisplaysProduct();
            //shoppingCart.Add(stock.apple);
            //shoppingCart.Add(stock.orange);
            //shoppingCart.Add(stock.grapes);



        }





        [TestMethod]
        public void testAddProduct()
        {
            shoppingCart = new ShoppingCart();
            shoppingCart.Add(a);
            shoppingCart.Add(b);
            Assert.IsTrue(shoppingCart.CheckForProduct(a));
        }
        [TestMethod]
        public void testPriceOneProdut()
        {
            shoppingCart = new ShoppingCart();
            shoppingCart.Add(a);
            Assert.AreEqual(4, shoppingCart.CalculateTheSumOfProducts());
        }
        [TestMethod]
        public void testSumProducts()
        {
            shoppingCart = new ShoppingCart(); ;
            shoppingCart.Add(a);
            shoppingCart.Add(b);
            shoppingCart.Add(c);
            shoppingCart.Add(p);
            Assert.AreEqual(12, shoppingCart.CalculateTheSumOfProducts());
        }
        [TestMethod]
        public void testCalculateTheAveragePrice()
        {
            shoppingCart = new ShoppingCart(); ;
            shoppingCart.Add(a);
            shoppingCart.Add(b);
            shoppingCart.Add(c);
            shoppingCart.Add(p);
            Assert.AreEqual(3, shoppingCart.CalculateTheAveragePrice());
        }
        [TestMethod]
        public void testTheCheapestProduct()
        {
            shoppingCart = new ShoppingCart();
            shoppingCart.Add(a);
            shoppingCart.Add(b);
            shoppingCart.Add(c);
            shoppingCart.Add(p);
            Assert.AreEqual("orange", shoppingCart.TheCheapestProduct());
        }
        [TestMethod]
        public void testLookingForTheMostMxpensiveProduct()
        {
            shoppingCart = new ShoppingCart();
            shoppingCart.Add(new Product("appel", 4));
            shoppingCart.Add(new Product("orange", 1));
            shoppingCart.Add(new Product("sugar", 7));
            shoppingCart.Add(new Product("a", 5));
            Assert.AreEqual(2, shoppingCart.LookingForTheMostMxpensiveProduct());
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
        public void testIEnumerable()
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
    }
}