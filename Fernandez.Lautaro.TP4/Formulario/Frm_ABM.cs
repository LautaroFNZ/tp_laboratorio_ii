using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Formulario
{
    public partial class Frm_ABM : Form
    {
        Cliente cliente;
        /// <summary>
        /// Este evento se encargara de asignar los botones para la manipulacion del cliente
        /// </summary>
        public event GestionDeClienteEncontrado asignarBotonesGestion;
        

        /// <summary>
        /// Retorna el campo cliente del Frm_ABM
        /// </summary>
        public Cliente RetornarCliente
        {
            get { return cliente; }
        }

        public Frm_ABM()
        {
            InitializeComponent();
            this.txt_nroCliente.Text = "0";
            CargarComboBox(Plan.Basico);
        }
        /// <summary>
        /// Constructor con un parametro, sirve para eliminar y modificar el cliente obtenido.
        /// </summary>
        /// <param name="cliente"></param>
        public Frm_ABM(Cliente cliente)
        {
            InitializeComponent();
            this.txt_Documento.Text = cliente.Documento.ToString();
            this.txt_Nombre.Text = cliente.Nombre;
            this.txt_Apellido.Text = cliente.Apellido;
            CargarComboBox(cliente.Plan);
            this.txt_nroCliente.Text = cliente.Id.ToString();
            this.lb_nroCliente.Text = "Numero de cliente:";

            asignarBotonesGestion += BotonesGestion;

            asignarBotonesGestion.Invoke();
        }
        /// <summary>
        /// Metodo que sera encapsulado por el delegado del evento asignarBotonesGestion.
        /// </summary>
        private void BotonesGestion()
        {
            this.btn_Agregar.Enabled = false;
            this.btn_Editar.Enabled = true;
            this.btn_Eliminar.Enabled = true;
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validaciones.ValidarCampos(txt_Documento.Text, txt_Nombre.Text, txt_Apellido.Text, cbox_Plan.SelectedItem.ToString(),VaciarCampos,Frm_Principal.GeneradorDeMensaje))
                {
                    cliente = new Cliente(txt_nroCliente.Text,txt_Nombre.Text,txt_Apellido.Text,txt_Documento.Text,cbox_Plan.SelectedItem.ToString());
                    this.DialogResult = DialogResult.OK;
                }
            
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Esta seguro que desea eliminar?", "Eliminar", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    if (Validaciones.validarIsEmpty(txt_Documento.Text, txt_Nombre.Text, txt_Apellido.Text))
                    {
                        throw new Exception("\tALERTA!\nNo deje ningun campo vacio!");
                    }
                    else
                    {
                        cliente = new Cliente(txt_nroCliente.Text,txt_Nombre.Text,txt_Apellido.Text,txt_Documento.Text,cbox_Plan.SelectedItem.ToString());

                        this.DialogResult = DialogResult.Abort;
                    }
                }
                    catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Esta seguro que desea editar?", "Editar", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    if (Validaciones.validarIsEmpty(txt_Documento.Text, txt_Nombre.Text, txt_Apellido.Text))
                    {
                        throw new Exception("\tALERTA!\nNo deje ningun campo vacio!");
                    }
                    else
                    {
                        cliente = new Cliente(txt_nroCliente.Text, txt_Nombre.Text, txt_Apellido.Text, txt_Documento.Text, cbox_Plan.SelectedItem.ToString());
                        this.DialogResult = DialogResult.Ignore;
                    }

                }
                catch (Exception ex)
                {
                     MessageBox.Show(ex.Message);
                }
        }


        }

        /// <summary>
        /// Esta funcion se encarga de limpiar todos los textBox. La encapsula delegado de tipo Action
        /// </summary>
        private void VaciarCampos()
        {
            txt_Documento.Text = string.Empty;
            txt_Nombre.Text = string.Empty;
            txt_Apellido.Text = string.Empty;
            cbox_Plan.SelectedIndex = 0;
        }

        /// <summary>
        /// Esta funcion se encarga de cargar y determinar el selectedItem pasado como parametro.
        /// </summary>
        /// <param name="plan"></param>
        private void CargarComboBox(Plan plan)
        {
            this.cbox_Plan.Items.Add(Plan.Basico);
            this.cbox_Plan.Items.Add(Plan.Inicial);
            this.cbox_Plan.Items.Add(Plan.Premiun);
            this.cbox_Plan.Items.Add(Plan.Familiar);
            this.cbox_Plan.Items.Add(Plan.Empresa);
            this.cbox_Plan.SelectedIndex = DeterminarItem(plan);          
            

        }
        /// <summary>
        /// Esta funcion se encarga dedeterminar el plan y asi su 
        /// index para pasarle al selectedIndex y establecerlo en el combobox.
        /// </summary>
        /// <param name="plan"></param>
        /// <returns></returns>
        private int DeterminarItem(Plan plan)
        {
            int retorno = -1;
            switch (plan)
            {
                case Plan.Basico:
                    retorno= 0;
                    break;
                case Plan.Inicial:
                    retorno= 1;
                    break;
                case Plan.Premiun:
                    retorno= 2;
                    break;
                case Plan.Familiar:
                    retorno= 3;
                    break;
                case Plan.Empresa:
                    retorno= 4;
                    break;
                default:
                    retorno = 0;
                    break;
            }

            return retorno;
        }

    }
}
