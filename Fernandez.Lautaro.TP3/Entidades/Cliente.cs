using System.Linq;
using System.Text;
using System;
using System.Collections.Generic;

namespace Entidades
{
    public class Cliente : Persona
    {
        private int nroCliente;
        private Plan plan;

        #region Propiedad

        public int NroCliente
        {
            get
            {
                return this.nroCliente;
            }

            set
            {
                this.nroCliente = value;
            }
        }

        public Plan Plan
        {
            get
            {
                return this.plan;
            }

            set
            {
                this.plan = value;
            }
        }

        #endregion

        #region Constructores

        public Cliente()
            : base() 
        {
            this.nroCliente = 0;
            this.Plan = (Plan)1000;
        }

        public Cliente(string nroCliente) 
            :this()
        {
            this.nroCliente = int.Parse(nroCliente);
        }

        public Cliente(string documento,string nombre, string apellido, string nrocliente)
            :base(documento, nombre,apellido)
        {
            this.nroCliente = int.Parse(nrocliente);
        }

        public Cliente(string documento, string nombre, string apellido, int codigoServ, string nroCliente)
            : base(documento, nombre, apellido)
        {
            
            this.Plan = (Plan)codigoServ;
        }

        public Cliente(string documento, string nombre, string apellido, string codigoServ, string nroCliente)
            :this(documento,nombre,apellido,nroCliente)
        {
            this.Plan = (Plan)Enum.Parse(typeof(Plan), codigoServ, true);
        }




        #endregion


        /// <summary>
        /// Busca el cliente que le pasamos como parametro en la lista
        /// </summary>
        /// <param name="listaCliente"></param>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public Cliente ClienteBuscado(List<Cliente> listaCliente, Cliente cliente)
        {            
            if(listaCliente.Count>0)
            {
                foreach (Cliente aux in listaCliente)
                {
                    if (aux == cliente)
                    {   
                        
                        return aux;
                    }
                }
            }            

            return null;            
        }

        #region Sobrecarga Operadores
        public static List<Cliente> operator +(List<Cliente> listaCliente,Cliente cliente)
        { 
            foreach(Cliente aux in listaCliente)
            {
                if(aux.Equals(cliente))
                {
                    return listaCliente;//indica que el cliente ya esta en la lista, por ende no lo agrega
                }

                //listaCliente.Add(cliente);
            }

            listaCliente.Add(cliente);

            return listaCliente;
        }

        public static List<Cliente> operator -(List<Cliente> listaCliente, Cliente cliente)
        {
            Cliente aux = new Cliente();

            if(listaCliente.Count>0)
            {
                if(aux.ClienteBuscado(listaCliente,cliente) is not null)
                {
                    listaCliente.Remove(cliente);
                }
            }
                      

            return listaCliente;
        }


        /// <summary>
        /// Si dos clientes comparten su numero son iguales. 
        /// </summary>
        /// <param name="cliente1"></param>
        /// <param name="cliente2"></param>
        /// <returns></returns>
        public static bool operator ==(Cliente cliente1, Cliente cliente2)
        {
            return cliente1.NroCliente == cliente2.NroCliente;
                

        }

        public static bool operator !=(Cliente cliente1, Cliente cliente2)
        {
            return !(cliente1 == cliente2);
        }
        #endregion

        #region Sobreescritura de metodos
        public override bool Equals(object obj)
        {
            Cliente cliente = obj as Cliente;

            return cliente is not null && this == cliente;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"DNI:{Documento}{Environment.NewLine}");
            sb.Append($"Nombre:{Nombre}{Environment.NewLine}");
            sb.Append($"Apellido:{Apellido}{Environment.NewLine}");
            sb.Append($"Servicio Contratado: Plan {Plan}{Environment.NewLine}");
            sb.Append($"Numero de Cliente:N°{NroCliente}{Environment.NewLine}");

            return sb.ToString();
        }
        #endregion  

    }



}
