namespace Contabilidad
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.navigator1 = new Contabilidad.Navigator();
            this.panel2 = new System.Windows.Forms.Panel();
            this._btnCatalogoEmpleados = new System.Windows.Forms.Button();
            this._btnCatalogoClientes = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Catalogo de Clientes";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.navigator1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 459);
            this.panel1.TabIndex = 5;
            // 
            // navigator1
            // 
            this.navigator1.AutoSize = true;
            this.navigator1.BackColor = System.Drawing.SystemColors.Control;
            this.navigator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigator1.Location = new System.Drawing.Point(0, 30);
            this.navigator1.Name = "navigator1";
            this.navigator1.Size = new System.Drawing.Size(573, 429);
            this.navigator1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this._btnCatalogoClientes);
            this.panel2.Controls.Add(this._btnCatalogoEmpleados);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(573, 30);
            this.panel2.TabIndex = 0;
            // 
            // _btnCatalogoEmpleados
            // 
            this._btnCatalogoEmpleados.Location = new System.Drawing.Point(405, 4);
            this._btnCatalogoEmpleados.Name = "_btnCatalogoEmpleados";
            this._btnCatalogoEmpleados.Size = new System.Drawing.Size(165, 23);
            this._btnCatalogoEmpleados.TabIndex = 6;
            this._btnCatalogoEmpleados.Text = "Catalogo de Empleados";
            this._btnCatalogoEmpleados.UseVisualStyleBackColor = true;
            this._btnCatalogoEmpleados.Click += new System.EventHandler(this._btnCatalogoEmpleados_Click);
            // 
            // _btnCatalogoClientes
            // 
            this._btnCatalogoClientes.Location = new System.Drawing.Point(234, 3);
            this._btnCatalogoClientes.Name = "_btnCatalogoClientes";
            this._btnCatalogoClientes.Size = new System.Drawing.Size(165, 23);
            this._btnCatalogoClientes.TabIndex = 7;
            this._btnCatalogoClientes.Text = "Catalogo de Clientes";
            this._btnCatalogoClientes.UseVisualStyleBackColor = true;
            this._btnCatalogoClientes.Click += new System.EventHandler(this._btnCatalogoClientes_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 483);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.Text = "Contabilidad";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Navigator navigator1;
        private System.Windows.Forms.Button _btnCatalogoEmpleados;
        private System.Windows.Forms.Button _btnCatalogoClientes;
    }
}

