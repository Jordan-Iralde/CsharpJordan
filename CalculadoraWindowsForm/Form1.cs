using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (txtCalculo.Text.Length == 0)
            {
                txtCalculo.Text += "";

            }
            else
            {
                txtCalculo.Text += "*";

            }
        }
        private void btnSumar_Click(object sender, EventArgs e)
        {
            txtCalculo.Text += "+";
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            txtCalculo.Text += "-";
        }
        private void btnDividir_Click(object sender, EventArgs e)
        {
            txtCalculo.Text += "/";

        }


        private void btnLimpiarTodo_Click(object sender, EventArgs e)
        {
            txtCalculo.Clear();
            txtResultado.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtCalculo.Text.Length > 0)
            {
                txtCalculo.Text = txtCalculo.Text.Remove(txtCalculo.Text.Length - 1);
            }
        }
        //---------------------------------
        private void btn1_Click(object sender, EventArgs e)
        {
            txtCalculo.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtCalculo.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtCalculo.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtCalculo.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtCalculo.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtCalculo.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtCalculo.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtCalculo.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtCalculo.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtCalculo.Text += "0";
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            if (txtCalculo.Text.Remove(txtCalculo.Text.Length - 1) == "*")
            {
            }
            else
            {
                string[] numeros = txtCalculo.Text.Split('*');
                int resultado = Convert.ToInt32(numeros[0]) * Convert.ToInt32(numeros[1]);
                txtResultado.Text = Convert.ToString(resultado);
            }
        }
        private void btnNumero_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            //esto para verificar si el boton es un numero y no es un dato
            //VACIO
            if (button != null)
            {
                txtCalculo.Text += button.Text;
            }
        }

 
    }
}