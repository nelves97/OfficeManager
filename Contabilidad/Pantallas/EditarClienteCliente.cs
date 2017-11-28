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
    public partial class EditarClienteCliente : Form
    {
        public EditarClienteCliente()
        {
            InitializeComponent();
        }

        private void EditarClienteCliente_Load(object sender, EventArgs e)
        {
            _txtNombre.Text = ClienteDeCliente.auxiliar.Nombre;
            _txtTelefono.Text = ClienteDeCliente.auxiliar.Telefono;
            _txtCorreo.Text = ClienteDeCliente.auxiliar.Correo;
            _txtRFC.Text = ClienteDeCliente.auxiliar.RFC;
            _txtComentarios.Text = ClienteDeCliente.auxiliar.Comentarios;
            _txtDomicilio.Text = ClienteDeCliente.auxiliar.Domicilio;
        }
        private void _btnEditar_Click(object sender, EventArgs e)
        {          

            SqlCommand editarCliente = new SqlCommand("UPDATE ClientesDeClientes SET Nombre = @Nombre, Correo = @Correo, Telefono = @Telefono, RFC = @RFC, Domicilio = @Domicilio, Comentarios = @Comentarios WHERE Id = @Id;", Connection.conn);
            editarCliente.Parameters.Add(new SqlParameter("Nombre", _txtNombre.Text));
            editarCliente.Parameters.Add(new SqlParameter("Correo", _txtCorreo.Text));
            editarCliente.Parameters.Add(new SqlParameter("Telefono", _txtTelefono.Text));
            editarCliente.Parameters.Add(new SqlParameter("RFC", _txtRFC.Text));
            editarCliente.Parameters.Add(new SqlParameter("Domicilio", _txtDomicilio.Text));
            editarCliente.Parameters.Add(new SqlParameter("Comentarios", _txtComentarios.Text));
            editarCliente.Parameters.Add(new SqlParameter("Id", ClienteDeCliente.auxiliar.Id));

            ClienteDeCliente.auxiliar.Nombre = _txtNombre.Text;
            ClienteDeCliente.auxiliar.Telefono = _txtTelefono.Text;
            ClienteDeCliente.auxiliar.Correo = _txtCorreo.Text;
            ClienteDeCliente.auxiliar.RFC = _txtRFC.Text;
            ClienteDeCliente.auxiliar.Domicilio = _txtDomicilio.Text;
            ClienteDeCliente.auxiliar.Comentarios = _txtComentarios.Text;

            try
            {
                Connection.conn.Open();
                editarCliente.ExecuteNonQuery();
                MessageBox.Show("Cliente editado correctamente");
                int i = 0;
                foreach (ClienteDeCliente row in ClienteDeCliente.ListaClientesDeClientes)
                {
                    if (row.Id == ClienteDeCliente.auxiliar.Id)
                    {
                        ClienteDeCliente.ListaClientesDeClientes[i] = ClienteDeCliente.auxiliar;
                        break;
                    }
                    i += 1;
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
