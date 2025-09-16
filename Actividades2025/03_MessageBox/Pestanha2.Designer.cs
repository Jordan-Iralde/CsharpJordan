namespace magicianappwform
{
    partial class Pestanha2
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
            this.btnText = new System.Windows.Forms.Button();
            this.lblHello = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblShowData = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnText
            // 
            this.btnText.Location = new System.Drawing.Point(438, 48);
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(75, 23);
            this.btnText.TabIndex = 0;
            this.btnText.Text = "Hola Mundo";
            this.btnText.UseVisualStyleBackColor = true;
            this.btnText.Click += new System.EventHandler(this.btnText_Click);
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Location = new System.Drawing.Point(435, 116);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(0, 13);
            this.lblHello.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.ForeColor = System.Drawing.Color.Crimson;
            this.btnSend.Location = new System.Drawing.Point(136, 238);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(202, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Enviar Datos";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.White;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Location = new System.Drawing.Point(136, 116);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 13);
            this.txtUser.TabIndex = 3;
            this.txtUser.Text = "usu";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Location = new System.Drawing.Point(136, 193);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 13);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Text = "pass";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(136, 100);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Usuario";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(136, 177);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 13);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Contrasenha";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(438, 199);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(35, 13);
            this.lblData.TabIndex = 7;
            this.lblData.Text = "Datos";
            this.lblData.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblShowData
            // 
            this.lblShowData.AutoSize = true;
            this.lblShowData.Location = new System.Drawing.Point(438, 183);
            this.lblShowData.Name = "lblShowData";
            this.lblShowData.Size = new System.Drawing.Size(94, 13);
            this.lblShowData.TabIndex = 8;
            this.lblShowData.Text = "Datos del Usuario:";
            this.lblShowData.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.pictureBox1.Location = new System.Drawing.Point(103, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 216);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Pestanha2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblShowData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.btnText);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Pestanha2";
            this.Text = "Pestanha2";
            this.Load += new System.EventHandler(this.Pestanha2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnText;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblShowData;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}