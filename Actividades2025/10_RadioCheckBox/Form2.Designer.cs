namespace _10_RadioCheckBox
{
    partial class Form2
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
            this.grpBoxMenu = new System.Windows.Forms.GroupBox();
            this.btnNuevaCompra = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.grpBoxTotal = new System.Windows.Forms.GroupBox();
            this.lblTotalAPagar = new System.Windows.Forms.Label();
            this.lblIva = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.grpBoxPrecio = new System.Windows.Forms.GroupBox();
            this.lblPrecio4 = new System.Windows.Forms.Label();
            this.lblPrecio3 = new System.Windows.Forms.Label();
            this.lblPrecio2 = new System.Windows.Forms.Label();
            this.lblPrecio1 = new System.Windows.Forms.Label();
            this.grpBoxItems = new System.Windows.Forms.GroupBox();
            this.chkBox4 = new System.Windows.Forms.CheckBox();
            this.chkBox3 = new System.Windows.Forms.CheckBox();
            this.chkBox2 = new System.Windows.Forms.CheckBox();
            this.chkBox1 = new System.Windows.Forms.CheckBox();
            this.grpBoxCantidad = new System.Windows.Forms.GroupBox();
            this.txtCantidad4 = new System.Windows.Forms.TextBox();
            this.txtCantidad3 = new System.Windows.Forms.TextBox();
            this.txtCantidad2 = new System.Windows.Forms.TextBox();
            this.txtCantidad1 = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.grpBoxMenu.SuspendLayout();
            this.grpBoxTotal.SuspendLayout();
            this.grpBoxPrecio.SuspendLayout();
            this.grpBoxItems.SuspendLayout();
            this.grpBoxCantidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxMenu
            // 
            this.grpBoxMenu.Controls.Add(this.btnNuevaCompra);
            this.grpBoxMenu.Controls.Add(this.btnExit);
            this.grpBoxMenu.Controls.Add(this.btnAceptar);
            this.grpBoxMenu.Controls.Add(this.grpBoxTotal);
            this.grpBoxMenu.Controls.Add(this.grpBoxPrecio);
            this.grpBoxMenu.Controls.Add(this.grpBoxItems);
            this.grpBoxMenu.Controls.Add(this.grpBoxCantidad);
            this.grpBoxMenu.Location = new System.Drawing.Point(51, 27);
            this.grpBoxMenu.Name = "grpBoxMenu";
            this.grpBoxMenu.Size = new System.Drawing.Size(640, 411);
            this.grpBoxMenu.TabIndex = 1;
            this.grpBoxMenu.TabStop = false;
            this.grpBoxMenu.Text = "Menu";
            // 
            // btnNuevaCompra
            // 
            this.btnNuevaCompra.Location = new System.Drawing.Point(44, 324);
            this.btnNuevaCompra.Name = "btnNuevaCompra";
            this.btnNuevaCompra.Size = new System.Drawing.Size(166, 36);
            this.btnNuevaCompra.TabIndex = 4;
            this.btnNuevaCompra.Text = "Nueva compra";
            this.btnNuevaCompra.UseVisualStyleBackColor = true;
            this.btnNuevaCompra.Click += new System.EventHandler(this.btnNuevaCompra_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(470, 377);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(116, 28);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(44, 269);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(166, 36);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // grpBoxTotal
            // 
            this.grpBoxTotal.Controls.Add(this.txtTotal);
            this.grpBoxTotal.Controls.Add(this.txtIva);
            this.grpBoxTotal.Controls.Add(this.txtSubtotal);
            this.grpBoxTotal.Controls.Add(this.lblTotalAPagar);
            this.grpBoxTotal.Controls.Add(this.lblIva);
            this.grpBoxTotal.Controls.Add(this.lblSubtotal);
            this.grpBoxTotal.Location = new System.Drawing.Point(235, 249);
            this.grpBoxTotal.Name = "grpBoxTotal";
            this.grpBoxTotal.Size = new System.Drawing.Size(351, 122);
            this.grpBoxTotal.TabIndex = 2;
            this.grpBoxTotal.TabStop = false;
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
            // grpBoxPrecio
            // 
            this.grpBoxPrecio.Controls.Add(this.lblPrecio4);
            this.grpBoxPrecio.Controls.Add(this.lblPrecio3);
            this.grpBoxPrecio.Controls.Add(this.lblPrecio2);
            this.grpBoxPrecio.Controls.Add(this.lblPrecio1);
            this.grpBoxPrecio.Location = new System.Drawing.Point(470, 35);
            this.grpBoxPrecio.Name = "grpBoxPrecio";
            this.grpBoxPrecio.Size = new System.Drawing.Size(116, 199);
            this.grpBoxPrecio.TabIndex = 1;
            this.grpBoxPrecio.TabStop = false;
            this.grpBoxPrecio.Text = "Precio";
            // 
            // lblPrecio4
            // 
            this.lblPrecio4.AutoSize = true;
            this.lblPrecio4.Location = new System.Drawing.Point(20, 154);
            this.lblPrecio4.Name = "lblPrecio4";
            this.lblPrecio4.Size = new System.Drawing.Size(34, 13);
            this.lblPrecio4.TabIndex = 3;
            this.lblPrecio4.Text = "95.50";
            // 
            // lblPrecio3
            // 
            this.lblPrecio3.AutoSize = true;
            this.lblPrecio3.Location = new System.Drawing.Point(20, 119);
            this.lblPrecio3.Name = "lblPrecio3";
            this.lblPrecio3.Size = new System.Drawing.Size(25, 13);
            this.lblPrecio3.TabIndex = 2;
            this.lblPrecio3.Text = "105";
            // 
            // lblPrecio2
            // 
            this.lblPrecio2.AutoSize = true;
            this.lblPrecio2.Location = new System.Drawing.Point(20, 79);
            this.lblPrecio2.Name = "lblPrecio2";
            this.lblPrecio2.Size = new System.Drawing.Size(34, 13);
            this.lblPrecio2.TabIndex = 1;
            this.lblPrecio2.Text = "90.00";
            // 
            // lblPrecio1
            // 
            this.lblPrecio1.AutoSize = true;
            this.lblPrecio1.Location = new System.Drawing.Point(20, 43);
            this.lblPrecio1.Name = "lblPrecio1";
            this.lblPrecio1.Size = new System.Drawing.Size(34, 13);
            this.lblPrecio1.TabIndex = 0;
            this.lblPrecio1.Text = "85.50";
            // 
            // grpBoxItems
            // 
            this.grpBoxItems.Controls.Add(this.chkBox4);
            this.grpBoxItems.Controls.Add(this.chkBox3);
            this.grpBoxItems.Controls.Add(this.chkBox2);
            this.grpBoxItems.Controls.Add(this.chkBox1);
            this.grpBoxItems.Location = new System.Drawing.Point(202, 35);
            this.grpBoxItems.Name = "grpBoxItems";
            this.grpBoxItems.Size = new System.Drawing.Size(237, 199);
            this.grpBoxItems.TabIndex = 1;
            this.grpBoxItems.TabStop = false;
            // 
            // chkBox4
            // 
            this.chkBox4.AutoSize = true;
            this.chkBox4.Location = new System.Drawing.Point(33, 154);
            this.chkBox4.Name = "chkBox4";
            this.chkBox4.Size = new System.Drawing.Size(98, 17);
            this.chkBox4.TabIndex = 3;
            this.chkBox4.Text = "Paquete el Trio";
            this.chkBox4.UseVisualStyleBackColor = true;
            // 
            // chkBox3
            // 
            this.chkBox3.AutoSize = true;
            this.chkBox3.Location = new System.Drawing.Point(33, 118);
            this.chkBox3.Name = "chkBox3";
            this.chkBox3.Size = new System.Drawing.Size(104, 17);
            this.chkBox3.TabIndex = 2;
            this.chkBox3.Text = "Paquete Familiar";
            this.chkBox3.UseVisualStyleBackColor = true;
            // 
            // chkBox2
            // 
            this.chkBox2.AutoSize = true;
            this.chkBox2.Location = new System.Drawing.Point(33, 78);
            this.chkBox2.Name = "chkBox2";
            this.chkBox2.Size = new System.Drawing.Size(89, 17);
            this.chkBox2.TabIndex = 1;
            this.chkBox2.Text = "Paquete Duo";
            this.chkBox2.UseVisualStyleBackColor = true;
            // 
            // chkBox1
            // 
            this.chkBox1.AutoSize = true;
            this.chkBox1.Location = new System.Drawing.Point(33, 43);
            this.chkBox1.Name = "chkBox1";
            this.chkBox1.Size = new System.Drawing.Size(100, 17);
            this.chkBox1.TabIndex = 0;
            this.chkBox1.Text = "Paquete Infantil";
            this.chkBox1.UseVisualStyleBackColor = true;
            this.chkBox1.Click += new System.EventHandler(this.chkBox1_Click);
            // 
            // grpBoxCantidad
            // 
            this.grpBoxCantidad.Controls.Add(this.txtCantidad4);
            this.grpBoxCantidad.Controls.Add(this.txtCantidad3);
            this.grpBoxCantidad.Controls.Add(this.txtCantidad2);
            this.grpBoxCantidad.Controls.Add(this.txtCantidad1);
            this.grpBoxCantidad.Location = new System.Drawing.Point(44, 35);
            this.grpBoxCantidad.Name = "grpBoxCantidad";
            this.grpBoxCantidad.Size = new System.Drawing.Size(152, 199);
            this.grpBoxCantidad.TabIndex = 0;
            this.grpBoxCantidad.TabStop = false;
            this.grpBoxCantidad.Text = "Cantidad";
            // 
            // txtCantidad4
            // 
            this.txtCantidad4.Enabled = false;
            this.txtCantidad4.Location = new System.Drawing.Point(10, 154);
            this.txtCantidad4.Name = "txtCantidad4";
            this.txtCantidad4.Size = new System.Drawing.Size(136, 20);
            this.txtCantidad4.TabIndex = 3;
            // 
            // txtCantidad3
            // 
            this.txtCantidad3.Enabled = false;
            this.txtCantidad3.Location = new System.Drawing.Point(10, 118);
            this.txtCantidad3.Name = "txtCantidad3";
            this.txtCantidad3.Size = new System.Drawing.Size(136, 20);
            this.txtCantidad3.TabIndex = 2;
            // 
            // txtCantidad2
            // 
            this.txtCantidad2.Enabled = false;
            this.txtCantidad2.Location = new System.Drawing.Point(10, 78);
            this.txtCantidad2.Name = "txtCantidad2";
            this.txtCantidad2.Size = new System.Drawing.Size(136, 20);
            this.txtCantidad2.TabIndex = 1;
            // 
            // txtCantidad1
            // 
            this.txtCantidad1.Enabled = false;
            this.txtCantidad1.Location = new System.Drawing.Point(10, 43);
            this.txtCantidad1.Name = "txtCantidad1";
            this.txtCantidad1.Size = new System.Drawing.Size(136, 20);
            this.txtCantidad1.TabIndex = 0;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(188, 20);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(147, 20);
            this.txtSubtotal.TabIndex = 3;
            // 
            // txtIva
            // 
            this.txtIva.Enabled = false;
            this.txtIva.Location = new System.Drawing.Point(188, 56);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(147, 20);
            this.txtIva.TabIndex = 4;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(188, 87);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(147, 20);
            this.txtTotal.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpBoxMenu);
            this.Name = "Form2";
            this.Text = "Form2";
            this.grpBoxMenu.ResumeLayout(false);
            this.grpBoxTotal.ResumeLayout(false);
            this.grpBoxTotal.PerformLayout();
            this.grpBoxPrecio.ResumeLayout(false);
            this.grpBoxPrecio.PerformLayout();
            this.grpBoxItems.ResumeLayout(false);
            this.grpBoxItems.PerformLayout();
            this.grpBoxCantidad.ResumeLayout(false);
            this.grpBoxCantidad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxMenu;
        private System.Windows.Forms.GroupBox grpBoxPrecio;
        private System.Windows.Forms.GroupBox grpBoxItems;
        private System.Windows.Forms.GroupBox grpBoxCantidad;
        private System.Windows.Forms.Button btnNuevaCompra;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox grpBoxTotal;
        private System.Windows.Forms.Label lblTotalAPagar;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblPrecio4;
        private System.Windows.Forms.Label lblPrecio3;
        private System.Windows.Forms.Label lblPrecio2;
        private System.Windows.Forms.Label lblPrecio1;
        private System.Windows.Forms.CheckBox chkBox4;
        private System.Windows.Forms.CheckBox chkBox3;
        private System.Windows.Forms.CheckBox chkBox2;
        private System.Windows.Forms.CheckBox chkBox1;
        private System.Windows.Forms.TextBox txtCantidad4;
        private System.Windows.Forms.TextBox txtCantidad3;
        private System.Windows.Forms.TextBox txtCantidad2;
        private System.Windows.Forms.TextBox txtCantidad1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.TextBox txtSubtotal;
    }
}