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
    public partial class EditarEmpleado : Form
    {
        public EditarEmpleado()
        {
            InitializeComponent();
        }

        private void EditarEmpleado_Load(object sender, EventArgs e)
        {
            _txtNombre.Text = Empleado.auxiliar.Nombre;
            _txtCorreo.Text = Empleado.auxiliar.Correo;
            _txtTelefono.Text = Empleado.auxiliar.Telefono;
            _dtpFechaNacimiento.Value = Empleado.auxiliar.FechadeNacimiento;
            _txtHorasSemanales.Text = Empleado.auxiliar.HorasSemanales.ToString();
            _txtSalario.Text = Empleado.auxiliar.Salario.ToString();
            _dtpFechaIngreso.Value = Empleado.auxiliar.FechadeIngreso;
            _cmbSexo.Text = Empleado.auxiliar.Sexo;
            _txtNombreUsuario.Text = Empleado.auxiliar.NombreUsuario;
            _txtContrasena.Text = Empleado.auxiliar.Contrasena;
        }

        private void _btnEditar_Click(object sender, EventArgs e)
        {
            SqlCommand editarEmpleado = new SqlCommand("UPDATE Empleados SET Nombre = @Nombre, FechaNacimiento = @FechaNacimiento, Correo = @Correo, Telefono = @Telefono, HorasSemanales = @HorasSemanales, Salario = @Salario, FechaIngreso = @FechaIngreso, Sexo = @Sexo, NombreUsuario = @NombreUsuario, Contrasena = @Contrasena WHERE IdEmpleado = @IdEmpleado;", Connection.conn);
            editarEmpleado.Parameters.Add(new SqlParameter("Nombre", _txtNombre.Text));
            editarEmpleado.Parameters.Add(new SqlParameter("FechaNacimiento", _dtpFechaNacimiento.Value.Date));
            editarEmpleado.Parameters.Add(new SqlParameter("Correo", _txtCorreo.Text));
            editarEmpleado.Parameters.Add(new SqlParameter("Telefono", _txtTelefono.Text));
            editarEmpleado.Parameters.Add(new SqlParameter("HorasSemanales", _txtHorasSemanales.Text));
            editarEmpleado.Parameters.Add(new SqlParameter("Salario", _txtSalario.Text));
            editarEmpleado.Parameters.Add(new SqlParameter("FechaIngreso", _dtpFechaIngreso.Value.Date));
            editarEmpleado.Parameters.Add(new SqlParameter("Sexo", _cmbSexo.Text));
            editarEmpleado.Parameters.Add(new SqlParameter("NombreUsuario", _txtNombreUsuario.Text));
            editarEmpleado.Parameters.Add(new SqlParameter("Contrasena", _txtContrasena.Text));
            editarEmpleado.Parameters.Add(new SqlParameter("IdEmpleado", Empleado.auxiliar.Id));

            Empleado.auxiliar.Nombre = _txtNombre.Text;
            Empleado.auxiliar.FechadeNacimiento = _dtpFechaNacimiento.Value.Date;
            Empleado.auxiliar.Telefono = _txtTelefono.Text;
            Empleado.auxiliar.Correo = _txtCorreo.Text;
            Empleado.auxiliar.HorasSemanales = Convert.ToInt32(_txtHorasSemanales.Text);
            Empleado.auxiliar.Salario = Convert.ToInt32(_txtSalario.Text);
            Empleado.auxiliar.FechadeIngreso = _dtpFechaIngreso.Value.Date;
            Empleado.auxiliar.Sexo = _cmbSexo.Text;
            Empleado.auxiliar.NombreUsuario = _txtNombreUsuario.Text;
            Empleado.auxiliar.Contrasena = _txtContrasena.Text;

            try
            {
                Connection.conn.Open();
                editarEmpleado.ExecuteNonQuery();
                MessageBox.Show("Empleado editado correctamente");
                int i = 0;
                foreach (Empleado row in Empleado.ListaEmpleados)
                {
                    if (row.Id == Empleado.auxiliar.Id)
                    {
                        Empleado.ListaEmpleados[i] = Empleado.auxiliar;
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
