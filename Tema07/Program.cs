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
            
            //create a cart that contains all FOOD with price bigger than 200
            cart.Add(shop.FilterBuilder()
                .ByPrice(Comp.Higher, 200)
                .ByType(ProductType.Food)
                .GetFilteredList());
            cart.ListProducts();

            //add int the cart all the clothes products that have a name starting with "B"
            cart.Add(shop.FilterBuilder()
                .ByType(ProductType.Clothes)
                .StartsWith("B")
                .GetFilteredList());
            cart.ListProducts();

            //add books lower than 50
            cart.Add(shop.FilterBuilder()
                .ByType(ProductType.Book)
                .ByPrice(Comp.Lower, 50)
                .GetFilteredList());
            cart.ListProducts();

           
            cart.GroupBy(ProductAtribute.Type)
                .OrderBy(Order.Descending, ProductAtribute.Price)
                .ListProducts();

            //tests and prints if productType exists
            cart.IsAnyByType(ProductType.Book);

            //display first item
            Product first = cart.FirstHigherPrice(20);
            if (first != null)
            {
                Console.WriteLine(first.ToString());
            }

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
            shop.AddProduct(new Product("Burger", 235, ProductType.Food));
            shop.AddProduct(new Product("Pizza", 9, ProductType.Food));
            shop.AddProduct(new Product("Apple", 220, ProductType.Food));
            shop.AddProduct(new Product("Mango", 250, ProductType.Food));
        }
    }
}
