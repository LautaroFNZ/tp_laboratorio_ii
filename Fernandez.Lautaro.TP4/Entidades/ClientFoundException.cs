using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClientFoundException : Exception
    {
        public ClientFoundException(string message)
            : base(message) { }


        public ClientFoundException(string message, Exception innerException)
            : base(message, innerException) { }
        
            

    }
}
