using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultaCEP.API.Exceptions
{
    public class CepExceptionsLib : Exception
    {
        public CepExceptionsLib()
        {
        }

        public CepExceptionsLib(string message)
            : base(message)
        {
        }

        public CepExceptionsLib(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
