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
using Contabilidad.Pantallas;

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
            } else
            {
                //MessageBox.Show("El archivo contabilidad.properties no existe");
            }
            if (DataSource == null) DataSource = "localhost\\SQLEXPRESS";
            if (InitialCatalog == null) InitialCatalog = "ContabilidadDB";
            Cliente.ListaClientes = new List<Cliente>();
            Contacto.ListaContactos = new List<Contacto>();
            Empleado.ListaEmpleados = new List<Empleado>();
            //Connection.conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            Connection.conn = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=ContabilidadDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand selectClientes = new SqlCommand("SELECT * FROM Clientes;", Connection.conn);
            SqlCommand selectContactos = new SqlCommand("SELECT * FROM Contactos;", Connection.conn);
            SqlCommand selectEmpleados = new SqlCommand("SELECT * FROM Empleados;", Connection.conn);
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
                            rdr.GetString(10),
                            rdr.GetString(11),
                            (Cliente.Periodos) rdr.GetInt32(9)
                        );

                        Cliente.ListaClientes.Add(nuevoCliente);
                    }
                }

                using (SqlDataReader rdr = selectContactos.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        Contacto nuevoCliente = new Contacto(
                            rdr.GetInt32(0),
                            rdr.GetString(1),
                            rdr.GetString(2),
                            rdr.GetString(3),
                            rdr.GetString(4),
                            rdr.GetString(6),
                            rdr.GetString(7),
                            rdr.GetInt32(5)
                            );

                        Contacto.ListaContactos.Add(nuevoCliente);
                    }
                }

                using (SqlDataReader rdr = selectEmpleados.ExecuteReader())
                {
                    while(rdr.Read())
                    {
                        Empleado nuevoEmpleado = new Empleado(
                            rdr.GetInt32(0),
                            rdr.GetString(1),
                            rdr.GetDateTime(2),
                            rdr.GetString(3),
                            rdr.GetString(4),
                            rdr.GetInt32(5),
                            rdr.GetInt32(6),
                            rdr.GetDateTime(7),
                            rdr.GetString(8),
                            rdr.GetString(9),
                            rdr.GetString(10)
                            );

                        Empleado.ListaEmpleados.Add(nuevoEmpleado);
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
            Login login = new Login();
            login.ShowDialog();
            this.WindowState = FormWindowState.Maximized;
        }

        private void catálogoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            navigator1.NavigateTo(new CatalogoClientes());
        }

        private void catálogoDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Connection.rol == 1)
                navigator1.NavigateTo(new CatalogoEmpleados());
            else
                MessageBox.Show("No tiene permisos de acceso");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Connection.rol == 0)
            {
                Checador.RegistrarSalida();
            }
            //Generar Backup
        }
    }
}
