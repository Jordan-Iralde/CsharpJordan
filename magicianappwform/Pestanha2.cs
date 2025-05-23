using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace magicianappwform
{
    public partial class Pestanha2: Form
    {
        public Pestanha2()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnText_Click(object sender, EventArgs e)
        {
            lblHello.Text = "Hola Mundo";
            MessageBox.Show("Hola mundo");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            lblData.Text = $"{txtUser.Text}\n{txtPassword.Text}";
            MessageBox.Show(lblData.Text);
        }

        private void Pestanha2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
