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
            this.label1 = new System.Windows.Forms.Label();
            this._btnSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this._btnAceptar = new System.Windows.Forms.Button();
            this._txtNombreUsuario = new System.Windows.Forms.TextBox();
            this._txtContrasena = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this._btnSalir);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this._btnAceptar);
            this.panel1.Controls.Add(this._txtNombreUsuario);
            this.panel1.Controls.Add(this._txtContrasena);
            this.panel1.Location = new System.Drawing.Point(55, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 117);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(38, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // _btnSalir
            // 
            this._btnSalir.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this._btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this._btnSalir.Location = new System.Drawing.Point(173, 79);
            this._btnSalir.Name = "_btnSalir";
            this._btnSalir.Size = new System.Drawing.Size(94, 23);
            this._btnSalir.TabIndex = 4;
            this._btnSalir.Text = "Salir";
            this._btnSalir.UseVisualStyleBackColor = false;
            this._btnSalir.Click += new System.EventHandler(this._btnSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(20, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // _btnAceptar
            // 
            this._btnAceptar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this._btnAceptar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this._btnAceptar.Location = new System.Drawing.Point(56, 79);
            this._btnAceptar.Name = "_btnAceptar";
            this._btnAceptar.Size = new System.Drawing.Size(90, 23);
            this._btnAceptar.TabIndex = 3;
            this._btnAceptar.Text = "Aceptar";
            this._btnAceptar.UseVisualStyleBackColor = false;
            this._btnAceptar.Click += new System.EventHandler(this._btnAceptar_Click);
            // 
            // _txtNombreUsuario
            // 
            this._txtNombreUsuario.BackColor = System.Drawing.SystemColors.ControlDark;
            this._txtNombreUsuario.ForeColor = System.Drawing.SystemColors.MenuBar;
            this._txtNombreUsuario.Location = new System.Drawing.Point(87, 10);
            this._txtNombreUsuario.MaxLength = 20;
            this._txtNombreUsuario.Name = "_txtNombreUsuario";
            this._txtNombreUsuario.Size = new System.Drawing.Size(206, 20);
            this._txtNombreUsuario.TabIndex = 1;
            // 
            // _txtContrasena
            // 
            this._txtContrasena.BackColor = System.Drawing.SystemColors.ControlDark;
            this._txtContrasena.ForeColor = System.Drawing.SystemColors.MenuBar;
            this._txtContrasena.Location = new System.Drawing.Point(87, 48);
            this._txtContrasena.MaxLength = 20;
            this._txtContrasena.Name = "_txtContrasena";
            this._txtContrasena.PasswordChar = '*';
            this._txtContrasena.Size = new System.Drawing.Size(206, 20);
            this._txtContrasena.TabIndex = 2;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 193);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}