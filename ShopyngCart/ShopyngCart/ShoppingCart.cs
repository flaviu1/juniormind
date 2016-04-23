using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopyngCart
{
    class ShoppingCart
    {
        public Product[] products = new Product[0];


        public void Add(Product product)
        {
            Array.Resize(ref  products, products.Length + 1);
            products[products.Length - 1] = product;
        }
        public bool CeckForProduct(Product product)
        {
            bool isPresent = false;

            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].Equals(product))
                {
                    isPresent = true;
                    break;
                }
            }
            return isPresent;
        }
        public int CalculateTheSumOfProducts()
        {
            int result = 0;

            for (int i = 0; i <= products.Length - 1; i++)
            {
                int counter = products[i].getProductPrice();
                result = result + counter;
            }
            return result;
        }

        public double CalculateTheAveragePrice()
        {
            return CalculateTheSumOfProducts() / products.Length;
        }
        public string TheCheapestProduct()
        {
            string result = string.Empty;
            int counter = 0;
            if (products.Length == 0)
                return "Array is empty";
            counter = products[0].getProductPrice();
            for (int i = 1; i < products.Length - 1; i++)
            {
                Product a = new Product();
                int x=products[i].getProductPrice();
                if (a.CompareProducts(counter, x) == 1)
                {
                    counter = x;
                    result = products[i].getProductName();
                }

           /*     if (counter > products[i].getProductPrice())
                {
                    counter = products[i].getProductPrice();
                    result = products[i].getProductName();
                }*/
            }
            return result;
        }

        public void RemoveAProduct()
        {
            int index = LookingForTheMostMxpensiveProduct();
            RemoveElementAtPositionX(index);
            Array.Resize(ref products, products.Length - 1);
        }
        public void RemoveElementAtPositionX(int index)
        {
            for (int i = index; i < products.Length - 1; i++)
                products[i] = products[i + 1];
            Array.Resize(ref products, products.Length - 1);
        }

        public int LookingForTheMostMxpensiveProduct()
        {
            int index = 0;
            int counter = 0;
            for (int i = 0; i < products.Length; i++)
            {

                Product a = new Product();
                int y = products[i].getProductPrice();
                if (a.CompareProducts(counter, y) == -1)
                {
                    counter = y;
                    index = i;
                }
            }
            return index;
        }

    }
}
