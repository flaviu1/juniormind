using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopyngCart
{
    class ProductRepository
    {

        List<Product> stock = new List<Product>();

        public List<Product> ListProduct()
        {
            Product apple = new Product("apple", 1, 3);
            Product orange = new Product("Orange", 2, 3);
            Product grapes = new Product("Grapes", 3, 3);
            Product strawberries = new Product("Strawberries", 4, 3);
            Product raspberry = new Product("Raspberry", 5, 3);
            Product nokia = new Product("Nokia", 20, 2);
            Product sony = new Product("Sony", 20, 2);
            Product samsung = new Product("Samsung", 20, 2);
            Product audi = new Product("Audi", 20, 2);
            Product mercedesb = new Product("Mercedesb", 20, 2);
            Product bmw = new Product("Bmw", 20, 2);
            stock.Add(apple);
            stock.Add(orange);
            stock.Add(grapes);
            stock.Add(strawberries);
            stock.Add(raspberry);
            stock.Add(nokia);
            stock.Add(sony);
            stock.Add(samsung);
            stock.Add(audi);
            stock.Add(mercedesb);
            stock.Add(bmw);
            return stock;
        }
        public void DecreasesInStock(Product[] products)
        {
            foreach (var product in products)
            {
                product.Quantity();
            }
        }
        public Product ReturnProduct(string element)
        {
            Product a = new Product("Product not existed");
            Product b = new Product("the stock is empty");
            for (int i = 0; i < stock.Count; i++)
            {
                if (stock[i].GetName() == element)
                {
                    if (stock[i].GetQuantity() > 0)
                        stock[i].Quantity();
                    else
                        return b;
                    return stock[i];
                }
            }
            return a;
        }
        public List<Product> GetAllProducts()
        {
            return stock;
        }
        public void RemoveProduct(Product product)
        {

        }
    }
}
