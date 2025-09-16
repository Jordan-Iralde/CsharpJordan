using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace respuestasPostulantes
{
    public partial class respuestasPostulantes : Form
    {
        public respuestasPostulantes()
        {
            InitializeComponent();
        }

        int Total = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCorrrectas.Text) && string.IsNullOrWhiteSpace(txtBlanco.Text) && string.IsNullOrWhiteSpace(txtIncorrectas.Text))
            {

                MessageBox.Show("Por favor, ingrese valores válidos en todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                int Correctas = Convert.ToInt32(txtCorrrectas.Text);
                int Incorrectas = Convert.ToInt32(txtIncorrectas.Text);
                int Blanco = Convert.ToInt32(txtBlanco.Text);
                Total += (Correctas * 4) + (Incorrectas * -1) - (Blanco * 0);
            }


                lblTotal.Visible = true;
            lblTotal.Text = Total.ToString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtBlanco.Clear();
            txtIncorrectas.Clear();
            txtCorrrectas.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
