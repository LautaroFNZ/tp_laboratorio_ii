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
    public class SerializadorXML<T> : IArchivo<T> where T : class
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
                using (XmlTextReader reader = new XmlTextReader(path))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));
                    return (T)ser.Deserialize(reader);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
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
                using (XmlTextWriter writer = new XmlTextWriter(path,Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));
                    ser.Serialize(writer, dato);
                }

            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

    }
}
