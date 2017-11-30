﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contabilidad.Pantallas
{
    public partial class CardEmpleado : UserControl
    {
        public CardEmpleado()
        {
            InitializeComponent();
        }

        private void CardEmpleado_Load(object sender, EventArgs e)
        {

            _txtNombre.Text = Empleado.auxiliar.Nombre;
            _txtCorreo.Text = Empleado.auxiliar.Correo;
            _txtTelefono.Text = Empleado.auxiliar.Telefono;
            _txtFechaNacimiento.Text = Empleado.auxiliar.FechadeNacimiento.ToString();
            _txtHorasSemanales.Text = Empleado.auxiliar.HorasSemanales.ToString();
            _txtSalario.Text = Empleado.auxiliar.Salario.ToString();
            _txtFechaIngreso.Text = Empleado.auxiliar.FechadeIngreso.ToString();
            _txtEdad.Text = Empleado.auxiliar.CalcularEdad(Empleado.auxiliar.FechadeNacimiento).ToString() + " años";
            _txtSexo.Text = Empleado.auxiliar.Sexo;
            _txtNombreUsuario.Text = Empleado.auxiliar.NombreUsuario;
            _txtContrasena.Text = Empleado.auxiliar.Contrasena;
        }

        private void _btnEditarEmpleado_Click(object sender, EventArgs e)
        {
            var editarEmpleado = new EditarEmpleado();
            editarEmpleado.ShowDialog();
            NotificationCenter.main.emit("EditarEmpleado");
        }
    }
}
