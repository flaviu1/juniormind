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
        public int Sum(ref int sum)
        {
            return sum += this.price;
        }
        public int QuantityAndPrice()
        {
            return this.quantity * this.price;
        }

        public void DecreaseQuantity(int quantity)
        {
            this.quantity -= quantity;
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
