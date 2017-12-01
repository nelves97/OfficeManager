namespace Contabilidad.Pantallas
{
    partial class RegistrosES
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
            this._dgvRegistros = new System.Windows.Forms.DataGridView();
            this.Dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._dgvRegistros)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registros de Entrada y Salida:";
            // 
            // _dgvRegistros
            // 
            this._dgvRegistros.AllowUserToAddRows = false;
            this._dgvRegistros.AllowUserToDeleteRows = false;
            this._dgvRegistros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvRegistros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dia,
            this.HoraEntrada,
            this.HoraSalida});
            this._dgvRegistros.Location = new System.Drawing.Point(16, 32);
            this._dgvRegistros.Name = "_dgvRegistros";
            this._dgvRegistros.ReadOnly = true;
            this._dgvRegistros.Size = new System.Drawing.Size(436, 188);
            this._dgvRegistros.TabIndex = 2;
            // 
            // Dia
            // 
            this.Dia.HeaderText = "Día";
            this.Dia.Name = "Dia";
            this.Dia.ReadOnly = true;
            // 
            // HoraEntrada
            // 
            this.HoraEntrada.HeaderText = "Hora de Entrada";
            this.HoraEntrada.Name = "HoraEntrada";
            this.HoraEntrada.ReadOnly = true;
            // 
            // HoraSalida
            // 
            this.HoraSalida.HeaderText = "Hora de Salida";
            this.HoraSalida.Name = "HoraSalida";
            this.HoraSalida.ReadOnly = true;
            // 
            // _btnSalir
            // 
            this._btnSalir.Location = new System.Drawing.Point(377, 226);
            this._btnSalir.Name = "_btnSalir";
            this._btnSalir.Size = new System.Drawing.Size(75, 23);
            this._btnSalir.TabIndex = 3;
            this._btnSalir.Text = "Salir";
            this._btnSalir.UseVisualStyleBackColor = true;
            this._btnSalir.Click += new System.EventHandler(this._btnSalir_Click);
            // 
            // RegistrosES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 259);
            this.Controls.Add(this._btnSalir);
            this.Controls.Add(this._dgvRegistros);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RegistrosES";
            this.Text = "OfficeManager";
            this.Load += new System.EventHandler(this.RegistrosES_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dgvRegistros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView _dgvRegistros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraSalida;
        private System.Windows.Forms.Button _btnSalir;
    }
}