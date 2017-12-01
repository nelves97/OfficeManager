using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Contabilidad.Clases
{
    public class Cita
    {

        public static List<Cita> ListaCitas;
        public Int32 Id;
        public DateTime Dia;
        public DateTime Hora;
        public string Info;
        public Color Color;
        public Int32 idCliente;

        public Cita() { }

        public Cita(Int32 Id, DateTime Dia, DateTime Hora, string Info, Color Color, Int32 idCliente)
        {
            this.Id = Id;
            this.Dia = Dia;
            this.Hora = Hora;
            this.Info = Info;
            this.Color = Color;
            this.idCliente = idCliente;
        }

    }
}
