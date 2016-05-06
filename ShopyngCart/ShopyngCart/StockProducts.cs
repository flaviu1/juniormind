using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopyngCart
{
    class Stock
    {

        Product[] stock = new Product[0];
       public Product apple = new Product("apple", 1, 3);
       public Product orange = new Product("Orange", 2, 3);
       public Product grapes = new Product("Grapes", 3, 3);
       public Product strawberries = new Product("Strawberries", 4, 3);
       public Product raspberry = new Product("Raspberry", 5, 3);
       public Product nokia = new Product("Nokia", 20, 2);
       public Product sony = new Product("Sony", 20, 2);
       public Product audi = new Product("Audi", 20, 2);
       public Product mercedesb = new Product("Mercedesb", 20, 2);

        public Product[] DisplaysProduct()
        {
            //Product apple = new Product("apple", 1, 3);
            //Product orange = new Product("Orange", 2, 3);
            //Product grapes = new Product("Grapes", 3, 3);
            //Product strawberries = new Product("Strawberries", 4, 3);
            //Product raspberry = new Product("Raspberry", 5, 3);
            //Product nokia = new Product("Nokia", 20, 2);
            //Product sony = new Product("Sony", 20, 2);
            //Product audi = new Product("Audi", 20, 2);
            //Product mercedesb = new Product("Mercedesb", 20, 2);
            Array.Resize(ref stock, stock.Length + 1);
            stock[stock.Length - 1] = apple;
            Array.Resize(ref stock, stock.Length + 1);
            stock[stock.Length - 1] = orange;
            Array.Resize(ref stock, stock.Length + 1);
            stock[stock.Length - 1] = grapes;
            Array.Resize(ref stock, stock.Length + 1);
            stock[stock.Length - 1] = strawberries;
            Array.Resize(ref stock, stock.Length + 1);
            stock[stock.Length - 1] = raspberry;
            Array.Resize(ref stock, stock.Length + 1);
            stock[stock.Length - 1] = nokia;
            Array.Resize(ref stock, stock.Length + 1);
            stock[stock.Length - 1] = sony;
            Array.Resize(ref stock, stock.Length + 1);
            stock[stock.Length - 1] = audi;
            Array.Resize(ref stock, stock.Length + 1);
            stock[stock.Length - 1] = mercedesb;
            return stock;

        }



        
        public Product[] AddProductAtStock(Product product)
        {
            Array.Resize(ref stock, stock.Length + 1);
            stock[stock.Length - 1] = product;

            return stock;
        }
        public int StockLength()
        {
            return stock.Length;
        }
        public void RemoveProduct(Product product)
        {
            Array.Resize(ref stock, stock.Length - stock.Length);
        }
    }
}
