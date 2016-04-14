using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopyngCart
{
    class ShoppingCart
    {
        static void Add(string[] args)
      {
            Product p = new Product();
            p.name = "apple";
            p.price=15;
            p.Product(p.name,p.price);
      }
   } 
}
