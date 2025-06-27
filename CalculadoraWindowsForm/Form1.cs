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
        public int numeroUno()
        {
            int numero1 = Convert.ToInt32(txtNumero1.Text);
            return numero1;
        }

        public int numeroDos()
        {
            int numero2 = Convert.ToInt32(txtNumero2.Text);
            return numero2;
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
       
            int resultado = numeroUno() * numeroDos();

            txtResultado.Text = Convert.ToString(resultado);

        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int resultado = numeroUno() + numeroDos();

            txtResultado.Text = Convert.ToString(resultado);
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            int resultado = numeroUno() - numeroDos();

            txtResultado.Text = Convert.ToString(resultado);
        }

        public int btnDividir_Click(object sender, EventArgs e)
        {
            int resultado = numeroUno() / numeroDos();

            return resultado;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }
        private void btnLimpiarTodo_Click(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtResultado.Clear();
        }
        
        public int btn1_Click()
        {
            var numero = 1;
            return numero;
        }
        public int btn2_Click()
        {
            var numero = 2;
            return numero;
        }
        public int btn3_Click()
        {
            var numero = 3;
            return numero;
        }
        public int btn4_Click()
        {
            var numero = 4;
            return numero;
        }
        public int btn5_Click()
        {
            var numero = 5;
            return numero;
        }
        public int btn6_Click()
        {
            var numero = 6;
            return numero;
        }

        public int btn7_Click()
        {
            var numero = 7;
            return numero;
        }
        public int btn8_Click()
        {
            var numero = 8;
            return numero;
        }
        public int btn9_Click()
        {
            var numero = 9;
            return numero;
        }
        private void txtResultado_Click(object sender, EventArgs e)
        {
            txtResultado.Text = btn1_Click().ToString();
        }



        private void btnResultado_Click(object sender, EventArgs e)
        {
            b btn1 = btn1_Click();
            int btn2 = btn2_Click();
            int btn3 = btn3_Click();
            int btn4 = btn4_Click();
            int btn5 = btn5_Click();
            int btn6 = btn6_Click();
            int btn7 = btn7_Click();
            int btn8 = btn8_Click();
            int btn9 = btn9_Click();

            if (btn1)
            {
                var numeroPresionado = btn1;
            }
            var NumerosPresionados = new string[] { numeroPresionado };

            for (int i = 0; i < NumerosPresionados.Length; i++)
            {
                 numeroPresionado += $"{i}";
            }
            txtCalculo.Text = numeroPresionado;
        }
    }
}
