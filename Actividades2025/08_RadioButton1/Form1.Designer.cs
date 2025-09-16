namespace EjerciciosRadioButton1
{
    partial class FrmIngresos
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
            this.lblNameLastName = new System.Windows.Forms.Label();
            this.lblDaysWork = new System.Windows.Forms.Label();
            this.lblIngresos = new System.Windows.Forms.Label();
            this.lblBonification = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.grpBxCategory = new System.Windows.Forms.GroupBox();
            this.rdbPeon = new System.Windows.Forms.RadioButton();
            this.rdbOperario = new System.Windows.Forms.RadioButton();
            this.rdbMaestro = new System.Windows.Forms.RadioButton();
            this.grpBxCondition = new System.Windows.Forms.GroupBox();
            this.rdbContratado = new System.Windows.Forms.RadioButton();
            this.rdbEstable = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.txtIngresos = new System.Windows.Forms.TextBox();
            this.txtBonification = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpBxCategory.SuspendLayout();
            this.grpBxCondition.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNameLastName
            // 
            this.lblNameLastName.AutoSize = true;
            this.lblNameLastName.Location = new System.Drawing.Point(125, 49);
            this.lblNameLastName.Name = "lblNameLastName";
            this.lblNameLastName.Size = new System.Drawing.Size(92, 13);
            this.lblNameLastName.TabIndex = 0;
            this.lblNameLastName.Text = "Nombre y Apellido";
            // 
            // lblDaysWork
            // 
            this.lblDaysWork.AutoSize = true;
            this.lblDaysWork.Location = new System.Drawing.Point(126, 84);
            this.lblDaysWork.Name = "lblDaysWork";
            this.lblDaysWork.Size = new System.Drawing.Size(80, 13);
            this.lblDaysWork.TabIndex = 1;
            this.lblDaysWork.Text = "Dias trabajados";
            // 
            // lblIngresos
            // 
            this.lblIngresos.AutoSize = true;
            this.lblIngresos.Location = new System.Drawing.Point(123, 281);
            this.lblIngresos.Name = "lblIngresos";
            this.lblIngresos.Size = new System.Drawing.Size(47, 13);
            this.lblIngresos.TabIndex = 2;
            this.lblIngresos.Text = "Ingresos";
            // 
            // lblBonification
            // 
            this.lblBonification.AutoSize = true;
            this.lblBonification.Location = new System.Drawing.Point(123, 319);
            this.lblBonification.Name = "lblBonification";
            this.lblBonification.Size = new System.Drawing.Size(65, 13);
            this.lblBonification.TabIndex = 3;
            this.lblBonification.Text = "Bonificacion";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(123, 356);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total";
            // 
            // grpBxCategory
            // 
            this.grpBxCategory.Controls.Add(this.rdbPeon);
            this.grpBxCategory.Controls.Add(this.rdbOperario);
            this.grpBxCategory.Controls.Add(this.rdbMaestro);
            this.grpBxCategory.Location = new System.Drawing.Point(125, 150);
            this.grpBxCategory.Name = "grpBxCategory";
            this.grpBxCategory.Size = new System.Drawing.Size(200, 100);
            this.grpBxCategory.TabIndex = 5;
            this.grpBxCategory.TabStop = false;
            this.grpBxCategory.Text = "Categoria";
            // 
            // rdbPeon
            // 
            this.rdbPeon.AutoSize = true;
            this.rdbPeon.Location = new System.Drawing.Point(26, 65);
            this.rdbPeon.Name = "rdbPeon";
            this.rdbPeon.Size = new System.Drawing.Size(50, 17);
            this.rdbPeon.TabIndex = 2;
            this.rdbPeon.Text = "Peon";
            this.rdbPeon.UseVisualStyleBackColor = true;
            this.rdbPeon.CheckedChanged += new System.EventHandler(this.rdbPeon_CheckedChanged);
            // 
            // rdbOperario
            // 
            this.rdbOperario.AutoSize = true;
            this.rdbOperario.Location = new System.Drawing.Point(26, 42);
            this.rdbOperario.Name = "rdbOperario";
            this.rdbOperario.Size = new System.Drawing.Size(65, 17);
            this.rdbOperario.TabIndex = 1;
            this.rdbOperario.Text = "Operario";
            this.rdbOperario.UseVisualStyleBackColor = true;
            this.rdbOperario.CheckedChanged += new System.EventHandler(this.rdbOperario_CheckedChanged);
            // 
            // rdbMaestro
            // 
            this.rdbMaestro.AutoSize = true;
            this.rdbMaestro.Location = new System.Drawing.Point(26, 19);
            this.rdbMaestro.Name = "rdbMaestro";
            this.rdbMaestro.Size = new System.Drawing.Size(63, 17);
            this.rdbMaestro.TabIndex = 0;
            this.rdbMaestro.Text = "Maestro";
            this.rdbMaestro.UseVisualStyleBackColor = true;
            this.rdbMaestro.CheckedChanged += new System.EventHandler(this.rdbMaestro_CheckedChanged);
            // 
            // grpBxCondition
            // 
            this.grpBxCondition.Controls.Add(this.rdbContratado);
            this.grpBxCondition.Controls.Add(this.rdbEstable);
            this.grpBxCondition.Location = new System.Drawing.Point(393, 150);
            this.grpBxCondition.Name = "grpBxCondition";
            this.grpBxCondition.Size = new System.Drawing.Size(200, 100);
            this.grpBxCondition.TabIndex = 6;
            this.grpBxCondition.TabStop = false;
            this.grpBxCondition.Text = "Condicion";
            // 
            // rdbContratado
            // 
            this.rdbContratado.AutoSize = true;
            this.rdbContratado.Location = new System.Drawing.Point(34, 42);
            this.rdbContratado.Name = "rdbContratado";
            this.rdbContratado.Size = new System.Drawing.Size(77, 17);
            this.rdbContratado.TabIndex = 1;
            this.rdbContratado.Text = "Contratado";
            this.rdbContratado.UseVisualStyleBackColor = true;
            this.rdbContratado.CheckedChanged += new System.EventHandler(this.rdbContratado_CheckedChanged);
            // 
            // rdbEstable
            // 
            this.rdbEstable.AutoSize = true;
            this.rdbEstable.Location = new System.Drawing.Point(34, 19);
            this.rdbEstable.Name = "rdbEstable";
            this.rdbEstable.Size = new System.Drawing.Size(60, 17);
            this.rdbEstable.TabIndex = 0;
            this.rdbEstable.Text = "Estable";
            this.rdbEstable.UseVisualStyleBackColor = true;
            this.rdbEstable.CheckedChanged += new System.EventHandler(this.rdbEstable_CheckedChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(238, 49);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(405, 20);
            this.txtName.TabIndex = 7;
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(238, 84);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(100, 20);
            this.txtDays.TabIndex = 8;
            // 
            // txtIngresos
            // 
            this.txtIngresos.Location = new System.Drawing.Point(238, 281);
            this.txtIngresos.Name = "txtIngresos";
            this.txtIngresos.ReadOnly = true;
            this.txtIngresos.Size = new System.Drawing.Size(100, 20);
            this.txtIngresos.TabIndex = 9;
            // 
            // txtBonification
            // 
            this.txtBonification.Location = new System.Drawing.Point(238, 312);
            this.txtBonification.Name = "txtBonification";
            this.txtBonification.ReadOnly = true;
            this.txtBonification.Size = new System.Drawing.Size(100, 20);
            this.txtBonification.TabIndex = 10;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(238, 349);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 11;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(393, 277);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 12;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(393, 319);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 13;
            this.btnClean.Text = "Limpiar";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(393, 356);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtBonification);
            this.Controls.Add(this.txtIngresos);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.grpBxCondition);
            this.Controls.Add(this.grpBxCategory);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblBonification);
            this.Controls.Add(this.lblIngresos);
            this.Controls.Add(this.lblDaysWork);
            this.Controls.Add(this.lblNameLastName);
            this.Name = "FrmIngresos";
            this.Text = "A";
            this.Load += new System.EventHandler(this.FrmIngresos_Load);
            this.grpBxCategory.ResumeLayout(false);
            this.grpBxCategory.PerformLayout();
            this.grpBxCondition.ResumeLayout(false);
            this.grpBxCondition.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameLastName;
        private System.Windows.Forms.Label lblDaysWork;
        private System.Windows.Forms.Label lblIngresos;
        private System.Windows.Forms.Label lblBonification;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox grpBxCategory;
        private System.Windows.Forms.GroupBox grpBxCondition;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.TextBox txtIngresos;
        private System.Windows.Forms.TextBox txtBonification;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.RadioButton rdbPeon;
        private System.Windows.Forms.RadioButton rdbOperario;
        private System.Windows.Forms.RadioButton rdbMaestro;
        private System.Windows.Forms.RadioButton rdbContratado;
        private System.Windows.Forms.RadioButton rdbEstable;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnExit;
    }
}

