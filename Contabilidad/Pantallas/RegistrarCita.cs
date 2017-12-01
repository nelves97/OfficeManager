using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Contabilidad.Clases;

namespace Contabilidad.Pantallas
{
    public partial class RegistrarCita : Form
    {
        public RegistrarCita()
        {
            InitializeComponent();
        }
        public String _color = "White";

        private void RegistrarCita_Load(object sender, EventArgs e)
        {
            _cmbClientes.BeginUpdate();
            _cmbClientes.Items.Clear();
            foreach (Cliente row in Cliente.ListaClientes)
            {
                _cmbClientes.Items.Add(row);
            }
            _cmbClientes.EndUpdate();
        }

        private void _btnRegistrar_Click(object sender, EventArgs e)
        {
            if (_cmbClientes.SelectedItem==null)
            {
                MessageBox.Show("Ingrese el nombre del cliente");
                return;
            }

            SqlCommand nuevaCita = new SqlCommand("INSERT INTO Citas (Dia, Hora, Info, Color, IdCliente) VALUES(@Dia, @Hora, @Info, @Color, @IdCliente);", Connection.conn);
            nuevaCita.Parameters.Add(new SqlParameter("Dia", _dtpFecha.Value));
            nuevaCita.Parameters.Add(new SqlParameter("Hora", _dtpHora.Value));
            nuevaCita.Parameters.Add(new SqlParameter("Info", _txtInfo.Text));
            nuevaCita.Parameters.Add(new SqlParameter("Color", _color));
            nuevaCita.Parameters.Add(new SqlParameter("IdCliente", Cliente.auxiliar.Id));
            SqlCommand idNueva = new SqlCommand("SELECT TOP 1 Id FROM Citas ORDER BY Id DESC;", Connection.conn);

            try
            {
                Connection.conn.Open();
                nuevaCita.ExecuteNonQuery();
                MessageBox.Show("Cita guardada correctamente.");
                using (SqlDataReader rdr = idNueva.ExecuteReader())
                {
                    rdr.Read();
                    Cita nuevo = new Cita(rdr.GetInt32(0), _dtpFecha.Value, _dtpHora.Value, _txtInfo.Text,ColorTranslator.FromHtml(_color), Cliente.auxiliar.Id);
                    Cita.ListaCitas.Add(nuevo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Connection.conn.Close();
                this.Close();
            }
        }

        private void _btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                _btnColor.BackColor = colorDialog1.Color;
                _color = ColorTranslator.ToHtml(colorDialog1.Color);
            }
        }

        private void _cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente.auxiliar = (Cliente)_cmbClientes.SelectedItem;
        }

        private void _btnCancelar_Click(object sender, EventArgs e)
        {
            Owner.Enabled = true;
            this.Close();
        }

        private void RegistrarCita_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Enabled = true;
        }
    }
}
