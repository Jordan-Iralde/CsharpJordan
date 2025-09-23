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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            curso1.Checked = false;
            curso2.Checked = false;
            curso3.Checked = false;
            curso4.Checked = false;
            curso5.Checked = false;
            curso6.Checked = false;
            curso7.Checked = false;
            curso8.Checked = false;
        
            rdbButtonOption1.Checked = false;
            rdbButtonOption2.Checked = false;

            txtIva.Text = "";
            txtSubtotal.Text = "";
            txtTotal.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form3.ActiveForm.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            isChecked(sender, e);
        }

        private void isChecked(object sender, EventArgs e)
        {
            double subtotal = 0;
            double iva = 0;
            double total = 0;
            if (curso1.Checked) {
                subtotal += 200;
            } 
            if (curso2.Checked) {
                subtotal += 2000;
            }
            if (curso3.Checked) {
                subtotal += 25000;
            }
            if (curso4.Checked) {
                subtotal += 15000;
            }
            if (curso5.Checked) {
                subtotal += 20000;
            }
            if (curso6.Checked) {
                subtotal += 35000;
            }
            if (curso7.Checked) {
                subtotal += 10000;
            }
            if (curso8.Checked) {
                subtotal += 4850;
            }

            if (rdbButtonOption2.Checked) 
            {
                subtotal += subtotal * 15 / 100;
            }
               
            iva = subtotal * 21 / 100;
            total = subtotal + iva;
            
            txtSubtotal.Text = Convert.ToString(subtotal);
            txtIva.Text = Convert.ToString(iva);
            txtTotal.Text = Convert.ToString(total);
        }
    }
}
