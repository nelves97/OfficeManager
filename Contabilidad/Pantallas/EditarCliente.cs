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
    public partial class EditarCliente : Form
    {
        public EditarCliente()
        {
            InitializeComponent();
        }

        private void EditarCliente_Load(object sender, EventArgs e)
        {
            _txtNombre.Text = Cliente.auxiliar.Nombre;
            _txtTelefono.Text = Cliente.auxiliar.Telefono;
            _txtCorreo.Text = Cliente.auxiliar.Correo;
            _txtCURP.Text = Cliente.auxiliar.CURP;
            _txtRFC.Text = Cliente.auxiliar.RFC;
            _txtContrasenaRFC.Text = Cliente.auxiliar.PasswordRFC;
            _txtContrasenaFIEL.Text = Cliente.auxiliar.PasswordFIEL;
            _txtDomicilio.Text = Cliente.auxiliar.Domicilio;
            _txtComentarios.Text = Cliente.auxiliar.Comentarios;
            _txtRegPatronal.Text = Cliente.auxiliar.RegPatronal;
            if(Cliente.auxiliar.Periodo == Cliente.Periodos.Bimestral)
            {
                _rbtnBimestral.Checked = true;
            }
            else
            {
                _rbtnMensual.Checked = true;
            }
        }

        private void _btnEditar_Click(object sender, EventArgs e)
        {
            int tipoCliente;

            if (_rbtnMensual.Checked == true)
            {
                tipoCliente = (Int32)Cliente.Periodos.Mensual;
            }
            else
            {
                tipoCliente = (Int32)Cliente.Periodos.Bimestral;
            }

            SqlCommand editarCliente = new SqlCommand("UPDATE Clientes SET Nombre = @Nombre, Correo = @Correo, Telefono = @Telefono, Domicilio = @Domicilio, RFC = @RFC, CURP = @CURP, PasswordRFC = @PasswordRFC, PasswordFIEL = @PasswordFIEL, RegPatronal = @RegPatronal, Comentarios = @Comentarios, Periodo = @Periodo WHERE Id = @Id;", Connection.conn);
            editarCliente.Parameters.Add(new SqlParameter("Nombre", _txtNombre.Text));
            editarCliente.Parameters.Add(new SqlParameter("Correo", _txtCorreo.Text));
            editarCliente.Parameters.Add(new SqlParameter("Telefono", _txtTelefono.Text));
            editarCliente.Parameters.Add(new SqlParameter("Domicilio", _txtDomicilio.Text));
            editarCliente.Parameters.Add(new SqlParameter("RFC", _txtRFC.Text));
            editarCliente.Parameters.Add(new SqlParameter("CURP", _txtCURP.Text));
            editarCliente.Parameters.Add(new SqlParameter("PasswordRFC", _txtContrasenaRFC.Text));
            editarCliente.Parameters.Add(new SqlParameter("PasswordFIEL", _txtContrasenaFIEL.Text));
            editarCliente.Parameters.Add(new SqlParameter("Periodo", tipoCliente));
            editarCliente.Parameters.Add(new SqlParameter("Comentarios", _txtComentarios.Text));
            editarCliente.Parameters.Add(new SqlParameter("RegPatronal", _txtRegPatronal.Text));
            editarCliente.Parameters.Add(new SqlParameter("Id", Cliente.auxiliar.Id));

            Cliente.auxiliar.Nombre = _txtNombre.Text;
            Cliente.auxiliar.Telefono = _txtTelefono.Text;
            Cliente.auxiliar.Correo = _txtCorreo.Text;
            Cliente.auxiliar.CURP = _txtCURP.Text;
            Cliente.auxiliar.RFC = _txtRFC.Text;
            Cliente.auxiliar.PasswordRFC =_txtContrasenaRFC.Text;
            Cliente.auxiliar.PasswordFIEL = _txtContrasenaFIEL.Text;
            Cliente.auxiliar.Periodo = (Cliente.Periodos)tipoCliente;
            Cliente.auxiliar.Domicilio = _txtDomicilio.Text;
            Cliente.auxiliar.Comentarios = _txtComentarios.Text;
            Cliente.auxiliar.RegPatronal = _txtRegPatronal.Text;
            try
            {
                Connection.conn.Open();
                editarCliente.ExecuteNonQuery();
                MessageBox.Show("Cliente editado correctamente");
                int i = 0;
                foreach (Cliente row in Cliente.ListaClientes)
                {
                    if (row.Id == Cliente.auxiliar.Id)
                    {
                        Cliente.ListaClientes[i] = Cliente.auxiliar;
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
