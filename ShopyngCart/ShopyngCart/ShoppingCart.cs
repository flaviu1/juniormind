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
        public IEnumerator GetEnumerator()
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
            int sum = 0;
            foreach (var product in products)
            {
                sum = product.Sum(ref sum);
            }
            return sum;
        }
        public double CalculateTheAveragePrice()
        {
            return CalculateTheSumOfProducts() / products.Length;
        }
        public Product TheCheapestProduct()
        {
            var index = 0;
            for (int i = 1; i < products.Length; i++)
            {
                if (products[index].CompareProduct(products[i]) == -1)
                    index = i;
            }
            return products[index];
        }
        public void RemoveAProduct()
        {
            int index = FindMostExpensive();
            RemoveElementAtPositionX(index);
        }
        public void RemoveElementAtPositionX(int index)
        {
            for (int i = index; i < products.Length - 1; i++)
                products[i] = products[i + 1];
            Array.Resize(ref products, products.Length - 1);
        }
        public int FindMostExpensive()
        {
            var index = 0;
            for (int i = 1; i < products.Length; i++)
            {
                if (products[index].CompareProduct(products[i]) == 1)
                    index = i;
            }
            return index;
        }
    }
}