using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorfism
{
    class UserNameError : UserError
    {
        public override string UEMessage()
        {
            return $"Your user name is error";
        }
    }
}
