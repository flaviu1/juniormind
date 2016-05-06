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
            string result = string.Empty;
            Product counter = new Product();
            counter = counter.Assignment(products[0]);
            if (counter.CompareProduct(products[1]) == -1)
                counter = counter.Assignment(products[1]);
            for (int i = 2; i < products.Length; i++)
            {
                if (counter.CompareProduct(products[i]) == -1)
                    counter = counter.Assignment(products[i]);
            }
            return counter;
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
            string result = string.Empty;
            int index = 0;
            Product counter = new Product();
            counter = counter.Assignment(products[0]);
            if (counter.CompareProduct(products[1]) == 1)
            {
                counter = counter.Assignment(products[1]);
                index = 1;
            }
            for (int i = 2; i < products.Length; i++)
            {
                if (counter.CompareProduct(products[i]) == 1)
                {
                    counter = counter.Assignment(products[i]);
                    index = i;
                }
            }
            return index;
        }
    }
}