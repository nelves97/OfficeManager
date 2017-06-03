using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            Connection.conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            SqlCommand selectClientes = new SqlCommand("SELECT * FROM CLIENTE;", Connection.conn);

            try
            {
                Connection.conn.Open();
                using (SqlDataReader rdr = selectClientes.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        Cliente nuevoCliente = new Cliente(
                            rdr.GetInt32(0),
                            rdr.GetGuid(1),
                            rdr.GetString(2),
                            rdr.GetString(3),
                            rdr.GetString(4),
                            rdr.GetString(5),
                            rdr.GetString(6),
                            rdr.GetString(7),
                            rdr.GetString(8),
                            rdr.GetString(9),
                            (Cliente.Periodos) rdr.GetInt32(10),
                            rdr.GetString(11) != null ? new Uri(rdr.GetString(11)) : null
                            );

                        Cliente.ListaClientes.Add(nuevoCliente);
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
