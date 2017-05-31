using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Contabilidad
{
    public partial class RegistrarCliente : UserControl
    {
        public RegistrarCliente()
        {
            InitializeComponent();
        }

        private void _btnRegistrar_Click(object sender, EventArgs e)
        {
            int tipoCliente;
            if(_rbtnMensual.Checked == true)
            {
                tipoCliente = 1;
            }
            else
            {
                tipoCliente = 2;
            }

            SqlCommand nuevoCliente = new SqlCommand("INSERT INTO CLIENTE VALUES(@nombre, @correo, @telefono, @domicilio, @RFC, @CURP, @contrasenaRFC, @contrasenaFIEL, @tipocliente", Connection.con);
            nuevoCliente.Parameters.Add(new SqlParameter("nombre", _txtNombre.Text));
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
