using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_RadioCheckBox
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void btnRevisar_Click(object sender, EventArgs e)
        {
            int divisores = 0;

            int Numero = Convert.ToInt32(txtNumero.Text);
            if (Numero < 0) {
                MessageBox.Show("Ingrese un numero mayor a 0");
            }

            if (rdbButton1.Checked && Numero % 2 == 0)
            {
                txtResultado.Text = "Es par";
            }
            else if (rdbButton2.Checked && Numero % 2 == 1)
            {
                txtResultado.Text = "Es impar";
            }
            else if (rdbButton3.Checked)
            {
                for (int i = 0; i < Numero; i++)
                {
                    i++;
                    if (Numero % i == 0)
                    {
                        divisores += i;
                    }
                }

                txtResultado.Text = "Es Perfecto";
            }
            else
            {
                txtResultado.Text = "Elija otro radioButton, el seleccionado no es correcto";
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtNumero.Text = "";
            rdbButton1.Checked = false;
            rdbButton2.Checked = false;
            rdbButton3.Checked = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }
    }
}
