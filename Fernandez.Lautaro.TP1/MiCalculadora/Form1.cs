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

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            cmbOperadores.Items.Add(' ');
            cmbOperadores.Items.Add('+');
            cmbOperadores.Items.Add('-');
            cmbOperadores.Items.Add('*');
            cmbOperadores.Items.Add('/');
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult resultado = MessageBox.Show("Estas seguro que deseas salir?", "Salir", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            //
            double resultado = Operar(txtNum1.Text, txtNum2.Text, ((char)cmbOperadores.SelectedItem));

            //mostrar resultado

            string num1 = txtNum1.Text;
            string num2 = txtNum2.Text;
            string operador = cmbOperadores.SelectedItem.ToString();


            if (resultado != Double.MinValue)
            {
                listBoxHistorial.Items.Add(num1 + " " + operador + " " + num2 + " = " + resultado);
                txtResultado.Text = resultado.ToString();
            }
            else
            {
                listBoxHistorial.Items.Add(num1 + " " + operador + " " + num2 + resultado);
                txtResultado.Text = "Syntax Error";

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Estas seguro que deseas salir ? ", "Salir", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            string control = "";

            if (txtResultado.Text != "" || txtResultado.Text != "Syntax Error" || txtResultado.Text != "Valor Inválido")
            {
                control = txtResultado.Text;
            }

            Operando binario = new Operando();

            string resultAdd = binario.DecimalBinario(control);
            txtResultado.Text = resultAdd;
            listBoxHistorial.Items.Add(resultAdd);
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            string control = "";

            if (txtResultado.Text != "" || txtResultado.Text != "Syntax Error" || txtResultado.Text != "Valor Inválido")
            {
                control = txtResultado.Text;
            }

            Operando binario = new Operando();

            string resultAdd = binario.BinarioDecimal(control);
            txtResultado.Text = resultAdd;
            listBoxHistorial.Items.Add(resultAdd);
        }
    }
}
