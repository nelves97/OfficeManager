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
            this.panel1 = new System.Windows.Forms.Panel();
            this.navigator1 = new Contabilidad.Navigator();
            this.panel2 = new System.Windows.Forms.Panel();
            this._menu = new System.Windows.Forms.MenuStrip();
            this.pantallasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catálogoDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catálogoDeEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this._menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.navigator1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 520);
            this.panel1.TabIndex = 5;
            // 
            // navigator1
            // 
            this.navigator1.AutoSize = true;
            this.navigator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigator1.Location = new System.Drawing.Point(0, 26);
            this.navigator1.Name = "navigator1";
            this.navigator1.Size = new System.Drawing.Size(651, 494);
            this.navigator1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this._menu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(651, 26);
            this.panel2.TabIndex = 0;
            // 
            // _menu
            // 
            this._menu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this._menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pantallasToolStripMenuItem});
            this._menu.Location = new System.Drawing.Point(0, 0);
            this._menu.Name = "_menu";
            this._menu.Size = new System.Drawing.Size(651, 24);
            this._menu.TabIndex = 0;
            this._menu.Text = "menuStrip1";
            // 
            // pantallasToolStripMenuItem
            // 
            this.pantallasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catálogoDeClientesToolStripMenuItem,
            this.catálogoDeEmpleadosToolStripMenuItem,
            this.calendarioToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.pantallasToolStripMenuItem.Name = "pantallasToolStripMenuItem";
            this.pantallasToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.pantallasToolStripMenuItem.Text = "Menú";
            // 
            // catálogoDeClientesToolStripMenuItem
            // 
            this.catálogoDeClientesToolStripMenuItem.Name = "catálogoDeClientesToolStripMenuItem";
            this.catálogoDeClientesToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.catálogoDeClientesToolStripMenuItem.Text = "Catálogo de clientes";
            this.catálogoDeClientesToolStripMenuItem.Click += new System.EventHandler(this.catálogoDeClientesToolStripMenuItem_Click);
            // 
            // catálogoDeEmpleadosToolStripMenuItem
            // 
            this.catálogoDeEmpleadosToolStripMenuItem.Name = "catálogoDeEmpleadosToolStripMenuItem";
            this.catálogoDeEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.catálogoDeEmpleadosToolStripMenuItem.Text = "Catálogo de empleados";
            this.catálogoDeEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.catálogoDeEmpleadosToolStripMenuItem_Click);
            // 
            // calendarioToolStripMenuItem
            // 
            this.calendarioToolStripMenuItem.Name = "calendarioToolStripMenuItem";
            this.calendarioToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.calendarioToolStripMenuItem.Text = "Calendario";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 523);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.Text = "Contabilidad";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this._menu.ResumeLayout(false);
            this._menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem pantallasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catálogoDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catálogoDeEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private Navigator navigator1;
        private System.Windows.Forms.MenuStrip _menu;
    }
}

