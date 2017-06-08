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
            this.navigator1 = new Contabilidad.Navigator();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // navigator1
            // 
            this.navigator1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navigator1.AutoSize = true;
            this.navigator1.BackColor = System.Drawing.SystemColors.Control;
            this.navigator1.Location = new System.Drawing.Point(12, 26);
            this.navigator1.Name = "navigator1";
            this.navigator1.Size = new System.Drawing.Size(1072, 741);
            this.navigator1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Catalogo de Clientes";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 741);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.navigator1);
            this.Name = "Main";
            this.Text = "Contabilidad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Navigator navigator1;
        private System.Windows.Forms.Label label1;
    }
}

