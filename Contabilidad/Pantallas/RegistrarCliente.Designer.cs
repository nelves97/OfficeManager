namespace Contabilidad
{
    partial class RegistrarCliente
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
            this._rbtnBimestral = new System.Windows.Forms.RadioButton();
            this._rbtnMensual = new System.Windows.Forms.RadioButton();
            this._txtDomicilio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this._txtContrasenaFIEL = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this._txtContrasenaRFC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this._txtRFC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._txtCURP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._txtCorreo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._txtTelefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._lblRegistrarCliente = new System.Windows.Forms.Label();
            this._txtComentarios = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this._txtRegPatronal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _btnCancelar
            // 
            this._btnCancelar.Location = new System.Drawing.Point(191, 492);
            this._btnCancelar.Name = "_btnCancelar";
            this._btnCancelar.Size = new System.Drawing.Size(75, 23);
            this._btnCancelar.TabIndex = 61;
            this._btnCancelar.Text = "Cancelar";
            this._btnCancelar.UseVisualStyleBackColor = true;
            this._btnCancelar.Click += new System.EventHandler(this._btnCancelar_Click);
            // 
            // _btnRegistrar
            // 
            this._btnRegistrar.Location = new System.Drawing.Point(87, 492);
            this._btnRegistrar.Name = "_btnRegistrar";
            this._btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this._btnRegistrar.TabIndex = 57;
            this._btnRegistrar.Text = "Registrar";
            this._btnRegistrar.UseVisualStyleBackColor = true;
            this._btnRegistrar.Click += new System.EventHandler(this._btnRegistrar_Click);
            // 
            // _rbtnBimestral
            // 
            this._rbtnBimestral.AutoSize = true;
            this._rbtnBimestral.Location = new System.Drawing.Point(205, 251);
            this._rbtnBimestral.Name = "_rbtnBimestral";
            this._rbtnBimestral.Size = new System.Drawing.Size(67, 17);
            this._rbtnBimestral.TabIndex = 54;
            this._rbtnBimestral.TabStop = true;
            this._rbtnBimestral.Text = "Bimestral";
            this._rbtnBimestral.UseVisualStyleBackColor = true;
            // 
            // _rbtnMensual
            // 
            this._rbtnMensual.AutoSize = true;
            this._rbtnMensual.Location = new System.Drawing.Point(116, 251);
            this._rbtnMensual.Name = "_rbtnMensual";
            this._rbtnMensual.Size = new System.Drawing.Size(65, 17);
            this._rbtnMensual.TabIndex = 52;
            this._rbtnMensual.TabStop = true;
            this._rbtnMensual.Text = "Mensual";
            this._rbtnMensual.UseVisualStyleBackColor = true;
            // 
            // _txtDomicilio
            // 
            this._txtDomicilio.Location = new System.Drawing.Point(116, 310);
            this._txtDomicilio.MaxLength = 256;
            this._txtDomicilio.Multiline = true;
            this._txtDomicilio.Name = "_txtDomicilio";
            this._txtDomicilio.Size = new System.Drawing.Size(219, 73);
            this._txtDomicilio.TabIndex = 54;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 60;
            this.label9.Text = "Domicilio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 59;
            this.label8.Text = "Periodo";
            // 
            // _txtContrasenaFIEL
            // 
            this._txtContrasenaFIEL.Location = new System.Drawing.Point(116, 223);
            this._txtContrasenaFIEL.MaxLength = 100;
            this._txtContrasenaFIEL.Name = "_txtContrasenaFIEL";
            this._txtContrasenaFIEL.Size = new System.Drawing.Size(219, 20);
            this._txtContrasenaFIEL.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 58;
            this.label7.Text = "Contraseña FIEL";
            // 
            // _txtContrasenaRFC
            // 
            this._txtContrasenaRFC.Location = new System.Drawing.Point(116, 196);
            this._txtContrasenaRFC.MaxLength = 20;
            this._txtContrasenaRFC.Name = "_txtContrasenaRFC";
            this._txtContrasenaRFC.Size = new System.Drawing.Size(219, 20);
            this._txtContrasenaRFC.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "Contraseña RFC";
            // 
            // _txtRFC
            // 
            this._txtRFC.Location = new System.Drawing.Point(116, 142);
            this._txtRFC.MaxLength = 20;
            this._txtRFC.Name = "_txtRFC";
            this._txtRFC.Size = new System.Drawing.Size(219, 20);
            this._txtRFC.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "RFC";
            // 
            // _txtCURP
            // 
            this._txtCURP.Location = new System.Drawing.Point(116, 169);
            this._txtCURP.MaxLength = 20;
            this._txtCURP.Name = "_txtCURP";
            this._txtCURP.Size = new System.Drawing.Size(219, 20);
            this._txtCURP.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "CURP";
            // 
            // _txtCorreo
            // 
            this._txtCorreo.Location = new System.Drawing.Point(116, 88);
            this._txtCorreo.MaxLength = 100;
            this._txtCorreo.Name = "_txtCorreo";
            this._txtCorreo.Size = new System.Drawing.Size(219, 20);
            this._txtCorreo.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Correo";
            // 
            // _txtTelefono
            // 
            this._txtTelefono.Location = new System.Drawing.Point(116, 115);
            this._txtTelefono.MaxLength = 20;
            this._txtTelefono.Name = "_txtTelefono";
            this._txtTelefono.Size = new System.Drawing.Size(219, 20);
            this._txtTelefono.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Teléfono";
            // 
            // _txtNombre
            // 
            this._txtNombre.Location = new System.Drawing.Point(116, 61);
            this._txtNombre.MaxLength = 100;
            this._txtNombre.Name = "_txtNombre";
            this._txtNombre.Size = new System.Drawing.Size(219, 20);
            this._txtNombre.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Nombre";
            // 
            // _lblRegistrarCliente
            // 
            this._lblRegistrarCliente.AutoSize = true;
            this._lblRegistrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblRegistrarCliente.Location = new System.Drawing.Point(82, 18);
            this._lblRegistrarCliente.Name = "_lblRegistrarCliente";
            this._lblRegistrarCliente.Size = new System.Drawing.Size(189, 25);
            this._lblRegistrarCliente.TabIndex = 40;
            this._lblRegistrarCliente.Text = "Registrar Cliente";
            // 
            // _txtComentarios
            // 
            this._txtComentarios.Location = new System.Drawing.Point(116, 389);
            this._txtComentarios.MaxLength = 256;
            this._txtComentarios.Multiline = true;
            this._txtComentarios.Name = "_txtComentarios";
            this._txtComentarios.Size = new System.Drawing.Size(219, 73);
            this._txtComentarios.TabIndex = 55;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 389);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 63;
            this.label10.Text = "Comentarios";
            // 
            // _txtRegPatronal
            // 
            this._txtRegPatronal.Location = new System.Drawing.Point(116, 274);
            this._txtRegPatronal.MaxLength = 20;
            this._txtRegPatronal.Name = "_txtRegPatronal";
            this._txtRegPatronal.Size = new System.Drawing.Size(219, 20);
            this._txtRegPatronal.TabIndex = 53;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 277);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 65;
            this.label11.Text = "Reg. Patronal";
            // 
            // RegistrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 528);
            this.Controls.Add(this._txtRegPatronal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this._txtComentarios);
            this.Controls.Add(this.label10);
            this.Controls.Add(this._btnCancelar);
            this.Controls.Add(this._btnRegistrar);
            this.Controls.Add(this._rbtnBimestral);
            this.Controls.Add(this._rbtnMensual);
            this.Controls.Add(this._txtDomicilio);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this._txtContrasenaFIEL);
            this.Controls.Add(this.label7);
            this.Controls.Add(this._txtContrasenaRFC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._txtRFC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._txtCURP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._txtCorreo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._txtTelefono);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._lblRegistrarCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RegistrarCliente";
            this.Text = "OfficeManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnCancelar;
        private System.Windows.Forms.Button _btnRegistrar;
        private System.Windows.Forms.RadioButton _rbtnBimestral;
        private System.Windows.Forms.RadioButton _rbtnMensual;
        private System.Windows.Forms.TextBox _txtDomicilio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox _txtContrasenaFIEL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox _txtContrasenaRFC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _txtRFC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _txtCURP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _txtCorreo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _txtTelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _lblRegistrarCliente;
        private System.Windows.Forms.TextBox _txtComentarios;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox _txtRegPatronal;
        private System.Windows.Forms.Label label11;
    }
}