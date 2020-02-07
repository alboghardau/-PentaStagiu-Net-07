using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema07
{
    class Cart
    {
        string Name;
        public List<Product> CartProducts { get; private set; }

        public Cart(string name)
        {
            this.Name = name;
            this.CartProducts = new List<Product>();
        }

    }
}
