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
    public partial class CatalogoClientes : UserControl
    {
        public CatalogoClientes()
        {
            InitializeComponent();
        }

        private void CatalogoClientes_Load(object sender, EventArgs e)
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
                Cliente.auxiliar = (Cliente)_lstbConsulta.SelectedItem;
                navigator1.NavigateTo(new CardClientes());
            }
        }

        private void _btnEliminar_Click(object sender, EventArgs e)
        {           
            if (_lstbConsulta.SelectedIndex != -1)
            {
                DialogResult respuesta = MessageBox.Show("¿Seguro que desea eliminar a " + _lstbConsulta.SelectedItem.ToString() + "?", "Eliminar Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.OK)
                {
                    Cliente clienteBorrado = (Cliente)_lstbConsulta.SelectedItem;
                    SqlCommand eliminarCliente = new SqlCommand("DELETE FROM Clientes WHERE Id = " + clienteBorrado.Id + ";", Connection.conn);

                    try
                    {
                        Connection.conn.Open();
                        eliminarCliente.ExecuteNonQuery();
                        MessageBox.Show("Cliente eliminado correctamente.");
                        Cliente.ListaClientes.Remove(clienteBorrado);
                        _lstbConsulta.BeginUpdate();
                        _lstbConsulta.Items.Clear();
                        foreach (Cliente row in Cliente.ListaClientes)
                        {
                            _lstbConsulta.Items.Add(row);
                        }
                        _lstbConsulta.EndUpdate();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        Connection.conn.Close();
                        navigator1.ClearNavigator();
                    }
                }
            }
        }

        private void _btnEditar_Click(object sender, EventArgs e)
        {
            if (_lstbConsulta.SelectedIndex != -1)
            {
                Cliente.auxiliar = (Cliente)_lstbConsulta.SelectedItem;
                var editarCliente = new EditarCliente();
                editarCliente.ShowDialog();
                _lstbConsulta.BeginUpdate();
                _lstbConsulta.Items.Clear();
                foreach (Cliente row in Cliente.ListaClientes)
                {
                    _lstbConsulta.Items.Add(row);
                }
                _lstbConsulta.EndUpdate();
                navigator1.ClearNavigator();
            }
        }

        private void _btnRegistrar_Click(object sender, EventArgs e)
        {
            var registrarCliente = new RegistrarCliente();
            registrarCliente.ShowDialog();
            _lstbConsulta.BeginUpdate();
            _lstbConsulta.Items.Clear();
            foreach (Cliente row in Cliente.ListaClientes)
            {
                _lstbConsulta.Items.Add(row);
            }
            _lstbConsulta.EndUpdate();
            navigator1.ClearNavigator();

        }
    }
}
