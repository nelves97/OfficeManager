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
    public partial class EditarContacto : Form
    {
        public EditarContacto()
        {
            InitializeComponent();
        }

        private void EditarContacto_Load(object sender, EventArgs e)
        {
            _txtNombre.Text = Contacto.auxiliar.Nombre;
            _txtTelefono.Text = Contacto.auxiliar.Telefono;
            _txtCorreo.Text = Contacto.auxiliar.Correo;
            _txtRFC.Text = Contacto.auxiliar.RFC;
            _txtComentarios.Text = Contacto.auxiliar.Comentarios;
            _txtDomicilio.Text = Contacto.auxiliar.Domicilio;
        }
        private void _btnEditar_Click(object sender, EventArgs e)
        {          

            SqlCommand editarContacto = new SqlCommand("UPDATE Contactos SET Nombre = @Nombre, Correo = @Correo, Telefono = @Telefono, RFC = @RFC, Domicilio = @Domicilio, Comentarios = @Comentarios WHERE IdContacto = @IdContacto;", Connection.conn);
            editarContacto.Parameters.Add(new SqlParameter("Nombre", _txtNombre.Text));
            editarContacto.Parameters.Add(new SqlParameter("Correo", _txtCorreo.Text));
            editarContacto.Parameters.Add(new SqlParameter("Telefono", _txtTelefono.Text));
            editarContacto.Parameters.Add(new SqlParameter("RFC", _txtRFC.Text));
            editarContacto.Parameters.Add(new SqlParameter("Domicilio", _txtDomicilio.Text));
            editarContacto.Parameters.Add(new SqlParameter("Comentarios", _txtComentarios.Text));
            editarContacto.Parameters.Add(new SqlParameter("IdContacto", Contacto.auxiliar.Id));

            Contacto.auxiliar.Nombre = _txtNombre.Text;
            Contacto.auxiliar.Telefono = _txtTelefono.Text;
            Contacto.auxiliar.Correo = _txtCorreo.Text;
            Contacto.auxiliar.RFC = _txtRFC.Text;
            Contacto.auxiliar.Domicilio = _txtDomicilio.Text;
            Contacto.auxiliar.Comentarios = _txtComentarios.Text;

            try
            {
                Connection.conn.Open();
                editarContacto.ExecuteNonQuery();
                MessageBox.Show("Contacto editado correctamente");
                int i = 0;
                foreach (Contacto row in Contacto.ListaContactos)
                {
                    if (row.Id == Contacto.auxiliar.Id)
                    {
                        Contacto.ListaContactos[i] = Contacto.auxiliar;
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
