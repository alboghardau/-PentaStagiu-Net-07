using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema07
{
    enum Comp { Higher, Lower, Equal }

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

        public Builder FilterBuilder()
        {
            return new Builder(this.ProductsList);
        }

        //FILTER LIST BUILDER
        public class Builder{

            private List<Product> TempList;
            
            public Builder(List<Product> list)
            {
                this.TempList = list;
            }

            public Builder ByType(ProductType type)
            {
                this.TempList = this.TempList.Where(x => x.ProductType.Equals(type)).ToList();
                return this;
            }

            public Builder StartsWith(string str)
            {
                this.TempList = this.TempList.Where(x => x.ProductName.StartsWith(str)).ToList();
                return this;
            }

            public Builder ByPrice(Comp comp, double value)
            {
                switch (comp)
                {
                    case Comp.Equal:
                        this.TempList = this.TempList.Where(x => (x.Price == value)).ToList();
                        break;
                    case Comp.Higher:
                        this.TempList = this.TempList.Where(x => (x.Price > value)).ToList();
                        break;
                    case Comp.Lower:
                        this.TempList = this.TempList.Where(x => (x.Price < value)).ToList();
                        break;
                }
                return this;
            }

            public List<Product> GetFilteredList()
            {
                return this.TempList;
            }
        }
    }
}
