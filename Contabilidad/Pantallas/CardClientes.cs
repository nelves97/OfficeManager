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
    public partial class CardClientes : UserControl
    {
        public CardClientes()
        {
            InitializeComponent();
        }

        private void CardClientes_Load(object sender, EventArgs e)
        {
            _txtNombre.Text = Cliente.auxiliar.Nombre;
            _txtTelefono.Text = Cliente.auxiliar.Telefono;
            _txtCorreo.Text = Cliente.auxiliar.Correo;
            _txtCURP.Text = Cliente.auxiliar.CURP;
            _txtRFC.Text = Cliente.auxiliar.RFC;
            _txtContrasenaRFC.Text = Cliente.auxiliar.PasswordRFC;
            _txtContrasenaFIEL.Text = Cliente.auxiliar.PasswordFIEL;
            _txtTipoCliente.Text = Cliente.auxiliar.Periodo.ToString();
            _txtDomicilio.Text = Cliente.auxiliar.Domicilio;
            _txtComentarios.Text = Cliente.auxiliar.Comentarios;
            _txtRegPatronal.Text = Cliente.auxiliar.RegPatronal;

            _lstbClienteCliente.BeginUpdate();
            foreach (ClienteDeCliente row in ClienteDeCliente.ListaClientesDeClientes)
            {
                if(row.IdCliente == Cliente.auxiliar.Id)
                _lstbClienteCliente.Items.Add(row);
            }
            _lstbClienteCliente.EndUpdate();
        }

        private void _btnRegistrar_Click(object sender, EventArgs e)
        {
            var registrarClienteCliente = new RegistrarClienteCliente();
            registrarClienteCliente.ShowDialog();
            _lstbClienteCliente.BeginUpdate();
            _lstbClienteCliente.Items.Clear();
            foreach (ClienteDeCliente row in ClienteDeCliente.ListaClientesDeClientes)
            {
                if (row.IdCliente == Cliente.auxiliar.Id)
                    _lstbClienteCliente.Items.Add(row);
            }
            _lstbClienteCliente.EndUpdate();
            navigator1.ClearNavigator();

        }

        private void _btnEliminar_Click(object sender, EventArgs e)
        {
            if (_lstbClienteCliente.SelectedIndex != -1)
            {
                DialogResult respuesta = MessageBox.Show("¿Seguro que desea eliminar a " + _lstbClienteCliente.SelectedItem.ToString() + "?", "Eliminar Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.OK)
                {
                    ClienteDeCliente clienteBorrado = (ClienteDeCliente)_lstbClienteCliente.SelectedItem;
                    SqlCommand eliminarCliente = new SqlCommand("DELETE FROM ClientesDeClientes WHERE Id = " + clienteBorrado.Id + ";", Connection.conn);

                    try
                    {
                        Connection.conn.Open();
                        eliminarCliente.ExecuteNonQuery();
                        MessageBox.Show("Cliente eliminado correctamente.");
                        ClienteDeCliente.ListaClientesDeClientes.Remove(clienteBorrado);
                        _lstbClienteCliente.BeginUpdate();
                        _lstbClienteCliente.Items.Clear();
                        foreach (ClienteDeCliente row in ClienteDeCliente.ListaClientesDeClientes)
                        {
                            if (row.IdCliente == Cliente.auxiliar.Id)
                                _lstbClienteCliente.Items.Add(row);
                        }
                        _lstbClienteCliente.EndUpdate();
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
            if (_lstbClienteCliente.SelectedIndex != -1)
            {
                ClienteDeCliente.auxiliar = (ClienteDeCliente)_lstbClienteCliente.SelectedItem;
                var editarCliente = new EditarClienteCliente();
                editarCliente.ShowDialog();
                _lstbClienteCliente.BeginUpdate();
                _lstbClienteCliente.Items.Clear();
                foreach (ClienteDeCliente row in ClienteDeCliente.ListaClientesDeClientes)
                {
                    if (row.IdCliente == Cliente.auxiliar.Id)
                        _lstbClienteCliente.Items.Add(row);
                }
                _lstbClienteCliente.SelectedItem = ClienteDeCliente.auxiliar;
                _lstbClienteCliente.EndUpdate();
                
            }
        }

        private void _lstbClienteCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_lstbClienteCliente.SelectedItem != null)
            {
                ClienteDeCliente.auxiliar = (ClienteDeCliente)_lstbClienteCliente.SelectedItem;
                navigator1.NavigateTo(new CardClienteCliente());
            }
        }
    }
}
