using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopyngCart
{
    class ShoppingCart : IEnumerable
    {
        public Product[] products = new Product[0];
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.products.GetEnumerator();
        }
        public void Add(Product product)
        {
            Array.Resize(ref  products, products.Length + 1);
            products[products.Length - 1] = product;
        }
        public bool CheckForProduct(Product product)
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
            int result = 0;
            for (int i = 0; i <= products.Length - 1; i++)
            {
                result += products[i].Sum();
            }
            return result;
        }
        public double CalculateTheAveragePrice()
        {
            return CalculateTheSumOfProducts() / products.Length;
        }
        public string TheCheapestProduct()
        {
            string result = string.Empty;
            result = products[0].TheCheapestProduct(products);
            return result;
        }
        public void RemoveAProduct()
        {
            int index = LookingForTheMostMxpensiveProduct();
            RemoveElementAtPositionX(index);
            Array.Resize(ref products, products.Length - 1);
        }
        public void RemoveElementAtPositionX(int index)
        {
            for (int i = index; i < products.Length - 1; i++)
                products[i] = products[i + 1];
            Array.Resize(ref products, products.Length - 1);
        }
        public int LookingForTheMostMxpensiveProduct()
        {
            int index = 0;
            index = products[0].LookingForTheMostMxpensiveProduct(products);
            return index;
        }
    }
}