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
            double resultado;
            bool huboOperacion = false;
            char operador;
            bool validado = char.TryParse(cmbOperadores.Text, out operador);

            Operando num1 = new Operando(txtNumero1.Text);
            Operando num2 = new Operando(txtNumero2.Text);

            if (validado)
            {
                resultado = Calculadora.Operar(num1, num2, operador);
                huboOperacion = true;
            }
            else
            {
                operador = '+';
                resultado = Calculadora.Operar(num1, num2, operador);
                huboOperacion = true;
            }

            if(huboOperacion)
            {
                txtResultado.Text = resultado.ToString();
                StringBuilder sb = new StringBuilder();
                sb.Append(txtNumero1.Text + " " + operador + " " + txtNumero2.Text + " = " + resultado);
                lstOperaciones.Items.Insert(0,sb.ToString());
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
            lstOperaciones.Items.Add(resultAdd);
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
            lstOperaciones.Items.Add(resultAdd);
        }

        private void Limpiar()
        {
            txtResultado.Text = "0";
            txtNumero1.Text = "0";
            txtNumero2.Text = "0";
            cmbOperadores.SelectedIndex = 0;
        }
    }
}
