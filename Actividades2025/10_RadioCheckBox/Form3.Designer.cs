namespace _10_RadioCheckBox
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbButtonOption2 = new System.Windows.Forms.RadioButton();
            this.rdbButtonOption1 = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.curso1 = new System.Windows.Forms.CheckBox();
            this.curso2 = new System.Windows.Forms.CheckBox();
            this.curso3 = new System.Windows.Forms.CheckBox();
            this.curso4 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.curso5 = new System.Windows.Forms.CheckBox();
            this.curso6 = new System.Windows.Forms.CheckBox();
            this.curso7 = new System.Windows.Forms.CheckBox();
            this.curso8 = new System.Windows.Forms.CheckBox();
            this.grpBoxTotal = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.lblTotalAPagar = new System.Windows.Forms.Label();
            this.lblIva = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpBoxTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbButtonOption2);
            this.groupBox2.Controls.Add(this.rdbButtonOption1);
            this.groupBox2.Location = new System.Drawing.Point(52, 320);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 105);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Frecuencia";
            // 
            // rdbButtonOption2
            // 
            this.rdbButtonOption2.AutoSize = true;
            this.rdbButtonOption2.Location = new System.Drawing.Point(71, 65);
            this.rdbButtonOption2.Name = "rdbButtonOption2";
            this.rdbButtonOption2.Size = new System.Drawing.Size(62, 17);
            this.rdbButtonOption2.TabIndex = 1;
            this.rdbButtonOption2.TabStop = true;
            this.rdbButtonOption2.Text = "Sábado";
            this.rdbButtonOption2.UseVisualStyleBackColor = true;
            // 
            // rdbButtonOption1
            // 
            this.rdbButtonOption1.AutoSize = true;
            this.rdbButtonOption1.Location = new System.Drawing.Point(71, 31);
            this.rdbButtonOption1.Name = "rdbButtonOption1";
            this.rdbButtonOption1.Size = new System.Drawing.Size(90, 17);
            this.rdbButtonOption1.TabIndex = 0;
            this.rdbButtonOption1.TabStop = true;
            this.rdbButtonOption1.Text = "Entre semana";
            this.rdbButtonOption1.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(461, 54);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(107, 105);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(461, 246);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(107, 105);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(461, 444);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 105);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // curso1
            // 
            this.curso1.AutoSize = true;
            this.curso1.Location = new System.Drawing.Point(46, 45);
            this.curso1.Name = "curso1";
            this.curso1.Size = new System.Drawing.Size(61, 17);
            this.curso1.TabIndex = 0;
            this.curso1.Text = "Access";
            this.curso1.UseVisualStyleBackColor = true;
            // 
            // curso2
            // 
            this.curso2.AutoSize = true;
            this.curso2.Location = new System.Drawing.Point(46, 93);
            this.curso2.Name = "curso2";
            this.curso2.Size = new System.Drawing.Size(65, 17);
            this.curso2.TabIndex = 1;
            this.curso2.Text = "PL/SQL";
            this.curso2.UseVisualStyleBackColor = true;
            // 
            // curso3
            // 
            this.curso3.AutoSize = true;
            this.curso3.Location = new System.Drawing.Point(46, 143);
            this.curso3.Name = "curso3";
            this.curso3.Size = new System.Drawing.Size(92, 17);
            this.curso3.TabIndex = 2;
            this.curso3.Text = "Transact-SQL";
            this.curso3.UseVisualStyleBackColor = true;
            // 
            // curso4
            // 
            this.curso4.AutoSize = true;
            this.curso4.Location = new System.Drawing.Point(46, 197);
            this.curso4.Name = "curso4";
            this.curso4.Size = new System.Drawing.Size(115, 17);
            this.curso4.TabIndex = 3;
            this.curso4.Text = "Visual Studio .NET";
            this.curso4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.curso5);
            this.groupBox1.Controls.Add(this.curso6);
            this.groupBox1.Controls.Add(this.curso7);
            this.groupBox1.Controls.Add(this.curso8);
            this.groupBox1.Controls.Add(this.curso4);
            this.groupBox1.Controls.Add(this.curso3);
            this.groupBox1.Controls.Add(this.curso2);
            this.groupBox1.Controls.Add(this.curso1);
            this.groupBox1.Location = new System.Drawing.Point(52, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 256);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecciona a los cursos a los que deseas asistir.";
            // 
            // curso5
            // 
            this.curso5.AutoSize = true;
            this.curso5.Location = new System.Drawing.Point(241, 45);
            this.curso5.Name = "curso5";
            this.curso5.Size = new System.Drawing.Size(81, 17);
            this.curso5.TabIndex = 7;
            this.curso5.Text = "SQL Server";
            this.curso5.UseVisualStyleBackColor = true;
            // 
            // curso6
            // 
            this.curso6.AutoSize = true;
            this.curso6.Location = new System.Drawing.Point(241, 93);
            this.curso6.Name = "curso6";
            this.curso6.Size = new System.Drawing.Size(57, 17);
            this.curso6.TabIndex = 6;
            this.curso6.Text = "Oracle";
            this.curso6.UseVisualStyleBackColor = true;
            // 
            // curso7
            // 
            this.curso7.AutoSize = true;
            this.curso7.Location = new System.Drawing.Point(241, 143);
            this.curso7.Name = "curso7";
            this.curso7.Size = new System.Drawing.Size(61, 17);
            this.curso7.TabIndex = 5;
            this.curso7.Text = "MySQL";
            this.curso7.UseVisualStyleBackColor = true;
            // 
            // curso8
            // 
            this.curso8.AutoSize = true;
            this.curso8.Location = new System.Drawing.Point(241, 197);
            this.curso8.Name = "curso8";
            this.curso8.Size = new System.Drawing.Size(48, 17);
            this.curso8.TabIndex = 4;
            this.curso8.Text = "PHP";
            this.curso8.UseVisualStyleBackColor = true;
            // 
            // grpBoxTotal
            // 
            this.grpBoxTotal.Controls.Add(this.txtTotal);
            this.grpBoxTotal.Controls.Add(this.txtIva);
            this.grpBoxTotal.Controls.Add(this.txtSubtotal);
            this.grpBoxTotal.Controls.Add(this.lblTotalAPagar);
            this.grpBoxTotal.Controls.Add(this.lblIva);
            this.grpBoxTotal.Controls.Add(this.lblSubtotal);
            this.grpBoxTotal.Location = new System.Drawing.Point(52, 431);
            this.grpBoxTotal.Name = "grpBoxTotal";
            this.grpBoxTotal.Size = new System.Drawing.Size(346, 122);
            this.grpBoxTotal.TabIndex = 6;
            this.grpBoxTotal.TabStop = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(188, 87);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(147, 20);
            this.txtTotal.TabIndex = 5;
            // 
            // txtIva
            // 
            this.txtIva.Enabled = false;
            this.txtIva.Location = new System.Drawing.Point(188, 56);
            this.txtIva.Name = "txtIva";
            this.txtIva.ReadOnly = true;
            this.txtIva.Size = new System.Drawing.Size(147, 20);
            this.txtIva.TabIndex = 4;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(188, 20);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(147, 20);
            this.txtSubtotal.TabIndex = 3;
            // 
            // lblTotalAPagar
            // 
            this.lblTotalAPagar.AutoSize = true;
            this.lblTotalAPagar.Location = new System.Drawing.Point(69, 87);
            this.lblTotalAPagar.Name = "lblTotalAPagar";
            this.lblTotalAPagar.Size = new System.Drawing.Size(73, 13);
            this.lblTotalAPagar.TabIndex = 2;
            this.lblTotalAPagar.Text = "Total a pagar:";
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.Location = new System.Drawing.Point(69, 56);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(27, 13);
            this.lblIva.TabIndex = 1;
            this.lblIva.Text = "IVA:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(69, 20);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(49, 13);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 589);
            this.Controls.Add(this.grpBoxTotal);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpBoxTotal.ResumeLayout(false);
            this.grpBoxTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbButtonOption2;
        private System.Windows.Forms.RadioButton rdbButtonOption1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox curso1;
        private System.Windows.Forms.CheckBox curso2;
        private System.Windows.Forms.CheckBox curso3;
        private System.Windows.Forms.CheckBox curso4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox curso5;
        private System.Windows.Forms.CheckBox curso6;
        private System.Windows.Forms.CheckBox curso7;
        private System.Windows.Forms.CheckBox curso8;
        private System.Windows.Forms.GroupBox grpBoxTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label lblTotalAPagar;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.Label lblSubtotal;
    }
}