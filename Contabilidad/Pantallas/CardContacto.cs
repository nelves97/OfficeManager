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
    public partial class CardContacto : UserControl
    {
        public CardContacto()
        {
            InitializeComponent();
        }

        private void CardContacto_Load(object sender, EventArgs e)
        {
            _txtNombre.Text = Contacto.auxiliar.Nombre;
            _txtTelefono.Text = Contacto.auxiliar.Telefono;
            _txtCorreo.Text = Contacto.auxiliar.Correo;
            _txtDomicilio.Text = Contacto.auxiliar.Domicilio;
            _txtRFC.Text = Contacto.auxiliar.RFC;
            _txtComentarios.Text = Contacto.auxiliar.Comentarios;
            
        }

        private void _btnEditarContacto_Click(object sender, EventArgs e)
        {
            var editarContacto = new EditarContacto();
            editarContacto.ShowDialog();
            NotificationCenter.main.emit("EditarContacto");
        }
    }
}
