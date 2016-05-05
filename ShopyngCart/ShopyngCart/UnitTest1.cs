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
        ProductRepository stock = new ProductRepository();
        List<Product> list;

        [TestMethod]
        public void HowManyProducts()
        {
            list = stock.ListProduct();
            Assert.AreEqual(11, list.Count);
        }
        [TestMethod]
        public void AddProductToShoppingCartFromStock()
        {
            shoppingCart = new ShoppingCart();
            list = stock.ListProduct();
            Product a = stock.ReturnProduct("apple");
            shoppingCart.Add(a);
            shoppingCart.Add(stock.ReturnProduct("Sony"));
            shoppingCart.Add(stock.ReturnProduct("Bmw"));
            shoppingCart.Add(stock.ReturnProduct("Grapes"));
            Assert.AreEqual(44, shoppingCart.CalculateTheSumOfProducts());
        }
        [TestMethod]
        public void DescraseQuantityWhenAddProductAtShoppingCart()
        {
            shoppingCart = new ShoppingCart();
            list = stock.ListProduct();
            shoppingCart.Add(stock.ReturnProduct("apple"));
            shoppingCart.Add(stock.ReturnProduct("apple"));
            shoppingCart.Add(stock.ReturnProduct("apple"));
            shoppingCart.Add(stock.ReturnProduct("apple"));
            Assert.AreEqual(3, shoppingCart.CalculateTheSumOfProducts());
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