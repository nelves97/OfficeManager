using Contabilidad.Clases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Contabilidad.Pantallas;

namespace Contabilidad
{
    public partial class frmCalendar: Form
    {
        public int x = 0;
        public frmCalendar()
        {
            InitializeComponent();
            Cita.ListaCitas = new List<Cita>();
            CrearLista();
        }

        private static void CrearLista()
        {
            Cita.ListaCitas.Clear();
            SqlCommand selectCitas = new SqlCommand("SELECT * FROM Citas;", Connection.conn);

            try
            {
                Connection.conn.Open();

                using (SqlDataReader rdr = selectCitas.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        Cita nuevaCita = new Cita(
                            rdr.GetInt32(0),
                            rdr.GetDateTime(1),
                            rdr.GetDateTime(2),
                            rdr.GetString(3),
                            ColorTranslator.FromHtml(rdr.GetString(4)),
                            rdr.GetInt32(5)
                        );

                        Cita.ListaCitas.Add(nuevaCita);

                    }
                }
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

        private void btnAgregarCita_Click(object sender, EventArgs e)
        {
            var RegistarCita = new RegistrarCita  { Owner = this };
            RegistarCita.Owner.Enabled = false;
            RegistarCita.ShowDialog();
            MostrarCitas();
        }

        private void _btnCerrar_Click(object sender, EventArgs e)
        {
            Owner.Enabled = true;
            this.Close();
        }

        private void frmCalendar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Enabled = true;
        }

        private void frmCalendar_Load(object sender, EventArgs e)
        {
            MostrarCitas();
        }

        private void btnEliminarCita_Click(object sender, EventArgs e)
        {
            var Id = Convert.ToInt32(_dgvCitas.CurrentRow.Cells[4].Value);
            if (Id != -1)
            {
                DialogResult respuesta = MessageBox.Show("¿Seguro que desea eliminar la cita", "Eliminar Cita", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.OK)
                {
                    SqlCommand eliminarCliente = new SqlCommand("DELETE FROM Citas WHERE Id = " + Id + ";", Connection.conn);
                    try
                    {
                        Connection.conn.Open();
                        eliminarCliente.ExecuteNonQuery();
                        MessageBox.Show("Cita eliminada correctamente.");
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
                MostrarCitas();
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            //try
            //{
            //    _dgvCitas.Rows.Clear();
            //    x = 0;
            //    foreach (Cita row in Cita.ListaCitas)
            //    {
            //        if (_mtcCalendario.SelectionRange.Start < row.Dia && row.Dia < _mtcCalendario.SelectionRange.End.AddDays(1))
            //        {
            //            _dgvCitas.Rows.Add(row.idCliente, row.Info, row.Dia.ToShortDateString(), row.Hora.ToShortTimeString(),row.Id);
            //            _dgvCitas.Rows[x].DefaultCellStyle.BackColor = row.Color;
            //            x++;
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}

            _dgvCitas.Rows.Clear();
            x = 0;
            _dgvCitas.AutoGenerateColumns = false;
            SqlCommand selectCitas = new SqlCommand("SELECT Nombre, Info, Dia, Hora, Citas.Id, Color FROM Citas,Clientes WHERE IdCliente = Clientes.Id;", Connection.conn);
            try
            {
                Connection.conn.Open();
                using (SqlDataReader rdr = selectCitas.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        MessageBox.Show(rdr.GetValue(2).ToString());
                        if (_mtcCalendario.SelectionRange.Start < Convert.ToDateTime(rdr.GetValue(2).ToString()) && Convert.ToDateTime(rdr.GetValue(2).ToString()) < _mtcCalendario.SelectionRange.End.AddDays(1))
                        _dgvCitas.Rows.Add(rdr.GetValue(0), rdr.GetValue(1), rdr.GetValue(2), rdr.GetValue(3), rdr.GetValue(4));
                        _dgvCitas.Rows[x].DefaultCellStyle.BackColor = ColorTranslator.FromHtml(rdr.GetValue(5).ToString());
                        x++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Connection.conn.Close();
            }


        }

        private void frmCalendar_Activated(object sender, EventArgs e)
        {
            //MostrarCitas();
        }

        private void MostrarCitas()
        {
            _dgvCitas.Rows.Clear();
            x = 0;
            _dgvCitas.AutoGenerateColumns = false;
            SqlCommand selectCitas = new SqlCommand("SELECT Nombre, Info, Dia, Hora, Citas.Id, Color FROM Citas,Clientes WHERE IdCliente = Clientes.Id;", Connection.conn);
            try
            {
                Connection.conn.Open();
                using (SqlDataReader rdr = selectCitas.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        _dgvCitas.Rows.Add(rdr.GetValue(0), rdr.GetValue(1), rdr.GetValue(2), rdr.GetValue(3), rdr.GetValue(4));
                        _dgvCitas.Rows[x].DefaultCellStyle.BackColor = ColorTranslator.FromHtml(rdr.GetValue(5).ToString());
                        x++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Connection.conn.Close();
            }
        }

        private void _btnMostrarTodas_Click(object sender, EventArgs e)
        {
            try
            {
                MostrarCitas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //private void MostrarCitas()
        //{
        //    _dgvCitas.Rows.Clear();
        //    x = 0;
        //    _dgvCitas.AutoGenerateColumns = false;
        //    foreach (Cita row in Cita.ListaCitas)
        //    {
        //        _dgvCitas.Rows.Add(row.idCliente, row.Info, row.Dia.ToShortDateString(), row.Hora.ToShortTimeString(),row.Id);
        //        _dgvCitas.Rows[x].DefaultCellStyle.BackColor = row.Color;
        //        x++;
                
        //    }
        //}

    }
}
