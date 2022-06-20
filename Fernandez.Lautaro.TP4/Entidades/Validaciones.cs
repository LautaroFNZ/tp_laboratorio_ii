using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Validaciones
    {
        #region Funciones de validacion de datos
        /// <summary>
        /// Valida que el campo ingresado es correcto, y que ninguno este vacio.
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="name"></param>
        /// <param name="lname"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        public static bool ValidarCampos(string dni, string name, string lname, string code, Action vaciadorCampos,GeneradorMensaje mensaje)
        {
            bool retorno = true;

            if (validarIsEmpty(dni, name, lname))
            {
                mensaje("\tALERTA!\nNo deje ningun campo vacio!");
                vaciadorCampos();
                retorno = false;
            }


            if (!validarEsNumerico(dni))
            {
                mensaje("\tALERTA!\nIngrese un valor válido para\n el DNI!");
                vaciadorCampos();
                retorno = false;
            }

            if (validarEsNumerico(name))
            {
                mensaje("\tALERTA!\nIngrese un valor válido para\nel NOMBRE!");
                vaciadorCampos();
                retorno = false;
            }

            if (validarEsNumerico(lname))
            {
                mensaje("\tALERTA!\nIngrese un valor válido para\n el APELLIDO!");
                vaciadorCampos();
                retorno = false;
            }

            //if (!validarPlan(code))
            //{
            //    MessageBox.Show("\tALERTA\nIngrese un valor válido para\n el CÓDIGO DEL PLAN!");
            //    txt_code.Text = string.Empty;
            //    retorno = false;
            //}
            return retorno;
        }
        /// <summary>
        /// Esta funcion se encarga de determinar si el parametro string que le pasamos contiene o no datos numericos.
        /// </summary>
        /// <param name="ingreso"></param>
        /// <returns></returns>
        public static bool validarEsNumerico(string ingreso)
        {
            int numero;
            bool result = Int32.TryParse(ingreso, out numero);

            return result;
        }
        /// <summary>
        /// Esta funcion de verificar si los campos estan vacios o no
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="name"></param>
        /// <param name="lname"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        public static bool validarIsEmpty(string dni, string name, string lname)
        {
            if (dni == string.Empty || dni == null || name == string.Empty || name == null || lname == string.Empty || lname == null)
            {
                return true;
            }

            return false;
        }
        
        
        #endregion
    }
}
