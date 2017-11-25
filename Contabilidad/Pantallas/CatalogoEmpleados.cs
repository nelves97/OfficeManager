﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Contabilidad.Pantallas
{
    public partial class CatalogoEmpleados : UserControl
    {
        public CatalogoEmpleados()
        {
            InitializeComponent();
        }

        private void CatalogoEmpleados_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            _txtBuscar.Focus();
            _lstbConsulta.BeginUpdate();
            foreach (Empleado row in Empleado.ListaEmpleados)
            {
                _lstbConsulta.Items.Add(row);
            }
            _lstbConsulta.EndUpdate();
        }

        private void _txtBuscar_TextChanged(object sender, EventArgs e)
        {
            _lstbConsulta.BeginUpdate();
            _lstbConsulta.Items.Clear();
            foreach (Empleado row in Empleado.ListaEmpleados)
            {
                if (row.Nombre.ToLower().Contains(_txtBuscar.Text))
                {
                    _lstbConsulta.Items.Add(row);
                }
            }
            _lstbConsulta.EndUpdate();
        }

        private void _btnRegistrar_Click(object sender, EventArgs e)
        {
            var registrarEmpleado = new RegistrarEmpleado();
            registrarEmpleado.ShowDialog();
            _lstbConsulta.BeginUpdate();
            _lstbConsulta.Items.Clear();
            foreach (Empleado row in Empleado.ListaEmpleados)
            {
                _lstbConsulta.Items.Add(row);
            }
            _lstbConsulta.EndUpdate();
            navigator1.ClearNavigator();
        }

        private void _btnEditar_Click(object sender, EventArgs e)
        {
            if (_lstbConsulta.SelectedIndex != -1)
            {
                Empleado.auxiliar = (Empleado)_lstbConsulta.SelectedItem;
                var editarEmpleado = new EditarEmpleado();
                editarEmpleado.ShowDialog();
                _lstbConsulta.BeginUpdate();
                _lstbConsulta.Items.Clear();
                foreach (Empleado row in Empleado.ListaEmpleados)
                {
                    _lstbConsulta.Items.Add(row);
                }
                _lstbConsulta.SelectedItem = Empleado.auxiliar;
                _lstbConsulta.EndUpdate();
            }
            else
            {
                MessageBox.Show("Seleccione a un empleado para editar");
            }
        }

        private void _btnEliminar_Click(object sender, EventArgs e)
        {
            if (_lstbConsulta.SelectedIndex != -1)
            {
                DialogResult respuesta = MessageBox.Show("¿Seguro que desea eliminar a " + _lstbConsulta.SelectedItem.ToString() + "?", "Eliminar Empleado", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.OK)
                {
                    Empleado empleadoBorrado = (Empleado)_lstbConsulta.SelectedItem;
                    SqlCommand eliminarEmpleado = new SqlCommand("DELETE FROM Empleados WHERE Id = " + empleadoBorrado.Id + ";", Connection.conn);

                    try
                    {
                        Connection.conn.Open();
                        eliminarEmpleado.ExecuteNonQuery();
                        MessageBox.Show("Empleado eliminado correctamente.");
                        Empleado.ListaEmpleados.Remove(empleadoBorrado);
                        _lstbConsulta.BeginUpdate();
                        _lstbConsulta.Items.Clear();
                        foreach (Empleado row in Empleado.ListaEmpleados)
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
    }
}
