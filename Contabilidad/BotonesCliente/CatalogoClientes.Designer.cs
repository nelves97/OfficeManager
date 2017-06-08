namespace Contabilidad
{
    partial class CatalogoClientes
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
            this._btnEditar = new System.Windows.Forms.Button();
            this._btnEliminar = new System.Windows.Forms.Button();
            this._btnRegistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _lstbConsulta
            // 
            this._lstbConsulta.FormattingEnabled = true;
            this._lstbConsulta.Location = new System.Drawing.Point(3, 30);
            this._lstbConsulta.Name = "_lstbConsulta";
            this._lstbConsulta.Size = new System.Drawing.Size(273, 251);
            this._lstbConsulta.Sorted = true;
            this._lstbConsulta.TabIndex = 2;
            this._lstbConsulta.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this._lstbConsulta_MouseDoubleClick);
            // 
            // _txtBuscar
            // 
            this._txtBuscar.Location = new System.Drawing.Point(49, 3);
            this._txtBuscar.Name = "_txtBuscar";
            this._txtBuscar.Size = new System.Drawing.Size(227, 20);
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
            this.navigator1.Location = new System.Drawing.Point(282, 3);
            this.navigator1.Name = "navigator1";
            this.navigator1.Size = new System.Drawing.Size(789, 585);
            this.navigator1.TabIndex = 4;
            // 
            // _btnEditar
            // 
            this._btnEditar.Location = new System.Drawing.Point(96, 285);
            this._btnEditar.Name = "_btnEditar";
            this._btnEditar.Size = new System.Drawing.Size(87, 23);
            this._btnEditar.TabIndex = 6;
            this._btnEditar.Text = "Editar";
            this._btnEditar.UseVisualStyleBackColor = true;
            this._btnEditar.Click += new System.EventHandler(this._btnEditar_Click);
            // 
            // _btnEliminar
            // 
            this._btnEliminar.Location = new System.Drawing.Point(189, 285);
            this._btnEliminar.Name = "_btnEliminar";
            this._btnEliminar.Size = new System.Drawing.Size(87, 23);
            this._btnEliminar.TabIndex = 7;
            this._btnEliminar.Text = "Eliminar";
            this._btnEliminar.UseVisualStyleBackColor = true;
            this._btnEliminar.Click += new System.EventHandler(this._btnEliminar_Click);
            // 
            // _btnRegistrar
            // 
            this._btnRegistrar.Location = new System.Drawing.Point(3, 285);
            this._btnRegistrar.Name = "_btnRegistrar";
            this._btnRegistrar.Size = new System.Drawing.Size(87, 23);
            this._btnRegistrar.TabIndex = 5;
            this._btnRegistrar.Text = "Registrar";
            this._btnRegistrar.UseVisualStyleBackColor = true;
            this._btnRegistrar.Click += new System.EventHandler(this._btnRegistrar_Click);
            // 
            // CatalogoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._btnRegistrar);
            this.Controls.Add(this._btnEliminar);
            this.Controls.Add(this._btnEditar);
            this.Controls.Add(this.navigator1);
            this.Controls.Add(this._lblBuscar);
            this.Controls.Add(this._txtBuscar);
            this.Controls.Add(this._lstbConsulta);
            this.Name = "CatalogoClientes";
            this.Size = new System.Drawing.Size(1082, 598);
            this.Load += new System.EventHandler(this.CatalogoClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox _lstbConsulta;
        private System.Windows.Forms.TextBox _txtBuscar;
        private System.Windows.Forms.Label _lblBuscar;
        private Navigator navigator1;
        private System.Windows.Forms.Button _btnEditar;
        private System.Windows.Forms.Button _btnEliminar;
        private System.Windows.Forms.Button _btnRegistrar;
    }
}
