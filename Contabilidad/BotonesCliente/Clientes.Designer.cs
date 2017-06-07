namespace Contabilidad
{
    partial class Clientes
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
            this._btnRegistrar = new System.Windows.Forms.Button();
            this._btnConsultar = new System.Windows.Forms.Button();
            this._lblCliente = new System.Windows.Forms.Label();
            this.navigator1 = new Contabilidad.Navigator();
            this.SuspendLayout();
            // 
            // _btnRegistrar
            // 
            this._btnRegistrar.Location = new System.Drawing.Point(3, 51);
            this._btnRegistrar.Name = "_btnRegistrar";
            this._btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this._btnRegistrar.TabIndex = 2;
            this._btnRegistrar.Text = "Registrar";
            this._btnRegistrar.UseVisualStyleBackColor = true;
            this._btnRegistrar.Click += new System.EventHandler(this._btnRegistrar_Click);
            // 
            // _btnConsultar
            // 
            this._btnConsultar.Location = new System.Drawing.Point(3, 22);
            this._btnConsultar.Name = "_btnConsultar";
            this._btnConsultar.Size = new System.Drawing.Size(75, 23);
            this._btnConsultar.TabIndex = 1;
            this._btnConsultar.Text = "Consultar";
            this._btnConsultar.UseVisualStyleBackColor = true;
            this._btnConsultar.Click += new System.EventHandler(this._btnConsultar_Click);
            // 
            // _lblCliente
            // 
            this._lblCliente.AutoSize = true;
            this._lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblCliente.Location = new System.Drawing.Point(3, 3);
            this._lblCliente.Name = "_lblCliente";
            this._lblCliente.Size = new System.Drawing.Size(64, 16);
            this._lblCliente.TabIndex = 4;
            this._lblCliente.Text = "Clientes";
            // 
            // navigator1
            // 
            this.navigator1.Location = new System.Drawing.Point(84, 3);
            this.navigator1.Name = "navigator1";
            this.navigator1.Size = new System.Drawing.Size(806, 426);
            this.navigator1.TabIndex = 3;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._lblCliente);
            this.Controls.Add(this.navigator1);
            this.Controls.Add(this._btnConsultar);
            this.Controls.Add(this._btnRegistrar);
            this.Name = "Clientes";
            this.Size = new System.Drawing.Size(904, 441);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button _btnRegistrar;
        private System.Windows.Forms.Button _btnConsultar;
        private Navigator navigator1;
        private System.Windows.Forms.Label _lblCliente;
    }
}
