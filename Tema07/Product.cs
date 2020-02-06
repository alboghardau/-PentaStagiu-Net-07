using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema07
{
    enum ProductType { Book, Food, Clothes }

    class Product
    {        
        public ProductType ProductType { get; set; }
        string ProductName { get; set; }
        public double Price { get; set; }

        public Product(string productName, double price, ProductType type)
        {
            this.ProductName = productName;
            this.Price = price;
            this.ProductType = type;            
        }

        public override string ToString()
        {
            return "Type:"+this.ProductType+" | Name:"+this.ProductName+" | Price:"+this.Price;
        }
    }
}
