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
    public partial class RegistrarContacto : Form
    {
        public RegistrarContacto()
        {
            InitializeComponent();
            _txtNombre.Focus();
        }

        private void _btnRegistrar_Click(object sender, EventArgs e)
        {
            if (_txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del contacto");
                return;
            }

            SqlCommand nuevoContacto = new SqlCommand("INSERT INTO Contactos (Nombre, Correo, Telefono, RFC, Domicilio, Comentarios, IdCliente) VALUES(@Nombre, @Correo, @Telefono, @RFC, @Domicilio, @Comentarios, @IdCliente);", Connection.conn);
            nuevoContacto.Parameters.Add(new SqlParameter("Nombre", _txtNombre.Text));
            nuevoContacto.Parameters.Add(new SqlParameter("Correo", _txtCorreo.Text));
            nuevoContacto.Parameters.Add(new SqlParameter("Telefono", _txtTelefono.Text));
            nuevoContacto.Parameters.Add(new SqlParameter("RFC", _txtRFC.Text));
            nuevoContacto.Parameters.Add(new SqlParameter("Domicilio", _txtDomicilio.Text));
            nuevoContacto.Parameters.Add(new SqlParameter("Comentarios", _txtComentarios.Text));
            nuevoContacto.Parameters.Add(new SqlParameter("IdCliente", Cliente.auxiliar.Id));
            SqlCommand idNueva = new SqlCommand("SELECT TOP 1 IdContacto FROM Contactos ORDER BY IdContacto DESC;", Connection.conn);

            try
            {
                Connection.conn.Open();
                nuevoContacto.ExecuteNonQuery();
                MessageBox.Show("Contacto guardado correctamente.");
                using (SqlDataReader rdr = idNueva.ExecuteReader())
                {
                    rdr.Read();
                    Contacto nuevo = new Contacto(rdr.GetInt32(0), _txtNombre.Text, _txtCorreo.Text, _txtTelefono.Text, _txtRFC.Text, _txtDomicilio.Text, _txtComentarios.Text, Cliente.auxiliar.Id);
                    Contacto.ListaContactos.Add(nuevo);
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
