using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorfism
{
    class PasswordError : UserError
    {
        public override string UEMessage()
        {
            return $"Your password is error";
        }
    }
}
