using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndumentariaCheckbox
{
    public partial class Form1 : Form
    {
        // 300000 Camisa 
        // 100000 Remera
        // 150000 Pantalon
        // 500000 Campera
        // 200000 Zapatilla
        public Form1()
        {
            InitializeComponent();
        }
        int total = 0;
        private void grpbox_Enter(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            total = 0;
            if (checkBox.Checked)
            {
                int valor = Convert.ToInt32(lblCamisa.Text);
                total += valor;
            }
            if (checkBox2.Checked) {
                total += Convert.ToInt32(lblRemera.Text);
            }
            if (checkBox3.Checked)
            {
                total += Convert.ToInt32(lblPantalon.Text);
            }
            if (checkBox4.Checked)
            {
                total += Convert.ToInt32(lblCampera.Text);
            }
            if (checkBox5.Checked)
            {
                total += Convert.ToInt32(lblZapatillas.Text);
            }
            lblTotal.Text = total.ToString();
        }
    }
}
