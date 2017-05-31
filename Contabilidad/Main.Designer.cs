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
            this.SuspendLayout();
            // 
            // buttonInicio
            // 
            this.buttonInicio.Location = new System.Drawing.Point(12, 12);
            this.buttonInicio.Name = "buttonInicio";
            this.buttonInicio.Size = new System.Drawing.Size(75, 23);
            this.buttonInicio.TabIndex = 0;
            this.buttonInicio.Text = "Inicio";
            this.buttonInicio.UseVisualStyleBackColor = true;
            this.buttonInicio.Click += new System.EventHandler(this.buttonInicio_Click);
            // 
            // buttonClientes
            // 
            this.buttonClientes.Location = new System.Drawing.Point(12, 41);
            this.buttonClientes.Name = "buttonClientes";
            this.buttonClientes.Size = new System.Drawing.Size(75, 23);
            this.buttonClientes.TabIndex = 1;
            this.buttonClientes.Text = "Clientes";
            this.buttonClientes.UseVisualStyleBackColor = true;
            this.buttonClientes.Click += new System.EventHandler(this.buttonClientes_Click);
            // 
            // buttonDocumentos
            // 
            this.buttonDocumentos.Location = new System.Drawing.Point(12, 70);
            this.buttonDocumentos.Name = "buttonDocumentos";
            this.buttonDocumentos.Size = new System.Drawing.Size(75, 23);
            this.buttonDocumentos.TabIndex = 2;
            this.buttonDocumentos.Text = "Documentos";
            this.buttonDocumentos.UseVisualStyleBackColor = true;
            this.buttonDocumentos.Click += new System.EventHandler(this.buttonDocumentos_Click);
            // 
            // navigator1
            // 
            this.navigator1.AutoSize = true;
            this.navigator1.Location = new System.Drawing.Point(93, 12);
            this.navigator1.Name = "navigator1";
            this.navigator1.Size = new System.Drawing.Size(200, 100);
            this.navigator1.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 741);
            this.Controls.Add(this.navigator1);
            this.Controls.Add(this.buttonDocumentos);
            this.Controls.Add(this.buttonClientes);
            this.Controls.Add(this.buttonInicio);
            this.Name = "Main";
            this.Text = "Contabilidad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInicio;
        private System.Windows.Forms.Button buttonClientes;
        private System.Windows.Forms.Button buttonDocumentos;
        private Navigator navigator1;
    }
}

