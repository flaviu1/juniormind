using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopyngCart
{
    class Product
    {
        private string name;
        private int price;

        public Product() { }
        public Product(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
        private string getProductName()
        {
            return name;
        }
        private int getProductPrice()
        {
            return price;
        }
        public string CompareProducts(Product[] products)
        {
            string result = string.Empty;
            int counter = 0;
            if (products.Length == 0)
                return "Array is empty";
            counter = products[0].price;
            for (int i = 1; i < products.Length; i++)
            {
                if (counter < products[i].price)
                {
                    counter = products[i].price;
                    result = products[i].name;
                }
            }
            return result;
        }
        public void RemoveElementAtPositionX(Product[] products, int index)
        {
            for (int i = index; i < products.Length - 1; i++)
                products[i] = products[i + 1];
            Array.Resize(ref products, products.Length - 1);
        }
        public int LookingForTheMostMxpensiveProduct(Product[] products)
        {
            int index = 0;
            int counter = 0;
            for (int i = 0; i < products.Length; i++)
            {
                if (counter < products[i].price)
                {
                    counter = products[i].price;
                    index = i;
                }
            }
            return index;
        }
        public int Sum(Product[] products)
        {
            int result = 0;

            for (int i = 0; i <= products.Length - 1; i++)
            {
                int counter = products[i].price;
                result = result + counter;
            }
            return result;
        }
    }
}
