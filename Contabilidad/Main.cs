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
        List<Cliente> ListaClientes = new List<Cliente>();
        
        public Main()
        {
            InitializeComponent();
            DM = new DirectoryManager();
            DM.InitialSetup();
            Connection.con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            SqlCommand cargarClientes = new SqlCommand("SELECT * FROM CLIENTE;", Connection.con);
            using (SqlDataReader rdr = cargarClientes.ExecuteReader())
            {
                while (rdr.Read())
                {
                    Cliente nuevoCliente = new Cliente();
                    nuevoCliente.Id_Cliente = rdr.GetInt32(0);
                    nuevoCliente.Nombre = rdr.GetString(1);
                    nuevoCliente.Correo = rdr.GetString(2);
                    nuevoCliente.Telefono = rdr.GetString(3);
                    nuevoCliente.Domicilio = rdr.GetString(4);
                    nuevoCliente.RFC = rdr.GetString(5);
                    nuevoCliente.CURP = rdr.GetString(6);
                    nuevoCliente.ContrasenaRFC = rdr.GetString(7);
                    nuevoCliente.ContrasenaFIEL = rdr.GetString(8);
                    nuevoCliente.TipoCliente = rdr.GetString(9);
                    ListaClientes.Add(nuevoCliente);
                }
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
