using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistanciaRecorrida
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double Distancia = 0;
        

        private void btnCalcular_Click(object sender, EventArgs e)
        {
   
            if (double.TryParse(txtVelocidad.Text, out double numero) && double.TryParse(txtTiempo.Text, out double numero2))
            {
                Distancia = numero * numero2;
                txtResultado.Text = Convert.ToString(Distancia) + " metros";
            }
            else
            {
                MessageBox.Show("Datos no validos");
            }
        }

        private void txtVelocidad_TextChanged(object sender, EventArgs e)
        {

            if (double.TryParse(txtVelocidad.Text, out double numero) && string.IsNullOrWhiteSpace(txtVelocidad.Text))
            {
                MessageBox.Show("Datos no validos, ingrese numeros");
            }
            else
            {
                txtTiempo.Enabled = true;
            }
        }

        private void txtTiempo_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtVelocidad.Text, out double numero) && string.IsNullOrWhiteSpace(txtVelocidad.Text))
            {
                MessageBox.Show("Datos no validos, ingrese numeros");
            }
            else
            {
                btnCalcular.Enabled = true;
            }
        }
    }
}
