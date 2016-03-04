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
            Assert.AreEqual(40, CalculateTheSumOfProducts(product));
        }

        double CalculateTheSumOfProducts(Product[] product)
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
            Assert.AreEqual("Apple", TheCheapestProduct(product));
           // var productEmpty= new Product[] { };
           // Assert.AreEqual("Array is empty", TheCheapestProduct(productEmpty));
        }
        string TheCheapestProduct(Product[] product)    
        {
            string result =string.Empty;
            double counter = 0;
            if (product.Length == 0)
                return "Array is empty";
            for (int i = 0; i < product.Length-1; i++)
            {
                counter = product[i].priceProduct;
                if (counter < product[i+1].priceProduct)
                {
                    counter = product[i].priceProduct;
                    result = product[i].nameProduct;
                }
            }
            return result;
        }

       [TestMethod]
        public void AddProduct()
        {
           var product = new Product[] { new Product("Apple",10), new Product("Sugar", 25), new Product("Orange", 15) };
           var first = new Product[] { new Product("Apple", 10),new Product("Sugar", 25), new Product("Orange", 15), new Product("Coffe", 20) };
           CollectionAssert.AreEqual(first, AddAProduct(product , "Coffe" , 20));
        }
        Product[] AddAProduct(Product[] product,string name , int price)
        {
            Array.Resize(ref product, product.Length+1);
            product[product.Length-1].priceProduct = price;
            product[product.Length-1].nameProduct = name;
            return product;
        }
        
        [TestMethod]
        public void RemoveAProduct ()
        {
            var product = new Product[] { new Product("Apple", 10), new Product("Sugar", 25), new Product("Orange", 15) };
            var first = new Product[] { new Product("Apple", 10), new Product("Orange", 15) };
            CollectionAssert.AreEqual(first, RemoveAProduct(product));
        }
        Product[] RemoveAProduct(Product[] product)
        {
            double counter = 0;
            int index = 0;
            for (int i = 0; i < product.Length; i++)
            {
                if (counter < product[i].priceProduct)
                {
                    counter = product[i].priceProduct; 
                    index = i;
                }
            }
            for (int i = index; i < product.Length - index; i++)
            {
                product[i].priceProduct = product[i + 1].priceProduct;
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
            return CalculateTheSumOfProducts(product) / product.Length;
        }
    }
}
