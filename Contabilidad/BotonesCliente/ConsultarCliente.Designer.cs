namespace Contabilidad
{
    partial class ConsultarCliente
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
            this._lstbConsulta = new System.Windows.Forms.ListBox();
            this._txtBuscar = new System.Windows.Forms.TextBox();
            this._lblBuscar = new System.Windows.Forms.Label();
            this.navigator1 = new Contabilidad.Navigator();
            this.SuspendLayout();
            // 
            // _lstbConsulta
            // 
            this._lstbConsulta.FormattingEnabled = true;
            this._lstbConsulta.Location = new System.Drawing.Point(3, 30);
            this._lstbConsulta.Name = "_lstbConsulta";
            this._lstbConsulta.Size = new System.Drawing.Size(370, 368);
            this._lstbConsulta.Sorted = true;
            this._lstbConsulta.TabIndex = 2;
            this._lstbConsulta.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this._lstbConsulta_MouseDoubleClick);
            // 
            // _txtBuscar
            // 
            this._txtBuscar.Location = new System.Drawing.Point(49, 3);
            this._txtBuscar.Name = "_txtBuscar";
            this._txtBuscar.Size = new System.Drawing.Size(324, 20);
            this._txtBuscar.TabIndex = 1;
            this._txtBuscar.TextChanged += new System.EventHandler(this._txtBuscar_TextChanged);
            // 
            // _lblBuscar
            // 
            this._lblBuscar.AutoSize = true;
            this._lblBuscar.Location = new System.Drawing.Point(3, 6);
            this._lblBuscar.Name = "_lblBuscar";
            this._lblBuscar.Size = new System.Drawing.Size(40, 13);
            this._lblBuscar.TabIndex = 3;
            this._lblBuscar.Text = "Buscar";
            // 
            // navigator1
            // 
            this.navigator1.Location = new System.Drawing.Point(379, 6);
            this.navigator1.Name = "navigator1";
            this.navigator1.Size = new System.Drawing.Size(366, 392);
            this.navigator1.TabIndex = 4;
            // 
            // ConsultarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.navigator1);
            this.Controls.Add(this._lblBuscar);
            this.Controls.Add(this._txtBuscar);
            this.Controls.Add(this._lstbConsulta);
            this.Name = "ConsultarCliente";
            this.Size = new System.Drawing.Size(757, 405);
            this.Load += new System.EventHandler(this.ConsultarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox _lstbConsulta;
        private System.Windows.Forms.TextBox _txtBuscar;
        private System.Windows.Forms.Label _lblBuscar;
        private Navigator navigator1;
    }
}
