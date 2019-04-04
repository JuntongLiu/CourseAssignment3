using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning32Arv
{
    public class NumericInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a numberic input in a text only field. this fired an error!";
        }

    }
}
