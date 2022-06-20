using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Entidades
{
    public class ClienteDAO
    {
        private SqlConnection connection;
        private static string connectionString;
        private SqlCommand command;

        static ClienteDAO()
        {
            connectionString = "Server=.;Database=FernandezLautarotp4;Trusted_Connection=True;";
        }

        public ClienteDAO()
        {
            connection = new SqlConnection(ClienteDAO.connectionString);
            command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }
        /// <summary>
        /// A traves de la query, retorna todos los datos que encuentre en una Lista de Clientes.
        /// </summary>
        /// <returns></returns>
        public List<Cliente> CargarDatos()
        {
            List<Cliente> retorno = new List<Cliente>();
            try
            {
                connection.Open();
                string query = "SELECT * FROM Clientes";
                command.CommandText = query;

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    int id = dataReader.GetInt32(0);
                    string nombre = dataReader.GetString(1);
                    string apellido = dataReader.GetString(2);
                    int documento = dataReader.GetInt32(3);
                    int plan = dataReader.GetInt32(4);
                    Cliente cliente = new Cliente(id, nombre, apellido, documento, plan);

                    retorno.Add(cliente);
                }

                return retorno;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection is not null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        /// <summary>
        /// Busca el cliente a traves de una query pasandole como id el parametro idSolicitada. Si lo encuentra lo retorna, sino devuelve default
        /// </summary>
        /// <param name="idSolicitada"></param>
        /// <returns></returns>
        public Cliente BuscarCliente(int idSolicitada)
        {
            Cliente clienteRetorno = default;
            try
            {
                string query = "SELECT * FROM Clientes WHERE NumeroCliente = @id";
                connection.Open();

                command.CommandText = query;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("id", idSolicitada);

                SqlDataReader dataReader = command.ExecuteReader();

                if(dataReader.Read())
                {
                    int id = dataReader.GetInt32(0);
                    string nombre = dataReader.GetString(1);
                    string apellido = dataReader.GetString(2);
                    int documento = dataReader.GetInt32(3);
                    int plan = dataReader.GetInt32(4);
                    clienteRetorno = new Cliente(id, nombre, apellido, documento, plan);
                }
                
                return clienteRetorno;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection is not null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        
        }
        /// <summary>
        /// Elimina el cliente que tenga la id pasada como parametro. El delegado sirve para llamar a la funcion que encapsula
        /// para mostrar un mensaje de exito.
        /// </summary>
        /// <param name="idSolicitado"></param>
        /// <param name="generarMensaje"></param>
        public void Eliminar (int idSolicitado, GeneradorMensaje generarMensaje)
        {
            try
            {
                connection.Open();
                string query = "DELETE FROM Clientes WHERE NumeroCliente = @id"; 
                command.CommandText = query;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("id", idSolicitado);
                command.ExecuteNonQuery();
                
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (connection is not null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }



        }
        /// <summary>
        /// Se agregara el cliente pasado como parametro en la tabla. El delegado sirve para llamar a la funcion que encapsula
        /// para mostrar un mensaje de exito.
        /// </summary>
        /// <param name="cliente"></param>
        /// <param name="generaMensaje"></param>
        public void Agregar(Cliente cliente,GeneradorMensaje generaMensaje)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO Clientes (Nombre,Apellido,Documento,TipoPlan) VALUES(@nombre,@apellido,@documento,@tipoplan)";
                command.CommandText = query;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("nombre",cliente.Nombre);
                command.Parameters.AddWithValue("apellido",cliente.Apellido);
                command.Parameters.AddWithValue("documento",cliente.Documento);
                command.Parameters.AddWithValue("tipoplan", cliente.PlanInt);
                command.ExecuteNonQuery();
                generaMensaje("Cliente agregado con exito!");
            }
            catch (Exception)
            {

                throw;
            }finally
            {
                if (connection is not null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            

        }
        /// <summary>
        /// Se modificara el cliente pasado como parametro
        /// </summary>
        /// <param name="cliente"></param>
        /// <param name="generarMensaje"></param>
        public void Modificar(Cliente cliente,GeneradorMensaje generarMensaje)
        {
            try
            {
                string query = "UPDATE Clientes SET Nombre = @nombre, Apellido = @apellido, Documento = @documento, TipoPlan = @plan WHERE NumeroCliente = @id";
                connection.Open();
                command.CommandText = query;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("nombre",cliente.Nombre);
                command.Parameters.AddWithValue("apellido", cliente.Apellido);
                command.Parameters.AddWithValue("documento", cliente.Documento);
                command.Parameters.AddWithValue("plan", cliente.PlanInt);
                command.Parameters.AddWithValue("id", cliente.Id);
                
                command.ExecuteNonQuery();
                generarMensaje("Cliente modificado!");
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                if (connection is not null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }


        }

    }
}
