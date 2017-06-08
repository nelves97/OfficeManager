namespace Contabilidad
{
    partial class CardClientes
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._lblNombre = new System.Windows.Forms.Label();
            this._lblCorreo = new System.Windows.Forms.Label();
            this._lblTelefono = new System.Windows.Forms.Label();
            this._lblDomicilio = new System.Windows.Forms.Label();
            this._lblRFC = new System.Windows.Forms.Label();
            this._lblCURP = new System.Windows.Forms.Label();
            this._lblContrasenaRFC = new System.Windows.Forms.Label();
            this._lblContrasenaFirma = new System.Windows.Forms.Label();
            this._lblPeriodo = new System.Windows.Forms.Label();
            this._txtNombre = new System.Windows.Forms.TextBox();
            this._txtCorreo = new System.Windows.Forms.TextBox();
            this._txtTelefono = new System.Windows.Forms.TextBox();
            this._txtDomicilio = new System.Windows.Forms.TextBox();
            this._txtRFC = new System.Windows.Forms.TextBox();
            this._txtCURP = new System.Windows.Forms.TextBox();
            this._txtContrasenaRFC = new System.Windows.Forms.TextBox();
            this._txtContrasenaFIEL = new System.Windows.Forms.TextBox();
            this._txtTipoCliente = new System.Windows.Forms.TextBox();
            this._btnRegistrar = new System.Windows.Forms.Button();
            this._btnEliminar = new System.Windows.Forms.Button();
            this._btnEditar = new System.Windows.Forms.Button();
            this._lstbClienteCliente = new System.Windows.Forms.ListBox();
            this.navigator1 = new Contabilidad.Navigator();
            this.SuspendLayout();
            // 
            // _lblNombre
            // 
            this._lblNombre.AutoSize = true;
            this._lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblNombre.Location = new System.Drawing.Point(12, 17);
            this._lblNombre.Name = "_lblNombre";
            this._lblNombre.Size = new System.Drawing.Size(54, 13);
            this._lblNombre.TabIndex = 0;
            this._lblNombre.Text = "Nombre:";
            // 
            // _lblCorreo
            // 
            this._lblCorreo.AutoSize = true;
            this._lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblCorreo.Location = new System.Drawing.Point(12, 41);
            this._lblCorreo.Name = "_lblCorreo";
            this._lblCorreo.Size = new System.Drawing.Size(48, 13);
            this._lblCorreo.TabIndex = 1;
            this._lblCorreo.Text = "Correo:";
            // 
            // _lblTelefono
            // 
            this._lblTelefono.AutoSize = true;
            this._lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblTelefono.Location = new System.Drawing.Point(12, 65);
            this._lblTelefono.Name = "_lblTelefono";
            this._lblTelefono.Size = new System.Drawing.Size(61, 13);
            this._lblTelefono.TabIndex = 2;
            this._lblTelefono.Text = "Teléfono:";
            // 
            // _lblDomicilio
            // 
            this._lblDomicilio.AutoSize = true;
            this._lblDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblDomicilio.Location = new System.Drawing.Point(12, 209);
            this._lblDomicilio.Name = "_lblDomicilio";
            this._lblDomicilio.Size = new System.Drawing.Size(62, 13);
            this._lblDomicilio.TabIndex = 3;
            this._lblDomicilio.Text = "Domicilio:";
            // 
            // _lblRFC
            // 
            this._lblRFC.AutoSize = true;
            this._lblRFC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblRFC.Location = new System.Drawing.Point(12, 89);
            this._lblRFC.Name = "_lblRFC";
            this._lblRFC.Size = new System.Drawing.Size(35, 13);
            this._lblRFC.TabIndex = 4;
            this._lblRFC.Text = "RFC:";
            // 
            // _lblCURP
            // 
            this._lblCURP.AutoSize = true;
            this._lblCURP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblCURP.Location = new System.Drawing.Point(12, 113);
            this._lblCURP.Name = "_lblCURP";
            this._lblCURP.Size = new System.Drawing.Size(45, 13);
            this._lblCURP.TabIndex = 5;
            this._lblCURP.Text = "CURP:";
            // 
            // _lblContrasenaRFC
            // 
            this._lblContrasenaRFC.AutoSize = true;
            this._lblContrasenaRFC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblContrasenaRFC.Location = new System.Drawing.Point(12, 137);
            this._lblContrasenaRFC.Name = "_lblContrasenaRFC";
            this._lblContrasenaRFC.Size = new System.Drawing.Size(103, 13);
            this._lblContrasenaRFC.TabIndex = 6;
            this._lblContrasenaRFC.Text = "Contraseña RFC:";
            // 
            // _lblContrasenaFirma
            // 
            this._lblContrasenaFirma.AutoSize = true;
            this._lblContrasenaFirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblContrasenaFirma.Location = new System.Drawing.Point(12, 161);
            this._lblContrasenaFirma.Name = "_lblContrasenaFirma";
            this._lblContrasenaFirma.Size = new System.Drawing.Size(105, 13);
            this._lblContrasenaFirma.TabIndex = 7;
            this._lblContrasenaFirma.Text = "Contraseña FIEL:";
            // 
            // _lblPeriodo
            // 
            this._lblPeriodo.AutoSize = true;
            this._lblPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblPeriodo.Location = new System.Drawing.Point(12, 185);
            this._lblPeriodo.Name = "_lblPeriodo";
            this._lblPeriodo.Size = new System.Drawing.Size(54, 13);
            this._lblPeriodo.TabIndex = 8;
            this._lblPeriodo.Text = "Periodo:";
            // 
            // _txtNombre
            // 
            this._txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtNombre.Location = new System.Drawing.Point(127, 17);
            this._txtNombre.Name = "_txtNombre";
            this._txtNombre.ReadOnly = true;
            this._txtNombre.Size = new System.Drawing.Size(184, 13);
            this._txtNombre.TabIndex = 1;
            this._txtNombre.TabStop = false;
            this._txtNombre.Text = ".";
            // 
            // _txtCorreo
            // 
            this._txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtCorreo.Location = new System.Drawing.Point(127, 41);
            this._txtCorreo.Name = "_txtCorreo";
            this._txtCorreo.ReadOnly = true;
            this._txtCorreo.Size = new System.Drawing.Size(184, 13);
            this._txtCorreo.TabIndex = 2;
            this._txtCorreo.TabStop = false;
            this._txtCorreo.Text = ".";
            // 
            // _txtTelefono
            // 
            this._txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtTelefono.Location = new System.Drawing.Point(127, 65);
            this._txtTelefono.Name = "_txtTelefono";
            this._txtTelefono.ReadOnly = true;
            this._txtTelefono.Size = new System.Drawing.Size(184, 13);
            this._txtTelefono.TabIndex = 3;
            this._txtTelefono.TabStop = false;
            this._txtTelefono.Text = ".";
            // 
            // _txtDomicilio
            // 
            this._txtDomicilio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._txtDomicilio.Location = new System.Drawing.Point(15, 230);
            this._txtDomicilio.Multiline = true;
            this._txtDomicilio.Name = "_txtDomicilio";
            this._txtDomicilio.ReadOnly = true;
            this._txtDomicilio.Size = new System.Drawing.Size(296, 51);
            this._txtDomicilio.TabIndex = 9;
            this._txtDomicilio.TabStop = false;
            this._txtDomicilio.Text = ".";
            // 
            // _txtRFC
            // 
            this._txtRFC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtRFC.Location = new System.Drawing.Point(127, 89);
            this._txtRFC.Name = "_txtRFC";
            this._txtRFC.ReadOnly = true;
            this._txtRFC.Size = new System.Drawing.Size(184, 13);
            this._txtRFC.TabIndex = 4;
            this._txtRFC.TabStop = false;
            this._txtRFC.Text = ".";
            // 
            // _txtCURP
            // 
            this._txtCURP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtCURP.Location = new System.Drawing.Point(127, 113);
            this._txtCURP.Name = "_txtCURP";
            this._txtCURP.ReadOnly = true;
            this._txtCURP.Size = new System.Drawing.Size(184, 13);
            this._txtCURP.TabIndex = 5;
            this._txtCURP.TabStop = false;
            this._txtCURP.Text = ".";
            // 
            // _txtContrasenaRFC
            // 
            this._txtContrasenaRFC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtContrasenaRFC.Location = new System.Drawing.Point(127, 137);
            this._txtContrasenaRFC.Name = "_txtContrasenaRFC";
            this._txtContrasenaRFC.ReadOnly = true;
            this._txtContrasenaRFC.Size = new System.Drawing.Size(184, 13);
            this._txtContrasenaRFC.TabIndex = 6;
            this._txtContrasenaRFC.TabStop = false;
            this._txtContrasenaRFC.Text = ".";
            // 
            // _txtContrasenaFIEL
            // 
            this._txtContrasenaFIEL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtContrasenaFIEL.Location = new System.Drawing.Point(127, 161);
            this._txtContrasenaFIEL.Name = "_txtContrasenaFIEL";
            this._txtContrasenaFIEL.ReadOnly = true;
            this._txtContrasenaFIEL.Size = new System.Drawing.Size(184, 13);
            this._txtContrasenaFIEL.TabIndex = 7;
            this._txtContrasenaFIEL.TabStop = false;
            this._txtContrasenaFIEL.Text = ".";
            // 
            // _txtTipoCliente
            // 
            this._txtTipoCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtTipoCliente.Location = new System.Drawing.Point(127, 185);
            this._txtTipoCliente.Name = "_txtTipoCliente";
            this._txtTipoCliente.ReadOnly = true;
            this._txtTipoCliente.Size = new System.Drawing.Size(184, 13);
            this._txtTipoCliente.TabIndex = 8;
            this._txtTipoCliente.TabStop = false;
            this._txtTipoCliente.Text = ".";
            // 
            // _btnRegistrar
            // 
            this._btnRegistrar.Location = new System.Drawing.Point(15, 388);
            this._btnRegistrar.Name = "_btnRegistrar";
            this._btnRegistrar.Size = new System.Drawing.Size(87, 23);
            this._btnRegistrar.TabIndex = 10;
            this._btnRegistrar.Text = "Registrar";
            this._btnRegistrar.UseVisualStyleBackColor = true;
            this._btnRegistrar.Click += new System.EventHandler(this._btnRegistrar_Click);
            // 
            // _btnEliminar
            // 
            this._btnEliminar.Location = new System.Drawing.Point(224, 388);
            this._btnEliminar.Name = "_btnEliminar";
            this._btnEliminar.Size = new System.Drawing.Size(87, 23);
            this._btnEliminar.TabIndex = 12;
            this._btnEliminar.Text = "Eliminar";
            this._btnEliminar.UseVisualStyleBackColor = true;
            this._btnEliminar.Click += new System.EventHandler(this._btnEliminar_Click);
            // 
            // _btnEditar
            // 
            this._btnEditar.Location = new System.Drawing.Point(119, 388);
            this._btnEditar.Name = "_btnEditar";
            this._btnEditar.Size = new System.Drawing.Size(87, 23);
            this._btnEditar.TabIndex = 11;
            this._btnEditar.Text = "Editar";
            this._btnEditar.UseVisualStyleBackColor = true;
            this._btnEditar.Click += new System.EventHandler(this._btnEditar_Click);
            // 
            // _lstbClienteCliente
            // 
            this._lstbClienteCliente.FormattingEnabled = true;
            this._lstbClienteCliente.Location = new System.Drawing.Point(15, 287);
            this._lstbClienteCliente.Name = "_lstbClienteCliente";
            this._lstbClienteCliente.Size = new System.Drawing.Size(296, 95);
            this._lstbClienteCliente.Sorted = true;
            this._lstbClienteCliente.TabIndex = 13;
            this._lstbClienteCliente.SelectedIndexChanged += new System.EventHandler(this._lstbClienteCliente_SelectedIndexChanged);
            // 
            // navigator1
            // 
            this.navigator1.Location = new System.Drawing.Point(317, 287);
            this.navigator1.Name = "navigator1";
            this.navigator1.Size = new System.Drawing.Size(291, 124);
            this.navigator1.TabIndex = 14;
            // 
            // CardClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.navigator1);
            this.Controls.Add(this._lstbClienteCliente);
            this.Controls.Add(this._btnRegistrar);
            this.Controls.Add(this._btnEliminar);
            this.Controls.Add(this._btnEditar);
            this.Controls.Add(this._txtTipoCliente);
            this.Controls.Add(this._txtContrasenaFIEL);
            this.Controls.Add(this._txtContrasenaRFC);
            this.Controls.Add(this._txtCURP);
            this.Controls.Add(this._txtRFC);
            this.Controls.Add(this._txtDomicilio);
            this.Controls.Add(this._txtTelefono);
            this.Controls.Add(this._txtCorreo);
            this.Controls.Add(this._txtNombre);
            this.Controls.Add(this._lblNombre);
            this.Controls.Add(this._lblPeriodo);
            this.Controls.Add(this._lblContrasenaFirma);
            this.Controls.Add(this._lblContrasenaRFC);
            this.Controls.Add(this._lblCURP);
            this.Controls.Add(this._lblRFC);
            this.Controls.Add(this._lblDomicilio);
            this.Controls.Add(this._lblTelefono);
            this.Controls.Add(this._lblCorreo);
            this.Name = "CardClientes";
            this.Size = new System.Drawing.Size(616, 424);
            this.Load += new System.EventHandler(this.CardClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblNombre;
        private System.Windows.Forms.Label _lblCorreo;
        private System.Windows.Forms.Label _lblTelefono;
        private System.Windows.Forms.Label _lblDomicilio;
        private System.Windows.Forms.Label _lblRFC;
        private System.Windows.Forms.Label _lblCURP;
        private System.Windows.Forms.Label _lblContrasenaRFC;
        private System.Windows.Forms.Label _lblContrasenaFirma;
        private System.Windows.Forms.Label _lblPeriodo;
        private System.Windows.Forms.TextBox _txtNombre;
        private System.Windows.Forms.TextBox _txtCorreo;
        private System.Windows.Forms.TextBox _txtTelefono;
        private System.Windows.Forms.TextBox _txtDomicilio;
        private System.Windows.Forms.TextBox _txtRFC;
        private System.Windows.Forms.TextBox _txtCURP;
        private System.Windows.Forms.TextBox _txtContrasenaRFC;
        private System.Windows.Forms.TextBox _txtContrasenaFIEL;
        private System.Windows.Forms.TextBox _txtTipoCliente;
        private System.Windows.Forms.Button _btnRegistrar;
        private System.Windows.Forms.Button _btnEliminar;
        private System.Windows.Forms.Button _btnEditar;
        private System.Windows.Forms.ListBox _lstbClienteCliente;
        private Navigator navigator1;
    }
}
