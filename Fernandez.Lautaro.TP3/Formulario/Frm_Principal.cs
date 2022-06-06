using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        public Frm_Principal()
        {
            InitializeComponent();
            cargarServicios("servicios.txt", rtb_Servicios);
            serializadorclientes = new SerializadorXML<List<Cliente>>();
            listaClientes = new List<Cliente>(serializadorclientes.Leer("datos.xml"));
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
                using (StreamReader sr = new StreamReader(path))
                {
                    String servicio;

                    while ((servicio = sr.ReadLine()) != null)
                    {
                        servicios.Text += string.Concat($"{servicio}\n");
                    }
                }

            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("No se ha encontrado el archivo 'servicios.txt'");
            }

        }

        /// <summary>
        /// Esta funcion se encarga de limpiar el datagrid y nuevamente cargarle la lista clientes, hace la funcion de un F5 por asi decirlo.
        /// </summary>
        private void ActualizarDatos()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaClientes;
        }

        /// <summary>
        /// Esta funcion se encarga de encontrar o no al cliente que se establece a partir del nroCliente. 
        /// Controla mediante un condicional si el cliente fue encontrado o no y limpia el textbox
        /// </summary>
        /// <param name="clientes">lista donde se buscara el cliente</param>
        /// <param name="nroCliente">numero en formato string para construir el objeto y que se busque en la lista</param>
        /// <returns></returns>
        private Cliente buscarCliente(List<Cliente> clientes, string nroCliente)
        {
            Cliente clienteBuscado = new Cliente(nroCliente);

            clienteBuscado = clienteBuscado.ClienteBuscado(clientes, clienteBuscado);

            if (clienteBuscado is not null)
            {
                MessageBox.Show(clienteBuscado.ToString());
                txt_nroCliente.Text = string.Empty;
                return clienteBuscado;
            }
            else
            {
                MessageBox.Show("No se ha encontrado al cliente");
                txt_nroCliente.Text = string.Empty;

            }

            return clienteBuscado;
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente();
                cliente = buscarCliente(listaClientes, txt_nroCliente.Text);
                Cliente clienteBackUp = new Cliente();

                if (cliente is not null)
                {
                    clienteBackUp = cliente;
                    
                    DialogResult resultado = MessageBox.Show("Desea gestionar el cliente encontrado?", "Acceder a Gestion de Clientes", MessageBoxButtons.YesNoCancel);
                    if (resultado == DialogResult.Yes)
                    {   
                        Frm_ABM frm = new Frm_ABM(cliente);
                        DialogResult estado = frm.ShowDialog();
                        
                        if (estado == DialogResult.Abort)
                        {
                            EliminarCliente(frm);
                        }

                        if(estado == DialogResult.None)
                        {
                            int nro = cliente.NroCliente;
                            listaClientes -= cliente;
                            ModificarCliente(frm,nro);
                            MessageBox.Show("Modificacion no implementada");//no pude implementar esta funcion. La logica era eliminar el
                                                                            //elemento encontrado y agregar otro con el mismo nro de cliente
                        }                                                   
                    }                 
                }
                else
                { 
                    DialogResult r = MessageBox.Show("Desea agregar un cliente?", "Agregar cliente", MessageBoxButtons.YesNo);
                    if (r == DialogResult.Yes)
                    {
                        Frm_ABM frm = new Frm_ABM();
                        DialogResult resultado = frm.ShowDialog();

                        if(resultado == DialogResult.OK)
                        {
                            AgregarCliente(frm);
                        }
                    }
                }
                

            }catch(FormatException ex)
            {
                MessageBox.Show("ERROR.No deje el campo vacio ni ingrese letras!");
                txt_nroCliente.Text = string.Empty;
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            Frm_ABM fr = new Frm_ABM();

            DialogResult resultado = fr.ShowDialog();

            if(resultado==DialogResult.OK)
            {
                AgregarCliente(fr);
            }
        }

        /// <summary>
        /// Esta funcion se encarga de obtener el cliente que retorna la propiedad del formulario ABM y agregarlo a la lista de clientes
        /// </summary>
        /// <param name="fr"></param> 
        private void AgregarCliente(Frm_ABM fr)
        {
            Cliente cliente = new Cliente();
            cliente = fr.RetornarCliente;
            cliente.NroCliente = GenerarNroCliente(listaClientes);
            listaClientes += cliente;

            MessageBox.Show("Cliente agregado con exito!");

            ActualizarDatos();
        }
        /// <summary>
        /// Esta funcion se encarga de obtener el cliente que retorna la propiedad del formulario ABM y eliminarlo a la lista de clientes
        /// </summary>
        /// <param name="fr"></param>
        private void EliminarCliente(Frm_ABM fr)
        {
            Cliente cliente = new Cliente();

            cliente = fr.RetornarCliente;

            listaClientes -= cliente;
            MessageBox.Show("Cliente eliminado con exito!");
            ActualizarDatos();
        }
        private void ModificarCliente(Frm_ABM fr, int nroClientePrevioAModificar)
        {
            Cliente clienteModificado = new Cliente();

            clienteModificado = fr.RetornarCliente;
            clienteModificado.NroCliente = nroClientePrevioAModificar;
            listaClientes += clienteModificado;

            ActualizarDatos();
        }

        /// <summary>
        /// Esta funcion se encarga de generar el nroCliente, sumandole al ultimo item de la lista un numero mas en el campo nroCliente
        /// </summary>
        /// <param name="lista"></param>
        /// <returns></returns>
        public int GenerarNroCliente(List<Cliente> lista)
        {
            int nroGenerado = 0;
            int i = 0;

            foreach (Cliente aux in lista)
            {
                i++;

                if (i == lista.Count)
                {
                    nroGenerado = aux.NroCliente + 1;
                }
            }

            return nroGenerado;
        }
        
        private void btn_GuardarNuevosDatos_Click(object sender, EventArgs e)
        {

            GuardarDatos("datos.xml");
        }

        private void Frm_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult resultado = MessageBox.Show("Quiere guardar los datos antes de salir?", "Salir", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    GuardarDatos("datos.xml");
                }
                else
                {
                    Application.Exit();
                }
            }
        }
        /// <summary>
        /// Esta funcion se encarga de serializar los datos de la lista en el path pasado como parametro
        /// </summary>
        /// <param name="path"></param>
        private void GuardarDatos(string path)
        {

            try
            {
                if (listaClientes.Count > 0)
                {
                    serializadorclientes.Escribir(listaClientes, path);

                    MessageBox.Show("Elementos guardados con exito!");

                }
                else
                {
                    MessageBox.Show("No hay elementos para guardar");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR al guardar los datos");
            }
        }
    }
}
