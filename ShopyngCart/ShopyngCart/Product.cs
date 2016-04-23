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
        public string getProductName()
        {
            return name;
        }
        public int getProductPrice()
        {
            return price;
        }
        public int CompareProducts(int x, int y)
        {
            if (x > y)
                return 1;
            if (x < y)
                return -1;
            return 1;

        }
    }
}
