﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contabilidad
{
    public class Cliente
    {
        public static List<Cliente> ListaClientes;

        public enum Periodos
        {
            MENSUAL = 1,
            BIMESTRAL = 2
        }

        public Int32 Id;
        public String Nombre;
        public String Correo;
        public String Telefono;
        public String Domicilio;
        public String RFC;
        public String CURP;
        public String PasswordRFC;
        public String PasswordFIEL;
        public Periodos Periodo;

        public Cliente() { }

        public Cliente(
            Int32  Id,
            String Nombre,
            String Correo, 
            String Telefono,
            String Domicilio,
            String RFC, 
            String CURP,
            String PasswordRFC,
            String PasswordFIEL, 
            Periodos Periodo)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Correo = Correo;
            this.Telefono = Telefono;
            this.Domicilio = Domicilio;
            this.RFC = RFC;
            this.CURP = CURP;
            this.PasswordRFC = PasswordRFC;
            this.PasswordFIEL = PasswordFIEL;
            this.Periodo = Periodo;
        }
    }
}
