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
    public partial class Clientes : UserControl
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void _btnRegistrar_Click(object sender, EventArgs e)
        {
            navigator1.NavigateTo(new RegistrarCliente());
        }

        private void _btnConsultar_Click(object sender, EventArgs e)
        {
            navigator1.NavigateTo(new ConsultarCliente());
        }
    }
}
