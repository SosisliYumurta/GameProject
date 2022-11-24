using System;
using System.Collections.Generic;
using System.Text;

namespace GameZero
{
    class ProductManager : IProductService
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.Name+" Added");
        }

        public void Delete(Product product)
        {
            Console.WriteLine(product.Name + " Deleted");

        }

        public void Update(Product product)
        {
            Console.WriteLine(product.Name + " Updated");

        }
    }
}
