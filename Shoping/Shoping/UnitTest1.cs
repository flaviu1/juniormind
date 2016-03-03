using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Shoping
{

    public struct Product
    {
        public string nameProduct;
        public double priceProduct;
        public Product(string nameProduct, double priceProduct)
        { 
            this.nameProduct = nameProduct;
            this.priceProduct = priceProduct;
        }
    }
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TheSumOfProducts()
        {
            var product = new Product[] { new Product("Apple", 10), new Product("Sugar", 15), new Product("Orange", 15) };
            Assert.AreEqual(40, CalculatePriceShopping(product));
        }


        double CalculatePriceShopping(Product[] product)
        {
            double result = 0;
            for (int i = 0; i < product.Length;i++)
            {
                result += product[i].priceProduct;
            }
                return result;
        }
         [TestMethod]
        public void ProdusuCheapest()
        {
            var product = new Product[] { new Product("Apple", 10), new Product("Sugar", 25), new Product("Orange", 15) };
            Assert.AreEqual(10, TheCheapestProduct(product));
        }
        double TheCheapestProduct(Product[] product)
        {
            double result =1000;
            for (int i = 0; i < product.Length; i++)
            {
                if (result > product[i].priceProduct)
                {
                    result = product[i].priceProduct;
                }
            }
            return result;
        }

        [TestMethod]
        public void ProdusuCheapest1()
        {
           var product = new Product[] { new Product("Apple",10), new Product("Sugar", 25), new Product("Orange", 15) };
           var first = new Product[] { new Product("Apple", 10), new Product("Orange", 15) };
           Assert.AreEqual(first, ToEliminateTheCheapestProduct(product));
        }
        Product[] ToEliminateTheCheapestProduct(Product[] product)
        {
            double counter = 0;
            int index=0;
            for (int i = 0; i < product.Length; i++)
            {
                if (counter < product[i].priceProduct)
                {
                    counter = product[i].priceProduct;
                    index=i;
                }
            }
            for (int i = index; i < product.Length-index;i++)
            {
                product[i].priceProduct = product[i+1].priceProduct;
                product[i].nameProduct = product[i + 1].nameProduct;
            }
            Array.Resize(ref product, product.Length - 1);
            return product;
        }


        [TestMethod]
        public void ShouldCalculateTheAveragePrice()
        {
            var product = new Product[] { new Product("Apple", 10), new Product("Sugar", 20), new Product("Orange", 15) };
            Assert.AreEqual(15, CalculateTheAveragePrice(product));
        }
       double CalculateTheAveragePrice(Product[] product)
        {
            double total = 0;
            for (int i = 0; i < product.Length; i++)
                total += product[i].priceProduct;
            return total / product.Length;
        }
    }
}
