using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        int Contador = 0;           // ESTO ES MUY IMPORTANTE LO APRENDI HOY 05/08/2025
        private void btnSubmit_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text)){
                MessageBox.Show("No valido");
                Contador++;
            }
            if (txtName.Text == "jordan" && txtPassword.Text == "12345678"){
                MessageBox.Show("Ingreso correctamente");
            }
            else            {
                MessageBox.Show("Se equivoco con los datos");
                Contador++;
            }
            if (Contador == 3)
            {
                btnSubmit.Enabled = false;
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
