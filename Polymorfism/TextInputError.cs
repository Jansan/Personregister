using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorfism
{
    class TextInputError : UserError
    {
        public override string UEMessage()
        {
            return $"You tried to use a text input in a numericonly field an error!";
        }
    }
}
