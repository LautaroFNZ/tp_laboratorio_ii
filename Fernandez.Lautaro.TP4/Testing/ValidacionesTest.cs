using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;


namespace Testing
{
    [TestClass]
    public class ValidacionesTest
    {
        [TestMethod]
        public void validarIsEmpty_UnCampoNull_DeberiaRetornarTrue()
        {
            //Arrange
            string nullCampo = null;
            string param1 = "asd";
            string param2 = "asd";
            bool expected = true;

            //Act
            bool retorno = Validaciones.validarIsEmpty(nullCampo, param1, param2);

            //Assert
            Assert.AreEqual(expected, retorno);
        }

        [TestMethod]
        public void validarIsEmpty_UnCampoVacioYOtroNull_DeberiaRetornarTrue()
        {
            //Arrange
            string nullCampo = null;
            string param1 = string.Empty;
            string param2 = "asd";
            bool expected = true;

            //Act
            bool retorno = Validaciones.validarIsEmpty(nullCampo, param1, param2);

            //Assert
            Assert.AreEqual(expected, retorno);
        }

        [TestMethod]
        public void validarIsEmpty_TodosCamposNull_DeberiaRetornarTrue()
        {
            //Arrange
            string param1 = null;
            string param2 = null;
            string param3 = null;
            bool expected = true;

            //Act
            bool retorno = Validaciones.validarIsEmpty(param1, param2, param3);

            //Assert
            Assert.AreEqual(expected, retorno);
        }

        [TestMethod]
        public void validarEsNumerico_ParametroNull_DeberiaRetornarFalse()
        {
            //Arrange
            bool expected = false;

            //Act
            bool retorno = Validaciones.validarEsNumerico(null);

            //Assert
            Assert.AreEqual(expected, retorno);
        }

        [TestMethod]
        public void validarEsNumerico_NumeroConSigno_DeberiaRetornarFalse()
        {
            //Arrange
            string param = "2;";
            bool expected = false;

            //Act
            bool retorno = Validaciones.validarEsNumerico(param);

            //Assert
            Assert.AreEqual(expected, retorno);
        }
    }
}
