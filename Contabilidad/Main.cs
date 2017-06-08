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
            Cliente.ListaClientes = new List<Cliente>();
            ClienteDeCliente.ListaClientesDeClientes = new List<ClienteDeCliente>();
            Connection.conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            SqlCommand selectClientes = new SqlCommand("SELECT * FROM Clientes;", Connection.conn);
            SqlCommand selectClientesClientes = new SqlCommand("SELECT * FROM ClientesDeClientes;", Connection.conn);
            navigator1.NavigateTo(new CatalogoClientes());
            try
            {
                Connection.conn.Open();
                
                using (SqlDataReader rdr = selectClientes.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        Cliente nuevoCliente = new Cliente(
                            rdr.GetInt32(0),
                            rdr.GetString(1),
                            rdr.GetString(2),
                            rdr.GetString(3),
                            rdr.GetString(4),
                            rdr.GetString(5),
                            rdr.GetString(6),
                            rdr.GetString(7),
                            rdr.GetString(8),
                            (Cliente.Periodos) rdr.GetInt32(9)
                        );

                        Cliente.ListaClientes.Add(nuevoCliente);
                    }
                }

                using (SqlDataReader rdr = selectClientesClientes.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        ClienteDeCliente nuevoCliente = new ClienteDeCliente(
                            rdr.GetInt32(0),
                            rdr.GetString(1),
                            rdr.GetString(2),
                            rdr.GetString(3),
                            rdr.GetString(4),
                            rdr.GetInt32(5)
                            );

                        ClienteDeCliente.ListaClientesDeClientes.Add(nuevoCliente);
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

    }
}
