using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema07
{
    class Program
    {
        static void Main(string[] args)
        {
            ShopService shop = new ShopService();
            CartService cart = new CartService(new Cart("Cart"));
            
            AddSomeProducts(shop);
            
            shop.ListProducts();

            cart.Add(shop.GetProductsByTypeAndHigherPrice(ProductType.Book, 10));
            cart.ListProducts();

            
        }

        //just adds some products to the list
        private static void AddSomeProducts(ShopService shop) 
        {
            shop.AddProduct(new Product("Origin", 10, ProductType.Book));
            shop.AddProduct(new Product("Harry Potter", 15, ProductType.Book));
            shop.AddProduct(new Product("American Gods", 12, ProductType.Book));
            shop.AddProduct(new Product("Puma Shoes", 22, ProductType.Clothes));
            shop.AddProduct(new Product("Nike Shirt", 35, ProductType.Clothes));
            shop.AddProduct(new Product("Stinky Socks", 15, ProductType.Clothes));
            shop.AddProduct(new Product("Wine", 20, ProductType.Food));
            shop.AddProduct(new Product("Burger", 12, ProductType.Food));
            shop.AddProduct(new Product("Pizza", 9, ProductType.Food));
        }

    }
}
