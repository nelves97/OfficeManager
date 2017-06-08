using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contabilidad
{
    public class ClienteDeCliente
    {
        public static List<ClienteDeCliente> ListaClientesDeClientes;
        public static ClienteDeCliente auxiliar;

        public Int32 Id;
        public String Nombre;
        public String Correo;
        public String Telefono;
        public String RFC;
        public Int32 IdCliente;

        public ClienteDeCliente(
            Int32 Id,
            String Nombre,
            String Correo,
            String Telefono,
            String RFC,
            Int32 IdCliente)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Correo = Correo;
            this.Telefono = Telefono;
            this.RFC = RFC;
            this.IdCliente = IdCliente;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
