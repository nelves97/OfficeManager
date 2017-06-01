using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contabilidad
{
    public class Cliente
    {
       public int Id_Cliente;
       public string Nombre;
       public string Correo;
       public string Telefono;
       public string Domicilio;
       public string RFC;
       public string CURP;
       public string ContrasenaRFC;
       public string ContrasenaFIEL;
       public string TipoCliente;
       public string DireccionURN;
       public static List<Cliente> ListaClientes;

        public Cliente(int id_Cliente, string nombre, string correo, 
                       string telefono, string domicilio, string rFC, 
                       string cURP, string contrasenaRFC, string contrasenaFIEL, 
                       string tipoCliente, string direccionURN)
        {
            Id_Cliente = id_Cliente;
            Nombre = nombre;
            Correo = correo;
            Telefono = telefono;
            Domicilio = domicilio;
            RFC = rFC;
            CURP = cURP;
            ContrasenaRFC = contrasenaRFC;
            ContrasenaFIEL = contrasenaFIEL;
            TipoCliente = tipoCliente;
            DireccionURN = direccionURN;
        }

        public Cliente()
        {
            Id_Cliente = 0;
            Nombre = null;
            Correo = null;
            Telefono = null;
            Domicilio = null;
            RFC = null;
            CURP = null;
            ContrasenaRFC = null;
            ContrasenaFIEL = null;
            TipoCliente = null;
            DireccionURN = null;
        }
    }
}
