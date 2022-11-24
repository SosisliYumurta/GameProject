using System;
using System.Collections.Generic;
using System.Text;

namespace GameZero
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(User user)
        {
            if (user.FirstName == "Oguz")
                return true;
            else
                return false;
        }
    }
}
