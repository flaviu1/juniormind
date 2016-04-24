using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopyngCart
{
    class ShoppingCart
    {
        private Product[] products = new Product[0];


        public void Add(Product product)
        {
            Array.Resize(ref  products, products.Length + 1);
            products[products.Length - 1] = product;
        }
        public bool CeckForProduct(Product product)
        {
            bool isPresent = false;
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].Equals(product))
                {
                    isPresent = true;
                    break;
                }
            }
            return isPresent;
        }
        public int CalculateTheSumOfProducts()
        {
            Product result = new Product();
            return result.Sum(products);
        }
        public double CalculateTheAveragePrice()
        {
            return CalculateTheSumOfProducts() / products.Length;
        }
        public string TheCheapestProduct()
        {
            string result = string.Empty;
            Product a = new Product();
            return a.CompareProducts(products);
        }
        private void RemoveAProduct()
        {
            Product result = new Product();
            int index = result.LookingForTheMostMxpensiveProduct(products);
            result.RemoveElementAtPositionX(products, index);
            Array.Resize(ref products, products.Length - 1);
        }
    }
}
