namespace Contabilidad.Pantallas
{
    partial class CatalogoEmpleados
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
            this._txtBuscar = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this._lblBuscar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this._lstbConsulta = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this._btnRegistrar = new System.Windows.Forms.Button();
            this._btnEliminar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.navigator1 = new Contabilidad.Navigator();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // _txtBuscar
            // 
            this._txtBuscar.Location = new System.Drawing.Point(71, 29);
            this._txtBuscar.Name = "_txtBuscar";
            this._txtBuscar.Size = new System.Drawing.Size(221, 20);
            this._txtBuscar.TabIndex = 4;
            this._txtBuscar.TextChanged += new System.EventHandler(this._txtBuscar_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this._lblBuscar);
            this.panel2.Controls.Add(this._txtBuscar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(664, 55);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Catálogo de Empleados:";
            // 
            // _lblBuscar
            // 
            this._lblBuscar.AutoSize = true;
            this._lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblBuscar.Location = new System.Drawing.Point(5, 30);
            this._lblBuscar.Name = "_lblBuscar";
            this._lblBuscar.Size = new System.Drawing.Size(60, 16);
            this._lblBuscar.TabIndex = 9;
            this._lblBuscar.Text = "Buscar:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._lstbConsulta);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 289);
            this.panel1.TabIndex = 0;
            // 
            // _lstbConsulta
            // 
            this._lstbConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lstbConsulta.FormattingEnabled = true;
            this._lstbConsulta.Location = new System.Drawing.Point(0, 0);
            this._lstbConsulta.Name = "_lstbConsulta";
            this._lstbConsulta.Size = new System.Drawing.Size(292, 252);
            this._lstbConsulta.TabIndex = 2;
            this._lstbConsulta.SelectedIndexChanged += new System.EventHandler(this._lstbConsulta_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this._btnRegistrar);
            this.panel3.Controls.Add(this._btnEliminar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 252);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(292, 37);
            this.panel3.TabIndex = 1;
            // 
            // _btnRegistrar
            // 
            this._btnRegistrar.Location = new System.Drawing.Point(112, 0);
            this._btnRegistrar.Name = "_btnRegistrar";
            this._btnRegistrar.Size = new System.Drawing.Size(87, 23);
            this._btnRegistrar.TabIndex = 0;
            this._btnRegistrar.Text = "Registrar";
            this._btnRegistrar.UseVisualStyleBackColor = true;
            this._btnRegistrar.Click += new System.EventHandler(this._btnRegistrar_Click);
            // 
            // _btnEliminar
            // 
            this._btnEliminar.Location = new System.Drawing.Point(205, 0);
            this._btnEliminar.Name = "_btnEliminar";
            this._btnEliminar.Size = new System.Drawing.Size(87, 23);
            this._btnEliminar.TabIndex = 2;
            this._btnEliminar.Text = "Eliminar";
            this._btnEliminar.UseVisualStyleBackColor = true;
            this._btnEliminar.Click += new System.EventHandler(this._btnEliminar_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 55);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(664, 289);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.navigator1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(292, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(372, 289);
            this.panel5.TabIndex = 2;
            // 
            // navigator1
            // 
            this.navigator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigator1.Location = new System.Drawing.Point(0, 0);
            this.navigator1.Name = "navigator1";
            this.navigator1.Size = new System.Drawing.Size(372, 289);
            this.navigator1.TabIndex = 1;
            // 
            // CatalogoEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Name = "CatalogoEmpleados";
            this.Size = new System.Drawing.Size(664, 344);
            this.Load += new System.EventHandler(this.CatalogoEmpleados_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox _txtBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox _lstbConsulta;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button _btnRegistrar;
        private System.Windows.Forms.Button _btnEliminar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private Navigator navigator1;
        private System.Windows.Forms.Label _lblBuscar;
        private System.Windows.Forms.Label label1;
    }
}
