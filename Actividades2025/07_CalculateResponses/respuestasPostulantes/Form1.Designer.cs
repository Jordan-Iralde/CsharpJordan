namespace respuestasPostulantes
{
    partial class respuestasPostulantes
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
            this.lblCorrectas = new System.Windows.Forms.Label();
            this.lblIncorrectas = new System.Windows.Forms.Label();
            this.lblBlank = new System.Windows.Forms.Label();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtCorrrectas = new System.Windows.Forms.TextBox();
            this.txtIncorrectas = new System.Windows.Forms.TextBox();
            this.txtBlanco = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCorrectas
            // 
            this.lblCorrectas.AutoSize = true;
            this.lblCorrectas.Location = new System.Drawing.Point(144, 57);
            this.lblCorrectas.Name = "lblCorrectas";
            this.lblCorrectas.Size = new System.Drawing.Size(202, 13);
            this.lblCorrectas.TabIndex = 0;
            this.lblCorrectas.Text = "Ingrese cantidad de respuestas correctas";
            // 
            // lblIncorrectas
            // 
            this.lblIncorrectas.AutoSize = true;
            this.lblIncorrectas.Location = new System.Drawing.Point(147, 113);
            this.lblIncorrectas.Name = "lblIncorrectas";
            this.lblIncorrectas.Size = new System.Drawing.Size(210, 13);
            this.lblIncorrectas.TabIndex = 1;
            this.lblIncorrectas.Text = "Ingrese cantidad de respuestas incorrectas";
            // 
            // lblBlank
            // 
            this.lblBlank.AutoSize = true;
            this.lblBlank.Location = new System.Drawing.Point(147, 163);
            this.lblBlank.Name = "lblBlank";
            this.lblBlank.Size = new System.Drawing.Size(205, 13);
            this.lblBlank.TabIndex = 2;
            this.lblBlank.Text = "Ingrese cantidad de respuestas en blanco";
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.Location = new System.Drawing.Point(150, 231);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(220, 13);
            this.lblPuntaje.TabIndex = 3;
            this.lblPuntaje.Text = "El puntaje total es ====================>";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(397, 231);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(42, 13);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "TOTAL";
            this.lblTotal.Visible = false;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(153, 338);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(400, 337);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(590, 337);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtCorrrectas
            // 
            this.txtCorrrectas.Location = new System.Drawing.Point(412, 57);
            this.txtCorrrectas.Name = "txtCorrrectas";
            this.txtCorrrectas.Size = new System.Drawing.Size(229, 20);
            this.txtCorrrectas.TabIndex = 8;
            // 
            // txtIncorrectas
            // 
            this.txtIncorrectas.Location = new System.Drawing.Point(412, 113);
            this.txtIncorrectas.Name = "txtIncorrectas";
            this.txtIncorrectas.Size = new System.Drawing.Size(229, 20);
            this.txtIncorrectas.TabIndex = 9;
            // 
            // txtBlanco
            // 
            this.txtBlanco.Location = new System.Drawing.Point(412, 163);
            this.txtBlanco.Name = "txtBlanco";
            this.txtBlanco.Size = new System.Drawing.Size(229, 20);
            this.txtBlanco.TabIndex = 10;
            // 
            // respuestasPostulantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBlanco);
            this.Controls.Add(this.txtIncorrectas);
            this.Controls.Add(this.txtCorrrectas);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblPuntaje);
            this.Controls.Add(this.lblBlank);
            this.Controls.Add(this.lblIncorrectas);
            this.Controls.Add(this.lblCorrectas);
            this.Name = "respuestasPostulantes";
            this.Text = "Respuestas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCorrectas;
        private System.Windows.Forms.Label lblIncorrectas;
        private System.Windows.Forms.Label lblBlank;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtCorrrectas;
        private System.Windows.Forms.TextBox txtIncorrectas;
        private System.Windows.Forms.TextBox txtBlanco;
    }
}

