using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class Cliente
    {
        private int id;
        private string nombre;
        private string apellido;
        private int documento;
        private Plan plan;
        
        #region Propiedades
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Documento
        {
            get
            {
                return this.documento;
            }

            set
            {
                this.documento = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }

            set
            {
                this.nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;

            }

            set
            {
                this.apellido = value;
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
        /// <summary>
        /// A diferencia de los demas, sirve para la clase ClienteDAO
        /// </summary>
        public int PlanInt
        {
            get
            {
                
                return (int)this.plan;
            }
        }


        #endregion

        #region Constructores 

        public Cliente()
        {
            this.id = 0;
            this.nombre = "nombre";
            this.apellido = "apellido";
            this.documento = 0;
            this.plan = Plan.Basico;
        }

        public Cliente(string nombre,string apellido)
            :this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public Cliente(int id,string nombre,string apellido,int documento,int plan)
            :this(nombre,apellido)
        {
            this.id = id;
            this.documento = documento;
            this.plan = (Plan)plan;
        }

        public Cliente(string id,string nombre,string apellido,string documento,string plan)
            :this(nombre,apellido)
        {
            this.id = int.Parse(id);
            this.documento = int.Parse(documento);
            this.plan = (Plan)Enum.Parse(typeof(Plan), plan, true);
        }




        #endregion
        
        #region Sobreescritura de operadores
        /// <summary>
        /// Dos clientes son iguales si su documento es igual.
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>
        public static bool operator ==(Cliente c1,Cliente c2)
        {
            return c1.Documento == c2.Documento;
        }
        /// <summary>
        /// Dos clientes son distintos si su documento varia.
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>
        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1==c2);
        }

        #endregion

        #region Sobreescritura de metodos
        /// <summary>
        /// Sobre escritura del metodo Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            Cliente cliente = obj as Cliente;

            return cliente is not null && this == cliente;
        }
        /// <summary>
        /// Sobre escritura del metodo ToString a traves de StringBuilder.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"ID:{Id}{Environment.NewLine}");
            sb.Append($"Nombre:{Nombre}{Environment.NewLine}");
            sb.Append($"Apellido:{Apellido}{Environment.NewLine}");
            sb.Append($"DNI:{Documento}{Environment.NewLine}");
            sb.Append($"Plan:{Plan}{Environment.NewLine}");

            return sb.ToString(); 
        }


        #endregion


    }

}
