namespace _10_RadioCheckBox
{
    partial class frm1
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
            this.grpBox1 = new System.Windows.Forms.GroupBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnRevisar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.grpBox2 = new System.Windows.Forms.GroupBox();
            this.rdbButton3 = new System.Windows.Forms.RadioButton();
            this.rdbButton2 = new System.Windows.Forms.RadioButton();
            this.rdbButton1 = new System.Windows.Forms.RadioButton();
            this.grpBox1.SuspendLayout();
            this.grpBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBox1
            // 
            this.grpBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpBox1.Controls.Add(this.txtResultado);
            this.grpBox1.Controls.Add(this.txtNumero);
            this.grpBox1.Controls.Add(this.btnSalir);
            this.grpBox1.Controls.Add(this.btnBorrar);
            this.grpBox1.Controls.Add(this.btnRevisar);
            this.grpBox1.Controls.Add(this.lblResultado);
            this.grpBox1.Controls.Add(this.lblNum);
            this.grpBox1.Controls.Add(this.grpBox2);
            this.grpBox1.Location = new System.Drawing.Point(118, 54);
            this.grpBox1.Name = "grpBox1";
            this.grpBox1.Size = new System.Drawing.Size(523, 356);
            this.grpBox1.TabIndex = 0;
            this.grpBox1.TabStop = false;
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(116, 299);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(360, 20);
            this.txtResultado.TabIndex = 6;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(113, 45);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(229, 20);
            this.txtNumero.TabIndex = 5;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(379, 221);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(97, 50);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(379, 165);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(97, 50);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnRevisar
            // 
            this.btnRevisar.Location = new System.Drawing.Point(379, 109);
            this.btnRevisar.Name = "btnRevisar";
            this.btnRevisar.Size = new System.Drawing.Size(97, 50);
            this.btnRevisar.TabIndex = 2;
            this.btnRevisar.Text = "Revisar";
            this.btnRevisar.UseVisualStyleBackColor = true;
            this.btnRevisar.Click += new System.EventHandler(this.btnRevisar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(49, 302);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(61, 13);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.Text = "Resultado=";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(49, 45);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(47, 13);
            this.lblNum.TabIndex = 0;
            this.lblNum.Text = "Numero:";
            // 
            // grpBox2
            // 
            this.grpBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpBox2.Controls.Add(this.rdbButton3);
            this.grpBox2.Controls.Add(this.rdbButton2);
            this.grpBox2.Controls.Add(this.rdbButton1);
            this.grpBox2.Location = new System.Drawing.Point(85, 111);
            this.grpBox2.Name = "grpBox2";
            this.grpBox2.Size = new System.Drawing.Size(257, 160);
            this.grpBox2.TabIndex = 0;
            this.grpBox2.TabStop = false;
            this.grpBox2.Text = "Revisar";
            // 
            // rdbButton3
            // 
            this.rdbButton3.AutoSize = true;
            this.rdbButton3.Location = new System.Drawing.Point(47, 127);
            this.rdbButton3.Name = "rdbButton3";
            this.rdbButton3.Size = new System.Drawing.Size(79, 17);
            this.rdbButton3.TabIndex = 2;
            this.rdbButton3.TabStop = true;
            this.rdbButton3.Text = "Es perfecto";
            this.rdbButton3.UseVisualStyleBackColor = true;
            // 
            // rdbButton2
            // 
            this.rdbButton2.AutoSize = true;
            this.rdbButton2.Location = new System.Drawing.Point(47, 71);
            this.rdbButton2.Name = "rdbButton2";
            this.rdbButton2.Size = new System.Drawing.Size(65, 17);
            this.rdbButton2.TabIndex = 1;
            this.rdbButton2.TabStop = true;
            this.rdbButton2.Text = "Es impar";
            this.rdbButton2.UseVisualStyleBackColor = true;
            // 
            // rdbButton1
            // 
            this.rdbButton1.AutoSize = true;
            this.rdbButton1.Location = new System.Drawing.Point(47, 19);
            this.rdbButton1.Name = "rdbButton1";
            this.rdbButton1.Size = new System.Drawing.Size(55, 17);
            this.rdbButton1.TabIndex = 0;
            this.rdbButton1.TabStop = true;
            this.rdbButton1.Text = "Es par";
            this.rdbButton1.UseVisualStyleBackColor = true;
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpBox1);
            this.Name = "frm1";
            this.Text = "ValidarNumeros";
            this.grpBox1.ResumeLayout(false);
            this.grpBox1.PerformLayout();
            this.grpBox2.ResumeLayout(false);
            this.grpBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBox1;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.GroupBox grpBox2;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnRevisar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.RadioButton rdbButton3;
        private System.Windows.Forms.RadioButton rdbButton2;
        private System.Windows.Forms.RadioButton rdbButton1;
    }
}

