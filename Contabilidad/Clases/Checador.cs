using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Contabilidad
{
    class Checador
    {

        public static void RegistrarEntrada()
        {
            SqlCommand registrarEntrada = new SqlCommand("Insert into Checador (Dia, HoraEntrada, IdEmpleado) Values (GETDATE(), GETDATE(), @IdEmpleado);", Connection.conn);
            registrarEntrada.Parameters.Add(new SqlParameter("IdEmpleado", Connection.idEmpleado));

            SqlCommand primerEntrada = new SqlCommand("Select * From Checador where Dia = CONVERT(DATE, GETDATE()) and IdEmpleado = @IdEmpleado;", Connection.conn);
            primerEntrada.Parameters.Add(new SqlParameter("IdEmpleado", Connection.idEmpleado));

            Connection.conn.Open();
            SqlDataReader readEntrada = primerEntrada.ExecuteReader();
            if (!readEntrada.HasRows)
            {
                Connection.conn.Close();
                try
                {                 
                    Connection.conn.Open();
                    registrarEntrada.ExecuteNonQuery();
                }
                finally
                {
                    Connection.conn.Close();
                }
            }  
            else
            {
                Connection.conn.Close();
            }

        }

        public static void RegistrarSalida()
        {
            SqlCommand registrarSalida = new SqlCommand("UPDATE Checador SET HoraSalida = GETDATE() WHERE IdEmpleado = @IdEmpleado and Dia = CONVERT(DATE, GETDATE());", Connection.conn);
            registrarSalida.Parameters.Add(new SqlParameter("IdEmpleado", Connection.idEmpleado));

                try
                {
                    Connection.conn.Open();
                    registrarSalida.ExecuteNonQuery();
                }

                finally
                {
                    Connection.conn.Close();
                }
        }
    }
}
