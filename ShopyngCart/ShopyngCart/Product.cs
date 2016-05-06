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
        private int quantity;

        public Product() { }
        public Product(string name, int price, int quantity = 1)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }
        public int Sum()
        {
            int result = 0;
            return result += this.price;
        }

        public void DecreaseQuantity()
        {




        }

       






        public int LookingForTheMostMxpensiveProduct(Product[] products)
        {
            Product productCounter;
            int index = 0;
            productCounter = this;
            for (int i = 1; i < products.Length; i++)
            {
                if (productCounter.CompareProduct(products[i]) == 1)
                {
                    productCounter.price = products[i].price;
                    index = i;
                }
            }
            return index;
        }
        public string TheCheapestProduct(Product[] products)
        {
            Product productCounter;
            int index = 0;
            productCounter = this;
            for (int i = 1; i < products.Length; i++)
            {
                if (productCounter.CompareProduct(products[i]) == -1)
                {
                    productCounter.price = products[i].price;
                    index = i;
                }
            }
            return products[index].name;
        }
        public int CompareProduct(Product b)
        {
            if (this.price < b.price)
                return 1;
            if (this.price > b.price)
                return -1;
            return 0;
        }
    }
}
