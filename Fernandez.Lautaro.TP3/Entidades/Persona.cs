using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        private int documento;
        private string nombre;
        private string apellido;
        

        #region Propiedades
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

        
        #endregion

        #region Constructores
        public Persona()
        {
            this.documento = 00000000;
            this.nombre = "nombre";
            this.apellido = "apellido";           
        }

        public Persona(string documento)
        {
            this.documento = int.Parse(documento);
        }

        public Persona(string documento, string nombre, string apellido) : this(documento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }


        #endregion

        #region Sobrecarga de operadores
        public static bool operator ==(Persona persona1,Persona persona2)
        {
            return persona1.Documento == persona2.Documento;
        }

        public static bool operator !=(Persona persona1, Persona persona2)
        {
            return !(persona1 == persona2);
        }
        #endregion

        #region Sobrescritura
        public override bool Equals(object obj)
        {
            Persona persona = obj as Persona;
            return persona is not null && this == persona;
        }
        #endregion
    }
}
