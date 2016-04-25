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
        private string GetProductName()
        {
            return name;
        }
        private int GetProductPrice()
        {
            return price;
        }
        public int Sum(Product[] products ,int Pozitions)
        {
            int result = 0;
            return result += products[Pozitions].price;
        }
    }
}
