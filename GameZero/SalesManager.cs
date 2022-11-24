using System;
using System.Collections.Generic;
using System.Text;

namespace GameZero
{
    class SalesManager : ISalesService
    {
        public void Sell(User user, Product product)
        {
            Console.WriteLine(product.Price+" "+product.Name+" sold to "+user.FirstName);

        }
    }
}
