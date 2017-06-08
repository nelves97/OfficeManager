namespace Contabilidad
{
    partial class CardClienteCliente
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
            this._txtRFC = new System.Windows.Forms.TextBox();
            this._txtTelefono = new System.Windows.Forms.TextBox();
            this._txtCorreo = new System.Windows.Forms.TextBox();
            this._txtNombre = new System.Windows.Forms.TextBox();
            this._lblNombre = new System.Windows.Forms.Label();
            this._lblRFC = new System.Windows.Forms.Label();
            this._lblTelefono = new System.Windows.Forms.Label();
            this._lblCorreo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _txtRFC
            // 
            this._txtRFC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtRFC.Location = new System.Drawing.Point(84, 72);
            this._txtRFC.Name = "_txtRFC";
            this._txtRFC.ReadOnly = true;
            this._txtRFC.Size = new System.Drawing.Size(191, 13);
            this._txtRFC.TabIndex = 11;
            this._txtRFC.TabStop = false;
            this._txtRFC.Text = ".";
            // 
            // _txtTelefono
            // 
            this._txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtTelefono.Location = new System.Drawing.Point(84, 48);
            this._txtTelefono.Name = "_txtTelefono";
            this._txtTelefono.ReadOnly = true;
            this._txtTelefono.Size = new System.Drawing.Size(191, 13);
            this._txtTelefono.TabIndex = 10;
            this._txtTelefono.TabStop = false;
            this._txtTelefono.Text = ".";
            // 
            // _txtCorreo
            // 
            this._txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtCorreo.Location = new System.Drawing.Point(84, 24);
            this._txtCorreo.Name = "_txtCorreo";
            this._txtCorreo.ReadOnly = true;
            this._txtCorreo.Size = new System.Drawing.Size(191, 13);
            this._txtCorreo.TabIndex = 8;
            this._txtCorreo.TabStop = false;
            this._txtCorreo.Text = ".";
            // 
            // _txtNombre
            // 
            this._txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtNombre.Location = new System.Drawing.Point(84, 0);
            this._txtNombre.Name = "_txtNombre";
            this._txtNombre.ReadOnly = true;
            this._txtNombre.Size = new System.Drawing.Size(191, 13);
            this._txtNombre.TabIndex = 6;
            this._txtNombre.TabStop = false;
            this._txtNombre.Text = ".";
            // 
            // _lblNombre
            // 
            this._lblNombre.AutoSize = true;
            this._lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblNombre.Location = new System.Drawing.Point(3, 0);
            this._lblNombre.Name = "_lblNombre";
            this._lblNombre.Size = new System.Drawing.Size(54, 13);
            this._lblNombre.TabIndex = 5;
            this._lblNombre.Text = "Nombre:";
            // 
            // _lblRFC
            // 
            this._lblRFC.AutoSize = true;
            this._lblRFC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblRFC.Location = new System.Drawing.Point(3, 72);
            this._lblRFC.Name = "_lblRFC";
            this._lblRFC.Size = new System.Drawing.Size(35, 13);
            this._lblRFC.TabIndex = 12;
            this._lblRFC.Text = "RFC:";
            // 
            // _lblTelefono
            // 
            this._lblTelefono.AutoSize = true;
            this._lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblTelefono.Location = new System.Drawing.Point(3, 48);
            this._lblTelefono.Name = "_lblTelefono";
            this._lblTelefono.Size = new System.Drawing.Size(61, 13);
            this._lblTelefono.TabIndex = 9;
            this._lblTelefono.Text = "Teléfono:";
            // 
            // _lblCorreo
            // 
            this._lblCorreo.AutoSize = true;
            this._lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblCorreo.Location = new System.Drawing.Point(3, 24);
            this._lblCorreo.Name = "_lblCorreo";
            this._lblCorreo.Size = new System.Drawing.Size(48, 13);
            this._lblCorreo.TabIndex = 7;
            this._lblCorreo.Text = "Correo:";
            // 
            // CardClienteCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this._txtRFC);
            this.Controls.Add(this._txtTelefono);
            this.Controls.Add(this._txtCorreo);
            this.Controls.Add(this._txtNombre);
            this.Controls.Add(this._lblNombre);
            this.Controls.Add(this._lblRFC);
            this.Controls.Add(this._lblTelefono);
            this.Controls.Add(this._lblCorreo);
            this.Name = "CardClienteCliente";
            this.Size = new System.Drawing.Size(287, 95);
            this.Load += new System.EventHandler(this.CardClienteCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _txtRFC;
        private System.Windows.Forms.TextBox _txtTelefono;
        private System.Windows.Forms.TextBox _txtCorreo;
        private System.Windows.Forms.TextBox _txtNombre;
        private System.Windows.Forms.Label _lblNombre;
        private System.Windows.Forms.Label _lblRFC;
        private System.Windows.Forms.Label _lblTelefono;
        private System.Windows.Forms.Label _lblCorreo;
    }
}
