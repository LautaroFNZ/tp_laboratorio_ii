using System;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Valida el operador que se le pasa por parametro, y en caso de no encontrar similitudes devuelve +
        /// </summary>
        /// <param name="operador">Obtiene el operador el cual va a validar</param>
        /// <returns></returns>
        private static char ValidarOperador(char operador)
        {

            char retorno;

            switch (operador)
            {
                case '+':
                    retorno = operador;
                    break;
                case '-':
                    retorno = operador;
                    break;
                case '*':
                    retorno = operador;
                    break;
                case '/':
                    retorno = operador;
                    break;
                default:
                    retorno = '+';
                    break;

            }

            return retorno;
        }

        /// <summary>
        /// Realiza la operacion correspondiente al operador validado a traves de la sobrecarga de operadores
        /// </summary>
        /// <param name="num1">hace referencia a un numero</param>
        /// <param name="num2">hace referencia a un numero</param>
        /// <param name="operador">sirve para llamar a la funcion que valida el operador</param>
        /// <returns>Retorna el resultado de la operación</returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double resultado = 0;

            char operadorValidado = ValidarOperador(operador);

            switch (operadorValidado)
            {
                case '+':
                    resultado = num1 + num2; //SOBRECARGA DE OPERADORES
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                case '/':
                    resultado = num1 / num2;
                    break;
                default:
                    break;
            }

            return resultado;
        }

    } 

    

}
