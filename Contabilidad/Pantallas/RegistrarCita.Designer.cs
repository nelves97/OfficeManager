namespace Contabilidad.Pantallas
{
    partial class RegistrarCita
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
            this.label5 = new System.Windows.Forms.Label();
            this._dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._lblRegistrarCita = new System.Windows.Forms.Label();
            this._txtInfo = new System.Windows.Forms.TextBox();
            this._dtpHora = new System.Windows.Forms.DateTimePicker();
            this._btnRegistrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this._btnColor = new System.Windows.Forms.Button();
            this._cmbClientes = new System.Windows.Forms.ComboBox();
            this._btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 105;
            this.label5.Text = "Hora";
            // 
            // _dtpFecha
            // 
            this._dtpFecha.Location = new System.Drawing.Point(190, 93);
            this._dtpFecha.Name = "_dtpFecha";
            this._dtpFecha.Size = new System.Drawing.Size(219, 20);
            this._dtpFecha.TabIndex = 104;
            this._dtpFecha.Value = new System.DateTime(2017, 11, 29, 20, 14, 21, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 103;
            this.label4.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 102;
            this.label3.Text = "Información";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 98;
            this.label1.Text = "Nombre del Cliente";
            // 
            // _lblRegistrarCita
            // 
            this._lblRegistrarCita.AutoSize = true;
            this._lblRegistrarCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblRegistrarCita.Location = new System.Drawing.Point(149, 20);
            this._lblRegistrarCita.Name = "_lblRegistrarCita";
            this._lblRegistrarCita.Size = new System.Drawing.Size(157, 25);
            this._lblRegistrarCita.TabIndex = 96;
            this._lblRegistrarCita.Text = "Registrar Cita";
            // 
            // _txtInfo
            // 
            this._txtInfo.Location = new System.Drawing.Point(190, 195);
            this._txtInfo.Multiline = true;
            this._txtInfo.Name = "_txtInfo";
            this._txtInfo.Size = new System.Drawing.Size(219, 63);
            this._txtInfo.TabIndex = 99;
            // 
            // _dtpHora
            // 
            this._dtpHora.CustomFormat = "hh:mm";
            this._dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._dtpHora.Location = new System.Drawing.Point(190, 119);
            this._dtpHora.Name = "_dtpHora";
            this._dtpHora.Size = new System.Drawing.Size(219, 20);
            this._dtpHora.TabIndex = 106;
            // 
            // _btnRegistrar
            // 
            this._btnRegistrar.Location = new System.Drawing.Point(206, 276);
            this._btnRegistrar.Name = "_btnRegistrar";
            this._btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this._btnRegistrar.TabIndex = 107;
            this._btnRegistrar.Text = "Aceptar";
            this._btnRegistrar.UseVisualStyleBackColor = true;
            this._btnRegistrar.Click += new System.EventHandler(this._btnRegistrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 108;
            this.label2.Text = "Color";
            // 
            // _btnColor
            // 
            this._btnColor.BackColor = System.Drawing.Color.White;
            this._btnColor.Location = new System.Drawing.Point(190, 151);
            this._btnColor.Name = "_btnColor";
            this._btnColor.Size = new System.Drawing.Size(41, 23);
            this._btnColor.TabIndex = 109;
            this._btnColor.UseVisualStyleBackColor = false;
            this._btnColor.Click += new System.EventHandler(this._btnColor_Click);
            // 
            // _cmbClientes
            // 
            this._cmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbClientes.FormattingEnabled = true;
            this._cmbClientes.Location = new System.Drawing.Point(190, 61);
            this._cmbClientes.Name = "_cmbClientes";
            this._cmbClientes.Size = new System.Drawing.Size(219, 21);
            this._cmbClientes.TabIndex = 110;
            this._cmbClientes.SelectedIndexChanged += new System.EventHandler(this._cmbClientes_SelectedIndexChanged);
            // 
            // _btnCancelar
            // 
            this._btnCancelar.Location = new System.Drawing.Point(304, 276);
            this._btnCancelar.Name = "_btnCancelar";
            this._btnCancelar.Size = new System.Drawing.Size(75, 23);
            this._btnCancelar.TabIndex = 111;
            this._btnCancelar.Text = "Cancelar";
            this._btnCancelar.UseVisualStyleBackColor = true;
            this._btnCancelar.Click += new System.EventHandler(this._btnCancelar_Click);
            // 
            // RegistrarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 327);
            this.Controls.Add(this._btnCancelar);
            this.Controls.Add(this._cmbClientes);
            this.Controls.Add(this._btnColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._btnRegistrar);
            this.Controls.Add(this._dtpHora);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._dtpFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._txtInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._lblRegistrarCita);
            this.Name = "RegistrarCita";
            this.Text = "Registar Cita";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistrarCita_FormClosing);
            this.Load += new System.EventHandler(this.RegistrarCita_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker _dtpFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _lblRegistrarCita;
        private System.Windows.Forms.TextBox _txtInfo;
        private System.Windows.Forms.DateTimePicker _dtpHora;
        private System.Windows.Forms.Button _btnRegistrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button _btnColor;
        private System.Windows.Forms.ComboBox _cmbClientes;
        private System.Windows.Forms.Button _btnCancelar;
    }
}