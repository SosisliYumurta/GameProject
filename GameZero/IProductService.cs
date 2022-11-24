using System;
using System.Collections.Generic;
using System.Text;

namespace GameZero
{
    interface IProductService
    {
        void Add(Product product);
        void Delete(Product product);
        void Update(Product product);
    }
}
