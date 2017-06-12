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
    public partial class CardClienteCliente : UserControl
    {
        public CardClienteCliente()
        {
            InitializeComponent();
        }

        private void CardClienteCliente_Load(object sender, EventArgs e)
        {
            _txtNombre.Text = ClienteDeCliente.auxiliar.Nombre;
            _txtTelefono.Text = ClienteDeCliente.auxiliar.Telefono;
            _txtCorreo.Text = ClienteDeCliente.auxiliar.Correo;
            _txtDomicilio.Text = ClienteDeCliente.auxiliar.Domicilio;
            _txtRFC.Text = ClienteDeCliente.auxiliar.RFC;
            _txtComentarios.Text = ClienteDeCliente.auxiliar.Comentarios;
            
        }
    }
}
