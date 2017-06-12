using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Contabilidad
{
    public partial class Main : Form
    {
        //DirectoryManager DM;
        String DataSource;
        String InitialCatalog;
        String UserId = "ContabilidadLogin";
        String Password = "xDfpm5magbWyomzjtjk5wbzbmsFT72356j8ADpiszgvnrqmw";

        public Main()
        {
            InitializeComponent();
            //DM = new DirectoryManager();
            //DM.InitialSetup();
            if (File.Exists(Application.StartupPath + @"\contabilidad.properties"))
            {
                using (StreamReader sr = new StreamReader(Application.StartupPath + @"\contabilidad.properties"))
                {
                    while (!sr.EndOfStream)
                    {
                        String[] tmp = sr.ReadLine().Split('=');
                        switch (tmp[0])
                        {
                            case "DataSource":
                                DataSource = tmp[1];
                                break;
                            case "InitialCatalog":
                                InitialCatalog = tmp[1];
                                break;
                        }
                    }
                }
            }
            if (DataSource == null) DataSource = "localhost";
            if (InitialCatalog == null) InitialCatalog = "ContabilidadDB";
            Cliente.ListaClientes = new List<Cliente>();
            ClienteDeCliente.ListaClientesDeClientes = new List<ClienteDeCliente>();
            //Connection.conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            Connection.conn = new SqlConnection($"Data Source={DataSource};Initial Catalog={InitialCatalog};User Id={UserId};Password={Password};");
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

        private void Main_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
