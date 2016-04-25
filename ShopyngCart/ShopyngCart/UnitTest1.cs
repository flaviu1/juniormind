using System;
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
      /* [TestMethod]
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
            //Assert.AreEqual("orange", shophoppingCart.TheCheapestProduct());
        }*/
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
       /* [TestMethod]
        public void testRemoveElementAtPositionX()
        {
            shophoppingCart = new ShoppingCart();
            shophoppingCart.Add(new Product("appel", 4));
            shophoppingCart.Add(new Product("orange", 1));
            shophoppingCart.Add(new Product("sugar", 1));
            shophoppingCart.Add(new Product("a", 5));
            //shophoppingCart.RemoveElementAtPositionX(1);
           // Assert.AreEqual(10, shophoppingCart.CalculateTheSumOfProducts());
        }*/
    }
}