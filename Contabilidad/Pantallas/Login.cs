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
                    Connection.conn.Close();
                }
                else if (Connection.rol == 0)
                {
                    Connection.conn.Close();
                    Checador.RegistrarEntrada();
                    this.Hide();
                }
                else
                {
                    Connection.conn.Close();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void _btnSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            Environment.Exit(0);
        }

        private void _txtNombreUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                _btnAceptar_Click(sender, e);
        }

        private void _txtContrasena_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                _btnAceptar_Click(sender, e);
        }
    }
}
