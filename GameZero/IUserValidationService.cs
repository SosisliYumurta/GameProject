using System;
using System.Collections.Generic;
using System.Text;

namespace GameZero
{
    interface IUserValidationService
    {
        bool Validate(User user);
    }
}
