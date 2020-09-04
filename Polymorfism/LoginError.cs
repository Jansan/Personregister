using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorfism
{
    class LoginError : UserError
    {
        public override string UEMessage()
        {
            return $"login is error";
        }
    }
}
