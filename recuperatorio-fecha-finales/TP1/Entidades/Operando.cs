using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        /// <summary>
        /// Constructor sin parametros, que asigna un valor al campo numero.
        /// </summary>
        public Operando()
        {
            this.numero = 0;
        }

        /// <summary>
        /// Sobrecarga de constructor que permite asignarle al campo numero el parametro de tipo double.
        /// </summary>
        /// <param name="numero">Se le asigna al campo numero.</param>
        public Operando(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// Este setter sirve para llamar a ValidarOperando y settearle el dato de tipo string al campo double.
        /// </summary>
        private string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }

        /// <summary>
        /// Sobrecarga del constructor que asigna el parametro de tipo string mediante el setter previamente explicado.
        /// </summary>
        /// <param name="strNumero">Variable a asignar.</param>
        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }

        /// <summary>
        /// Valida que el operando de tipo string contenga todos numeros, y de ser asi lo devuelve.
        /// </summary>
        /// <param name="strNumero">Parametro de tipo string a validar</param>
        /// <returns>0 en caso de contener letras o el numero en caso de no contenerlas.</returns>
        private double ValidarOperando(string strNumero)
        {
            int numero;
            double retorno = 0;

            bool result = Int32.TryParse(strNumero, out numero);

            if (result)
            {
                retorno = numero;
            }

            return retorno;
        }

        /// <summary>
        /// Se encarga de determinar que parametro string sea o no binario.
        /// </summary>
        /// <param name="nroBinario">Parametro a analizar.</param>
        /// <returns>Retorna false en caso de no ser binario, y true en caso de serlo</returns>
        private bool EsBinario(string nroBinario)
        {
            int comparador = 0;

            foreach (char c in nroBinario)
            {
                if (c == '0' || c == '1')
                {
                    comparador++;
                }
            }

            bool retorno = false;

            if (comparador == nroBinario.Length)
            {
                retorno = true;
            }


            return retorno;
        }

        /// <summary>
        /// Esta funcion se encarga de convertir el parametro string de Binario a decimal, validando que el parametro sea binario.
        /// </summary>
        /// <param name="nroBinario">String a analizar.</param>
        /// <returns>Si pudo convertir el parametro a decimal lo retorna, y de no ser asi retorna mensaje de error.</returns>
        public string BinarioDecimal(string nroBinario)
        {
            string retorno = "Valor Inválido";
            int numero;

            if (EsBinario(nroBinario))
            {
                numero = Convert.ToInt32(nroBinario, 2);
                retorno = Math.Abs(numero).ToString();
            }


            return retorno;
        }

        /// <summary>
        /// Convierte el numero de decimal a binario, en caso de este ser decimal. 
        /// </summary>
        /// <param name="numero">parametro a analizar</param>
        /// <returns>mensaje de error, o el resultado del parametro convertido a binario</returns>
        public string DecimalBinario(double numero)
        {
            string retorno = "Valor inválido";
            string nroBinario;
            if (numero > 0 && EsBinario(numero.ToString()) == false)
            {
                nroBinario = Convert.ToString((int)numero, 2);

                if (EsBinario(nroBinario))
                {
                    retorno = nroBinario;
                }
            }

            return retorno;
        }

        /// <summary>
        /// Sobrecarga de la funcion, pero esta vez hace lo mismo recibiendo un parametro de tipo string
        /// </summary>
        /// <param name="numeroStr">parametro a analizar</param>
        /// <returns>El numero convertido a binario o mensaje de error.</returns>
        public string DecimalBinario(string numeroStr)
        {
            string retorno = "Valor inválido";

            if (EsBinario(numeroStr) == false)
            {
                double numero = Double.Parse(numeroStr);
                retorno = DecimalBinario(numero);
            }

            return retorno;
        }
        /// <summary>
        /// Sobrecarga de operador +
        /// </summary>
        /// <param name="num1">A través de este accede al campo a sumar</param>
        /// <param name="num2">A través de este accede al campo a sumar</param>
        /// <returns>La suma de los parametros.</returns>
        public static double operator +(Operando num1, Operando num2)
        {
            double suma = num1.numero + num2.numero;
            return suma;
        }


        /// <summary>
        /// Sobrecarga de operador -
        /// </summary>
        /// <param name="num1">A través de este accede al campo a restar</param>
        /// <param name="num2">A través de este accede al campo a restar</param>
        /// <returns>La resta de los parametros</returns>
        public static double operator -(Operando num1, Operando num2)
        {
            double suma = num1.numero - num2.numero;
            return suma;
        }
        /// <summary>
        /// Sobrecarga de operador *
        /// </summary>
        /// <param name="num1">A través de este accede al campo a multiplicar</param>
        /// <param name="num2">A través de este accede al campo a multiplicar</param>
        /// <returns>Multiplicación de los parametros</returns>
        public static double operator *(Operando num1, Operando num2)
        {
            double suma = num1.numero * num2.numero;
            return suma;
        }
        /// <summary>
        /// Sobrecarga de operador /
        /// </summary>
        /// <param name="num1">A través de este accede al campo a dividir</param>
        /// <param name="num2">A través de este accede al campo a dividir</param>
        /// <returns>La resta en caso de ser posible.</returns>
        public static double operator /(Operando num1, Operando num2)
        {
            return num2.numero != 0 ? num1.numero / num2.numero : double.MinValue;
            //if (num2.numero != 0)
            //{
            //    return num1.numero / num2.numero;
            //}


            //return double.MinValue;
        }
    }
}
