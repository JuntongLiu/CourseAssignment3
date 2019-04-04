using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning32Arv
{
    class TypeCastError : UserError
    {
        public override string UEMessage()
        {
            return "It is not valide to cast the type, this cause the error";
        }
    }
}
