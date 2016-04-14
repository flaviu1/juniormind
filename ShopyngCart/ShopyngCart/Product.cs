using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopyngCart
{
    class Product
    {
        public string name;
        public int price;
        public Product(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
        public Product AddNedwProductWhenListIsEmpty(string name, int price)
            {
                Product Product1=new Product(string.Empty,0);
                Product1.name = name;
                Product1.price = price;
                return Product1;
            }
    }
}
