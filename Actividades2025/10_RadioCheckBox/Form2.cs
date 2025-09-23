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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Close();
        }

        private void btnNuevaCompra_Click(object sender, EventArgs e)
        {
            txtCantidad1.Text = "0";
            txtCantidad2.Text = "0";
            txtCantidad3.Text = "0";
            txtCantidad4.Text = "0";

            txtSubtotal.Text = "";
            txtIva.Text = "";
            txtTotal.Text = "";

            txtCantidad1.Enabled = false;
            txtCantidad2.Enabled = false;
            txtCantidad3.Enabled = false;
            txtCantidad4.Enabled = false;

            chkBox1.Checked = false;
            chkBox2.Checked = false;
            chkBox3.Checked = false;
            chkBox4.Checked = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            isNotNull();
            int c1 = Convert.ToInt32(txtCantidad1.Text);
            double cantidad1 = c1 * 85.5;

            int c2 = Convert.ToInt32(txtCantidad2.Text);
            double cantidad2 = c2 * 90;

            int c3 = Convert.ToInt32(txtCantidad3.Text);
            double cantidad3 = c3 * 105;

            int c4 = Convert.ToInt32(txtCantidad4.Text);
            double cantidad4 = c4 * 95.5;

            double subtotal = cantidad1 + cantidad2 + cantidad3 + cantidad4;
            double IVA = subtotal * 21 / 100;
            double Total = subtotal + IVA;
            txtSubtotal.Text = Convert.ToString(subtotal);
            txtIva.Text = Convert.ToString(IVA);
            txtTotal.Text = Convert.ToString(Total);


        }

        private void chkBox1_Click(object sender, EventArgs e)
        {
            IsChecked();
        }

        private void chkBox2_Click(object sender, EventArgs e)
        {
            IsChecked();
        }

        private void chkBox3_Click(object sender, EventArgs e)
        {
            IsChecked();
        }

        private void chkBox4_Click(object sender, EventArgs e)
        {
            IsChecked();
        }


        private void IsChecked()
        {
            if (chkBox1.Checked == true)
            {
                txtCantidad1.Enabled = true;
            }
            else
            {
                txtCantidad1.Text = "0";
                txtCantidad1.Enabled = false;
            }



            if (chkBox2.Checked == true)
            {
                txtCantidad2.Enabled = true;
            }
            else
            {
                txtCantidad2.Text = "0";
                txtCantidad2.Enabled = false;
            }


            if (chkBox3.Checked == true)
            {
                txtCantidad3.Enabled = true;
            }
            else
            {
                txtCantidad3.Enabled = false;
                txtCantidad3.Text = "0";
            }



            if (chkBox4.Checked == true)
            {
                txtCantidad4.Enabled = true;
            }
            else 
            {
                txtCantidad4.Enabled = false;
                txtCantidad4.Text = "0";
            }
        }

        private void isNotNull()
        {
            if (txtCantidad1.Text == "")
            {
                txtCantidad1.Text = "0";
            }
            else if (txtCantidad2.Text == "")
            {
                txtCantidad2.Text = "0";
            }
            else if(txtCantidad3.Text == "")
            {
                txtCantidad3.Text = "0";
            }
            else if(txtCantidad4.Text == "")
            {
                txtCantidad4.Text = "0";
            }
        }
    }
}
