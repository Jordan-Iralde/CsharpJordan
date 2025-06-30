using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace CalculadoraWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnSumar_Click(object sender, EventArgs e)
        {
            AgregarOperador("+");
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            AgregarOperador("-");
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            AgregarOperador("*");
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            AgregarOperador("/");
        }

        private void AgregarOperador(string operador)
        {
            if (txtCalculo.Text.Length == 0) return;

            char ultimo = txtCalculo.Text[txtCalculo.Text.Length - 1];
            if ("+-*/".Contains(ultimo)) return;

            txtCalculo.Text += operador;
        }


        private void btnNumero_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            txtCalculo.Text += btn.Text;
        }

        // ================= ACCIONES =================

        private void btnLimpiarTodo_Click(object sender, EventArgs e)
        {
            txtCalculo.Clear();
            txtResultado.Clear();
        }

        private void btnBorrarUno_Click(object sender, EventArgs e)
        {
            if (txtCalculo.Text.Length > 0)
            {
                txtCalculo.Text = txtCalculo.Text.Remove(txtCalculo.Text.Length - 1);
            }
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            if (txtCalculo.Text.Length == 0 || TerminaEnOperador())
            {
                txtResultado.Text = "Expresión inválida";
                return;
            }

            try
            {
                var resultado = new DataTable().Compute(txtCalculo.Text, null);
                txtResultado.Text = resultado.ToString();
            }
            catch
            {
                txtResultado.Text = "Error de cálculo";
            }
        }

        private bool TerminaEnOperador()
        {
            if (txtCalculo.Text.Length == 0) return true;
            char lastChar = txtCalculo.Text[txtCalculo.Text.Length - 1];
            return "+-*/".Contains(lastChar);
        }
    }
}
