using System;

namespace GameZero
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();
            user1.FirstName = "Oguz";

            IUserValidationService userValidationService = new UserValidationManager();

            UserManager userManager = new UserManager(userValidationService);
            userManager.Add(user1);


            Product table = new Product() { Id = 1, Name = "Table", Price = 100 };
            ProductManager productManager = new ProductManager();
            productManager.Add(table);

            Console.WriteLine("table price is= "+table.Price);

            Campaign blackFriday = new Campaign() { Name = "Black Friday", DiscountRate = 10 };
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(blackFriday, table);

            Console.WriteLine("table price is= "+table.Price);

            SalesManager salesManager = new SalesManager();
            salesManager.Sell(user1, table);
        }
    }
}
