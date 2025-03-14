﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo
    {
        public enum EMarca
        {
            Chevrolet, 
            Ford, 
            Renault, 
            Toyota, 
            BMW, 
            Honda, 
            HarleyDavidson
        }
        public enum ETamanio
        {
            Chico, 
            Mediano, 
            Grande
        }

        #region Atributos
        private EMarca marca;
        private string chasis;
        private ConsoleColor color;
        #endregion 

        public Vehiculo(EMarca marca, string chasis, ConsoleColor color)
        {
            this.marca = marca;
            this.chasis = chasis;
            this.color = color;
        }


        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        protected virtual ETamanio Tamanio { get; }
        

        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            return (string)this;
        }

        public static explicit operator string(Vehiculo p)
        {
            StringBuilder sb = new StringBuilder();

            //sb.AppendFormat("CHASIS: {0}\r\n", p.chasis);
            sb.Append($"CHASIS: {p.chasis}\r\n");
            //sb.AppendLine();
            //sb.AppendFormat("MARCA : {0}\r\n", p.marca.ToString());
            sb.Append($"MARCA: {p.marca}\r\n");
            //sb.AppendLine();
            //sb.AppendFormat("COLOR : {0}\r\n", p.color.ToString());
            sb.Append($"COLOR: {p.color}\r\n");
            sb.AppendLine("---------------------");
            sb.Append($"\nTAMAÑO: {p.Tamanio}\r");

            return sb.ToString();
        }

        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return v1.chasis == v2.chasis;
        }
        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
    }
}
