using System;
using Entidades;
using System.Collections.Generic;
using System.Xml;
using System.Text;
using System.Xml.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace pruebaConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            SerializadorXML<List<Cliente>>

            



            






            Console.ReadKey();
        }


        public static Cliente buscarCliente(List<Cliente> clientes, string nroCliente)
        {
            Cliente clienteBuscado = new Cliente(nroCliente);

            clienteBuscado = clienteBuscado.ClienteBuscado(clientes, clienteBuscado);

            if (clienteBuscado is not null)
            {
                //MessageBox.Show(clienteBuscado.ToString());
                //txb_NumeroCliente.Text = string.Empty;
                Console.WriteLine(clienteBuscado.ToString());
                return clienteBuscado;
            }
            else
            {
                //MessageBox.Show("No se ha encontrado al cliente");
                Console.WriteLine("No se ha encontrado al cliente");
                //txb_NumeroCliente.Text = string.Empty;

            }

            return clienteBuscado;
        }
    }
}
