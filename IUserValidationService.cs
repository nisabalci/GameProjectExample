using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectExample
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
