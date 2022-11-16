using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefugioPerritos
{
    public class Refugio
    {
        private string NombreRefugioID;
        private string Direccion;
        private decimal Telefono;
        private string Persona_a_cargo;
        private DateTime Hora_apertura;
        private DateTime Hora_cierre;

        public string NombreRefugioId
        {
            get { return NombreRefugioID; }
            set { NombreRefugioID = value; }
        }
        public string direccion
        {
            get { return Direccion; }
            set { Direccion = value; }
        }
        public decimal telefono
        {
            get { return Telefono; }
            set { Telefono = value; }
        }
        public string persona_a_cargo
        {
            get { return Persona_a_cargo; }
            set { Persona_a_cargo = value; }
        }
        public DateTime hora_apertura
        {
            get { return Hora_apertura; }
            set { Hora_apertura = value; }
        }
        public DateTime hora_cierre
        {
            get { return Hora_cierre; }
            set { Hora_cierre = value; }
        }

    }
}
