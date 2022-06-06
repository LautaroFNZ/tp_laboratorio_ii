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
            this.txt_code.Text = cliente.Plan.ToString();
            this.txt_nroCliente.Text = cliente.NroCliente.ToString();
            this.lb_nroCliente.Text = "Numero de cliente:";

            this.btn_Agregar.Enabled = false;
            this.btn_Editar.Enabled = true;
            this.btn_Eliminar.Enabled = true;
        }

        /// <summary>
        /// Valida que el campo ingresado es correcto, y que ninguno este vacio.
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="name"></param>
        /// <param name="lname"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        private bool ValidarCampos(string dni, string name, string lname, string code)
        {
            bool retorno = true;

            if(validarIsEmpty(dni,name,lname,code))
            {
                MessageBox.Show("\tALERTA!\nNo deje ningun campo vacio!");
                VaciarCampos();
                retorno = false;
            }
            

            if (!validarEsNumerico(dni))
            {
                MessageBox.Show("\tALERTA!\nIngrese un valor válido para\n el DNI!");
                txt_Documento.Text = string.Empty;
                retorno = false;
            }

            if (validarEsNumerico(name))
            {
                MessageBox.Show("\tALERTA!\nIngrese un valor válido para\nel NOMBRE!");
                txt_Nombre.Text = string.Empty;
                retorno = false;
            }

            if (validarEsNumerico(lname))
            {
                MessageBox.Show("\tALERTA!\nIngrese un valor válido para\n el APELLIDO!");
                txt_Apellido.Text = string.Empty;
                retorno = false;
            }

            if (!validarPlan(code))
            {
                MessageBox.Show("\tALERTA\nIngrese un valor válido para\n el CÓDIGO DEL PLAN!");
                txt_code.Text = string.Empty;
                retorno = false;
            }
            return retorno;
        }
        
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos(txt_Documento.Text, txt_Nombre.Text, txt_Apellido.Text, txt_code.Text))
                {
                    cliente = new Cliente(txt_Documento.Text, txt_Nombre.Text, txt_Apellido.Text, txt_code.Text, txt_nroCliente.Text);
                    this.DialogResult = DialogResult.OK;            
                }
                else
                {
                    
                }

            }catch(FormatException ex)
            {
                MessageBox.Show("\tERROR\nIngrese correctamente los \ndatos solicitados");
            }catch(Exception ex)
            {
                MessageBox.Show("\tERROR\nIngrese correctamente los \ndatos solicitados");
            }
            
            
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Esta seguro que desea eliminar?", "Eliminar", MessageBoxButtons.YesNo);

            if(resultado == DialogResult.Yes)
            {   
                if(validarIsEmpty(txt_Documento.Text, txt_Nombre.Text, txt_Apellido.Text, txt_code.Text))
                {
                    MessageBox.Show("\tALERTA!\nNo deje ningun campo vacio!");
                }
                else
                {
                    cliente = new Cliente(txt_Documento.Text, txt_Nombre.Text, txt_Apellido.Text, txt_code.Text, txt_nroCliente.Text);

                    this.DialogResult = DialogResult.Abort;
                }
            }
            
            
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (validarIsEmpty(txt_Documento.Text, txt_Nombre.Text, txt_Apellido.Text, txt_code.Text))
            {
                MessageBox.Show("\tALERTA!\nNo deje ningun campo vacio!");
            }
            else
            {
                if(!validarPlan(txt_code.Text))
                {
                    cliente = new Cliente(txt_Documento.Text, txt_Nombre.Text, txt_Apellido.Text, txt_code.Text, txt_nroCliente.Text);
                    this.DialogResult = DialogResult.None;
                }
                else
                {
                    cliente = new Cliente(txt_Documento.Text, txt_Nombre.Text, txt_Apellido.Text, txt_code.Text, txt_nroCliente.Text);
                    this.DialogResult = DialogResult.None;
                }
            }
        }

        /// <summary>
        /// Esta funcion se encarga de validar que el plan pasado como parametro sea uno de los datos numericos constantes del enumerado
        /// </summary>
        /// <param name="ingreso"></param>
        /// <returns></returns>
        private bool validarPlan(string codigo)
        {
            int numero;

            bool result = Int32.TryParse(codigo, out numero);

            if(result)
            {
                if (numero<1005 && numero>999)
                {
                    return true;
                }
            }

            return false;
        }
        /// <summary>
        /// Esta funcion se encarga de determinar si el parametro string que le pasamos contiene o no datos numericos.
        /// </summary>
        /// <param name="ingreso"></param>
        /// <returns></returns>
        private bool validarEsNumerico(string ingreso)
        {
            int numero;
            bool result = Int32.TryParse(ingreso,out numero);
                      
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
        private bool validarIsEmpty(string dni,string name,string lname,string code)
        {
            if (dni == string.Empty || name == string.Empty || lname == string.Empty || code == string.Empty)
            {
                return true;
            }

            return false;
        }
        /// <summary>
        /// Esta funcion sirve para vaciar los campos
        /// </summary>
        private void VaciarCampos()
        {
            txt_Documento.Text = string.Empty;
            txt_Nombre.Text = string.Empty;
            txt_Apellido.Text = string.Empty;
            txt_code.Text = string.Empty;
        }
        

        
    }
}
