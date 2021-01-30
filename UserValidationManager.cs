using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectExample
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1985 && gamer.FirstName == "NISA"
            && gamer.LastName == "BALCI" && gamer.IdentityNumber == 123)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
