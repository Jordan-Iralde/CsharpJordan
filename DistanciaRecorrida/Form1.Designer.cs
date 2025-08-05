namespace DistanciaRecorrida
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTittle = new System.Windows.Forms.Label();
            this.lblVelocidad = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblResultados = new System.Windows.Forms.Label();
            this.txtVelocidad = new System.Windows.Forms.TextBox();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Location = new System.Drawing.Point(321, 67);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(104, 13);
            this.lblTittle.TabIndex = 0;
            this.lblTittle.Text = "Calculo de Distancia";
            // 
            // lblVelocidad
            // 
            this.lblVelocidad.AutoSize = true;
            this.lblVelocidad.Location = new System.Drawing.Point(202, 115);
            this.lblVelocidad.Name = "lblVelocidad";
            this.lblVelocidad.Size = new System.Drawing.Size(81, 13);
            this.lblVelocidad.TabIndex = 1;
            this.lblVelocidad.Text = "Velocidad (m/s)";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(202, 168);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(97, 13);
            this.lblTiempo.TabIndex = 2;
            this.lblTiempo.Text = "Tiempo (segundos)";
            // 
            // lblResultados
            // 
            this.lblResultados.AutoSize = true;
            this.lblResultados.Location = new System.Drawing.Point(248, 292);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(55, 13);
            this.lblResultados.TabIndex = 3;
            this.lblResultados.Text = "Resultado";
            // 
            // txtVelocidad
            // 
            this.txtVelocidad.Location = new System.Drawing.Point(314, 112);
            this.txtVelocidad.Name = "txtVelocidad";
            this.txtVelocidad.Size = new System.Drawing.Size(100, 20);
            this.txtVelocidad.TabIndex = 4;
            this.txtVelocidad.TextChanged += new System.EventHandler(this.txtVelocidad_TextChanged);
            // 
            // txtTiempo
            // 
            this.txtTiempo.Enabled = false;
            this.txtTiempo.Location = new System.Drawing.Point(314, 165);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(100, 20);
            this.txtTiempo.TabIndex = 5;
            this.txtTiempo.TextChanged += new System.EventHandler(this.txtTiempo_TextChanged);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(314, 292);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 6;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Enabled = false;
            this.btnCalcular.Location = new System.Drawing.Point(314, 232);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 23);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular Distancia";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.txtVelocidad);
            this.Controls.Add(this.lblResultados);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblVelocidad);
            this.Controls.Add(this.lblTittle);
            this.Name = "Form1";
            this.Text = "Distancia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Label lblVelocidad;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.TextBox txtVelocidad;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnCalcular;
    }
}

