using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OOP_Shoping
{
    public class UnitTest1
    {
        public class shoping
        {
            public string nameProduct;
            public double priceProduct;
            public shoping(string nameProduct, double priceProduct)
            {
                this.nameProduct = nameProduct;
                this.priceProduct = priceProduct;
            }
            public static double CalculateTheSumOfProducts(shoping[] product)
            {
                double result = 0;
                for (int i = 0; i < product.Length; i++)
                {
                    result += product[i].priceProduct;
                }
                return result;
            }
            public static double CalculateTheAveragePrice(shoping[] product)
            {
                return CalculateTheSumOfProducts(product) / product.Length;
            }
            public static string TheCheapestProduct(shoping[] product)
            {
                string result = string.Empty;
                double counter = 0;
                if (product.Length == 0)
                    return "Array is empty";
                for (int i = 0; i < product.Length - 1; i++)
                {
                    counter = product[i].priceProduct;
                    if (counter < product[i + 1].priceProduct)
                    {
                        counter = product[i].priceProduct;
                        result = product[i].nameProduct;
                    }
                }
                return result;
            }
            public static shoping[] AddAProduct(shoping[] product, string name, int price)
            {
                Array.Resize(ref product, product.Length + 1);
                product[product.Length - 2].priceProduct = price;
                product[product.Length - 1].nameProduct = name;
                return product;
            }
            public static shoping[] RemoveAProduct(shoping[] product)
            {
                int index = LookingForTheMostMxpensiveProduct(product);
                RemoveElementAtPositionX(product, index);
                Array.Resize(ref product, product.Length - 1);
                return product;
            }

            public static void RemoveElementAtPositionX(shoping[] product, int index)
            {
                for (int i = index; i < product.Length - index; i++)
                {
                    product[i].priceProduct = product[i + 1].priceProduct;
                    product[i].nameProduct = product[i + 1].nameProduct;
                }
            }

            public static int LookingForTheMostMxpensiveProduct(shoping[] product)
            {
                int index = 0;
                double counter = 0;
                for (int i = 0; i < product.Length; i++)
                {
                    if (counter < product[i].priceProduct)
                    {
                        counter = product[i].priceProduct;
                        index = i;
                    }
                }
                return index;
            }
        }


        [TestClass]
        public class UnitTest11
        {
            [TestMethod]
            public void TheSumOfProducts()
            {
                var product = new shoping[] { new shoping("Apple", 10), new shoping("Sugar", 15), new shoping("Orange", 15) };
                Assert.AreEqual(40, shoping.CalculateTheSumOfProducts(product));
            }
            [TestMethod]
            public void ProdusuCheapest()
            {
                var product = new shoping[] { new shoping("Apple", 10), new shoping("Sugar", 25), new shoping("Orange", 15) };
                Assert.AreEqual("Apple", shoping.TheCheapestProduct(product));
            }
            [TestMethod]
            public void ShouldCalculateTheAveragePrice()
            {
                var product = new shoping[] { new shoping("Apple", 10), new shoping("Sugar", 20), new shoping("Orange", 15) };
                Assert.AreEqual(15, shoping.CalculateTheAveragePrice(product));
            }

            [TestMethod]
            public void RemoveAProduct()
            {
                shoping[] actual = new shoping[] { new shoping("Apple", 10), new shoping("Sugar", 25), new shoping("Orange", 15) };
                shoping[] result = new shoping[] { new shoping("Apple", 10), new shoping("Orange", 15) };
                CollectionAssert.AreEqual(result, shoping.RemoveAProduct(actual));
            }
            [TestMethod]
            public void AddProduct()
            {
                var product = new shoping[] { new shoping("Apple", 10), new shoping("Sugar", 25), new shoping("Orange", 15) };
                var first = new shoping[] { new shoping("Apple", 10), new shoping("Sugar", 25), new shoping("Orange", 15), new shoping("Coffe", 20) };
                CollectionAssert.AreEqual(first, shoping.AddAProduct(product, "Coffe", 20));
            }
        }
    }
}
