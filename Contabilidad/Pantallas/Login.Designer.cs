namespace Contabilidad
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this._txtContrasena = new System.Windows.Forms.TextBox();
            this._btnSalir = new System.Windows.Forms.Button();
            this._txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._btnAceptar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 126);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this._txtContrasena);
            this.panel2.Controls.Add(this._btnSalir);
            this.panel2.Controls.Add(this._txtNombreUsuario);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this._btnAceptar);
            this.panel2.Location = new System.Drawing.Point(137, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 120);
            this.panel2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // _txtContrasena
            // 
            this._txtContrasena.Location = new System.Drawing.Point(77, 50);
            this._txtContrasena.MaxLength = 20;
            this._txtContrasena.Name = "_txtContrasena";
            this._txtContrasena.PasswordChar = '*';
            this._txtContrasena.Size = new System.Drawing.Size(206, 20);
            this._txtContrasena.TabIndex = 2;
            this._txtContrasena.KeyDown += new System.Windows.Forms.KeyEventHandler(this._txtContrasena_KeyDown);
            // 
            // _btnSalir
            // 
            this._btnSalir.Location = new System.Drawing.Point(163, 81);
            this._btnSalir.Name = "_btnSalir";
            this._btnSalir.Size = new System.Drawing.Size(94, 23);
            this._btnSalir.TabIndex = 4;
            this._btnSalir.Text = "Salir";
            this._btnSalir.UseVisualStyleBackColor = false;
            this._btnSalir.Click += new System.EventHandler(this._btnSalir_Click);
            // 
            // _txtNombreUsuario
            // 
            this._txtNombreUsuario.Location = new System.Drawing.Point(77, 16);
            this._txtNombreUsuario.MaxLength = 20;
            this._txtNombreUsuario.Name = "_txtNombreUsuario";
            this._txtNombreUsuario.Size = new System.Drawing.Size(206, 20);
            this._txtNombreUsuario.TabIndex = 1;
            this._txtNombreUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this._txtNombreUsuario_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(10, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // _btnAceptar
            // 
            this._btnAceptar.Location = new System.Drawing.Point(46, 81);
            this._btnAceptar.Name = "_btnAceptar";
            this._btnAceptar.Size = new System.Drawing.Size(90, 23);
            this._btnAceptar.TabIndex = 3;
            this._btnAceptar.Text = "Aceptar";
            this._btnAceptar.UseVisualStyleBackColor = false;
            this._btnAceptar.Click += new System.EventHandler(this._btnAceptar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Contabilidad.Properties.Resources.logogaribayaguirre;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 120);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(458, 151);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.Text = "OfficeManager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _btnSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button _btnAceptar;
        private System.Windows.Forms.TextBox _txtNombreUsuario;
        private System.Windows.Forms.TextBox _txtContrasena;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
    }
}