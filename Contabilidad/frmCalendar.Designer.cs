namespace Contabilidad
{
    partial class frmCalendar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this._mtcCalendario = new System.Windows.Forms.MonthCalendar();
            this._dgvCitas = new System.Windows.Forms.DataGridView();
            this.btnAgregarCita = new System.Windows.Forms.Button();
            this.btnEliminarCita = new System.Windows.Forms.Button();
            this._btnCerrar = new System.Windows.Forms.Button();
            this._btnMostrarTodas = new System.Windows.Forms.Button();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._dgvCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // _mtcCalendario
            // 
            this._mtcCalendario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._mtcCalendario.CalendarDimensions = new System.Drawing.Size(1, 2);
            this._mtcCalendario.Location = new System.Drawing.Point(0, 34);
            this._mtcCalendario.Name = "_mtcCalendario";
            this._mtcCalendario.TabIndex = 0;
            this._mtcCalendario.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // _dgvCitas
            // 
            this._dgvCitas.AllowUserToAddRows = false;
            this._dgvCitas.AllowUserToDeleteRows = false;
            this._dgvCitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvCitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNombre,
            this.ColumnInfo,
            this.ColumnDia,
            this.ColumnHora,
            this.ColumnId});
            this._dgvCitas.Location = new System.Drawing.Point(260, 34);
            this._dgvCitas.Name = "_dgvCitas";
            this._dgvCitas.ReadOnly = true;
            this._dgvCitas.Size = new System.Drawing.Size(491, 333);
            this._dgvCitas.TabIndex = 1;
            // 
            // btnAgregarCita
            // 
            this.btnAgregarCita.Location = new System.Drawing.Point(39, 357);
            this.btnAgregarCita.Name = "btnAgregarCita";
            this.btnAgregarCita.Size = new System.Drawing.Size(116, 23);
            this.btnAgregarCita.TabIndex = 2;
            this.btnAgregarCita.Text = "Agegar Cita";
            this.btnAgregarCita.UseVisualStyleBackColor = true;
            this.btnAgregarCita.Click += new System.EventHandler(this.btnAgregarCita_Click);
            // 
            // btnEliminarCita
            // 
            this.btnEliminarCita.Location = new System.Drawing.Point(39, 397);
            this.btnEliminarCita.Name = "btnEliminarCita";
            this.btnEliminarCita.Size = new System.Drawing.Size(116, 23);
            this.btnEliminarCita.TabIndex = 3;
            this.btnEliminarCita.Text = "Eliminar Cita";
            this.btnEliminarCita.UseVisualStyleBackColor = true;
            this.btnEliminarCita.Click += new System.EventHandler(this.btnEliminarCita_Click);
            // 
            // _btnCerrar
            // 
            this._btnCerrar.Location = new System.Drawing.Point(595, 408);
            this._btnCerrar.Name = "_btnCerrar";
            this._btnCerrar.Size = new System.Drawing.Size(116, 23);
            this._btnCerrar.TabIndex = 5;
            this._btnCerrar.Text = "Cerrar";
            this._btnCerrar.UseVisualStyleBackColor = true;
            this._btnCerrar.Click += new System.EventHandler(this._btnCerrar_Click);
            // 
            // _btnMostrarTodas
            // 
            this._btnMostrarTodas.Location = new System.Drawing.Point(384, 408);
            this._btnMostrarTodas.Name = "_btnMostrarTodas";
            this._btnMostrarTodas.Size = new System.Drawing.Size(116, 23);
            this._btnMostrarTodas.TabIndex = 7;
            this._btnMostrarTodas.Text = "Todas las Citas";
            this._btnMostrarTodas.UseVisualStyleBackColor = true;
            this._btnMostrarTodas.Click += new System.EventHandler(this._btnMostrarTodas_Click);
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.HeaderText = "Nombre del Cliente";
            this.ColumnNombre.Name = "ColumnNombre";
            this.ColumnNombre.ReadOnly = true;
            // 
            // ColumnInfo
            // 
            this.ColumnInfo.HeaderText = "Información de cita";
            this.ColumnInfo.Name = "ColumnInfo";
            this.ColumnInfo.ReadOnly = true;
            // 
            // ColumnDia
            // 
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.ColumnDia.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnDia.HeaderText = "Fecha";
            this.ColumnDia.Name = "ColumnDia";
            this.ColumnDia.ReadOnly = true;
            // 
            // ColumnHora
            // 
            dataGridViewCellStyle2.Format = "t";
            dataGridViewCellStyle2.NullValue = null;
            this.ColumnHora.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnHora.HeaderText = "Hora";
            this.ColumnHora.Name = "ColumnHora";
            this.ColumnHora.ReadOnly = true;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Visible = false;
            // 
            // frmCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 466);
            this.Controls.Add(this._btnMostrarTodas);
            this.Controls.Add(this._btnCerrar);
            this.Controls.Add(this.btnEliminarCita);
            this.Controls.Add(this.btnAgregarCita);
            this.Controls.Add(this._dgvCitas);
            this.Controls.Add(this._mtcCalendario);
            this.Name = "frmCalendar";
            this.Text = "Agenda de Citas";
            this.Activated += new System.EventHandler(this.frmCalendar_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCalendar_FormClosing);
            this.Load += new System.EventHandler(this.frmCalendar_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dgvCitas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar _mtcCalendario;
        private System.Windows.Forms.DataGridView _dgvCitas;
        private System.Windows.Forms.Button btnAgregarCita;
        private System.Windows.Forms.Button btnEliminarCita;
        private System.Windows.Forms.Button _btnCerrar;
        private System.Windows.Forms.Button _btnMostrarTodas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
    }
}