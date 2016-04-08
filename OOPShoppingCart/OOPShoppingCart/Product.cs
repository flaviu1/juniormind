using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPShoppingCart
{
    class Product
    {
        public string name;
        public decimal price;
        public Product(string name ,decimal price)
        {
            this.name = name;
            this.price = price;
        }
        public static Product[] AddNewProduct(Product[] prod , string name, decimal price)
        {
            Array.Resize(ref prod, prod.Length + 1);
            prod[prod.Length-1].name = name;
            prod[prod.Length - 1].price = price;
            return prod;
        } 
    }
}
