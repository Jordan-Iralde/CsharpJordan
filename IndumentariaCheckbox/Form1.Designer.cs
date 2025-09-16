namespace IndumentariaCheckbox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grpbox = new System.Windows.Forms.GroupBox();
            this.lblZapatillas = new System.Windows.Forms.Label();
            this.lblCampera = new System.Windows.Forms.Label();
            this.lblPantalon = new System.Windows.Forms.Label();
            this.lblRemera = new System.Windows.Forms.Label();
            this.lblCamisa = new System.Windows.Forms.Label();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.grpbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbox
            // 
            this.grpbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpbox.BackColor = System.Drawing.Color.Transparent;
            this.grpbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpbox.BackgroundImage")));
            this.grpbox.Controls.Add(this.lblTotal);
            this.grpbox.Controls.Add(this.btnCalcular);
            this.grpbox.Controls.Add(this.lblZapatillas);
            this.grpbox.Controls.Add(this.lblCampera);
            this.grpbox.Controls.Add(this.lblPantalon);
            this.grpbox.Controls.Add(this.lblRemera);
            this.grpbox.Controls.Add(this.lblCamisa);
            this.grpbox.Controls.Add(this.checkBox5);
            this.grpbox.Controls.Add(this.checkBox4);
            this.grpbox.Controls.Add(this.checkBox3);
            this.grpbox.Controls.Add(this.checkBox2);
            this.grpbox.Controls.Add(this.checkBox);
            this.grpbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grpbox.Location = new System.Drawing.Point(178, 41);
            this.grpbox.Name = "grpbox";
            this.grpbox.Size = new System.Drawing.Size(490, 501);
            this.grpbox.TabIndex = 0;
            this.grpbox.TabStop = false;
            this.grpbox.Text = "Indumentaria";
            this.grpbox.Enter += new System.EventHandler(this.grpbox_Enter);
            // 
            // lblZapatillas
            // 
            this.lblZapatillas.AutoSize = true;
            this.lblZapatillas.Location = new System.Drawing.Point(315, 300);
            this.lblZapatillas.Name = "lblZapatillas";
            this.lblZapatillas.Size = new System.Drawing.Size(123, 42);
            this.lblZapatillas.TabIndex = 9;
            this.lblZapatillas.Text = "20000";
            // 
            // lblCampera
            // 
            this.lblCampera.AutoSize = true;
            this.lblCampera.Location = new System.Drawing.Point(315, 248);
            this.lblCampera.Name = "lblCampera";
            this.lblCampera.Size = new System.Drawing.Size(123, 42);
            this.lblCampera.TabIndex = 8;
            this.lblCampera.Text = "50000";
            // 
            // lblPantalon
            // 
            this.lblPantalon.AutoSize = true;
            this.lblPantalon.Location = new System.Drawing.Point(315, 196);
            this.lblPantalon.Name = "lblPantalon";
            this.lblPantalon.Size = new System.Drawing.Size(123, 42);
            this.lblPantalon.TabIndex = 7;
            this.lblPantalon.Text = "15000";
            // 
            // lblRemera
            // 
            this.lblRemera.AutoSize = true;
            this.lblRemera.Location = new System.Drawing.Point(315, 140);
            this.lblRemera.Name = "lblRemera";
            this.lblRemera.Size = new System.Drawing.Size(123, 42);
            this.lblRemera.TabIndex = 6;
            this.lblRemera.Text = "10000";
            // 
            // lblCamisa
            // 
            this.lblCamisa.AutoSize = true;
            this.lblCamisa.Location = new System.Drawing.Point(315, 89);
            this.lblCamisa.Name = "lblCamisa";
            this.lblCamisa.Size = new System.Drawing.Size(123, 42);
            this.lblCamisa.TabIndex = 5;
            this.lblCamisa.Text = "30000";
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(33, 296);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(197, 46);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Zapatillas";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(33, 244);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(190, 46);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Campera";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(33, 192);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(185, 46);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Pantalon";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(33, 140);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(169, 46);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Remera";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(33, 88);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(163, 46);
            this.checkBox.TabIndex = 0;
            this.checkBox.Text = "Camisa";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalcular.Location = new System.Drawing.Point(48, 433);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(200, 49);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(324, 433);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 42);
            this.lblTotal.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 554);
            this.Controls.Add(this.grpbox);
            this.Name = "Form1";
            this.Text = "FrmElectronica";
            this.grpbox.ResumeLayout(false);
            this.grpbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbox;
        private System.Windows.Forms.Label lblCamisa;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Label lblZapatillas;
        private System.Windows.Forms.Label lblCampera;
        private System.Windows.Forms.Label lblPantalon;
        private System.Windows.Forms.Label lblRemera;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCalcular;
    }
}

