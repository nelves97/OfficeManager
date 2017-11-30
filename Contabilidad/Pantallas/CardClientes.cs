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
    public partial class CardClientes : UserControl, Listener
    {
        public CardClientes()
        {
            InitializeComponent();
            NotificationCenter.main.subscribe("EditarContacto", this);
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

            _lstbContacto.BeginUpdate();
            foreach (Contacto row in Contacto.ListaContactos)
            {
                if(row.IdCliente == Cliente.auxiliar.Id)
                _lstbContacto.Items.Add(row);
            }
            _lstbContacto.EndUpdate();
        }

        private void _btnRegistrar_Click(object sender, EventArgs e)
        {
            var registrarContacto = new RegistrarContacto();
            registrarContacto.ShowDialog();
            _lstbContacto.BeginUpdate();
            _lstbContacto.Items.Clear();
            foreach (Contacto row in Contacto.ListaContactos)
            {
                if (row.IdCliente == Cliente.auxiliar.Id)
                    _lstbContacto.Items.Add(row);
            }
            _lstbContacto.EndUpdate();
            navigator1.ClearNavigator();

        }

        private void _btnEliminar_Click(object sender, EventArgs e)
        {
            if (_lstbContacto.SelectedIndex != -1)
            {
                DialogResult respuesta = MessageBox.Show("¿Seguro que desea eliminar a " + _lstbContacto.SelectedItem.ToString() + "?", "Eliminar Contacto", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.OK)
                {
                    Contacto contactoBorrado = (Contacto)_lstbContacto.SelectedItem;
                    SqlCommand eliminarContacto = new SqlCommand("DELETE FROM Contactos WHERE IdContacto = " + contactoBorrado.Id + ";", Connection.conn);

                    try
                    {
                        Connection.conn.Open();
                        eliminarContacto.ExecuteNonQuery();
                        MessageBox.Show("Contacto eliminado correctamente.");
                        Contacto.ListaContactos.Remove(contactoBorrado);
                        _lstbContacto.BeginUpdate();
                        _lstbContacto.Items.Clear();
                        foreach (Contacto row in Contacto.ListaContactos)
                        {
                            if (row.IdCliente == Cliente.auxiliar.Id)
                                _lstbContacto.Items.Add(row);
                        }
                        _lstbContacto.EndUpdate();
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
        public void listen(string evento)
        {
            _lstbContacto.BeginUpdate();
            _lstbContacto.Items.Clear();
            foreach (Contacto row in Contacto.ListaContactos)
            {
                if (row.IdCliente == Cliente.auxiliar.Id)
                    _lstbContacto.Items.Add(row);
            }
            _lstbContacto.SelectedItem = Contacto.auxiliar;
            _lstbContacto.EndUpdate();
        }


        private void _lstbContacto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_lstbContacto.SelectedItem != null)
            {
                Contacto.auxiliar = (Contacto)_lstbContacto.SelectedItem;
                navigator1.NavigateTo(new CardContacto());
            }
        }

        private void _btnEditarCliente_Click(object sender, EventArgs e)
        {
            var editarCliente = new EditarCliente();
            editarCliente.ShowDialog();
            NotificationCenter.main.emit("EditarCliente");
        }
    }
}

