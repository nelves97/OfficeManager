﻿namespace Contabilidad
{
    partial class RegistrarClienteCliente
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
            this._btnCancelar = new System.Windows.Forms.Button();
            this._btnRegistrar = new System.Windows.Forms.Button();
            this._txtRFC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._txtCorreo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._txtTelefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._lblRegistrarClienteCliente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _btnCancelar
            // 
            this._btnCancelar.Location = new System.Drawing.Point(191, 190);
            this._btnCancelar.Name = "_btnCancelar";
            this._btnCancelar.Size = new System.Drawing.Size(75, 23);
            this._btnCancelar.TabIndex = 83;
            this._btnCancelar.Text = "Cancelar";
            this._btnCancelar.UseVisualStyleBackColor = true;
            this._btnCancelar.Click += new System.EventHandler(this._btnCancelar_Click);
            // 
            // _btnRegistrar
            // 
            this._btnRegistrar.Location = new System.Drawing.Point(87, 190);
            this._btnRegistrar.Name = "_btnRegistrar";
            this._btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this._btnRegistrar.TabIndex = 79;
            this._btnRegistrar.Text = "Registrar";
            this._btnRegistrar.UseVisualStyleBackColor = true;
            this._btnRegistrar.Click += new System.EventHandler(this._btnRegistrar_Click);
            // 
            // _txtRFC
            // 
            this._txtRFC.Location = new System.Drawing.Point(116, 142);
            this._txtRFC.Name = "_txtRFC";
            this._txtRFC.Size = new System.Drawing.Size(219, 20);
            this._txtRFC.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 75;
            this.label5.Text = "RFC";
            // 
            // _txtCorreo
            // 
            this._txtCorreo.Location = new System.Drawing.Point(116, 88);
            this._txtCorreo.Name = "_txtCorreo";
            this._txtCorreo.Size = new System.Drawing.Size(219, 20);
            this._txtCorreo.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "Correo";
            // 
            // _txtTelefono
            // 
            this._txtTelefono.Location = new System.Drawing.Point(116, 115);
            this._txtTelefono.Name = "_txtTelefono";
            this._txtTelefono.Size = new System.Drawing.Size(219, 20);
            this._txtTelefono.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 66;
            this.label2.Text = "Teléfono";
            // 
            // _txtNombre
            // 
            this._txtNombre.Location = new System.Drawing.Point(116, 61);
            this._txtNombre.Name = "_txtNombre";
            this._txtNombre.Size = new System.Drawing.Size(219, 20);
            this._txtNombre.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "Nombre";
            // 
            // _lblRegistrarClienteCliente
            // 
            this._lblRegistrarClienteCliente.AutoSize = true;
            this._lblRegistrarClienteCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblRegistrarClienteCliente.Location = new System.Drawing.Point(29, 18);
            this._lblRegistrarClienteCliente.Name = "_lblRegistrarClienteCliente";
            this._lblRegistrarClienteCliente.Size = new System.Drawing.Size(295, 25);
            this._lblRegistrarClienteCliente.TabIndex = 62;
            this._lblRegistrarClienteCliente.Text = "Registrar cliente de cliente";
            // 
            // RegistrarClienteCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 230);
            this.Controls.Add(this._btnCancelar);
            this.Controls.Add(this._btnRegistrar);
            this.Controls.Add(this._txtRFC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._txtCorreo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._txtTelefono);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._lblRegistrarClienteCliente);
            this.Name = "RegistrarClienteCliente";
            this.Text = "Registrar cliente de cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnCancelar;
        private System.Windows.Forms.Button _btnRegistrar;
        private System.Windows.Forms.TextBox _txtRFC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _txtCorreo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _txtTelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _lblRegistrarClienteCliente;
    }
}