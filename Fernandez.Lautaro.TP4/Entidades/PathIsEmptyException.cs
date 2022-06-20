using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PathIsEmptyException : Exception
    {
        public PathIsEmptyException(string mensaje) : base(mensaje) { }

        public PathIsEmptyException(string mensaje, Exception innerException) : base(mensaje, innerException) { }
        
    }
}
