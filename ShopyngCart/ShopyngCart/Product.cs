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
        public string GetProductName()
        {
            return name;
        }
        public int GetProductPrice()
        {
            return price;
        }
        public int Sum(Product[] products, int Pozitions)
        {
            int result = 0;
            return result += products[Pozitions].price;
        }
        public int CompareProduct(Product[] products)
        {
            int counter = 0;
            int index = 0;
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
        public int CompareProduct(Product b)
        {
            if (this.GetProductPrice() < b.GetProductPrice())
                return 1;
            if (this.GetProductPrice()> b.GetProductPrice())
                return -1;
            return 0;
        }
    }
}
