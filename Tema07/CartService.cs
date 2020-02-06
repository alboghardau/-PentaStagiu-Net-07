using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema07
{
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
    }
}
