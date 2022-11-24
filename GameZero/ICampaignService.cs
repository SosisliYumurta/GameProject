using System;
using System.Collections.Generic;
using System.Text;

namespace GameZero
{
    interface ICampaignService
    {
        void Add(Campaign campaign, Product product);
        void Delete(Campaign campaign, Product product);
        void Update(Campaign campaign, Product product);
    }
}
