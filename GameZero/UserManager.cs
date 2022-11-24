using System;
using System.Collections.Generic;
using System.Text;

namespace GameZero
{
    class UserManager : IUserService
    {
        IUserValidationService userValidationService;

        public UserManager(IUserValidationService userValidationService)
        {
            this.userValidationService = userValidationService;
        }

        public void Add(User user)
        {
            if (userValidationService.Validate(user))
                Console.WriteLine(user.FirstName+" Added");
            else
                Console.WriteLine(user.FirstName+" Failed");
        }

        public void Delete(User user)
        {
            Console.WriteLine(user.FirstName + " deleted");

        }

        public void Update(User user)
        {
            Console.WriteLine(user.FirstName + " updated");

        }
    }
}
