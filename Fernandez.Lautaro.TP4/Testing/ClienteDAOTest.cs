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
    public class ClienteDAOTest
    {
        [TestMethod]
        public void BuscarCliente_CuandoElIdEsNegativo_DeberiaRetornarDefault()
        {
            // Arrange
            int id = -1;
            ClienteDAO clienteDAO = new ClienteDAO();
            Cliente expected = default;

            // Act
            Cliente cliente = clienteDAO.BuscarCliente(id);

            //Assert
            Assert.AreEqual(expected, cliente);
        }

        [TestMethod]
        public void BuscarCliente_CuandoElIdEsCero_DeberiaRetornarDefault()
        {
            // Arrange
            int id = 0;
            ClienteDAO clienteDAO = new ClienteDAO();
            Cliente expected = default;

            // Act
            Cliente cliente = clienteDAO.BuscarCliente(id);

            //Assert
            Assert.AreEqual(expected, cliente);
        }

    }
}
