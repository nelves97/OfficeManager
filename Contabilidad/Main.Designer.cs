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
            this.buttonInicio = new System.Windows.Forms.Button();
            this.buttonClientes = new System.Windows.Forms.Button();
            this.buttonDocumentos = new System.Windows.Forms.Button();
            this.navigator1 = new Contabilidad.Navigator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonInicio
            // 
            this.buttonInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonInicio.Location = new System.Drawing.Point(0, 46);
            this.buttonInicio.Name = "buttonInicio";
            this.buttonInicio.Size = new System.Drawing.Size(104, 23);
            this.buttonInicio.TabIndex = 0;
            this.buttonInicio.Text = "Inicio";
            this.buttonInicio.UseVisualStyleBackColor = true;
            this.buttonInicio.Click += new System.EventHandler(this.buttonInicio_Click);
            // 
            // buttonClientes
            // 
            this.buttonClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonClientes.Location = new System.Drawing.Point(0, 0);
            this.buttonClientes.Name = "buttonClientes";
            this.buttonClientes.Size = new System.Drawing.Size(104, 23);
            this.buttonClientes.TabIndex = 1;
            this.buttonClientes.Text = "Clientes";
            this.buttonClientes.UseVisualStyleBackColor = true;
            this.buttonClientes.Click += new System.EventHandler(this.buttonClientes_Click);
            // 
            // buttonDocumentos
            // 
            this.buttonDocumentos.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDocumentos.Location = new System.Drawing.Point(0, 23);
            this.buttonDocumentos.Name = "buttonDocumentos";
            this.buttonDocumentos.Size = new System.Drawing.Size(104, 23);
            this.buttonDocumentos.TabIndex = 2;
            this.buttonDocumentos.Text = "Documentos";
            this.buttonDocumentos.UseVisualStyleBackColor = true;
            this.buttonDocumentos.Click += new System.EventHandler(this.buttonDocumentos_Click);
            // 
            // navigator1
            // 
            this.navigator1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navigator1.AutoSize = true;
            this.navigator1.BackColor = System.Drawing.SystemColors.Control;
            this.navigator1.Location = new System.Drawing.Point(110, 0);
            this.navigator1.Name = "navigator1";
            this.navigator1.Size = new System.Drawing.Size(1072, 741);
            this.navigator1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonInicio);
            this.panel1.Controls.Add(this.buttonDocumentos);
            this.panel1.Controls.Add(this.buttonClientes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(104, 741);
            this.panel1.TabIndex = 4;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 741);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.navigator1);
            this.Name = "Main";
            this.Text = "Contabilidad";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInicio;
        private System.Windows.Forms.Button buttonClientes;
        private System.Windows.Forms.Button buttonDocumentos;
        private Navigator navigator1;
        private System.Windows.Forms.Panel panel1;
    }
}

