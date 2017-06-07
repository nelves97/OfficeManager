using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contabilidad
{
    public partial class CardClientes : UserControl
    {
        public CardClientes()
        {
            InitializeComponent();
        }

        private void CardClientes_Load(object sender, EventArgs e)
        {
            _txtNombre.Text = Cliente.consulta.Nombre;
            _txtTelefono.Text = Cliente.consulta.Telefono;
            _txtCorreo.Text = Cliente.consulta.Correo;
            _txtCURP.Text = Cliente.consulta.CURP;
            _txtRFC.Text = Cliente.consulta.RFC;
            _txtContrasenaRFC.Text = Cliente.consulta.PasswordRFC;
            _txtContrasenaFirma.Text = Cliente.consulta.PasswordFIEL;
            _txtTipoCliente.Text = Cliente.consulta.Periodo.ToString();
            _txtDomicilio.Text = Cliente.consulta.Domicilio;
        }
    }
}
