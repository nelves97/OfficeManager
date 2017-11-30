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

namespace Contabilidad.Pantallas
{
    public partial class RegistrarEmpleado : Form
    {
        public RegistrarEmpleado()
        {
            InitializeComponent();
            _txtNombre.Focus();
        }

        private void _btnEditar_Click(object sender, EventArgs e)
        {
            if (_txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del Empleado");
                return;
            }

            SqlCommand nuevoEmpleado = new SqlCommand("INSERT INTO Empleados (Nombre, FechaNacimiento, Correo, Telefono, HorasSemanales, Salario, FechaIngreso, Sexo, NombreUsuario, Contrasena) " +
                "VALUES(@Nombre, @FechaNacimiento, @Correo, @Telefono, @HorasSemanales, @Salario, @FechaIngreso, @Sexo, @NombreUsuario, @Contrasena);", Connection.conn);
            nuevoEmpleado.Parameters.Add(new SqlParameter("Nombre", _txtNombre.Text));
            nuevoEmpleado.Parameters.Add(new SqlParameter("FechaNacimiento", _dtpFechaNacimiento.Value));
            nuevoEmpleado.Parameters.Add(new SqlParameter("Correo", _txtCorreo.Text));
            nuevoEmpleado.Parameters.Add(new SqlParameter("Telefono", _txtTelefono.Text));
            nuevoEmpleado.Parameters.Add(new SqlParameter("HorasSemanales", _txtHorasSemanales.Text));
            nuevoEmpleado.Parameters.Add(new SqlParameter("Salario", _txtSalario.Text));
            nuevoEmpleado.Parameters.Add(new SqlParameter("FechaIngreso", _dtpFechaIngreso.Value));
            nuevoEmpleado.Parameters.Add(new SqlParameter("Sexo", _cmbSexo.Text));
            nuevoEmpleado.Parameters.Add(new SqlParameter("NombreUsuario", _txtNombreUsuario.Text));
            nuevoEmpleado.Parameters.Add(new SqlParameter("Contrasena", _txtContrasena.Text));

            SqlCommand idNueva = new SqlCommand("SELECT TOP 1 IdEmpleado FROM Empleados ORDER BY IdEmpleado DESC;", Connection.conn);

            try
            {
                Connection.conn.Open();
                nuevoEmpleado.ExecuteNonQuery();
                MessageBox.Show("Empleado guardado correctamente.");
                using (SqlDataReader rdr = idNueva.ExecuteReader())
                {
                    rdr.Read();
                    Empleado nuevo = new Empleado(rdr.GetInt32(0), _txtNombre.Text, _dtpFechaNacimiento.Value, _txtCorreo.Text, _txtTelefono.Text, Convert.ToInt32(_txtHorasSemanales.Text), Convert.ToInt32(_txtSalario.Text), _dtpFechaIngreso.Value, _cmbSexo.Text, _txtNombreUsuario.Text, _txtContrasena.Text);
                    Empleado.ListaEmpleados.Add(nuevo);
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

        private void _txtHorasSemanales_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void _txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

    }
}
