﻿namespace Contabilidad.Pantallas
{
    partial class EditarEmpleado
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
            this._btnEditar = new System.Windows.Forms.Button();
            this._lblEditarEmpleado = new System.Windows.Forms.Label();
            this._txtContrasena = new System.Windows.Forms.TextBox();
            this._txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this._cmbSexo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this._dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this._txtSalario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this._txtHorasSemanales = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this._txtCorreo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._txtTelefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _btnCancelar
            // 
            this._btnCancelar.Location = new System.Drawing.Point(219, 369);
            this._btnCancelar.Name = "_btnCancelar";
            this._btnCancelar.Size = new System.Drawing.Size(75, 23);
            this._btnCancelar.TabIndex = 12;
            this._btnCancelar.Text = "Cancelar";
            this._btnCancelar.UseVisualStyleBackColor = true;
            this._btnCancelar.Click += new System.EventHandler(this._btnCancelar_Click);
            // 
            // _btnEditar
            // 
            this._btnEditar.Location = new System.Drawing.Point(115, 369);
            this._btnEditar.Name = "_btnEditar";
            this._btnEditar.Size = new System.Drawing.Size(75, 23);
            this._btnEditar.TabIndex = 11;
            this._btnEditar.Text = "Editar";
            this._btnEditar.UseVisualStyleBackColor = true;
            this._btnEditar.Click += new System.EventHandler(this._btnEditar_Click);
            // 
            // _lblEditarEmpleado
            // 
            this._lblEditarEmpleado.AutoSize = true;
            this._lblEditarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblEditarEmpleado.Location = new System.Drawing.Point(112, 16);
            this._lblEditarEmpleado.Name = "_lblEditarEmpleado";
            this._lblEditarEmpleado.Size = new System.Drawing.Size(185, 25);
            this._lblEditarEmpleado.TabIndex = 100;
            this._lblEditarEmpleado.Text = "Editar Empleado";
            // 
            // _txtContrasena
            // 
            this._txtContrasena.Location = new System.Drawing.Point(167, 250);
            this._txtContrasena.MaxLength = 100;
            this._txtContrasena.Name = "_txtContrasena";
            this._txtContrasena.Size = new System.Drawing.Size(219, 20);
            this._txtContrasena.TabIndex = 7;
            // 
            // _txtNombreUsuario
            // 
            this._txtNombreUsuario.Location = new System.Drawing.Point(167, 224);
            this._txtNombreUsuario.MaxLength = 100;
            this._txtNombreUsuario.Name = "_txtNombreUsuario";
            this._txtNombreUsuario.Size = new System.Drawing.Size(219, 20);
            this._txtNombreUsuario.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 122;
            this.label10.Text = "Contraseña";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 121;
            this.label9.Text = "Nombre de usuario";
            // 
            // _cmbSexo
            // 
            this._cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbSexo.FormattingEnabled = true;
            this._cmbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this._cmbSexo.Location = new System.Drawing.Point(167, 146);
            this._cmbSexo.Name = "_cmbSexo";
            this._cmbSexo.Size = new System.Drawing.Size(219, 21);
            this._cmbSexo.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 119;
            this.label8.Text = "Sexo";
            // 
            // _dtpFechaIngreso
            // 
            this._dtpFechaIngreso.Location = new System.Drawing.Point(167, 328);
            this._dtpFechaIngreso.Name = "_dtpFechaIngreso";
            this._dtpFechaIngreso.Size = new System.Drawing.Size(219, 20);
            this._dtpFechaIngreso.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 118;
            this.label7.Text = "Fecha de Ingreso";
            // 
            // _txtSalario
            // 
            this._txtSalario.Location = new System.Drawing.Point(167, 302);
            this._txtSalario.MaxLength = 10;
            this._txtSalario.Name = "_txtSalario";
            this._txtSalario.Size = new System.Drawing.Size(219, 20);
            this._txtSalario.TabIndex = 9;
            this._txtSalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtSalario_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 117;
            this.label6.Text = "Salario Semanal";
            // 
            // _txtHorasSemanales
            // 
            this._txtHorasSemanales.Location = new System.Drawing.Point(167, 276);
            this._txtHorasSemanales.MaxLength = 10;
            this._txtHorasSemanales.Name = "_txtHorasSemanales";
            this._txtHorasSemanales.Size = new System.Drawing.Size(219, 20);
            this._txtHorasSemanales.TabIndex = 8;
            this._txtHorasSemanales.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtHorasSemanales_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 116;
            this.label5.Text = "Horas Semanales";
            // 
            // _dtpFechaNacimiento
            // 
            this._dtpFechaNacimiento.Location = new System.Drawing.Point(167, 173);
            this._dtpFechaNacimiento.Name = "_dtpFechaNacimiento";
            this._dtpFechaNacimiento.Size = new System.Drawing.Size(219, 20);
            this._dtpFechaNacimiento.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 115;
            this.label4.Text = "Fecha de Nacimiento";
            // 
            // _txtCorreo
            // 
            this._txtCorreo.Location = new System.Drawing.Point(167, 94);
            this._txtCorreo.MaxLength = 50;
            this._txtCorreo.Name = "_txtCorreo";
            this._txtCorreo.Size = new System.Drawing.Size(219, 20);
            this._txtCorreo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 114;
            this.label3.Text = "Correo";
            // 
            // _txtTelefono
            // 
            this._txtTelefono.Location = new System.Drawing.Point(167, 120);
            this._txtTelefono.MaxLength = 20;
            this._txtTelefono.Name = "_txtTelefono";
            this._txtTelefono.Size = new System.Drawing.Size(219, 20);
            this._txtTelefono.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 113;
            this.label2.Text = "Teléfono";
            // 
            // _txtNombre
            // 
            this._txtNombre.Location = new System.Drawing.Point(167, 68);
            this._txtNombre.MaxLength = 100;
            this._txtNombre.Name = "_txtNombre";
            this._txtNombre.Size = new System.Drawing.Size(219, 20);
            this._txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 112;
            this.label1.Text = "Nombre";
            // 
            // EditarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 413);
            this.Controls.Add(this._txtContrasena);
            this.Controls.Add(this._txtNombreUsuario);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this._cmbSexo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this._dtpFechaIngreso);
            this.Controls.Add(this.label7);
            this.Controls.Add(this._txtSalario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._txtHorasSemanales);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._dtpFechaNacimiento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._txtCorreo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._txtTelefono);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._btnCancelar);
            this.Controls.Add(this._btnEditar);
            this.Controls.Add(this._lblEditarEmpleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditarEmpleado";
            this.Text = "OfficeManager";
            this.Load += new System.EventHandler(this.EditarEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button _btnCancelar;
        private System.Windows.Forms.Button _btnEditar;
        private System.Windows.Forms.Label _lblEditarEmpleado;
        private System.Windows.Forms.TextBox _txtContrasena;
        private System.Windows.Forms.TextBox _txtNombreUsuario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox _cmbSexo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker _dtpFechaIngreso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox _txtSalario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _txtHorasSemanales;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker _dtpFechaNacimiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _txtCorreo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _txtTelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _txtNombre;
        private System.Windows.Forms.Label label1;
    }
}