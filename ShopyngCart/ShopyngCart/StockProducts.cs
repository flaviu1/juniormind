﻿using System;
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
        public Product[] DisplaysProduct()
        {
            stock = new Product[] 
            {
                apple,
                orange,
                grapes,
                strawberries,
                raspberry
            };
            return stock;
        }
        public Product[] AddProductAtStock(Product product, int quantity=1)
        {
            Array.Resize(ref stock, stock.Length + 1);
            stock[stock.Length - 1] = product;
            product.DecreaseQuantity(quantity);

            return stock;
        }
        public int StockLength()
        {
            return stock.Length;
        }
        public void RemoveProduct(Product product)
        {
            for (int i = 0; i < stock.Length; i++)
            {
                if (stock[i] == product)
                {
                    RemoveElementAtPositionX(i);
                    break;
                }
            }
        }
        public void RemoveElementAtPositionX(int index)
        {
            for (int i = index; i < stock.Length - 1; i++)
                stock[i] = stock[i + 1];
            Array.Resize(ref stock, stock.Length - 1);
        }
    }
}
