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

namespace Contabilidad
{
    public partial class RegistrarCliente : UserControl
    {
        public RegistrarCliente()
        {
            InitializeComponent();
        }
        private void LimpiarCampos()
        {
            foreach(Control c in Controls)
            {
                if(c is TextBox)
                {
                    c.Text = "";
                }
            }
        }
        
        private void _btnRegistrar_Click(object sender, EventArgs e)
        {
            if (_txtNombre != null)
            {
                int tipoCliente;
                if (_rbtnMensual.Checked == true)
                {
                    tipoCliente = 1;
                }
                else
                {
                    tipoCliente = 2;
                }

                SqlCommand nuevoCliente = new SqlCommand("INSERT INTO CLIENTE VALUES(@nombre, @correo, @telefono, @domicilio, @RFC, @CURP, @contrasenaRFC, @contrasenaFIEL, @tipocliente;", Connection.conn);
                nuevoCliente.Parameters.Add(new SqlParameter("nombre", _txtNombre.Text));
                nuevoCliente.Parameters.Add(new SqlParameter("correo", _txtCorreo.Text));
                nuevoCliente.Parameters.Add(new SqlParameter("telefono", _txtTelefono.Text));
                nuevoCliente.Parameters.Add(new SqlParameter("domicilio", _txtDomicilio.Text));
                nuevoCliente.Parameters.Add(new SqlParameter("RFC", _txtRFC.Text));
                nuevoCliente.Parameters.Add(new SqlParameter("CURP", _txtCURP.Text));
                nuevoCliente.Parameters.Add(new SqlParameter("contrasenaRFC", _txtContrasenaRFC.Text));
                nuevoCliente.Parameters.Add(new SqlParameter("contrasenaFIEL", _txtContrasenaFIEL.Text));
                nuevoCliente.Parameters.Add(new SqlParameter("tipocliente", tipoCliente));
                SqlCommand idNueva = new SqlCommand(" SELECT TOP 1 ID_CLIENTE FROM CLIENTE ORDER BY ID_CLIENTE DESC;", Connection.conn);
                
                try
                {
                    Connection.conn.Open();
                    nuevoCliente.ExecuteNonQuery();
                    MessageBox.Show("Cliente guardado correctamente.");
                    using (SqlDataReader rdr = idNueva.ExecuteReader())
                    {
                        Cliente nuevo = new Cliente(rdr.GetByte(0), _txtNombre.Text, _txtCorreo.Text, _txtTelefono.Text, _txtDomicilio.Text, _txtRFC.Text, _txtCURP.Text, _txtContrasenaRFC.Text, _txtContrasenaFIEL.Text, tipoCliente.ToString(), "x");
                        Cliente.ListaClientes.Add(nuevo);
                    }                        
                    LimpiarCampos();
                    _rbtnBimestral.Checked = false;
                    _rbtnMensual.Checked = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    Connection.conn.Close();
                }
            }
            else
            {
                MessageBox.Show("El campo nombre se encuentra vacío");
            }

        }
    }
}