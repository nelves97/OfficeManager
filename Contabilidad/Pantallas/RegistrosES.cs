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
    public partial class RegistrosES : Form
    {
        public RegistrosES()
        {
            InitializeComponent();
        }

        private void RegistrosES_Load(object sender, EventArgs e)
        {
            SqlCommand selectRegistros = new SqlCommand("SELECT Dia, HoraEntrada, HoraSalida FROM Checador WHERE IdEmpleado = @IdEmpleado;", Connection.conn);
            selectRegistros.Parameters.Add(new SqlParameter("IdEmpleado", Empleado.auxiliar.Id));
            try
            {
                Connection.conn.Open();
                using (SqlDataReader rdr = selectRegistros.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        _dgvRegistros.Rows.Add(rdr.GetValue(0), rdr.GetValue(1), rdr.GetValue(2));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Connection.conn.Close();
            }
        }

        private void _btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
