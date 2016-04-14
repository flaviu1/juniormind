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
            Product p = new Product("apple",15);
            p.name = "apple";
            p.price=15;
            p.AddNedwProductWhenListIsEmpty("apple", 15);
      }
   } 
}
