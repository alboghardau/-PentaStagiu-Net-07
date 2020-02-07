using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema07
{
    enum Order { Ascending, Descending };
    class CartService
    {
        Cart Cart;

        public CartService(Cart cart)
        {
            this.Cart = cart;
        }

        public void ListProducts()
        {
            Console.WriteLine("CART ITEMS");
            Console.WriteLine("*************************************");
            this.Cart.CartProducts.ForEach(product =>
            {
                Console.WriteLine(product.ToString());
            });
            Console.WriteLine("*************************************");
        }
        
        public void Add(List<Product> list)
        {
            list.ForEach(x => this.Cart.CartProducts.Add(x));
        }

        public void Add(Product product)
        {
            this.Cart.CartProducts.Add(product);
        }

        //methods to sort the cart
        public CartService OrderBy(Order order, ProductAtribute productAtribute)
        {
            if(order == Order.Ascending)
            {
                if(productAtribute == ProductAtribute.Name)
                {
                    this.Cart.CartProducts.OrderBy(x => x.ProductName);
                }
                else if (productAtribute == ProductAtribute.Price)
                {
                    this.Cart.CartProducts.OrderBy(x => x.Price);
                }
                else if (productAtribute == ProductAtribute.Type)
                {
                    this.Cart.CartProducts.OrderBy(x => x.ProductType);
                }
            }
            else
            {
                if (productAtribute == ProductAtribute.Name)
                {
                    this.Cart.CartProducts.OrderByDescending(x => x.ProductName);
                }
                else if (productAtribute == ProductAtribute.Price)
                {
                    this.Cart.CartProducts.OrderByDescending(x => x.Price);
                }
                else if (productAtribute == ProductAtribute.Type)
                {
                    this.Cart.CartProducts.OrderByDescending(x => x.ProductType);
                }
            }
            return this;
        }

        public CartService GroupBy(ProductAtribute productAtribute)
        {
            if (productAtribute == ProductAtribute.Name)
            {
                this.Cart.CartProducts.GroupBy(x => x.ProductName);
            }
            else if (productAtribute == ProductAtribute.Price)
            {
                this.Cart.CartProducts.GroupBy(x => x.Price);
            }
            else if (productAtribute == ProductAtribute.Type)
            {
                this.Cart.CartProducts.GroupBy(x => x.ProductType);
            }
            return this;
        }       
        
        public void IsAnyByType(ProductType productType)
        {
            Boolean test;
            if (productType == ProductType.Book)
            {
                test = this.Cart.CartProducts.Any(x => x.ProductType == ProductType.Book);
            }
            else if (productType == ProductType.Clothes)
            {
                test = this.Cart.CartProducts.Any(x => x.ProductType == ProductType.Clothes);
            }
            else
            {
                test = this.Cart.CartProducts.Any(x => x.ProductType == ProductType.Food);
            }
            Console.WriteLine("Product type: " + productType + " exist: " + test);
        }

        public Product FirstHigherPrice(double price)
        {
            return this.Cart.CartProducts.FirstOrDefault(x => x.Price > price);
        }
    }
}
