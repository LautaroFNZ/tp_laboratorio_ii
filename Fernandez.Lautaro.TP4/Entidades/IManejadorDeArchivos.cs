using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IManejadorDeArchivos<T> where T: class
    {
        /// <summary>
        /// Lee el archivo
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        T Leer(string path);

        /// <summary>
        /// Si el archivo existe, le escribe los datos. De no existir, lo crea.
        /// </summary>
        /// <param name="dato"></param>
        /// <param name="path"></param>
        void Escribir(T dato, string path);

    }
}
