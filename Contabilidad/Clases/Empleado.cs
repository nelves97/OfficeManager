using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contabilidad
{
    public class Empleado
    {
        public static List<Empleado> ListaEmpleados;
        public static Empleado auxiliar;

        public Int32 Id;
        public String Nombre;
        public DateTime FechadeNacimiento;
        public String Correo;
        public String Telefono;
        public Int32 HorasSemanales;
        public Int32 Salario;
        public DateTime FechadeIngreso;
        public String Sexo;
        public String NombreUsuario;
        public String Contrasena;
        
        public Empleado() { }

        public Empleado(
            Int32 Id,
            String Nombre,
            DateTime FechadeNacimiento,
            String Correo,
            String Telefono,
            Int32 HorasSemanales,
            Int32 Salario,
            DateTime FechadeIngreso,
            String Sexo,
            String NombreUsuario,
            String Contrasena)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.FechadeNacimiento = FechadeNacimiento;
            this.Correo = Correo;
            this.Telefono = Telefono;
            this.HorasSemanales = HorasSemanales;
            this.Salario = Salario;
            this.FechadeIngreso = FechadeIngreso;
            this.Sexo = Sexo;
            this.NombreUsuario = NombreUsuario;
            this.Contrasena = Contrasena;
        }
        public override string ToString()
        {
            return Nombre;
        }

        public int CalcularEdad(DateTime birthdate)
        {
            var today = DateTime.Today;           
            var age = today.Year - birthdate.Year;    
            if (birthdate > today.AddYears(-age)) age--;

            return Convert.ToInt16(age);
        }
    }
}
