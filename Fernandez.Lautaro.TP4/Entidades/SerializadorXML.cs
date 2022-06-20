using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Entidades
{
    public class SerializadorXML<T> : IManejadorDeArchivos<T> where T : class
    {

        /// <summary>
        /// Lee el archivo xml.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public T Leer(string path)
        {
            try
            {
                if (path != null || path != string.Empty)
                {
                    using (XmlTextReader reader = new XmlTextReader(path))
                    {
                        XmlSerializer ser = new XmlSerializer(typeof(T));
                        return (T)ser.Deserialize(reader);
                    }
                }
                else
                {
                    throw new FileNotFoundException("No se ha encontrado el archivo!");
                }

            }
            catch (FileNotFoundException ex)
            {
                throw new FileNotFoundException(ex.Message);

            }
            catch (Exception)
            {
                throw new Exception("ERROR AL LEER EL ARCHIVO!");
            }

        }

        /// <summary>
        /// Crea, de no existir, o escribe los datos en un archivo xml. 
        /// </summary>
        /// <param name="dato"></param>
        /// <param name="path"></param>
        public void Escribir(T dato, string path)
        {
            try
            {
                if (path != null || path != string.Empty)
                {
                    using (XmlTextWriter writer = new XmlTextWriter(path, Encoding.UTF8))
                    {
                        XmlSerializer ser = new XmlSerializer(typeof(T));
                        ser.Serialize(writer, dato);
                    }
                }
                else
                {
                    throw new FileNotFoundException("No se ha encontrado el archivo!");
                }

            }
            catch (FileNotFoundException ex)
            {
                throw new FileNotFoundException(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

    }
}