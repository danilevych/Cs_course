using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HomeWork6
{
    class СheckTheValidityOfInputParametersException : ApplicationException
    {
        public СheckTheValidityOfInputParametersException(string message) : base(message) { }
    }
}
