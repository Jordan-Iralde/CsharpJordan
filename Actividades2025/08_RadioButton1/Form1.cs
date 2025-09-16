using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosRadioButton1
{
    public partial class FrmIngresos : Form
    {
        public FrmIngresos()
        {
            InitializeComponent();
        }
        double Total = 0;
        int EleccionTrabajo = 0;
        int Bonificacion = 0;
        private void FrmIngresos_Load(object sender, EventArgs e)
        {

        }

        private void rdbMaestro_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMaestro.Checked)
            {
                EleccionTrabajo = 1;
            }
        }

        private void rdbOperario_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbOperario.Checked)
            {
                EleccionTrabajo = 2;
            }
        }

        private void rdbPeon_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPeon.Checked)
            {
                EleccionTrabajo = 3;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDays.Text) && string.IsNullOrWhiteSpace(txtName.Text))
            {

                MessageBox.Show("Por favor, ingrese valores válidos en todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                int diasTrabajados = Convert.ToInt32(txtDays.Text);

                Total = 0;

                if (EleccionTrabajo == 1)
                {
                    Total += 15000 * diasTrabajados;
                    txtIngresos.Text = Total.ToString();
                }
                else if (EleccionTrabajo == 2)
                {
                    Total += 9500 * diasTrabajados;
                    txtIngresos.Text = Total.ToString();
                }
                else
                {
                    Total += 7500 * diasTrabajados;
                    txtIngresos.Text = Total.ToString();
                }



                if (Bonificacion == 1)
                {
                    double BonificacionAplicada = Total * 20 / 100;
                    Total += BonificacionAplicada;
                    txtBonification.Text = BonificacionAplicada.ToString();
                }
                if (Bonificacion == 2)
                {
                    double BonificacionAplicada = Total * 10 / 100;
                    Total += BonificacionAplicada;
                    txtBonification.Text = BonificacionAplicada.ToString();
                }



                txtTotal.Text = Total.ToString();
            }
        }

        private void rdbEstable_CheckedChanged(object sender, EventArgs e)
        {
            
            if (rdbEstable.Checked)
            {
                Bonificacion = 1;
            }
        }

        private void rdbContratado_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbContratado.Checked)
            {
                Bonificacion = 2;
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            rdbPeon.Checked = false;
            rdbOperario.Checked = false;
            rdbMaestro.Checked = false;
            rdbEstable.Checked = false;
            rdbContratado.Checked = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
