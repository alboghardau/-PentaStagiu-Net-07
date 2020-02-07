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
        private List<Product> TempList;

        public ShopService()
        {
            this.ProductsList = new List<Product>();
            this.TempList = new List<Product>();
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

        //FILTER LIST BUILDER
        public void FilterBuilder()
        {
            this.TempList.Clear();
            this.TempList.AddRange(this.ProductsList);
        }

        public void ByType(ProductType type)
        {
            this.TempList = this.TempList.Where( x => x.ProductType.Equals(type)).ToList();
        }

        public void ByFirstNameLetter(char c)
        {

        }

        public void ByPrice(Comp comp,double value)
        {
            switch (comp)
            {

            }
        }

 
        public List<Product> GetFilteredList(){
            return this.TempList;
        }

        public List<Product> GetProductsByTypeAndHigherPrice(ProductType type, double price)
        {
            return this.ProductsList.Where(x => x.ProductType.Equals(type)).Where( x => x.Price > price).ToList();
        }


        

    }
}
