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

namespace Contabilidad
{
    public partial class RegistrarCliente : Form
    {
        public RegistrarCliente()
        {
            InitializeComponent();
            _txtNombre.Focus();
        }

        private void _btnRegistrar_Click(object sender, EventArgs e)
        {
            if (_txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del cliente");
                return;
            }

            if (!_rbtnMensual.Checked && !_rbtnBimestral.Checked)
            {
                MessageBox.Show("Seleccione un perido");
                return;
            }

            int tipoCliente;
            if (_rbtnMensual.Checked == true)
            {
                tipoCliente = (Int32)Cliente.Periodos.Mensual;
            }
            else
            {
                tipoCliente = (Int32)Cliente.Periodos.Bimestral;
            }

            SqlCommand nuevoCliente = new SqlCommand("INSERT INTO Clientes (Nombre, Correo, Telefono, Domicilio, RFC, CURP, PasswordRFC, PasswordFIEL, Comentarios, RegPatronal, Periodo) VALUES(@Nombre, @Correo, @Telefono, @Domicilio, @RFC, @CURP, @PasswordRFC, @PasswordFIEL, @Comentarios, @RegPatronal, @Periodo);", Connection.conn);
            nuevoCliente.Parameters.Add(new SqlParameter("Nombre", _txtNombre.Text));
            nuevoCliente.Parameters.Add(new SqlParameter("Correo", _txtCorreo.Text));
            nuevoCliente.Parameters.Add(new SqlParameter("Telefono", _txtTelefono.Text));
            nuevoCliente.Parameters.Add(new SqlParameter("Domicilio", _txtDomicilio.Text));
            nuevoCliente.Parameters.Add(new SqlParameter("RFC", _txtRFC.Text));
            nuevoCliente.Parameters.Add(new SqlParameter("CURP", _txtCURP.Text));
            nuevoCliente.Parameters.Add(new SqlParameter("PasswordRFC", _txtContrasenaRFC.Text));
            nuevoCliente.Parameters.Add(new SqlParameter("PasswordFIEL", _txtContrasenaFIEL.Text));
            nuevoCliente.Parameters.Add(new SqlParameter("Comentarios", _txtComentarios.Text));
            nuevoCliente.Parameters.Add(new SqlParameter("RegPatronal", _txtRegPatronal.Text));
            nuevoCliente.Parameters.Add(new SqlParameter("Periodo", tipoCliente));
            SqlCommand idNueva = new SqlCommand("SELECT TOP 1 IdCliente FROM Clientes ORDER BY IdCliente DESC;", Connection.conn);

            try
            {
                Connection.conn.Open();
                nuevoCliente.ExecuteNonQuery();
                MessageBox.Show("Cliente guardado correctamente.");
                using (SqlDataReader rdr = idNueva.ExecuteReader())
                {
                    rdr.Read();
                    Cliente nuevo = new Cliente(rdr.GetInt32(0), _txtNombre.Text, _txtCorreo.Text, _txtTelefono.Text, _txtDomicilio.Text, _txtRFC.Text, _txtCURP.Text, _txtContrasenaRFC.Text, _txtContrasenaFIEL.Text, _txtComentarios.Text, _txtRegPatronal.Text, (Cliente.Periodos)tipoCliente);
                    Cliente.ListaClientes.Add(nuevo);
                }
                _rbtnBimestral.Checked = false;
                _rbtnMensual.Checked = false;
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

        private void _btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
