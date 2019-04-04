using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning32Arv
{
    class FunctionReturnTypeError : UserError 
    {
        public override string UEMessage()
        {
            return "Functon tried to return a wrong type, this cause the error";
        } 
    }
}
