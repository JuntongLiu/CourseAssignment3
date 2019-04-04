using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning32Arv
{
    class Program
    {
        static void Main(string[] args)
        {
            List<UserError> userErrorsList = new List<UserError>();

            UserError numericInputError = new NumericInputError();
            UserError textInputError = new TextInputError();

            // put onto list
            userErrorsList.Add(numericInputError);
            userErrorsList.Add(textInputError);

            // foreach loop
            foreach(UserError err in userErrorsList)
            {
                Console.WriteLine(err.UEMessage());
            }

         // 3.4 ---- 7
         
            FunctionReturnTypeError functionReturnTypeError = new FunctionReturnTypeError();
            TypeCastError typeCastError = new TypeCastError();
            FunctionArgumentError functionArgumentError = new FunctionArgumentError();

            List<UserError> userErrorList = new List<UserError>();
            

            UserError[] userError = new UserError[10]; //  { typeCastError,  functionReturnTypeError,functionArgumentError };
            userError[0] = typeCastError;
            userError[1] = functionReturnTypeError;
            userError[2] = functionArgumentError;

            Console.WriteLine("Error happened: " + userError[2]);
            Console.ReadKey();
        }
    }
}
