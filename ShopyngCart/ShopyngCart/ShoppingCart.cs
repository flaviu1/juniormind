using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopyngCart
{
    class ShoppingCart
    {
        private Product[] products;


        public void Add(Product product)
        {
            products = new Product[] { };
            Array.Resize(ref  products, products.Length + 1);
            products[products.Length - 1] = product;
        }
        public bool CeckForProduct(Product product)
        {
            bool isPresent = false;

            for(int i=0;i<products.Length;i++)
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
            int result = 0;

            for (int i = 0; i <= products.Length-1; i++)
            {
                int counter = products[i].getProductPrice();
                result = result +counter;
            }
            return result;
        }
   }
}
