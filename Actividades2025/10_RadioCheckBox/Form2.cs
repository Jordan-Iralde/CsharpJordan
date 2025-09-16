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
        int Total = 0;

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNuevaCompra_Click(object sender, EventArgs e)
        {
            txtCantidad1.Text = "";
            txtCantidad2.Text = "";
            txtCantidad3.Text = "";
            txtCantidad4.Text = "";
            
            txtSubtotal.Text = "";
            txtIva.Text = "";
            txtTotal.Text = "";

            chkBox1.Checked = false;
            chkBox2.Checked = false;
            chkBox3.Checked = false;
            chkBox4.Checked = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
        }

        private void chkBox1_Click(object sender, EventArgs e)
        {
            if (chkBox1.Checked) { 
                txtCantidad1.Enabled = true;
            }
        }
    }
}
