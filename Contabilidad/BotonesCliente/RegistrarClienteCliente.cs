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
    public partial class RegistrarClienteCliente : Form
    {
        public RegistrarClienteCliente()
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

            SqlCommand nuevoCliente = new SqlCommand("INSERT INTO ClientesDeClientes (Nombre, Correo, Telefono, RFC, Domicilio, Comentarios, IdCliente) VALUES(@Nombre, @Correo, @Telefono, @RFC, @Domicilio, @Comentarios, @IdCliente);", Connection.conn);
            nuevoCliente.Parameters.Add(new SqlParameter("Nombre", _txtNombre.Text));
            nuevoCliente.Parameters.Add(new SqlParameter("Correo", _txtCorreo.Text));
            nuevoCliente.Parameters.Add(new SqlParameter("Telefono", _txtTelefono.Text));
            nuevoCliente.Parameters.Add(new SqlParameter("RFC", _txtRFC.Text));
            nuevoCliente.Parameters.Add(new SqlParameter("Domicilio", _txtDomicilio.Text));
            nuevoCliente.Parameters.Add(new SqlParameter("Comentarios", _txtComentarios.Text));
            nuevoCliente.Parameters.Add(new SqlParameter("IdCliente", Cliente.auxiliar.Id));
            SqlCommand idNueva = new SqlCommand("SELECT TOP 1 Id FROM ClientesDeClientes ORDER BY Id DESC;", Connection.conn);

            try
            {
                Connection.conn.Open();
                nuevoCliente.ExecuteNonQuery();
                MessageBox.Show("Cliente guardado correctamente.");
                using (SqlDataReader rdr = idNueva.ExecuteReader())
                {
                    rdr.Read();
                    ClienteDeCliente nuevo = new ClienteDeCliente(rdr.GetInt32(0), _txtNombre.Text, _txtCorreo.Text, _txtTelefono.Text, _txtRFC.Text, _txtDomicilio.Text, _txtComentarios.Text, Cliente.auxiliar.Id);
                    ClienteDeCliente.ListaClientesDeClientes.Add(nuevo);
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

        private void _btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
