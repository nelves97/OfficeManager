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
    public partial class Main : Form
    {
        DirectoryManager DM;

        public Main()
        {
            InitializeComponent();
            DM = new DirectoryManager();
            DM.InitialSetup();
        }

        private void buttonInicio_Click(object sender, EventArgs e)
        {
            navigator1.NavigateTo(new Inicio());
        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            navigator1.NavigateTo(new Clientes());
        }

        private void buttonDocumentos_Click(object sender, EventArgs e)
        {
            navigator1.NavigateTo(new Documentos());
        }
    }
}
