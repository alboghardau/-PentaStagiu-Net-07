using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema07
{
    class ShopService
    {
        List<Product> ProductsList;

        public ShopService()
        {
            this.ProductsList = new List<Product>();
        }

        public List<Product> GetProducts()
        {
            return this.ProductsList;
        }

        public void AddProduct(Product product)
        {
            this.ProductsList.Add(product);
        }

        public void ListProducts()
        {
            this.ProductsList.ForEach(product =>
           {
               Console.WriteLine(product.ToString());
           });
        }

        public List<Product> GetProductsByTypeAndHigherPrice(ProductType type, double price)
        {
            return this.ProductsList.Where(x => x.ProductType.Equals(type)).Where( x => x.Price > price).ToList();
        }

    }
}
