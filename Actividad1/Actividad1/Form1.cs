using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad1
{
    public partial class Actividad1: Form
    {
        public Actividad1()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Hola {txtNombre.Text}");
            lblResultado.Text = "Hola " + txtNombre.Text;
        }

        private void Actividad1_Load(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(txtInput1.Text);
            int numero2 = Convert.ToInt32(txtInput2.Text);
            int total = numero1 + numero2;
            lblTotal.Text = $"{total}";
        }
    }
}
