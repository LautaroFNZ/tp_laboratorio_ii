using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Entidades;


namespace Formulario
{
    public partial class Frm_Principal : Form
    {
        List<Cliente> listaClientes;
        SerializadorXML<List<Cliente>> serializadorclientes;
        ClienteDAO clientesDB;
        public delegate void GuardadorDeDatos();
        GuardadorDeDatos guardadorDeDatos;

        public event ModoOscuro cambiarModoOscuro;
        public event ModoOscuro cambiarModoClaro;

        public Frm_Principal()
        {
            InitializeComponent();
            this.cargarServicios("servicios.txt", rtb_Servicios);
            serializadorclientes = new SerializadorXML<List<Cliente>>();
            clientesDB = new ClienteDAO();
            cambiarModoOscuro += ActivarModoOscuro;
            cambiarModoClaro += ModoClaro;
            ActualizarDatos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmFyH.Enabled = true;          
        }

        private void tmFyH_Tick(object sender, EventArgs e)
        {
            lb_Fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lb_Hora.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        /// <summary>
        /// Esta funcion se encarga de leer el archivo txt y concatenarlo en el richtextbox
        /// </summary>
        /// <param name="path"></param>
        /// <param name="servicios"></param>
        private void cargarServicios(string path, RichTextBox servicios)
        {
            try
            {
                if (path != string.Empty)
                {
                    using (StreamReader sr = new StreamReader(path))
                    {
                        String servicio;

                        while ((servicio = sr.ReadLine()) != null)
                        {
                            servicios.Text += string.Concat($"{servicio}\n");
                        }
                    }
                }
                else
                {
                    throw new PathIsEmptyException("La ruta esta vacia!");
                }
            
            }catch(PathIsEmptyException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("No se ha encontrado el archivo 'servicios.txt'");

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Esta funcion se encarga de limpiar el datagrid y nuevamente cargarle la lista clientes, hace la funcion de un F5 por asi decirlo.
        /// </summary>
        private void ActualizarDatos()
        {
            listaClientes = clientesDB.CargarDatos();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaClientes;
        }
        
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            int id = 0;
            bool existe = false;
            String mensaje = "";

            if (txt_nroCliente.Text != string.Empty)
            {
                id = int.Parse(txt_nroCliente.Text);
                existe = listaClientes.Exists(cliente => cliente.Id == id);

            }
            else MessageBox.Show(mensaje.BuscarError());
            
            if (existe)
            {
                Cliente encontrado = clientesDB.BuscarCliente(id);
                MessageBox.Show(encontrado.ToString());

                DialogResult resultado = MessageBox.Show("Desea gestionar el cliente encontrado?", "Acceder a Gestion de Clientes", MessageBoxButtons.YesNoCancel);

                try
                {
                    if (resultado == DialogResult.Yes)
                    {
                        Frm_ABM frm = new Frm_ABM(encontrado);
                        DialogResult estado = frm.ShowDialog();

                        if (estado == DialogResult.Abort)
                        {
                            clientesDB.Eliminar(encontrado.Id, GeneradorDeMensaje);
                            
                        }

                        if (estado == DialogResult.Ignore)
                        {
                            clientesDB.Modificar(frm.RetornarCliente,GeneradorDeMensaje);
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }finally
                {
                    ActualizarDatos();
                }
            }
            else
            {
                MessageBox.Show("El cliente no existe");
                
            }

            txt_nroCliente.Text = string.Empty;
        }
        
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            Frm_ABM fr = new Frm_ABM();
            DialogResult resultado = fr.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                Cliente clienteAgregar = fr.RetornarCliente;

                bool existe = listaClientes.Exists(cliente => cliente.Documento == clienteAgregar.Documento);

                try
                {
                    if (!existe)
                    {
                        clientesDB.Agregar(clienteAgregar, GeneradorDeMensaje);
                        ActualizarDatos();
                    }
                    else
                    {
                        throw new ClientFoundException("El cliente ya se encuentra cargado!");
                    }
                }
                catch (ClientFoundException ex)
                {
                    MessageBox.Show(ex.Message);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        
        private async void btn_GuardarNuevosDatos_Click(object sender, EventArgs e)
        {
            try
            {
                string retorno = await SerializarDatos(GuardarXML);
                MessageBox.Show(retorno);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private  void Frm_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            String mensaje = "";
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult resultado = MessageBox.Show("Estas seguro que deseas salir?", "Salir", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    MessageBox.Show(mensaje.Saludo());
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
        
        /// <summary>
        /// Esta funcion sera encapsulada por un delegado, el cual generara mensajes dentro de la biblioteca de clases.
        /// </summary>
        /// <param name="mensaje"></param> el mensaje que se mostrara por pantalla.
        public static void GeneradorDeMensaje(string mensaje)
        {
            if(mensaje != string.Empty)
            {
                MessageBox.Show(mensaje);
            }
            else
            {
                MessageBox.Show("Error en el mensaje");
            }

        }

        /// <summary>
        /// Funcion que serialira los datos, manejada en otro Hilo para no 
        /// </summary>
        /// <param name="guardadorDeDatos"></param>
        /// <returns></returns>
        public static async Task<string> SerializarDatos(GuardadorDeDatos guardadorDeDatos)
        {
            string informacion = await Task.Run(() =>
            {
                Thread.Sleep(3000);// Con fines didacticos.
                guardadorDeDatos.Invoke();

                return "Se han guardado los datos como:\n\t'datos.xml'!";
            });
            

            

            if(informacion.Length < 0)
            {
                throw new Exception("No se han podido guardar los datos!");
            }


            return informacion;
        }

        /// <summary>
        /// Se encarga de llamar a la funcion escribir del serializador xml.
        /// </summary>
        private void GuardarXML()
        {
            listaClientes = clientesDB.CargarDatos();
            serializadorclientes.Escribir(listaClientes, "datos.xml");
        }
        /// <summary>
        /// Se usara en el evento cambiarModoOscuro
        /// </summary>
        private void ActivarModoOscuro()
        {
            this.lb_List.ForeColor = Color.White;
            this.lb_Servicios.ForeColor = Color.White;
            this.BackColor = Color.Black;
        }
        /// <summary>
        /// Se usara en el evento cambiarModoClaro
        /// </summary>
        private void ModoClaro()
        {
            this.lb_List.ForeColor = Color.Black;
            this.lb_Servicios.ForeColor = Color.Black;
            this.BackColor = Color.White;

        }

        private void chb_darkMode_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_darkMode.Checked)
            {
                if (cambiarModoOscuro is not null)
                {
                    cambiarModoOscuro.Invoke();
                }
            }
            else
            {
                if (cambiarModoClaro is not null)
                {
                    cambiarModoClaro.Invoke();
                }
            }
        }

        
    }
}
