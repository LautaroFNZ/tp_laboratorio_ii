using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class StringMessages
    {
        /// <summary>
        /// Metodo de extension que retorna un mensaje de despedida
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>        
        public static string Saludo(this String s)
        {
            return "Gracias por usar nuestro programa!\n\tVuelva Prontos!";
        }
        /// <summary>
        /// Metodo de extension que retorna un mensaje de error al buscar.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string BuscarError(this String s)
        {
            return "Ingrese un id!";
        }


    }
}
