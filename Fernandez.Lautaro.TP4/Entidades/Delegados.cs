using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //Este apartado solo contiene delegados que se utilizaran en las distintas clases de la bilbioteca.

    public delegate void GeneradorMensaje(string mensaje);

    public delegate void GestionDeClienteEncontrado();

    public delegate void ModoOscuro();
}
