using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contabilidad
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void _btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.conn.Open();
                Connection.Autenticar(_txtNombreUsuario.Text, _txtContrasena.Text);
                if (Connection.rol == -1)
                {
                    MessageBox.Show("Error en los datos.");
                }
                else
                {
                    Connection.conn.Close();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Connection.conn.Close();
            }
        }

        private void _btnSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
