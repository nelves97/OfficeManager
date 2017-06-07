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
    public partial class ConsultarCliente : UserControl
    {
        public ConsultarCliente()
        {
            InitializeComponent();
        }

        private void ConsultarCliente_Load(object sender, EventArgs e)
        {
            _txtBuscar.Focus();
            _lstbConsulta.BeginUpdate();
            foreach(Cliente row in Cliente.ListaClientes)
            {
                _lstbConsulta.Items.Add(row);
            }
            _lstbConsulta.EndUpdate();
        }

        private void _txtBuscar_TextChanged(object sender, EventArgs e)
        {
            _lstbConsulta.BeginUpdate();
            _lstbConsulta.Items.Clear();
            foreach (Cliente row in Cliente.ListaClientes)
            {
                if(row.Nombre.Contains(_txtBuscar.Text))
                {
                    _lstbConsulta.Items.Add(row);
                }
            }
            _lstbConsulta.EndUpdate();
        }

        private void _lstbConsulta_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (_lstbConsulta.SelectedItem != null)
            {
                Cliente.consulta = (Cliente)_lstbConsulta.SelectedItem;
                navigator1.NavigateTo(new CardClientes());
            }
        }
    }
}
