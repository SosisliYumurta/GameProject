using System;
using System.Collections.Generic;
using System.Text;

namespace GameZero
{
    interface ISalesService 
    {
        void Sell(User user, Product product);
    }
}
