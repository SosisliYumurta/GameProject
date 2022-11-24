using System;
using System.Collections.Generic;
using System.Text;

namespace GameZero
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign, Product product)
        {
            product.Price -= product.Price * campaign.DiscountRate / 100;
            Console.WriteLine(campaign.Name+" Campaign Added"+product.Name+"'s new price is= "+product.Price);

        }

        public void Delete(Campaign campaign, Product product)
        {
            throw new NotImplementedException();
        }

        public void Update(Campaign campaign, Product product)
        {
            throw new NotImplementedException();
        }
    }
}
