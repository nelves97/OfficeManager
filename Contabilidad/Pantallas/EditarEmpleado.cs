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
        }

        private void _btnEditar_Click(object sender, EventArgs e)
        {
            SqlCommand editarEmpleado = new SqlCommand("UPDATE Empleados SET Nombre = @Nombre, Fecha de nacimiento = @Fecha de nacimiento, Correo = @Correo, Telefono = @Telefono, Horas semanales = @Horas semanales, Salario = @Salario, Fecha de ingreso = @Fecha de ingreso, WHERE Id = @Id;", Connection.conn);
            editarEmpleado.Parameters.Add(new SqlParameter("Nombre", _txtNombre.Text));
            editarEmpleado.Parameters.Add(new SqlParameter("Fecha de nacimiento", _dtpFechaNacimiento.Value));
            editarEmpleado.Parameters.Add(new SqlParameter("Correo", _txtCorreo.Text));
            editarEmpleado.Parameters.Add(new SqlParameter("Telefono", _txtTelefono.Text));
            editarEmpleado.Parameters.Add(new SqlParameter("Horas semanales", _txtHorasSemanales.Text));
            editarEmpleado.Parameters.Add(new SqlParameter("Salario", _txtSalario.Text));
            editarEmpleado.Parameters.Add(new SqlParameter("Fecha de ingreso", _dtpFechaIngreso.Value));
            editarEmpleado.Parameters.Add(new SqlParameter("Id", Empleado.auxiliar.Id));

            Empleado.auxiliar.Nombre = _txtNombre.Text;
            Empleado.auxiliar.FechadeNacimiento = _dtpFechaNacimiento.Value;
            Empleado.auxiliar.Telefono = _txtTelefono.Text;
            Empleado.auxiliar.Correo = _txtCorreo.Text;
            Empleado.auxiliar.HorasSemanales = Convert.ToInt32(_txtHorasSemanales.Text);
            Empleado.auxiliar.Salario = Convert.ToInt32(_txtSalario.Text);
            Empleado.auxiliar.FechadeIngreso = _dtpFechaIngreso.Value;

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
    }
}
