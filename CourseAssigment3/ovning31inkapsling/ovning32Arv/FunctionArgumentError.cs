using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning32Arv
{
    class FunctionArgumentError : UserError
    {
        public override string UEMessage()
        {
            return "Function Argument Error. this fired an error!";
        }
    }
}
